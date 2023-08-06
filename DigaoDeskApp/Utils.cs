using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

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

        public static bool IsProcessValid(Process process)
        {
            try
            {
                _ = process.Id;
                return true;
            }
            catch (InvalidOperationException) 
            {
                return false;
            }
        }

        public static List<Process> GetChildProcesses(Process parent)
        {
            var query = "Select ProcessId From Win32_Process Where ParentProcessId = " + parent.Id;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            List<Process> ret = new();
            foreach (ManagementObject mo in processList)
            {
                var pid = Convert.ToInt32(mo.GetPropertyValue("ProcessId"));
                Process proc;
                try
                {
                    proc = Process.GetProcessById(pid);
                }
                catch (ArgumentException) 
                {
                    continue; //PID already expired
                }
                ret.Add(proc);
            }
            return ret;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);

        private static void ThrowWinLastError()
        {
            throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
        }

        public static void TerminateProcess(Process process)
        {
            if (!TerminateProcess(process.Handle, 0))
            {
                ThrowWinLastError();
            }
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
            EventAudit.Do("Load resource " + resourceName);

            var assembly = Assembly.GetExecutingAssembly();

            var fullResName = "DigaoDeskApp." + resourceName;

            using (Stream stream = assembly.GetManifestResourceStream(fullResName))
            {
                if (stream == null) throw new Exception(string.Format("Resouce '{0}' not found", fullResName));

                using (StreamReader reader = new StreamReader(stream))
                    return reader.ReadToEnd();
            }
        }

        //-----------------------------------------------------------------

        public static string RemoveEsc(string text)
        {
            if (text != null)
            {
                text = Regex.Replace(text, @"\x1B.*?m", "");
            }
            return text;
        }

        //-----------------------------------------------------------------

        public static bool TcpPortInUse(ushort port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] lst = ipGlobalProperties.GetActiveTcpListeners();
            return lst.Any(x => x.Port == port);
        }

        //-----------------------------------------------------------------

        public static void DrawGridImage(ImageList images, DataGridViewCellPaintingEventArgs e, int imageIndex, bool right = false)
        {
            images.Draw(e.Graphics, 
                right ? e.CellBounds.Right-3-images.ImageSize.Width : e.CellBounds.X+3, 
                e.CellBounds.Y + ((e.CellBounds.Height - images.ImageSize.Height) / 2), imageIndex);
        }

        public static void SetGridDoubleBuffer(DataGridView g)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
                BindingFlags.Instance | BindingFlags.SetProperty, null,
                g, new object[] { true });
        }

        //-----------------------------------------------------------------

        private static int GetColorPartReversed(int part)
        {
            return part > 128 ? 0 : 255;
        }

        public static Color GetNegativeColor(Color color)
        {
            return Color.FromArgb(
                GetColorPartReversed(color.R),
                GetColorPartReversed(color.G),
                GetColorPartReversed(color.B)
            );
        }

        //-----------------------------------------------------------------

        public static void Navigate(string url)
        {
            Process.Start("explorer", url);
        }

        //-----------------------------------------------------------------

        public static string FindFolderInPathEnvironmentByFile(string filename)
        {
            var paths = Environment.GetEnvironmentVariable("PATH").Split(";");

            return paths.FirstOrDefault(folder => File.Exists(Path.Combine(folder, filename)));
        }

    }
}
