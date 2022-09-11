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
            tabTheme.Text = Vars.Lang.Config_Tab_Theme;
            tabApplications.Text = Vars.Lang.Config_Tab_Applications;
            tabRepos.Text = Vars.Lang.Config_Tab_Repositories;

            lbLanguage.Text = Vars.Lang.Config_General_Language;
            lbLanguageInfo.Text = Vars.Lang.Config_General_LanguageInfo;

            btnResetColors.Text = Vars.Lang.Config_Theme_Reset;
            ckThemeDarkTitle.Text = Vars.Lang.Config_Theme_DarkTitle;
            lbColorToolbarBack.Text = Vars.Lang.Config_Theme_ColorToolbarBack;
            lbColorToolbarFore.Text = Vars.Lang.Config_Theme_ColorToolbarFore;
            lbColorGridHeadBack.Text = Vars.Lang.Config_Theme_ColorGridHeadBack;
            lbColorGridHeadFore.Text = Vars.Lang.Config_Theme_ColorGridHeadFore;
            lbColorGridBack.Text = Vars.Lang.Config_Theme_ColorGridBack;
            lbColorGridLines.Text = Vars.Lang.Config_Theme_ColorGridLines;
            lbColorGridDataBack.Text = Vars.Lang.Config_Theme_ColorGridDataBack;
            lbColorGridDataFore.Text = Vars.Lang.Config_Theme_ColorGridDataFore;
            lbColorGridSelBack.Text = Vars.Lang.Config_Theme_ColorGridSelBack;
            lbColorGridSelFore.Text = Vars.Lang.Config_Theme_ColorGridSelFore;
            lbColorSplitterBack.Text = Vars.Lang.Config_Theme_ColorSplitterBack;
            lbColorConsoleBack.Text = Vars.Lang.Config_Theme_ColorConsoleBack;
            lbColorConsoleFore.Text = Vars.Lang.Config_Theme_ColorConsoleFore;
            lbColorStatusBack.Text = Vars.Lang.Config_Theme_ColorStatusBack;
            lbColorStatusFore.Text = Vars.Lang.Config_Theme_ColorStatusFore;
            lbConsoleFont.Text = Vars.Lang.Config_Theme_Font;
            ckLogShowTs.Text = Vars.Lang.Config_Theme_ShowDateTime;
            ckLogWordWrap.Text = Vars.Lang.Config_Theme_WordWrap;

            ckNotifyWhenAppStops.Text = Vars.Lang.Config_Apps_NotifyWhenStop;
            ckDontNotifyWhenAppsActive.Text = Vars.Lang.Config_Apps_DontNotifyStopWhenActive;
            lbAppsLinesLog.Text = Vars.Lang.Config_Apps_LinesLog;

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
            
            //--Theme tab
            _dlgFont.Font = new Font(Vars.Config.Theme.FontName, Vars.Config.Theme.FontSize);
            UpdateFontButton();

            ckLogShowTs.Checked = Vars.Config.Theme.ShowTimestamp;
            ckLogWordWrap.Checked = Vars.Config.Theme.WordWrap;

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
            //--

            //--Apps tab
            ckNotifyWhenAppStops.Checked = Vars.Config.Apps.NotifyAppStops;
            ckDontNotifyWhenAppsActive.Checked = Vars.Config.Apps.DontNotifyWhenAppsActive;
            edAppsLinesLog.Value = Vars.Config.Apps.LinesLog;
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

            if (edAppsLinesLog.Text == "" || edAppsLinesLog.Value == 0)
            {
                Messages.Error(Vars.Lang.Config_AppLogLinesRequired);
                edAppsLinesLog.Select();
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

            //--Theme tab
            Vars.Config.Theme.FontName = _dlgFont.Font.Name;
            Vars.Config.Theme.FontSize = _dlgFont.Font.Size;

            Vars.Config.Theme.ShowTimestamp = ckLogShowTs.Checked;
            Vars.Config.Theme.WordWrap = ckLogWordWrap.Checked;

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
            //--

            //--Apps tab
            Vars.Config.Apps.NotifyAppStops = ckNotifyWhenAppStops.Checked;
            Vars.Config.Apps.DontNotifyWhenAppsActive = ckDontNotifyWhenAppsActive.Checked;
            Vars.Config.Apps.LinesLog = (int)edAppsLinesLog.Value;
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

        private void btnResetColors_Click(object sender, System.EventArgs e)
        {
            Config.ConfigTheme def = new();

            btnColorToolbarBack.BackColor = def.ToolbarBack;
            btnColorToolbarFore.BackColor = def.ToolbarFore;
            btnColorGridHeadBack.BackColor = def.GridHeadBack;
            btnColorGridHeadFore.BackColor = def.GridHeadFore;
            btnColorGridBack.BackColor = def.GridBack;
            btnColorGridLines.BackColor = def.GridLines;
            btnColorGridDataBack.BackColor = def.GridDataBack;
            btnColorGridDataFore.BackColor = def.GridDataFore;
            btnColorGridSelBack.BackColor = def.GridSelBack;
            btnColorGridSelFore.BackColor = def.GridSelFore;
            btnColorSplitterBack.BackColor = def.SplitterBack;
            btnColorConsoleBack.BackColor = def.ConsoleBack;
            btnColorConsoleFore.BackColor = def.ConsoleFore;
            btnColorStatusBack.BackColor = def.StatusBack;
            btnColorStatusFore.BackColor = def.StatusFore;
        }

    }
}
