﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
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
        DONE,
        REFRESHING,
        REFRESH_DONE
    }

    public class LogHighlight
    {

        public class Part
        {
            public string Text;
            public Color Color;
            public bool Bold;

            public Part(string text, Color color, bool bold = false)
            {
                Text = text;
                Color = color;
                Bold = bold;
            }
        }

        private RichTextBoxEx _edControl;
        private string _logFile;

        public LogHighlight(RichTextBoxEx ed, string logFile)
        {
            _edControl = ed;
            _logFile = logFile;
        }

        private string GetTimestampPrefix()
        {
            return DateTime.Now.ToString(Vars.DATETIME_FMT) + " - ";
        }

        private void SaveLog(Part[] parts)
        {
            string info = null;
            if (parts.Any())
            {
                info = GetTimestampPrefix() + string.Join(null, parts.Select(x => x.Text));
            }
            File.AppendAllText(_logFile, info + Environment.NewLine);
        }

        public void Log(Part[] parts)
        {
            _edControl.Invoke(new MethodInvoker(() =>
            {
                _edControl.SuspendPainting();

                _edControl.SelectionStart = _edControl.TextLength;

                if (parts.Any())
                {
                    if (Vars.Config.Theme.ShowTimestamp)
                    {
                        _edControl.SelectionColor = Vars.Config.Theme.TimestampFore;
                        _edControl.SelectedText = GetTimestampPrefix();
                    }

                    foreach (var part in parts)
                    {
                        _edControl.SelectionColor = part.Color;
                        _edControl.SelectionFont = new Font(_edControl.Font, part.Bold ? FontStyle.Bold : FontStyle.Regular);
                        _edControl.SelectedText = part.Text;
                    }
                }

                _edControl.SelectedText = Environment.NewLine;

                _edControl.ResumePainting(false);

                if (_logFile != null) SaveLog(parts);
            }));
        }

        public void Log()
        {
            Log(new Part[] { });
        }

        public void Log(string text, LogHighlightType type)
        {
            Log(new Part[] { new Part(text, LogHighlightTypeToColor(type), type == LogHighlightType.TITLE) });
        }

        public void LogLabel(string label, string value)
        {
            Log(new Part[] { 
                new Part(label + ": ", Vars.Config.Theme.RepoLogLabelCaptionFore), 
                new Part(value, Vars.Config.Theme.RepoLogLabelValueFore) 
            });
        }

        private static Color LogHighlightTypeToColor(LogHighlightType type)
        {
            switch (type)
            {
                case LogHighlightType.NORMAL: 
                    return Vars.Config.Theme.RepoLogNormalFore;
                case LogHighlightType.ALERT:
                    return Vars.Config.Theme.RepoLogAlertFore;
                case LogHighlightType.ERROR: 
                    return Vars.Config.Theme.RepoLogErrorFore;
                case LogHighlightType.TITLE: 
                    return Vars.Config.Theme.RepoLogTitleFore;
                case LogHighlightType.AGG_PROCESSING:
                    return Vars.Config.Theme.RepoLogAggProcessingFore;
                case LogHighlightType.PROCESSING:
                    return Vars.Config.Theme.RepoLogProcessingFore;
                case LogHighlightType.DONE: 
                    return Vars.Config.Theme.RepoLogDoneFore;
                case LogHighlightType.REFRESHING:
                    return Vars.Config.Theme.RepoLogRefreshing;
                case LogHighlightType.REFRESH_DONE:
                    return Vars.Config.Theme.RepoLogRefreshDone;
                default: 
                    throw new Exception("Invalid Log Highlight type");
            }
        }

    }

}