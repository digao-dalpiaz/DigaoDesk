using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DigaoDeskApp
{
    internal class Theme
    {

        private static Color BACK_COLOR = Color.FromArgb(30, 30, 30);

        public static void setToolStrip(ToolStrip c)
        {
            c.BackColor = BACK_COLOR;
            c.GripStyle = ToolStripGripStyle.Hidden;
            c.RenderMode = ToolStripRenderMode.Professional;

            c.Renderer = new TSRenderer();

            foreach (ToolStripItem item in c.Items)
            {
                item.ForeColor = Color.White;
            }
        }

        public static void setGrid(DataGridView c)
        {
            c.BackgroundColor = BACK_COLOR;
            c.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            c.EnableHeadersVisualStyles = false;
            c.GridColor = Color.DimGray;

            c.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            c.ColumnHeadersDefaultCellStyle.SelectionBackColor = c.ColumnHeadersDefaultCellStyle.BackColor;
            c.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            c.RowTemplate.DefaultCellStyle.BackColor = BACK_COLOR;
            c.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 0);
            c.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 192);
            c.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        public static void setSplitter(Splitter c)
        {
            c.BackColor = Color.FromArgb(64, 64, 64);
        }

        public static void setStatusStrip(StatusStrip c)
        {
            c.BackColor = BACK_COLOR;

            foreach (ToolStripStatusLabel item in c.Items)
            {
                if (item.ForeColor == SystemColors.ControlText)
                {
                    item.ForeColor = Color.Silver;
                }
            }
        }

        //

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        public static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }

        private static bool IsWindows10OrGreater(int build)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }

    }
}
