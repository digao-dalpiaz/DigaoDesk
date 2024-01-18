using System.Runtime.InteropServices;

namespace DigaoDeskApp
{
    internal class Theme
    {

        public static void setToolStrip(ToolStrip c)
        {
            c.BackColor = Vars.Config.Theme.ToolbarBack;
            c.GripStyle = ToolStripGripStyle.Hidden;
            c.RenderMode = ToolStripRenderMode.Professional;

            c.Renderer = new TSRenderer();

            foreach (ToolStripItem item in c.Items)
            {
                item.ForeColor = Vars.Config.Theme.ToolbarFore;
            }
        }

        public static void setGrid(DataGridView c)
        {
            c.BackgroundColor = Vars.Config.Theme.GridBack;
            c.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            c.EnableHeadersVisualStyles = false;
            c.GridColor = Vars.Config.Theme.GridLines;

            c.ColumnHeadersDefaultCellStyle.BackColor = Vars.Config.Theme.GridHeadBack;
            c.ColumnHeadersDefaultCellStyle.SelectionBackColor = c.ColumnHeadersDefaultCellStyle.BackColor;
            c.ColumnHeadersDefaultCellStyle.ForeColor = Vars.Config.Theme.GridHeadFore;
            c.ColumnHeadersDefaultCellStyle.SelectionForeColor = c.ColumnHeadersDefaultCellStyle.ForeColor;

            c.RowTemplate.DefaultCellStyle.BackColor = Vars.Config.Theme.GridDataBack;
            c.RowTemplate.DefaultCellStyle.SelectionBackColor = Vars.Config.Theme.GridSelBack;
            c.RowTemplate.DefaultCellStyle.ForeColor = Vars.Config.Theme.GridDataFore;
            c.RowTemplate.DefaultCellStyle.SelectionForeColor = Vars.Config.Theme.GridSelFore;
        }

        public static void setSplitter(Splitter c)
        {
            c.BackColor = Vars.Config.Theme.SplitterBack;
        }

        public static void setConsole(RichTextBoxEx c)
        {
            c.Font = new Font(Vars.Config.Theme.FontName, Vars.Config.Theme.FontSize);
            c.BackColor = Vars.Config.Theme.ConsoleBack;

            c.WordWrap = Vars.Config.Theme.WordWrap;
        }

        public static void setStatusStrip(StatusStrip c)
        {
            c.BackColor = Vars.Config.Theme.StatusBack;

            c.Renderer = new TSRenderer();

            foreach (ToolStripItem item in c.Items)
            {
                if (item.ForeColor == SystemColors.ControlText)
                {
                    item.ForeColor = Vars.Config.Theme.StatusFore;
                }
            }
        }

        //

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        public static bool UseImmersiveDarkMode(IntPtr handle)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useImmersiveDarkMode = Vars.Config.Theme.DarkTitle ? 1 : 0;
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
