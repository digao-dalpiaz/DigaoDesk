using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public class LogHighlight
    {

        public class Part
        {
            public string Text;
            public Color Color;
            public bool Bold;

            public Part(string text, Color color, bool bold = false)
            {
                this.Text = text;
                this.Color = color;
                this.Bold = bold;
            }
        }

        private RichTextBoxEx _edControl;

        public LogHighlight(RichTextBoxEx ed)
        {
            this._edControl = ed;
        }
        
        public void Log(Part[] parts)
        {
            _edControl.Invoke(new MethodInvoker(() =>
            {
                _edControl.SuspendPainting();

                _edControl.SelectionStart = _edControl.TextLength;

                if (Vars.Config.Log.ShowTimestamp && parts.Length > 0)
                {
                    _edControl.SelectionColor = Color.Gray;
                    _edControl.SelectedText = DateTime.Now.ToString(Vars.DATETIME_FMT) + " - ";
                }

                foreach (var part in parts)
                {
                    _edControl.SelectionColor = part.Color;
                    _edControl.SelectionFont = new Font(_edControl.Font, part.Bold ? FontStyle.Bold : FontStyle.Regular);
                    _edControl.SelectedText = part.Text;
                }

                _edControl.SelectedText = Environment.NewLine;

                _edControl.ResumePainting(false);
            }));
        }

        public void Log()
        {
            Log(new Part[] { });
        }

        public void Log(string text, Color color, bool bold = false)
        {
            Log(new Part[] { new Part(text, color, bold) });
        }

        public void LogLabel(string label, string value)
        {
            Log(new Part[] { new Part(label + ": ", Color.Wheat), new Part(value, Color.DodgerBlue) });
        }

    }

}
