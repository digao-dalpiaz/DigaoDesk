using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
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

        [JsonProperty]
        public ushort? TcpPort;

        public string Status
        {
            get
            {
                return Running ? Vars.Lang.AppStatus_Running : Vars.Lang.AppStatus_Stoped;
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
                return LastLogIsError ? "ERROR" : "OK";
            }
        }

        public string LogStatistics
        {
            get
            {
                return string.Format(Vars.Lang.AppStatistics, Logs.Count);
            }
        }

        public string Memory { get; set; }
        public string Processor { get; set; }
        public string ProcCount { get; set; }

        private TimeSpan _lastProcessorTime;
        private DateTime _lastProcessorCapture;

        private bool _tcpOnline;
        public string TcpStatus
        {
            get
            {
                if (Running && TcpPort.HasValue)
                {
                    return _tcpOnline ? "UP" : "DOWN";
                }

                return null;
            }
        }

        public enum LogType
        {
            ERROR,
            DYN_ERROR,
            DYN_WARN,
            INFO
        }
        public class LogRecord
        {
            public DateTime Timestamp;
            public string Text;
            public LogType Type;
        }

        public List<LogRecord> Logs = new();

        public bool Running;

        private Process _process;

        public Task monitorTask;

        public void Start()
        {
            Logs.Clear();

            if (TcpPort.HasValue)
            {
                if (Utils.TcpPortInUse(TcpPort.Value))
                {
                    AddLog(string.Format(Vars.Lang.AppLog_TcpPortInUse, TcpPort.Value), true);
                    return;
                }
            }

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

            _process.OutputDataReceived += (s, e) => AddLog(Utils.RemoveEsc(e.Data), false);
            _process.ErrorDataReceived += (s, e) => AddLog(Utils.RemoveEsc(e.Data), true);
            _process.Exited += (s, e) =>
            {
                _process.WaitForExit();
                AddLog(Vars.Lang.AppLog_Terminated, true);

                Running = false;
                _startTime = null;
                RunningTime = null;
                LastLogTime = null;
                LastLogIsError = false;
                Memory = null;
                Processor = null;
                ProcCount = null;
                _tcpOnline = false;
                InvokeInForm(() => Vars.FrmAppsObj.EventUpdated(this));
                Vars.FrmMainObj.UpdateTrayIcon();

                if (Vars.Config.NotifyAppStops)
                {
                    Vars.FrmMainObj.Invoke(new MethodInvoker(() => {
                        if (!(Vars.Config.DontNotifyWhenAppsActive && Vars.FrmAppsObj != null && Form.ActiveForm == Vars.FrmAppsObj))
                            Vars.FrmMainObj.tray.ShowBalloonTip(5000, Vars.Lang.AppTerminatedBalloonTitle, string.Format(Vars.Lang.AppTerminatedBalloonMsg, Name), ToolTipIcon.Info);
                    }));
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
            AddLog(Vars.Lang.AppLog_Stopping, true);
            KillChildProcs(_process, 0);
        }

        private void KillChildProcs(Process parent, int level)
        {
            var children = Utils.GetChildProcesses(parent.Id);
            foreach (var child in children)
            {
                KillChildProcs(child, level+1);
            }

            AddLog(string.Format(Vars.Lang.AppLog_TerminatingProcessLevel, level, parent.ProcessName, parent.Id), true);
            parent.Kill();
        }

        private void AddLog(string text, bool error)
        {
            if (text == null) text = "";

            LogRecord r = new();
            r.Timestamp = DateTime.Now;
            r.Text = text;
            if (error)
            {
                r.Type = LogType.ERROR;
            } else if (text.Contains("ERROR", StringComparison.OrdinalIgnoreCase))
            {
                r.Type = LogType.DYN_ERROR;
            } else if (text.Contains("WARN", StringComparison.OrdinalIgnoreCase))
            {
                r.Type = LogType.DYN_WARN;
            } else
            {
                r.Type = LogType.INFO;
            }
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
            string[] debugArgs = { Name, Guid.NewGuid().ToString() }; 
            Debug.WriteLine("Started Analyse App {0} {1}", debugArgs);

            var ts = (DateTime.Now - _startTime.Value);
            RunningTime = (ts.TotalMinutes / 60).ToString("0") + ":" + (ts.TotalMinutes % 60).ToString("00");

            CheckWebPort();

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

            Debug.WriteLine("Finished Analyse App {0} {1}", debugArgs);
        }

        public void CheckWebPort()
        {
            if (!TcpPort.HasValue) return;

            _tcpOnline = Utils.TcpPortInUse(TcpPort.Value);
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
