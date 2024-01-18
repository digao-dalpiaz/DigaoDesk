using System.Runtime.InteropServices;

namespace DigaoDeskApp
{
    static class FormExtensions
    {
        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, uint Msg);

        private const uint SW_RESTORE = 0x09;

        public static void Restore(this Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
            {
                _ = ShowWindow(form.Handle, SW_RESTORE);
            }
        }
    }
    
}
