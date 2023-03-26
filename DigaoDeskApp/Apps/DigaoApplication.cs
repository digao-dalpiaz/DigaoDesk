using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
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

        public override string ToString()
        {
            return Name;
        }

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

        public string RunningTime
        {
            get
            {
                if (_startTime == null) return null;

                var ts = (DateTime.Now - _startTime.Value);
                var minutes = Math.Truncate(ts.TotalMinutes);
                return (minutes / 60).ToString("0") + ":" + (minutes % 60).ToString("00");
            }
        }

        public string LastLogTime { get; set; }

        private bool _lastLogIsError;
        public string LogHealth
        {
            get
            {
                return _lastLogIsError ? "ERROR" : "OK";
            }
        }

        public string LogLines
        {
            get
            {
                return Logs.Count.ToString();
            }
        }
        public string LogSize
        {
            get
            {
                return string.Format("{0}", _logSize);
            }
        }

        public string Memory { get; set; }
        public string Processor { get; set; }
        public string ProcCount { get; set; }

        private TimeSpan _lastProcessorTime;
        private DateTime _lastProcessorCapture;

        public bool TcpOnline;
        public string TcpStatus
        {
            get
            {
                if (Running && TcpPort.HasValue)
                {
                    return TcpOnline ? "UP" : "DOWN";
                }

                return null;
            }
        }

        public enum LogType
        {
            ERROR,
            DYN_ERROR,
            DYN_WARN,
            INFO,
            STOP
        }
        public class LogRecord
        {
            public DateTime Timestamp;
            public string Text;
            public LogType Type;
        }

        public SynchronizedCollection<LogRecord> Logs = new();
        private long _logSize;
        public bool PendingLog;

        public void ClearLog()
        {
            Logs.Clear();
            _logSize = 0;

            LastLogTime = null;
            _lastLogIsError = false;
        }

        public bool Running;
        private bool _stopping;

        private Process _process;

        public Task monitorTask;

        public void Start()
        {
            ClearLog();

            if (TcpPort.HasValue)
            {
                if (Utils.TcpPortInUse(TcpPort.Value))
                {
                    AddLog(string.Format(Vars.Lang.AppLog_TcpPortInUse, TcpPort.Value), true);
                    return;
                }
            }

            EventAudit.Do("Run app " + Name);

            var si = new ProcessStartInfo();
            si.FileName = Environment.ExpandEnvironmentVariables(Cmd);
            si.WorkingDirectory = !string.IsNullOrEmpty(WorkDir) ? Environment.ExpandEnvironmentVariables(WorkDir) : Path.GetDirectoryName(si.FileName);
            si.Arguments = Environment.ExpandEnvironmentVariables(Args);
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
                _process.Dispose();
                AddLog(Vars.Lang.AppLog_Terminated, false, true);

                EventAudit.Do("Terminated app " + Name);

                Running = false;
                _startTime = null;
                Memory = null;
                Processor = null;
                ProcCount = null;
                TcpOnline = false;
                DispatchApplicationAttributesChanged();

                if (Vars.Config.Apps.NotifyAppStops)
                {
                    if (!(Vars.Config.Apps.DontNotifyWhenAppsActive && Vars.FrmAppsObj != null && Form.ActiveForm == Vars.FrmAppsObj))
                    {
                        Vars.FrmMainObj.BeginInvoke(new MethodInvoker(() =>
                        {
                            Vars.FrmMainObj.tray.ShowBalloonTip(5000, Vars.Lang.AppTerminatedBalloonTitle, string.Format(Vars.Lang.AppTerminatedBalloonMsg, Name), ToolTipIcon.Info);
                        }));
                    }
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
            DispatchApplicationAttributesChanged();

            _process.BeginOutputReadLine();
            _process.BeginErrorReadLine();
        }

        public void Stop()
        {
            if (_stopping) return;
            _stopping = true;

            AddLog(Vars.Lang.AppLog_Stopping, false, true);
            EventAudit.Do("Stop app " + Name);

            Task.Run(() =>
            {
                try
                {
                    KillChildProcs(_process, 0);
                }
                catch (AbortException) { }
                finally
                {
                    _stopping = false;
                }
            });
        }

        private void KillChildProcs(Process parent, int level)
        {
            var children = Utils.GetChildProcesses(parent.Id);
            foreach (var child in children)
            {
                KillChildProcs(child, level+1);
                child.Dispose();
            }

            AddLog(string.Format(Vars.Lang.AppLog_TerminatingProcessLevel, level, parent.ProcessName, parent.Id), false, true);
            try
            {
                parent.Kill();
            } 
            catch (Exception ex)
            {
                AddLog(string.Format(Vars.Lang.AppLog_ErrorTerminating, parent.ProcessName, ex.Message), true);
                throw new AbortException();
            }
        }

        private void AddLog(string text, bool error, bool stop = false)
        {
            if (error && stop) throw new Exception("Invalid flags combining");

            if (text == null) text = "";

            LogRecord r = new();
            r.Timestamp = DateTime.Now;
            r.Text = text;
            if (stop)
            {
                r.Type = LogType.STOP;
            } else if (error)
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
            Interlocked.Add(ref _logSize, text.Length);

            while (Logs.Count>1 && _logSize > Vars.Config.Apps.MaxLogSize)
            {
                Interlocked.Add(ref _logSize, -Logs[0].Text.Length);
                Logs.RemoveAt(0);
            }

            LastLogTime = r.Timestamp.ToString(Vars.DATETIME_FMT);
            _lastLogIsError = error;

            if (Vars.FrmAppsObj == null || Vars.FrmAppsObj.GetSelApp() != this)
            {
                PendingLog = true;
            }

            Vars.FrmMainObj.UpdateTrayIcon();
        }

        private void DispatchApplicationAttributesChanged()
        {
            if (Vars.FrmAppsObj != null)
            {
                try
                {
                    Vars.FrmAppsObj.BeginInvoke(new MethodInvoker(() =>
                    {
                        Vars.FrmAppsObj.EventUpdated(this);
                    }));
                }
                catch (Exception)
                {
                    if (Vars.FrmAppsObj != null) throw; //when closing form, can throw an exception when refreshing controls???
                }
            }

            Vars.FrmMainObj.UpdateTrayIcon();
        }

        public bool CheckWebPort()
        {
            bool oldValue = TcpOnline;
            TcpOnline = Utils.TcpPortInUse(TcpPort.Value);

            return TcpOnline != oldValue;
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

            AnalyseResources();

            Debug.WriteLine("Finished Analyse App {0} {1}", debugArgs);
        }

        private void AnalyseResources()
        {
            try
            {
                var r = new Resources();
                r.Mem = 0;
                r.ProcessorTime = TimeSpan.Zero;
                r.ProcCount = 0;

                AnalyzeChildren(_process, r);

                if (Running) //can stop process when analysis running
                {
                    Memory = (r.Mem / 1024 / 1024).ToString("0.00") + " MB";

                    var utcNow = DateTime.UtcNow;
                    var percent = (r.ProcessorTime - _lastProcessorTime).TotalMilliseconds / (Environment.ProcessorCount * (utcNow - _lastProcessorCapture).TotalMilliseconds);
                    Processor = percent.ToString("0.00 %");

                    _lastProcessorTime = r.ProcessorTime;
                    _lastProcessorCapture = utcNow;

                    ProcCount = r.ProcCount.ToString();
                }
            }
            catch (AnalyzeException)
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
                child.Dispose();
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
                throw new AnalyzeException();
            }
        }

        private class AbortException : Exception { }
        private class AnalyzeException : Exception { }

    }
}
