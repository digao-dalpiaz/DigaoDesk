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

            LoadLang();
            LoadLanguageList();

            btnSelReposDir.Height = edReposDir.Height;
            btnSelShellProgram.Height = edShellProgram.Height;
            btnSelDiffProgram.Height = edDiffProgram.Height;

            _dlgFont = new();
            _dlgFont.ShowEffects = false;
        }

        private void LoadLang()
        {
            this.Text = Vars.Lang.Config_Title;

            tabGeneral.Text = Vars.Lang.Config_Tab_General;
            tabLogs.Text = Vars.Lang.Config_Tab_Logs;
            tabApplications.Text = Vars.Lang.Config_Tab_Applications;
            tabRepos.Text = Vars.Lang.Config_Tab_Repositories;

            lbLanguage.Text = Vars.Lang.Config_General_Language;
            lbLanguageInfo.Text = Vars.Lang.Config_General_LanguageInfo;

            lbConsoleFont.Text = Vars.Lang.Config_Logs_Font;
            lbColorConsoleFore.Text = Vars.Lang.Config_Logs_TextColor;
            lbColorConsoleBack.Text = Vars.Lang.Config_Logs_BackgroundColor;
            ckLogShowTs.Text = Vars.Lang.Config_Logs_ShowDateTime;
            ckLogWordWrap.Text = Vars.Lang.Config_Logs_WordWrap;

            ckNotifyWhenAppStops.Text = Vars.Lang.Config_Apps_NotifyWhenStop;
            CkDontNotifyWhenAppsActive.Text = Vars.Lang.Config_Apps_DontNotifyStopWhenActive;

            lbRepositoryFolder.Text = Vars.Lang.Config_Repos_Folder;
            boxGitAuthor.Text = Vars.Lang.Config_Repos_BoxAuthor;
            lbAuthorName.Text = Vars.Lang.Config_Repos_Author_Name;
            lbAuthorEmail.Text = Vars.Lang.Config_Repos_Author_Email;
            boxGitCredentials.Text = Vars.Lang.Config_Repos_BoxCredentials;
            lbCredUsername.Text = Vars.Lang.Config_Repos_Credentials_Username;
            lbCredPassword.Text = Vars.Lang.Config_Repos_Credentials_Password;
            lbShellProgram.Text = Vars.Lang.Config_Repos_ShellProgram;
            lbDiffProgram.Text = Vars.Lang.Config_Repos_DiffProgram;
            lbDifProgramArgs.Text = Vars.Lang.Config_Repos_DiffProgramArgs;
            lbDifProgramArgsInfo.Text = Vars.Lang.Config_Repos_DiffProgramArgsInfo;
            lbNewBranchPrefix.Text = Vars.Lang.Config_Repos_NewBranchPrefixList;
            lbNewBranchPrefixInfo.Text = Vars.Lang.Config_Repos_NewBranchPrefixListInfo;
            ckGitAutoFetch.Text = Vars.Lang.Config_Repos_AutoFetch;
            lbCommitMsg.Text = Vars.Lang.Config_Repos_CommitMsg;
            lbCommitMsgInfo.Text = Vars.Lang.Config_Repos_CommitMsgInfo;

            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        private void FrmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vars.FrmConfigObj = null;
        }

        private void FrmConfig_Load(object sender, System.EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            edLanguage.SelectedItem = LangEngine.GetDefinitionByValue(Vars.Config.Language);
            
            _dlgFont.Font = new Font(Vars.Config.Log.FontName, Vars.Config.Log.FontSize);
            UpdateFontButton();

            ckLogShowTs.Checked = Vars.Config.Log.ShowTimestamp;
            ckLogWordWrap.Checked = Vars.Config.Log.WordWrap;

            ckThemeDarkTitle.Checked = Vars.Config.Theme.DarkTitle;
            btnColorToolbarBack.BackColor = Vars.Config.Theme.ToolbarBack;
            btnColorToolbarFore.BackColor = Vars.Config.Theme.ToolbarFore;
            btnColorGridHeadBack.BackColor = Vars.Config.Theme.GridHeadBack;
            btnColorGridHeadFore.BackColor = Vars.Config.Theme.GridHeadFore;
            btnColorGridBack.BackColor = Vars.Config.Theme.GridBack;
            btnColorGridLines.BackColor = Vars.Config.Theme.GridLines;
            btnColorGridDataBack.BackColor = Vars.Config.Theme.GridDataBack;
            btnColorGridDataFore.BackColor = Vars.Config.Theme.GridDataFore;
            btnColorGridSelBack.BackColor = Vars.Config.Theme.GridSelBack;
            btnColorGridSelFore.BackColor = Vars.Config.Theme.GridSelFore;
            btnColorSplitterBack.BackColor = Vars.Config.Theme.SplitterBack;
            btnColorConsoleBack.BackColor = Vars.Config.Theme.ConsoleBack;
            btnColorConsoleFore.BackColor = Vars.Config.Theme.ConsoleFore;
            btnColorStatusBack.BackColor = Vars.Config.Theme.StatusBack;
            btnColorStatusFore.BackColor = Vars.Config.Theme.StatusFore;

            //--Apps tab
            ckNotifyWhenAppStops.Checked = Vars.Config.NotifyAppStops;
            CkDontNotifyWhenAppsActive.Checked = Vars.Config.DontNotifyWhenAppsActive;
            //--

            //--Repos tab
            edReposDir.Text = Vars.Config.ReposDir;
            edShellProgram.Text = Vars.Config.ShellProgram;
            edDiffProgram.Text = Vars.Config.DiffProgram;
            edDiffProgramArguments.Text = Vars.Config.DiffProgramArguments;
            edGitNewBranchPrefixList.Text = Vars.Config.GitNewBranchPrefixList;
            ckGitAutoFetch.Checked = Vars.Config.GitAutoFetch;
            edCommitMessage.Text = Vars.Config.GitCommitMessage;

            edGitName.Text = Vars.Config.Git.Name;
            edGitEmail.Text = Vars.Config.Git.Email;

            edGitCredUsername.Text = Vars.Config.Git.CredUsername;
            edGitCredPassword.Text = Vars.Config.Git.CredPassword;
            //--
        }

        private void LoadLanguageList()
        {
            foreach (var lang in LangEngine.Definitions)
            {
                edLanguage.Items.Add(lang);
            }
        }

        private void UpdateFontButton()
        {
            btnLogFont.Text = $"{_dlgFont.Font.Name}, {_dlgFont.Font.Size}";
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (edLanguage.SelectedItem == null)
            {
                Messages.Error(Vars.Lang.Config_InvalidLanguage);
                edLanguage.Select();
                return;
            }

            edReposDir.Text = edReposDir.Text.Trim();
            if (edReposDir.Text != string.Empty)
            {
                if (!Directory.Exists(edReposDir.Text))
                {
                    Messages.Error(Vars.Lang.Config_GitRepositoryNotFound);
                    edReposDir.Select();
                    return;
                }
            }

            edShellProgram.Text = edShellProgram.Text.Trim();

            edDiffProgram.Text = edDiffProgram.Text.Trim();
            edDiffProgramArguments.Text = edDiffProgramArguments.Text.Trim();

            edGitName.Text = edGitName.Text.Trim();
            edGitEmail.Text = edGitEmail.Text.Trim();
            edGitCredUsername.Text = edGitCredUsername.Text.Trim();

            //

            SaveSettings();

            if (Vars.FrmAppsObj != null) Vars.FrmAppsObj.LoadConfig();
            if (Vars.FrmReposObj != null) Vars.FrmReposObj.LoadConfig();

            this.Close();
        }

        private void SaveSettings()
        {
            Vars.Config.Language = ((LangEngine.Definition)edLanguage.SelectedItem).Value;

            Vars.Config.Log.FontName = _dlgFont.Font.Name;
            Vars.Config.Log.FontSize = _dlgFont.Font.Size;

            Vars.Config.Log.ShowTimestamp = ckLogShowTs.Checked;
            Vars.Config.Log.WordWrap = ckLogWordWrap.Checked;

            Vars.Config.Theme.DarkTitle = ckThemeDarkTitle.Checked;
            Vars.Config.Theme.ToolbarBack = btnColorToolbarBack.BackColor;
            Vars.Config.Theme.ToolbarFore = btnColorToolbarFore.BackColor;
            Vars.Config.Theme.GridHeadBack = btnColorGridHeadBack.BackColor;
            Vars.Config.Theme.GridHeadFore = btnColorGridHeadFore.BackColor;
            Vars.Config.Theme.GridBack = btnColorGridBack.BackColor;
            Vars.Config.Theme.GridLines = btnColorGridLines.BackColor;
            Vars.Config.Theme.GridDataBack = btnColorGridDataBack.BackColor;
            Vars.Config.Theme.GridDataFore = btnColorGridDataFore.BackColor;            
            Vars.Config.Theme.GridSelBack = btnColorGridSelBack.BackColor;
            Vars.Config.Theme.GridSelFore = btnColorGridSelFore.BackColor;
            Vars.Config.Theme.SplitterBack = btnColorSplitterBack.BackColor;
            Vars.Config.Theme.ConsoleBack = btnColorConsoleBack.BackColor;
            Vars.Config.Theme.ConsoleFore = btnColorConsoleFore.BackColor;
            Vars.Config.Theme.StatusBack = btnColorStatusBack.BackColor;
            Vars.Config.Theme.StatusFore = btnColorStatusFore.BackColor;

            //--Apps tab
            Vars.Config.NotifyAppStops = ckNotifyWhenAppStops.Checked;
            Vars.Config.DontNotifyWhenAppsActive = CkDontNotifyWhenAppsActive.Checked;
            //--

            //--Repos tab
            Vars.Config.ReposDir = edReposDir.Text;
            Vars.Config.ShellProgram = edShellProgram.Text;
            Vars.Config.DiffProgram = edDiffProgram.Text;
            Vars.Config.DiffProgramArguments = edDiffProgramArguments.Text;
            Vars.Config.GitNewBranchPrefixList = edGitNewBranchPrefixList.Text;
            Vars.Config.GitAutoFetch = ckGitAutoFetch.Checked;
            Vars.Config.GitCommitMessage = edCommitMessage.Text;

            Vars.Config.Git.Name = edGitName.Text;
            Vars.Config.Git.Email = edGitEmail.Text;

            Vars.Config.Git.CredUsername = edGitCredUsername.Text;
            Vars.Config.Git.CredPassword = edGitCredPassword.Text;
            //--

            Vars.Config.Save();
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

        private void btnColor_Click(object sender, System.EventArgs e)
        {
            DoSelColor((Button)sender);
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

        private void btnSelShellProgram_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new();

            dlg.FileName = edShellProgram.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edShellProgram.Text = dlg.FileName;
            }
        }

        private void btnSelDiffProgram_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new();

            dlg.FileName = edDiffProgram.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edDiffProgram.Text = dlg.FileName;
            }
        }

    }
}
