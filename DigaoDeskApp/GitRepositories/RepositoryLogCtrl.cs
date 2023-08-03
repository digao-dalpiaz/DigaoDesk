﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigaoDeskApp
{

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

    public class LogGroup
    {
        public RepositoryLogCtrl Master;
        public int? Position;

        private List<LogPart[]> _lines = new();

        public void Log(LogPart[] parts)
        {
            _lines.Add(parts);

            var ed = Master.EdControl;

            ed.Invoke(new MethodInvoker(() =>
            {
                if (!Position.HasValue)
                {
                    Position = ed.TextLength;
                }

                ed.SuspendPainting();
                try
                {
                    ed.SelectionStart = Position.Value;

                    if (parts.Any())
                    {
                        if (Vars.Config.Theme.ShowTimestamp)
                        {
                            ed.SelectionColor = Vars.Config.Theme.TimestampFore;
                            ed.SelectedText = GetTimestampPrefix();
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

                var dif = ed.SelectionStart - Position.Value;

                var idx = Master.Groups.IndexOf(this);
                for (int i = idx; i < Master.Groups.Count; i++)
                {
                    Master.Groups[i].Position += dif;
                }

                ed.SelectionStart = ed.TextLength;
            }));
        }

        private static string GetTimestampPrefix()
        {
            return DateTime.Now.ToString(Vars.DATETIME_FMT) + " - ";
        }

        public void Log()
        {
            Log(new LogPart[] { });
        }

        public void Log(string text, LogHighlightType type)
        {
            Log(new LogPart[] { new LogPart(text, LogHighlightTypeToColor(type), type == LogHighlightType.TITLE) });
        }

        public void LogLabel(string label, string value)
        {
            Log(new LogPart[] {
                new LogPart(label + ": ", Vars.Config.Theme.RepoLogLabelCaption),
                new LogPart(value, Vars.Config.Theme.RepoLogLabelValue)
            });
        }

        private static Color LogHighlightTypeToColor(LogHighlightType type)
        {
            switch (type)
            {
                case LogHighlightType.NORMAL:
                    return Vars.Config.Theme.RepoLogNormal;
                case LogHighlightType.ALERT:
                    return Vars.Config.Theme.RepoLogAlert;
                case LogHighlightType.ERROR:
                    return Vars.Config.Theme.RepoLogError;
                case LogHighlightType.TITLE:
                    return Vars.Config.Theme.RepoLogTitle;
                case LogHighlightType.AGG_PROCESSING:
                    return Vars.Config.Theme.RepoLogAggProcessing;
                case LogHighlightType.PROCESSING:
                    return Vars.Config.Theme.RepoLogProcessing;
                case LogHighlightType.DONE:
                    return Vars.Config.Theme.RepoLogDone;
                default:
                    throw new Exception("Invalid Log Highlight type");
            }
        }

        public void Save(string logFile)
        {
            StringBuilder sb = new();

            foreach (var line in _lines)
            {
                string info = null;
                if (line.Any())
                {
                    info = GetTimestampPrefix() + string.Join(null, line.Select(x => x.Text));
                }
                sb.AppendLine(info);
            }

            File.AppendAllText(logFile, sb.ToString());
        }

    }

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

    public class RepositoryLogCtrl
    {
        public RichTextBoxEx EdControl;
        public List<LogGroup> Groups = new();

        private string _logFile;

        public RepositoryLogCtrl(RichTextBoxEx ed, string logFile)
        {
            this.EdControl = ed;
            this._logFile = logFile;
        }

        public LogGroup InitGroup()
        {
            LogGroup g = new();
            g.Master = this;
            Groups.Add(g);

            g.Log(); //blank line
            return g;
        }

        public void TerminateGroup(LogGroup g)
        {
            Groups.Remove(g);

            g.Save(_logFile);
        }

        public void FastLog(Action<LogGroup> proc)
        {
            var g = InitGroup();
            proc(g);
            TerminateGroup(g);
        }

        public void ClearLog()
        {
            if (Groups.Any()) throw new Exception("Trying to clear log with cached groups");

            EdControl.Clear();
        }

    }

}
