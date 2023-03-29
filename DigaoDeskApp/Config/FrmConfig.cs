using System;
using System.Drawing;
using System.IO;
using System.Linq;
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

            BoxThemeAppLog.Text = Vars.Lang.Config_Theme_BoxAppLog;
            BoxThemeRepoLog.Text = Vars.Lang.Config_Theme_BoxRepoLog;
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
            lbColorStatusBack.Text = Vars.Lang.Config_Theme_ColorStatusBack;
            lbColorStatusFore.Text = Vars.Lang.Config_Theme_ColorStatusFore;
            lbColorAppLogNormal.Text = Vars.Lang.Config_Theme_ColorAppLogNormal;
            lbColorAppLogError.Text = Vars.Lang.Config_Theme_ColorAppLogError;
            lbColorAppLogDynWarn.Text = Vars.Lang.Config_Theme_ColorAppLogDynWarn;
            lbColorAppLogDynError.Text = Vars.Lang.Config_Theme_ColorAppLogDynError;
            lbColorAppLogStop.Text = Vars.Lang.Config_Theme_ColorAppLogStop;
            lbColorRepoLogNormal.Text = Vars.Lang.Config_Theme_ColorRepoLogNormal;
            lbColorRepoLogAlert.Text = Vars.Lang.Config_Theme_ColorRepoLogAlert;
            lbColorRepoLogError.Text = Vars.Lang.Config_Theme_ColorRepoLogError;
            lbColorRepoLogDone.Text = Vars.Lang.Config_Theme_ColorRepoLogDone;
            lbColorRepoLogTitle.Text = Vars.Lang.Config_Theme_ColorRepoLogTitle;
            lbColorRepoLogAggProcessing.Text = Vars.Lang.Config_Theme_ColorRepoLogAggProcessing;
            lbColorRepoLogProcessing.Text = Vars.Lang.Config_Theme_ColorRepoLogProcessing;
            lbColorRepoLogRefreshing.Text = Vars.Lang.Config_Theme_ColorRepoLogRefreshing;
            lbColorRepoLogRefreshDone.Text = Vars.Lang.Config_Theme_ColorRepoLogRefreshDone;
            lbColorRepoLogLabelCaption.Text = Vars.Lang.Config_Theme_ColorRepoLogLabelCaption;
            lbColorRepoLogLabelValue.Text = Vars.Lang.Config_Theme_ColorRepoLogLabelValue;
            lbColorRepoLogStatusOK.Text = Vars.Lang.Config_Theme_ColorRepoLogStatusOK;
            lbColorRepoLogStatusWarn.Text = Vars.Lang.Config_Theme_ColorRepoLogStatusWarn;
            lbColorRepoLogStatusNone.Text = Vars.Lang.Config_Theme_ColorRepoLogStatusNone;
            lbColorLogTimestampFore.Text = Vars.Lang.Config_Theme_ColorLogTimestampFore;
            lbConsoleFont.Text = Vars.Lang.Config_Theme_Font;
            ckLogShowTs.Text = Vars.Lang.Config_Theme_ShowDateTime;
            ckLogWordWrap.Text = Vars.Lang.Config_Theme_WordWrap;

            ckCalcAppResources.Text = Vars.Lang.Config_Apps_CalcResources;
            ckNotifyWhenAppStops.Text = Vars.Lang.Config_Apps_NotifyWhenStop;
            ckDontNotifyWhenAppsActive.Text = Vars.Lang.Config_Apps_DontNotifyStopWhenActive;
            lbAppsLinesLog.Text = Vars.Lang.Config_Apps_MaxLogSize;

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
            lbCustomCommands.Text = Vars.Lang.Config_Repos_CustomCommands;
            lbMemoInfo.Text = Vars.Lang.Config_Repos_MemoInfo;
            ckGitAutoCRLF.Text = Vars.Lang.Config_Repos_AutoCRLF;
            ckGitAutoFetch.Text = Vars.Lang.Config_Repos_AutoFetch;
            lbCommitMsg.Text = Vars.Lang.Config_Repos_CommitMsg;
            lbCommitMsgInfo.Text = Vars.Lang.Config_Repos_CommitMsgInfo;

            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        private void FrmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vars.FrmConfigObj = null;

            EventAudit.Do("Closed Config form");
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            EventAudit.Do("Load Config form");

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
            LoadOrSaveTheme(Vars.Config.Theme, false, true);
            //--

            //--Apps tab
            ckCalcAppResources.Checked = Vars.Config.Apps.CalcResources;
            ckNotifyWhenAppStops.Checked = Vars.Config.Apps.NotifyAppStops;
            ckDontNotifyWhenAppsActive.Checked = Vars.Config.Apps.DontNotifyWhenAppsActive;
            edAppLogMaxSize.Value = Vars.Config.Apps.MaxLogSize;
            //--

            //--Repos tab
            edReposDir.Text = Vars.Config.ReposDir;
            edShellProgram.Text = Vars.Config.ShellProgram;
            edDiffProgram.Text = Vars.Config.DiffProgram;
            edDiffProgramArguments.Text = Vars.Config.DiffProgramArguments;
            edGitNewBranchPrefixList.Text = Vars.Config.GitNewBranchPrefixList;
            edGitCustomCommands.Text = Vars.Config.GitCustomCommands;
            ckGitAutoCRLF.Checked = Vars.Config.GitAutoCRLF;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (edLanguage.SelectedItem == null)
            {
                Messages.Error(Vars.Lang.Config_InvalidLanguage);
                edLanguage.Select();
                return;
            }

            if (edAppLogMaxSize.Text == "" || edAppLogMaxSize.Value == 0)
            {
                Messages.Error(Vars.Lang.Config_AppMaxLogSizeRequired);
                edAppLogMaxSize.Select();
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
            LoadOrSaveTheme(Vars.Config.Theme, true);
            //--

            //--Apps tab
            Vars.Config.Apps.CalcResources = ckCalcAppResources.Checked;
            Vars.Config.Apps.NotifyAppStops = ckNotifyWhenAppStops.Checked;
            Vars.Config.Apps.DontNotifyWhenAppsActive = ckDontNotifyWhenAppsActive.Checked;
            Vars.Config.Apps.MaxLogSize = (int)edAppLogMaxSize.Value;
            //--

            //--Repos tab
            Vars.Config.ReposDir = edReposDir.Text;
            Vars.Config.ShellProgram = edShellProgram.Text;
            Vars.Config.DiffProgram = edDiffProgram.Text;
            Vars.Config.DiffProgramArguments = edDiffProgramArguments.Text;
            Vars.Config.GitNewBranchPrefixList = edGitNewBranchPrefixList.Text;
            Vars.Config.GitCustomCommands = edGitCustomCommands.Text;
            Vars.Config.GitAutoCRLF = ckGitAutoCRLF.Checked;
            Vars.Config.GitAutoFetch = ckGitAutoFetch.Checked;
            Vars.Config.GitCommitMessage = edCommitMessage.Text;

            Vars.Config.Git.Name = edGitName.Text;
            Vars.Config.Git.Email = edGitEmail.Text;

            Vars.Config.Git.CredUsername = edGitCredUsername.Text;
            Vars.Config.Git.CredPassword = edGitCredPassword.Text;
            //--

            Vars.Config.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogFont_Click(object sender, EventArgs e)
        {
            if (_dlgFont.ShowDialog() == DialogResult.OK)
            {
                UpdateFontButton();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DoSelColor((Button)sender);
        }

        private void DoSelColor(Button btn)
        {
            ColorDialog dlg = new();

            dlg.Color = btn.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SetButtonColor(btn, dlg.Color);
            }
        }

        private void SetButtonColor(Button btn, Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = Utils.GetNegativeColor(color);

            btn.Text = string.Format("{0}, {1}, {2}", color.R, color.G, color.B);
            btn.Font = new Font(btn.Font.FontFamily, 7);
        }

        private void btnSelReposDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new();

            dlg.SelectedPath = edReposDir.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edReposDir.Text = dlg.SelectedPath;
            }
        }

        private void btnSelShellProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new();

            dlg.FileName = edShellProgram.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edShellProgram.Text = dlg.FileName;
            }
        }

        private void btnSelDiffProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new();

            dlg.FileName = edDiffProgram.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edDiffProgram.Text = dlg.FileName;
            }
        }

        private void btnResetColors_Click(object sender, EventArgs e)
        {
            LoadOrSaveTheme(new Config.ConfigTheme(), false);
        }

        private void LoadOrSaveTheme(Config.ConfigTheme def, bool save, bool first = false)
        {
            foreach (var f in def.GetType().GetFields())
            {
                if (f.FieldType != typeof(Color)) continue;

                string controlName = "btnColor" + f.Name;
                var lstFind = tabTheme.Controls.Find(controlName, true);
                if (!lstFind.Any()) throw new Exception(string.Format("Control {0} not found", controlName));

                var btn = (Button)lstFind.First();

                if (first) btn.Click += btnColor_Click;

                if (save)
                {
                    f.SetValue(def, btn.BackColor);
                }
                else
                {
                    SetButtonColor(btn, (Color)f.GetValue(def));
                }
            }
        }

        private void btnCustomCommandsHelp_Click(object sender, EventArgs e)
        {
            Messages.Info(Vars.Lang.Config_Repos_CustomCommandsHelp);
        }

    }
}
