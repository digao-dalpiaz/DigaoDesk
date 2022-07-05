using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    class Utils
    {

        public static void LoadWindowStateFromRegistry(Form f, string key) {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(key + @"\Wnd");

            if ((int)r.GetValue("Stored", 0) != 1) return;

            var wpTemp = GetPlacement();
            wpTemp.rcNormalPosition = new System.Drawing.Rectangle(
                (int)r.GetValue("X"),
                (int)r.GetValue("Y"),
                (int)r.GetValue("W"),
                (int)r.GetValue("H"));

            if ((int)r.GetValue("Max") == 1)
            {
                wpTemp.showCmd = ShowWindowCommands.Maximized;
            }

            SetWindowPlacement(f.Handle, ref wpTemp);
        }

        public static void SaveWindowStateToRegistry(Form f, string key) {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(key + @"\Wnd");

            var wpTemp = GetPlacement();
            GetWindowPlacement(f.Handle, ref wpTemp);

            r.SetValue("X", wpTemp.rcNormalPosition.Left);
            r.SetValue("Y", wpTemp.rcNormalPosition.Top);

            r.SetValue("W", wpTemp.rcNormalPosition.Right - wpTemp.rcNormalPosition.Left);
            r.SetValue("H", wpTemp.rcNormalPosition.Bottom - wpTemp.rcNormalPosition.Top);

            r.SetValue("Max", wpTemp.showCmd == ShowWindowCommands.Maximized ? 1 : 0);
            r.SetValue("Stored", 1);
        }

        private static WINDOWPLACEMENT GetPlacement()
        {
            WINDOWPLACEMENT placement = new();
            placement.length = Marshal.SizeOf(placement);
            return placement;
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        internal struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public ShowWindowCommands showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        internal enum ShowWindowCommands : int
        {
            Hide = 0,
            Normal = 1,
            Minimized = 2,
            Maximized = 3,
        }

        //-----------------------------------------------------------------

        public static string GridColumnsToString(DataGridView g) { 
            var lst = new List<string>();

            foreach (DataGridViewColumn col in g.Columns) {
                if (col.Resizable == DataGridViewTriState.True) {
                    lst.Add($"{col.Name}={col.Width}");
                }
            }

            return String.Join(";", lst);
        }


        public static void StringToGridColumns(string a, DataGridView g) {
            var lst = a.Split(";");

            foreach (var item in lst) {
                var dados = item.Split("=");
                if (dados.Length != 2) continue;

                var col = g.Columns[dados[0]];
                if (col != null) {
                    if (col.Resizable == DataGridViewTriState.True) {
                        col.Width = int.Parse(dados[1]);
                    }
                }
            }
        }

        //-----------------------------------------------------------------

        public static List<Process> GetChildProcesses(int parentId)
        {
            var query = "Select ProcessId From Win32_Process Where ParentProcessId = " + parentId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            List<Process> ret = new();
            foreach (ManagementObject mo in processList)
            {
                ret.Add(Process.GetProcessById(Convert.ToInt32(mo.GetPropertyValue("ProcessId"))));
            }
            return ret;
        }

        //-----------------------------------------------------------------

        public static void BeginUpdate(Control ctrl)
        {
            SendMessage(ctrl.Handle, WM_SETREDRAW, (IntPtr)0, IntPtr.Zero);
        }

        public static void EndUpdate(Control ctrl)
        {
            SendMessage(ctrl.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            ctrl.Invalidate();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int WM_SETREDRAW = 0x0b;

        //-----------------------------------------------------------------

        public static void AdjustToolStrip(ToolStrip c)
        {
            int? max = null;
            foreach (ToolStripItem item in c.Items)
            {
                item.AutoSize = true;
                if (max == null || max < item.Width)
                {
                    max = item.Width;
                }
            }

            foreach (ToolStripItem item in c.Items)
            {
                if (item is ToolStripSeparator) continue;

                item.AutoSize = false;
                item.Width = max.Value;
            }
        }

        //-----------------------------------------------------------------

        public static bool IsSameGridColumn(DataGridViewColumn c1, DataGridViewColumn c2)
        {
            return c1.Name == c2.Name;
        }

        //-----------------------------------------------------------------

        public static string GetResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var fullResName = "DigaoDeskApp." + resourceName;

            using (Stream stream = assembly.GetManifestResourceStream(fullResName))
            {
                if (stream == null) throw new Exception(string.Format("Resouce '{0}' not found", fullResName));

                using (StreamReader reader = new StreamReader(stream))
                    return reader.ReadToEnd();
            }
        }

    }
}
