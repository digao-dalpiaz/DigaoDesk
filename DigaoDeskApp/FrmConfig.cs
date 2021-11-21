using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmConfig : Form
    {

        private FontDialog _dlgFont;

        public FrmConfig()
        {
            InitializeComponent();

            _dlgFont = new();
            _dlgFont.ShowEffects = false;
        }

        private void FrmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vars.FrmConfigObj = null;
        }

        private void FrmConfig_Load(object sender, System.EventArgs e)
        {
            //--Apps tab
            _dlgFont.Font = new Font(Vars.Config.Log.FontName, Vars.Config.Log.FontSize);
            UpdateFontButton();

            btnLogTextColor.BackColor = Vars.Config.Log.TextColor;
            btnLogBgColor.BackColor = Vars.Config.Log.BgColor;

            ckLogShowTs.Checked = Vars.Config.Log.ShowTimestamp;
            ckLogWordWrap.Checked = Vars.Config.Log.WordWrap;

            ckNotifyWhenAppStops.Checked = Vars.Config.NotifyAppStops;
            CkDontNotifyWhenAppsActive.Checked = Vars.Config.DontNotifyWhenAppsActive;
            //--

            //--Repos tab
            edReposDir.Text = Vars.Config.ReposDir;
            edShellProgram.Text = Vars.Config.ShellProgram;

            edGitName.Text = Vars.Config.Git.Name;
            edGitEmail.Text = Vars.Config.Git.Email;

            edGitCredUsername.Text = Vars.Config.Git.CredUsername;
            edGitCredPassword.Text = Vars.Config.Git.CredPassword;
            //--
        }

        private void UpdateFontButton()
        {
            btnLogFont.Text = $"{_dlgFont.Font.Name}, {_dlgFont.Font.Size}";
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            edReposDir.Text = edReposDir.Text.Trim();
            if (edReposDir.Text != string.Empty)
            {
                if (!Directory.Exists(edReposDir.Text))
                {
                    Messages.Error("Git repository folder not found");
                    edReposDir.Select();
                    return;
                }
            }

            edShellProgram.Text = edShellProgram.Text.Trim();

            edGitName.Text = edGitName.Text.Trim();
            edGitEmail.Text = edGitEmail.Text.Trim();
            edGitCredUsername.Text = edGitCredUsername.Text.Trim();

            //

            //--Apps tab
            Vars.Config.Log.FontName = _dlgFont.Font.Name;
            Vars.Config.Log.FontSize = _dlgFont.Font.Size;

            Vars.Config.Log.TextColor = btnLogTextColor.BackColor;
            Vars.Config.Log.BgColor = btnLogBgColor.BackColor;

            Vars.Config.Log.ShowTimestamp = ckLogShowTs.Checked;
            Vars.Config.Log.WordWrap = ckLogWordWrap.Checked;

            Vars.Config.NotifyAppStops = ckNotifyWhenAppStops.Checked;
            Vars.Config.DontNotifyWhenAppsActive = CkDontNotifyWhenAppsActive.Checked;
            //--

            //--Repos tab
            Vars.Config.ReposDir = edReposDir.Text;
            Vars.Config.ShellProgram = edShellProgram.Text;

            Vars.Config.Git.Name = edGitName.Text;
            Vars.Config.Git.Email = edGitEmail.Text;

            Vars.Config.Git.CredUsername = edGitCredUsername.Text;
            Vars.Config.Git.CredPassword = edGitCredPassword.Text;
            //--

            Vars.Config.Save();

            if (Vars.FrmAppsObj != null) Vars.FrmAppsObj.LoadConfig();
            if (Vars.FrmReposObj != null) Vars.FrmReposObj.LoadConfig();

            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnLogFont_Click(object sender, System.EventArgs e)
        {
            if (_dlgFont.ShowDialog() == DialogResult.OK)
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
            ColorDialog dlg = new();

            dlg.Color = btn.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = dlg.Color;
            }
        }

        private void btnSelReposDir_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog dlg = new();

            dlg.SelectedPath = edReposDir.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edReposDir.Text = dlg.SelectedPath;
            }
        }

        private void btnSelShellProgramDir_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new();

            dlg.FileName = edShellProgram.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edShellProgram.Text = dlg.FileName;
            }
        }

    }
}
