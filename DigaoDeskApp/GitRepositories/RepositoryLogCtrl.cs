using System.Text;

namespace DigaoDeskApp
{

    public class LogPart
    {
        public string Text;
        public Color Color;
        public bool Bold;

        public LogPart(string text, Color color, bool bold = false)
        {
            this.Text = text;
            this.Color = color;
            this.Bold = bold;
        }
    }

    public enum LogHighlightType
    {
        NORMAL,
        ALERT,
        ERROR,
        TITLE,
        AGG_PROCESSING,
        PROCESSING,
        DONE
    }

    internal class LogUtils
    {

        public static Color LogHighlightTypeToColor(LogHighlightType type)
        {
            return type switch
            {
                LogHighlightType.NORMAL => Vars.Config.Theme.RepoLogNormal,
                LogHighlightType.ALERT => Vars.Config.Theme.RepoLogAlert,
                LogHighlightType.ERROR => Vars.Config.Theme.RepoLogError,
                LogHighlightType.TITLE => Vars.Config.Theme.RepoLogTitle,
                LogHighlightType.AGG_PROCESSING => Vars.Config.Theme.RepoLogAggProcessing,
                LogHighlightType.PROCESSING => Vars.Config.Theme.RepoLogProcessing,
                LogHighlightType.DONE => Vars.Config.Theme.RepoLogDone,
                _ => throw new Exception("Invalid Log Highlight type"),
            };
        }

        public static string GetTimestampPrefix()
        {
            return DateTime.Now.ToString(Vars.DATETIME_FMT) + " - ";
        }

    }

    public class RepositoryLogCtrl
    {
        public RichTextBoxEx EdControl;
        public List<LogGroup> Groups = [];

        public object LockGroupsCtrl = new();
        public object LockFileCtrl = new();

        public RepositoryLogCtrl(RichTextBoxEx ed)
        {
            this.EdControl = ed;
        }

        public void SafeUI(Action proc)
        {
            EdControl.Invoke(new MethodInvoker(proc));
        }

        public LogGroup InitGroup()
        {
            LogGroup g = new();
            g.Master = this;

            lock (LockGroupsCtrl)
            {
                SafeUI(() =>
                {
                    g.Position = EdControl.TextLength;
                });

                Groups.Add(g);
            }

            g.Log(); //blank line
            return g;
        }

        public void TerminateGroup(LogGroup g)
        {
            lock (LockGroupsCtrl)
            {
                Groups.Remove(g);
            }

            g.Save(Vars.FrmReposObj.GetCurrentGitLogFile()); //here current Git Group is the same until task is complete (and only then the user can change group)
        }

        public void FastLog(Action<LogGroup> proc)
        {
            var g = InitGroup();
            proc(g);
            TerminateGroup(g);
        }

        public void ClearLog()
        {
            if (Groups.Count > 0) throw new Exception("Trying to clear log with cached groups");

            EdControl.Clear();
        }

    }

    public class LogGroup
    {
        public RepositoryLogCtrl Master;
        public int Position;

        public readonly Guid Ident = Guid.NewGuid();

        private readonly List<LogPart[]> _lines = [];

        public void Log(LogPart[] parts)
        {
            _lines.Add(parts);

            var ed = Master.EdControl;

            //lock inside SafeUI to ensure correct position in list
            lock (Master.LockGroupsCtrl)
            {
                int? dif = null;

                Master.SafeUI(() =>
                {
                    ed.SuspendPainting();
                    try
                    {
                        ed.SelectionStart = Position;

                        //ed.SelectionColor = Color.White;
                        //ed.SelectedText = Ident.ToString() + " > ";

                        if (parts.Length > 0)
                        {
                            if (Vars.Config.Theme.ShowTimestamp)
                            {
                                ed.SelectionColor = Vars.Config.Theme.TimestampFore;
                                ed.SelectedText = LogUtils.GetTimestampPrefix();
                            }

                            foreach (var part in parts)
                            {
                                ed.SelectionColor = part.Color;
                                ed.SelectionFont = new Font(ed.Font, part.Bold ? FontStyle.Bold : FontStyle.Regular);
                                ed.SelectedText = part.Text;
                            }
                        }

                        ed.SelectedText = Environment.NewLine;
                    }
                    finally
                    {
                        ed.ResumePainting(false);
                    }

                    dif = ed.SelectionStart - Position;

                    ed.SelectionStart = ed.TextLength;
                });

                var idx = Master.Groups.IndexOf(this);
                for (int i = idx; i < Master.Groups.Count; i++)
                {
                    Master.Groups[i].Position += dif.Value;
                }
            }
        }

        public void Log()
        {
            Log([]);
        }

        public void Log(string text, LogHighlightType type)
        {
            Log([new(text, LogUtils.LogHighlightTypeToColor(type), type == LogHighlightType.TITLE)]);
        }

        public void LogLabel(string label, string value)
        {
            Log([
                new(label + ": ", Vars.Config.Theme.RepoLogLabelCaption),
                new(value, Vars.Config.Theme.RepoLogLabelValue)
            ]);
        }

        public void Save(string logFile)
        {
            StringBuilder sb = new();

            foreach (var line in _lines)
            {
                string info = null;
                if (line.Length > 0)
                {
                    info = LogUtils.GetTimestampPrefix() + string.Join(null, line.Select(x => x.Text));
                }
                sb.AppendLine(info);
            }
            
            lock (Master.LockFileCtrl)
            {
                File.AppendAllText(logFile, sb.ToString());
            }
        }

    }

}
