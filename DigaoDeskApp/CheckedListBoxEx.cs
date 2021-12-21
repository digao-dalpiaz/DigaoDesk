using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public class CheckedListBoxEx : CheckedListBox
    {

        private bool _allowClick;

        public CheckedListBoxEx()
        {
            CheckOnClick = true;
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
                rec.Width = 16;

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

    }
}
