using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DigaoApplication
    {

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Cmd;

        [JsonProperty]
        public string Args;

        [JsonProperty]
        public string WorkDir;

        [JsonProperty]
        public Dictionary<string, string> EnvVars = new(); //auto new instance due to new version

        public string Status
        {
            get
            {
                return Running ? "Running..." : "Stopped";
            }                
        }

        private DateTime? _startTime;
        public string StartTime 
        {
            get
            {
                if (_startTime == null) return null;
                return _startTime.Value.ToString(Vars.DATETIME_FMT);
            }
        }

        public string RunningTime { get; set; }

        public string LastLogTime { get; set; }

        public bool LastLogIsError;
        public string LogHealth
        {
            get
            {
                return LastLogIsError ? "# ERROR #" : "OK";
            }
        }

        public string LogStatistics
        {
            get
            {
                return $"Lines: {Logs.Count}";
            }
        }

        public string Memory { get; set; }
        public string Processor { get; set; }
        public string ProcCount { get; set; }

        private TimeSpan _lastProcessorTime;
        private DateTime _lastProcessorCapture;

        public class LogRecord
        {
            public DateTime Timestamp;
            public string Text;
        }

        public List<LogRecord> Logs = new();

        public bool Running;

        private Process _process;

        public void Start()
        {
            Logs.Clear();

            var si = new ProcessStartInfo();
            si.FileName = Cmd;
            si.WorkingDirectory = !string.IsNullOrEmpty(WorkDir) ? WorkDir : Path.GetDirectoryName(Cmd);
            si.Arguments = Args;
            si.UseShellExecute = false;
            si.CreateNoWindow = true;
            si.RedirectStandardOutput = true;
            si.RedirectStandardError = true;
            si.StandardOutputEncoding = System.Text.Encoding.UTF8;
            si.StandardErrorEncoding = System.Text.Encoding.UTF8;

            foreach (var ev in EnvVars)
            {
                si.Environment.Add(ev.Key, ev.Value);
            }

            _process = new();
            _process.StartInfo = si;
            _process.EnableRaisingEvents = true;

            _process.OutputDataReceived += (s, e) => AddLog(e.Data, false);
            _process.ErrorDataReceived += (s, e) => AddLog(e.Data, true);
            _process.Exited += (s, e) =>
            {
                _process.WaitForExit();
                AddLog("TERMINATED!", true);

                Running = false;
                _startTime = null;
                RunningTime = null;
                LastLogTime = null;
                LastLogIsError = false;
                Memory = null;
                Processor = null;
                ProcCount = null;
                InvokeInForm(() => Vars.FrmAppsObj.EventUpdated(this));
                Vars.FrmMainObj.UpdateTrayIcon();

                if (Vars.Config.NotifyAppStops)
                {
                    Vars.FrmMainObj.Invoke(new MethodInvoker(() =>
                        Vars.FrmMainObj.tray.ShowBalloonTip(5000, "Process stopped", $"The application \"{Name}\" has stopped!", ToolTipIcon.Info)));
                }
            };
            
            try
            {
                _process.Start();
            } 
            catch (Exception ex)
            {
                AddLog(ex.Message, true);
                return;
            }

            Running = true;
            _startTime = DateTime.Now;
            _lastProcessorTime = TimeSpan.Zero;
            _lastProcessorCapture = DateTime.UtcNow;
            InvokeInForm(() => Vars.FrmAppsObj.EventUpdated(this)); //no need to use invoke
            Vars.FrmMainObj.UpdateTrayIcon();

            _process.BeginOutputReadLine();
            _process.BeginErrorReadLine();
        }

        public void Stop()
        {
            AddLog("Stopping process...", true);
            KillChildProcs(_process, 0);
        }

        private void KillChildProcs(Process parent, int level)
        {
            var children = Utils.GetChildProcesses(parent.Id);
            foreach (var child in children)
            {
                KillChildProcs(child, level+1);
            }

            AddLog($"Terminating process level {level} \"{parent.ProcessName}\" ({parent.Id})...", true);
            parent.Kill();
        }       

        private void AddLog(string text, bool error)
        {
            if (error) text = "### " + text;

            LogRecord r = new();
            r.Timestamp = DateTime.Now;
            r.Text = text;
            Logs.Add(r);

            LastLogTime = r.Timestamp.ToString(Vars.DATETIME_FMT);
            LastLogIsError = error;
                        
            Vars.FrmMainObj.UpdateTrayIcon();
        }

        private void InvokeInForm(Action proc)
        {
            if (Vars.FrmAppsObj != null)
            {
                try
                {
                    Vars.FrmAppsObj.Invoke(new MethodInvoker(proc));
                }
                catch (Exception)
                {
                    if (Vars.FrmAppsObj != null) throw;
                }
            }
        }        

        private class Resources
        {
            public long Mem;
            public TimeSpan ProcessorTime;
            public int ProcCount;
        }

        public void Analyze()
        {
            var ts = (DateTime.Now - _startTime.Value);
            RunningTime = (ts.TotalMinutes / 60).ToString("0") + ":" + (ts.TotalMinutes % 60).ToString("00");

            try
            {
                var r = new Resources();
                r.Mem = 0;
                r.ProcessorTime = TimeSpan.Zero;
                r.ProcCount = 0;

                AnalyzeChildren(_process, r);

                Memory = (r.Mem / 1024 / 1024).ToString("0.00") + " MB";

                var utcNow = DateTime.UtcNow;
                var percent = (r.ProcessorTime - _lastProcessorTime).TotalMilliseconds / (Environment.ProcessorCount * (utcNow - _lastProcessorCapture).TotalMilliseconds);
                Processor = percent.ToString("0.00 %");

                _lastProcessorTime = r.ProcessorTime;
                _lastProcessorCapture = utcNow;

                ProcCount = r.ProcCount.ToString();
            } 
            catch (AbortAnalyzeException)
            {
                Memory = null;
                Processor = null;
                ProcCount = null;
            }
        }

        private void AnalyzeChildren(Process parent, Resources r)
        {
            var children = Utils.GetChildProcesses(parent.Id);
            foreach (var child in children)
            {
                AnalyzeChildren(child, r);               
            }

            SumResources(parent, r);
        }

        private void SumResources(Process p, Resources r)
        {
            try
            {
                p.Refresh();

                r.Mem += p.PrivateMemorySize64;
                r.ProcessorTime += p.TotalProcessorTime;
                r.ProcCount++;
            }
            catch (InvalidOperationException)
            {
                //if process stops while checking info, it will fire an exception
                throw new AbortAnalyzeException();
            }
        }

        private class AbortAnalyzeException : Exception { }

    }
}
