using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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

    }
}
