using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DigaoDeskApp
{

    public class RichTextBoxEx : RichTextBox
    {
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, Int32 wMsg, Int32 wParam, ref Point lParam);

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, Int32 wMsg, Int32 wParam, IntPtr lParam);

        const int WM_USER = 0x400;
        const int WM_SETREDRAW = 0x000B;
        const int EM_GETEVENTMASK = WM_USER + 59;
        const int EM_SETEVENTMASK = WM_USER + 69;
        const int EM_GETSCROLLPOS = WM_USER + 221;
        const int EM_SETSCROLLPOS = WM_USER + 222;

        Point _ScrollPoint;
        bool _Painting = true;
        IntPtr _EventMask;
        int _SuspendIndex = 0;
        int _SuspendLength = 0;

        public void SuspendPainting()
        {
            if (_Painting)
            {
                //--save position
                _SuspendIndex = this.SelectionStart;
                _SuspendLength = this.SelectionLength;
                SendMessage(this.Handle, EM_GETSCROLLPOS, 0, ref _ScrollPoint);
                //--

                SendMessage(this.Handle, WM_SETREDRAW, 0, IntPtr.Zero);
                _EventMask = SendMessage(this.Handle, EM_GETEVENTMASK, 0, IntPtr.Zero); // Stop sending of events

                _Painting = false;
            }
        }

        public void ResumePainting(bool restorePosition)
        {
            if (!_Painting)
            {
                if (restorePosition)
                {
                    this.Select(_SuspendIndex, _SuspendLength);
                    SendMessage(this.Handle, EM_SETSCROLLPOS, 0, ref _ScrollPoint);
                }
                
                SendMessage(this.Handle, EM_SETEVENTMASK, 0, _EventMask); // turn on events
                SendMessage(this.Handle, WM_SETREDRAW, 1, IntPtr.Zero);

                _Painting = true;
                this.Invalidate();
            }
        }
    }

}
