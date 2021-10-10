using System.Drawing;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmConfig : Form
    {

        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vars.FrmConfigObj = null;
        }

        private void FrmConfig_Load(object sender, System.EventArgs e)
        {
            selFont.Font = new Font(Vars.Config.Log.FontName, Vars.Config.Log.FontSize);
            UpdateFontButton();

            btnLogTextColor.BackColor = Vars.Config.Log.TextColor;
            btnLogBgColor.BackColor = Vars.Config.Log.BgColor;

            ckLogShowTs.Checked = Vars.Config.Log.ShowTimestamp;
            ckLogWordWrap.Checked = Vars.Config.Log.WordWrap;
            ckLogAutoScroll.Checked = Vars.Config.Log.AutoScroll;

            ckNotifyWhenAppStops.Checked = Vars.Config.NotifyAppStops;
        }

        private void UpdateFontButton()
        {
            btnLogFont.Text = $"{selFont.Font.Name}, {selFont.Font.Size}";
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            Vars.Config.Log.FontName = selFont.Font.Name;
            Vars.Config.Log.FontSize = selFont.Font.Size;

            Vars.Config.Log.TextColor = btnLogTextColor.BackColor;
            Vars.Config.Log.BgColor = btnLogBgColor.BackColor;

            Vars.Config.Log.ShowTimestamp = ckLogShowTs.Checked;
            Vars.Config.Log.WordWrap = ckLogWordWrap.Checked;
            Vars.Config.Log.AutoScroll = ckLogAutoScroll.Checked;

            Vars.Config.NotifyAppStops = ckNotifyWhenAppStops.Checked;

            Vars.Config.Save();

            if (Vars.FrmAppsObj != null)
            {
                Vars.FrmAppsObj.LoadConfig(); //reload window config
                Vars.FrmAppsObj.ReloadSelectedLog(); //reload log
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnLogFont_Click(object sender, System.EventArgs e)
        {
            if (selFont.ShowDialog() == DialogResult.OK)
            {
                UpdateFontButton();
            }

        }

        private void btnLogTextColor_Click(object sender, System.EventArgs e)
        {
            DoSelColor(btnLogTextColor);
        }

        private void btnLogBgColor_Click(object sender, System.EventArgs e)
        {
            DoSelColor(btnLogBgColor);
        }

        private void DoSelColor(Button btn)
        {
            selColor.Color = btn.BackColor;
            if (selColor.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = selColor.Color;
            }
        }
                
    }
}
