using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DigaoDeskApp
{
    public class CheckedListBoxEx : CheckedListBox
    {

        private Size _checkSize;
        private const int BOX_SPAN = 3;

        public int BoxAreaWidth
        {
            get
            {
                return BOX_SPAN + _checkSize.Width;
            }
        }

        public event DrawItemEventHandler CustomDrawItem;

        private bool _allowClick;

        public CheckedListBoxEx()
        {
            CheckOnClick = true;
        }

        public void SetItemHeight(int value)
        {
            var heightField = typeof(CheckedListBox).GetField("scaledListItemBordersHeight", BindingFlags.NonPublic | BindingFlags.Instance);
            heightField.SetValue(this, value - Font.Height);

            //must be set after ItemHeight
            _checkSize = CheckBoxRenderer.GetGlyphSize(Graphics.FromHwnd(Handle), CheckBoxState.CheckedNormal);
        }

        public void SurroundAllowingCheck(Action proc)
        {
            _allowClick = true;
            try
            {
                proc();
            }
            finally
            {
                _allowClick = false;
            }
        }

        private void InvertCheck(int index)
        {
            SurroundAllowingCheck(() => SetItemChecked(index, !GetItemChecked(index)));
        }

        protected override void OnItemCheck(ItemCheckEventArgs ice)
        {
            if (!_allowClick)
            {
                ice.NewValue = ice.CurrentValue;
            }
            
            //base.OnItemCheck(ice);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Point loc = PointToClient(Cursor.Position);
            for (int i = 0; i < Items.Count; i++)
            {
                Rectangle rec = GetItemRectangle(i);
                rec.Offset(BOX_SPAN, (rec.Height - _checkSize.Height) / 2);
                rec.Size = _checkSize;

                if (rec.Contains(loc))
                {
                    InvertCheck(i);
                    break;
                }
            }
            
            //base.OnMouseDown(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (SelectedIndex != -1)
                {
                    InvertCheck(SelectedIndex);
                }
            }

            //base.OnKeyDown(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (DesignMode) return;
            if (e.Index == -1) return;

            //e.DrawBackground();
            if (e.State.HasFlag(DrawItemState.Selected))
            {
                e.Graphics.FillRectangle(Brushes.Gold, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(BackColor), e.Bounds);
            }
            var status = GetItemChecked(e.Index) ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
            var p = new Point(e.Bounds.X + BOX_SPAN, e.Bounds.Y + ((e.Bounds.Height - _checkSize.Height) / 2));
            CheckBoxRenderer.DrawCheckBox(e.Graphics, p, status);
            if (CustomDrawItem != null)
            {
                CustomDrawItem(this, e);
            }
            //e.DrawFocusRectangle();

            //base.OnDrawItem(e);
        }

    }
}
