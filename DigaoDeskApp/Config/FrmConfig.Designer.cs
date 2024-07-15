
namespace DigaoDeskApp
{
    partial class FrmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pages = new TabControl();
            tabGeneral = new TabPage();
            lbLanguageInfo = new Label();
            lbLanguage = new Label();
            edLanguage = new ComboBox();
            tabTheme = new TabPage();
            BoxThemeConsole = new GroupBox();
            btnLogFont = new Button();
            lbConsoleFont = new Label();
            ckLogShowTs = new CheckBox();
            lbColorLogTimestampFore = new Label();
            ckLogWordWrap = new CheckBox();
            btnColorTimestampFore = new Button();
            btnColorConsoleBack = new Button();
            lbColorConsoleBack = new Label();
            BoxThemeRepoLog = new GroupBox();
            btnColorRepoLogStatusNone = new Button();
            lbColorRepoLogStatusNone = new Label();
            btnColorRepoLogStatusWarn = new Button();
            lbColorRepoLogStatusWarn = new Label();
            lbColorRepoLogLabelValue = new Label();
            btnColorRepoLogLabelValue = new Button();
            lbColorRepoLogLabelCaption = new Label();
            btnColorRepoLogLabelCaption = new Button();
            btnColorRepoLogStatusOK = new Button();
            lbColorRepoLogStatusOK = new Label();
            btnColorRepoLogNormal = new Button();
            lbColorRepoLogDone = new Label();
            lbColorRepoLogNormal = new Label();
            btnColorRepoLogDone = new Button();
            btnColorRepoLogAggProcessing = new Button();
            lbColorRepoLogAggProcessing = new Label();
            btnColorRepoLogAlert = new Button();
            lbColorRepoLogProcessing = new Label();
            lbColorRepoLogAlert = new Label();
            btnColorRepoLogProcessing = new Button();
            btnColorRepoLogTitle = new Button();
            lbColorRepoLogTitle = new Label();
            btnColorRepoLogError = new Button();
            lbColorRepoLogError = new Label();
            BoxThemeAppLog = new GroupBox();
            btnColorAppLogStop = new Button();
            btnColorAppLogNormal = new Button();
            lbColorAppLogNormal = new Label();
            lbColorAppLogStop = new Label();
            btnColorAppLogError = new Button();
            lbColorAppLogError = new Label();
            btnColorAppLogDynError = new Button();
            lbColorAppLogDynError = new Label();
            btnColorAppLogDynWarn = new Button();
            lbColorAppLogDynWarn = new Label();
            btnResetColors = new Button();
            lbColorGridDataBack = new Label();
            btnColorGridDataBack = new Button();
            lbColorGridLines = new Label();
            btnColorGridLines = new Button();
            lbColorStatusFore = new Label();
            btnColorStatusFore = new Button();
            lbColorGridHeadBack = new Label();
            btnColorGridHeadBack = new Button();
            lbColorSplitterBack = new Label();
            btnColorSplitterBack = new Button();
            lbColorStatusBack = new Label();
            btnColorStatusBack = new Button();
            lbColorGridSelBack = new Label();
            btnColorGridSelBack = new Button();
            lbColorGridDataFore = new Label();
            btnColorGridDataFore = new Button();
            lbColorGridHeadFore = new Label();
            btnColorGridHeadFore = new Button();
            lbColorGridSelFore = new Label();
            btnColorGridSelFore = new Button();
            lbColorGridBack = new Label();
            btnColorGridBack = new Button();
            lbColorToolbarFore = new Label();
            btnColorToolbarFore = new Button();
            lbColorToolbarBack = new Label();
            btnColorToolbarBack = new Button();
            ckThemeDarkTitle = new CheckBox();
            tabApplications = new TabPage();
            ckClearLogWhenStartApp = new CheckBox();
            ckCalcAppResources = new CheckBox();
            edAppLogMaxSize = new NumericUpDown();
            lbAppsLinesLog = new Label();
            ckDontNotifyWhenAppsActive = new CheckBox();
            ckNotifyWhenAppStops = new CheckBox();
            tabRepos = new TabPage();
            btnDelGitGroup = new Button();
            btnEditGitGroup = new Button();
            btnAddGitGroup = new Button();
            label1 = new Label();
            listGitGroups = new ListBox();
            ckGitAutoCRLF = new CheckBox();
            btnCustomCommandsHelp = new Label();
            edGitCustomCommands = new TextBox();
            lbCustomCommands = new Label();
            lbDifProgramArgs = new Label();
            edDiffProgramArguments = new TextBox();
            lbDifProgramArgsInfo = new Label();
            btnSelDiffProgram = new Button();
            lbShellProgram = new Label();
            edDiffProgram = new TextBox();
            lbDiffProgram = new Label();
            lbCommitMsgInfo = new Label();
            edCommitMessage = new TextBox();
            lbCommitMsg = new Label();
            ckGitAutoFetch = new CheckBox();
            lbMemoInfo = new Label();
            edGitNewBranchPrefixList = new TextBox();
            lbNewBranchPrefix = new Label();
            btnSelShellProgram = new Button();
            edShellProgram = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            lbRestartGitWndRemember = new Label();
            pages.SuspendLayout();
            tabGeneral.SuspendLayout();
            tabTheme.SuspendLayout();
            BoxThemeConsole.SuspendLayout();
            BoxThemeRepoLog.SuspendLayout();
            BoxThemeAppLog.SuspendLayout();
            tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edAppLogMaxSize).BeginInit();
            tabRepos.SuspendLayout();
            SuspendLayout();
            // 
            // pages
            // 
            pages.Controls.Add(tabGeneral);
            pages.Controls.Add(tabTheme);
            pages.Controls.Add(tabApplications);
            pages.Controls.Add(tabRepos);
            pages.Location = new Point(9, 11);
            pages.Margin = new Padding(3, 4, 3, 4);
            pages.Name = "pages";
            pages.SelectedIndex = 0;
            pages.Size = new Size(1047, 765);
            pages.TabIndex = 0;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(lbLanguageInfo);
            tabGeneral.Controls.Add(lbLanguage);
            tabGeneral.Controls.Add(edLanguage);
            tabGeneral.Location = new Point(4, 29);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(1039, 732);
            tabGeneral.TabIndex = 3;
            tabGeneral.Text = "General";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lbLanguageInfo
            // 
            lbLanguageInfo.AutoSize = true;
            lbLanguageInfo.Location = new Point(352, 44);
            lbLanguageInfo.Name = "lbLanguageInfo";
            lbLanguageInfo.Size = new Size(119, 20);
            lbLanguageInfo.TabIndex = 2;
            lbLanguageInfo.Text = "* Restart needed";
            // 
            // lbLanguage
            // 
            lbLanguage.AutoSize = true;
            lbLanguage.Location = new Point(22, 16);
            lbLanguage.Name = "lbLanguage";
            lbLanguage.Size = new Size(74, 20);
            lbLanguage.TabIndex = 1;
            lbLanguage.Text = "Language";
            // 
            // edLanguage
            // 
            edLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            edLanguage.FormattingEnabled = true;
            edLanguage.Location = new Point(24, 40);
            edLanguage.Name = "edLanguage";
            edLanguage.Size = new Size(304, 28);
            edLanguage.TabIndex = 0;
            // 
            // tabTheme
            // 
            tabTheme.Controls.Add(BoxThemeConsole);
            tabTheme.Controls.Add(BoxThemeRepoLog);
            tabTheme.Controls.Add(BoxThemeAppLog);
            tabTheme.Controls.Add(btnResetColors);
            tabTheme.Controls.Add(lbColorGridDataBack);
            tabTheme.Controls.Add(btnColorGridDataBack);
            tabTheme.Controls.Add(lbColorGridLines);
            tabTheme.Controls.Add(btnColorGridLines);
            tabTheme.Controls.Add(lbColorStatusFore);
            tabTheme.Controls.Add(btnColorStatusFore);
            tabTheme.Controls.Add(lbColorGridHeadBack);
            tabTheme.Controls.Add(btnColorGridHeadBack);
            tabTheme.Controls.Add(lbColorSplitterBack);
            tabTheme.Controls.Add(btnColorSplitterBack);
            tabTheme.Controls.Add(lbColorStatusBack);
            tabTheme.Controls.Add(btnColorStatusBack);
            tabTheme.Controls.Add(lbColorGridSelBack);
            tabTheme.Controls.Add(btnColorGridSelBack);
            tabTheme.Controls.Add(lbColorGridDataFore);
            tabTheme.Controls.Add(btnColorGridDataFore);
            tabTheme.Controls.Add(lbColorGridHeadFore);
            tabTheme.Controls.Add(btnColorGridHeadFore);
            tabTheme.Controls.Add(lbColorGridSelFore);
            tabTheme.Controls.Add(btnColorGridSelFore);
            tabTheme.Controls.Add(lbColorGridBack);
            tabTheme.Controls.Add(btnColorGridBack);
            tabTheme.Controls.Add(lbColorToolbarFore);
            tabTheme.Controls.Add(btnColorToolbarFore);
            tabTheme.Controls.Add(lbColorToolbarBack);
            tabTheme.Controls.Add(btnColorToolbarBack);
            tabTheme.Controls.Add(ckThemeDarkTitle);
            tabTheme.Location = new Point(4, 29);
            tabTheme.Margin = new Padding(3, 4, 3, 4);
            tabTheme.Name = "tabTheme";
            tabTheme.Padding = new Padding(3, 4, 3, 4);
            tabTheme.Size = new Size(1039, 732);
            tabTheme.TabIndex = 2;
            tabTheme.Text = "Theme";
            tabTheme.UseVisualStyleBackColor = true;
            // 
            // BoxThemeConsole
            // 
            BoxThemeConsole.Controls.Add(btnLogFont);
            BoxThemeConsole.Controls.Add(lbConsoleFont);
            BoxThemeConsole.Controls.Add(ckLogShowTs);
            BoxThemeConsole.Controls.Add(lbColorLogTimestampFore);
            BoxThemeConsole.Controls.Add(ckLogWordWrap);
            BoxThemeConsole.Controls.Add(btnColorTimestampFore);
            BoxThemeConsole.Controls.Add(btnColorConsoleBack);
            BoxThemeConsole.Controls.Add(lbColorConsoleBack);
            BoxThemeConsole.Location = new Point(24, 472);
            BoxThemeConsole.Name = "BoxThemeConsole";
            BoxThemeConsole.Size = new Size(488, 248);
            BoxThemeConsole.TabIndex = 15;
            BoxThemeConsole.TabStop = false;
            BoxThemeConsole.Text = "Console";
            // 
            // btnLogFont
            // 
            btnLogFont.Location = new Point(8, 48);
            btnLogFont.Margin = new Padding(3, 4, 3, 4);
            btnLogFont.Name = "btnLogFont";
            btnLogFont.Size = new Size(472, 43);
            btnLogFont.TabIndex = 0;
            btnLogFont.UseVisualStyleBackColor = true;
            btnLogFont.Click += btnLogFont_Click;
            // 
            // lbConsoleFont
            // 
            lbConsoleFont.AutoSize = true;
            lbConsoleFont.Location = new Point(6, 26);
            lbConsoleFont.Name = "lbConsoleFont";
            lbConsoleFont.Size = new Size(95, 20);
            lbConsoleFont.TabIndex = 13;
            lbConsoleFont.Text = "Console Font";
            // 
            // ckLogShowTs
            // 
            ckLogShowTs.AutoSize = true;
            ckLogShowTs.Location = new Point(8, 168);
            ckLogShowTs.Margin = new Padding(3, 4, 3, 4);
            ckLogShowTs.Name = "ckLogShowTs";
            ckLogShowTs.Size = new Size(235, 24);
            ckLogShowTs.TabIndex = 3;
            ckLogShowTs.Text = "Show date/time in each record";
            ckLogShowTs.UseVisualStyleBackColor = true;
            // 
            // lbColorLogTimestampFore
            // 
            lbColorLogTimestampFore.AutoSize = true;
            lbColorLogTimestampFore.Location = new Point(246, 99);
            lbColorLogTimestampFore.Name = "lbColorLogTimestampFore";
            lbColorLogTimestampFore.Size = new Size(191, 20);
            lbColorLogTimestampFore.TabIndex = 51;
            lbColorLogTimestampFore.Text = "Log Timestamp foreground";
            // 
            // ckLogWordWrap
            // 
            ckLogWordWrap.AutoSize = true;
            ckLogWordWrap.Location = new Point(8, 200);
            ckLogWordWrap.Margin = new Padding(3, 4, 3, 4);
            ckLogWordWrap.Name = "ckLogWordWrap";
            ckLogWordWrap.Size = new Size(104, 24);
            ckLogWordWrap.TabIndex = 4;
            ckLogWordWrap.Text = "Word wrap";
            ckLogWordWrap.UseVisualStyleBackColor = true;
            // 
            // btnColorTimestampFore
            // 
            btnColorTimestampFore.Location = new Point(248, 120);
            btnColorTimestampFore.Margin = new Padding(3, 4, 3, 4);
            btnColorTimestampFore.Name = "btnColorTimestampFore";
            btnColorTimestampFore.Size = new Size(232, 32);
            btnColorTimestampFore.TabIndex = 2;
            btnColorTimestampFore.UseVisualStyleBackColor = true;
            // 
            // btnColorConsoleBack
            // 
            btnColorConsoleBack.Location = new Point(8, 120);
            btnColorConsoleBack.Margin = new Padding(3, 4, 3, 4);
            btnColorConsoleBack.Name = "btnColorConsoleBack";
            btnColorConsoleBack.Size = new Size(232, 32);
            btnColorConsoleBack.TabIndex = 1;
            btnColorConsoleBack.UseVisualStyleBackColor = true;
            // 
            // lbColorConsoleBack
            // 
            lbColorConsoleBack.AutoSize = true;
            lbColorConsoleBack.Location = new Point(6, 99);
            lbColorConsoleBack.Name = "lbColorConsoleBack";
            lbColorConsoleBack.Size = new Size(145, 20);
            lbColorConsoleBack.TabIndex = 8;
            lbColorConsoleBack.Text = "Console background";
            // 
            // BoxThemeRepoLog
            // 
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogStatusNone);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogStatusNone);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogStatusWarn);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogStatusWarn);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogLabelValue);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogLabelValue);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogLabelCaption);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogLabelCaption);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogStatusOK);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogStatusOK);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogNormal);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogDone);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogNormal);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogDone);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogAggProcessing);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogAggProcessing);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogAlert);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogProcessing);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogAlert);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogProcessing);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogTitle);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogTitle);
            BoxThemeRepoLog.Controls.Add(btnColorRepoLogError);
            BoxThemeRepoLog.Controls.Add(lbColorRepoLogError);
            BoxThemeRepoLog.Location = new Point(768, 72);
            BoxThemeRepoLog.Name = "BoxThemeRepoLog";
            BoxThemeRepoLog.Size = new Size(248, 648);
            BoxThemeRepoLog.TabIndex = 17;
            BoxThemeRepoLog.TabStop = false;
            BoxThemeRepoLog.Text = "Repositories Log";
            // 
            // btnColorRepoLogStatusNone
            // 
            btnColorRepoLogStatusNone.Location = new Point(162, 496);
            btnColorRepoLogStatusNone.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogStatusNone.Name = "btnColorRepoLogStatusNone";
            btnColorRepoLogStatusNone.Size = new Size(78, 32);
            btnColorRepoLogStatusNone.TabIndex = 13;
            btnColorRepoLogStatusNone.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogStatusNone
            // 
            lbColorRepoLogStatusNone.AutoSize = true;
            lbColorRepoLogStatusNone.Location = new Point(160, 475);
            lbColorRepoLogStatusNone.Name = "lbColorRepoLogStatusNone";
            lbColorRepoLogStatusNone.Size = new Size(45, 20);
            lbColorRepoLogStatusNone.TabIndex = 82;
            lbColorRepoLogStatusNone.Text = "None";
            // 
            // btnColorRepoLogStatusWarn
            // 
            btnColorRepoLogStatusWarn.Location = new Point(85, 496);
            btnColorRepoLogStatusWarn.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogStatusWarn.Name = "btnColorRepoLogStatusWarn";
            btnColorRepoLogStatusWarn.Size = new Size(78, 32);
            btnColorRepoLogStatusWarn.TabIndex = 12;
            btnColorRepoLogStatusWarn.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogStatusWarn
            // 
            lbColorRepoLogStatusWarn.AutoSize = true;
            lbColorRepoLogStatusWarn.Location = new Point(83, 475);
            lbColorRepoLogStatusWarn.Name = "lbColorRepoLogStatusWarn";
            lbColorRepoLogStatusWarn.Size = new Size(64, 20);
            lbColorRepoLogStatusWarn.TabIndex = 80;
            lbColorRepoLogStatusWarn.Text = "Warning";
            // 
            // lbColorRepoLogLabelValue
            // 
            lbColorRepoLogLabelValue.AutoSize = true;
            lbColorRepoLogLabelValue.Location = new Point(126, 419);
            lbColorRepoLogLabelValue.Name = "lbColorRepoLogLabelValue";
            lbColorRepoLogLabelValue.Size = new Size(45, 20);
            lbColorRepoLogLabelValue.TabIndex = 78;
            lbColorRepoLogLabelValue.Text = "Value";
            // 
            // btnColorRepoLogLabelValue
            // 
            btnColorRepoLogLabelValue.Location = new Point(128, 440);
            btnColorRepoLogLabelValue.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogLabelValue.Name = "btnColorRepoLogLabelValue";
            btnColorRepoLogLabelValue.Size = new Size(112, 32);
            btnColorRepoLogLabelValue.TabIndex = 10;
            btnColorRepoLogLabelValue.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogLabelCaption
            // 
            lbColorRepoLogLabelCaption.AutoSize = true;
            lbColorRepoLogLabelCaption.Location = new Point(6, 419);
            lbColorRepoLogLabelCaption.Name = "lbColorRepoLogLabelCaption";
            lbColorRepoLogLabelCaption.Size = new Size(61, 20);
            lbColorRepoLogLabelCaption.TabIndex = 76;
            lbColorRepoLogLabelCaption.Text = "Caption";
            // 
            // btnColorRepoLogLabelCaption
            // 
            btnColorRepoLogLabelCaption.Location = new Point(8, 440);
            btnColorRepoLogLabelCaption.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogLabelCaption.Name = "btnColorRepoLogLabelCaption";
            btnColorRepoLogLabelCaption.Size = new Size(112, 32);
            btnColorRepoLogLabelCaption.TabIndex = 9;
            btnColorRepoLogLabelCaption.UseVisualStyleBackColor = true;
            // 
            // btnColorRepoLogStatusOK
            // 
            btnColorRepoLogStatusOK.Location = new Point(8, 496);
            btnColorRepoLogStatusOK.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogStatusOK.Name = "btnColorRepoLogStatusOK";
            btnColorRepoLogStatusOK.Size = new Size(78, 32);
            btnColorRepoLogStatusOK.TabIndex = 11;
            btnColorRepoLogStatusOK.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogStatusOK
            // 
            lbColorRepoLogStatusOK.AutoSize = true;
            lbColorRepoLogStatusOK.Location = new Point(6, 475);
            lbColorRepoLogStatusOK.Name = "lbColorRepoLogStatusOK";
            lbColorRepoLogStatusOK.Size = new Size(29, 20);
            lbColorRepoLogStatusOK.TabIndex = 71;
            lbColorRepoLogStatusOK.Text = "OK";
            // 
            // btnColorRepoLogNormal
            // 
            btnColorRepoLogNormal.Location = new Point(8, 48);
            btnColorRepoLogNormal.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogNormal.Name = "btnColorRepoLogNormal";
            btnColorRepoLogNormal.Size = new Size(232, 32);
            btnColorRepoLogNormal.TabIndex = 0;
            btnColorRepoLogNormal.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogDone
            // 
            lbColorRepoLogDone.AutoSize = true;
            lbColorRepoLogDone.Location = new Point(6, 363);
            lbColorRepoLogDone.Name = "lbColorRepoLogDone";
            lbColorRepoLogDone.Size = new Size(45, 20);
            lbColorRepoLogDone.TabIndex = 69;
            lbColorRepoLogDone.Text = "Done";
            // 
            // lbColorRepoLogNormal
            // 
            lbColorRepoLogNormal.AutoSize = true;
            lbColorRepoLogNormal.Location = new Point(6, 27);
            lbColorRepoLogNormal.Name = "lbColorRepoLogNormal";
            lbColorRepoLogNormal.Size = new Size(59, 20);
            lbColorRepoLogNormal.TabIndex = 57;
            lbColorRepoLogNormal.Text = "Normal";
            // 
            // btnColorRepoLogDone
            // 
            btnColorRepoLogDone.Location = new Point(8, 384);
            btnColorRepoLogDone.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogDone.Name = "btnColorRepoLogDone";
            btnColorRepoLogDone.Size = new Size(232, 32);
            btnColorRepoLogDone.TabIndex = 6;
            btnColorRepoLogDone.UseVisualStyleBackColor = true;
            // 
            // btnColorRepoLogAggProcessing
            // 
            btnColorRepoLogAggProcessing.Location = new Point(8, 272);
            btnColorRepoLogAggProcessing.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogAggProcessing.Name = "btnColorRepoLogAggProcessing";
            btnColorRepoLogAggProcessing.Size = new Size(232, 32);
            btnColorRepoLogAggProcessing.TabIndex = 4;
            btnColorRepoLogAggProcessing.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogAggProcessing
            // 
            lbColorRepoLogAggProcessing.AutoSize = true;
            lbColorRepoLogAggProcessing.Location = new Point(6, 251);
            lbColorRepoLogAggProcessing.Name = "lbColorRepoLogAggProcessing";
            lbColorRepoLogAggProcessing.Size = new Size(163, 20);
            lbColorRepoLogAggProcessing.TabIndex = 58;
            lbColorRepoLogAggProcessing.Text = "Aggregated Processing";
            // 
            // btnColorRepoLogAlert
            // 
            btnColorRepoLogAlert.Location = new Point(8, 104);
            btnColorRepoLogAlert.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogAlert.Name = "btnColorRepoLogAlert";
            btnColorRepoLogAlert.Size = new Size(232, 32);
            btnColorRepoLogAlert.TabIndex = 1;
            btnColorRepoLogAlert.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogProcessing
            // 
            lbColorRepoLogProcessing.AutoSize = true;
            lbColorRepoLogProcessing.Location = new Point(6, 307);
            lbColorRepoLogProcessing.Name = "lbColorRepoLogProcessing";
            lbColorRepoLogProcessing.Size = new Size(79, 20);
            lbColorRepoLogProcessing.TabIndex = 67;
            lbColorRepoLogProcessing.Text = "Processing";
            // 
            // lbColorRepoLogAlert
            // 
            lbColorRepoLogAlert.AutoSize = true;
            lbColorRepoLogAlert.Location = new Point(6, 83);
            lbColorRepoLogAlert.Name = "lbColorRepoLogAlert";
            lbColorRepoLogAlert.Size = new Size(41, 20);
            lbColorRepoLogAlert.TabIndex = 59;
            lbColorRepoLogAlert.Text = "Alert";
            // 
            // btnColorRepoLogProcessing
            // 
            btnColorRepoLogProcessing.Location = new Point(8, 328);
            btnColorRepoLogProcessing.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogProcessing.Name = "btnColorRepoLogProcessing";
            btnColorRepoLogProcessing.Size = new Size(232, 32);
            btnColorRepoLogProcessing.TabIndex = 5;
            btnColorRepoLogProcessing.UseVisualStyleBackColor = true;
            // 
            // btnColorRepoLogTitle
            // 
            btnColorRepoLogTitle.Location = new Point(8, 216);
            btnColorRepoLogTitle.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogTitle.Name = "btnColorRepoLogTitle";
            btnColorRepoLogTitle.Size = new Size(232, 32);
            btnColorRepoLogTitle.TabIndex = 3;
            btnColorRepoLogTitle.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogTitle
            // 
            lbColorRepoLogTitle.AutoSize = true;
            lbColorRepoLogTitle.Location = new Point(6, 195);
            lbColorRepoLogTitle.Name = "lbColorRepoLogTitle";
            lbColorRepoLogTitle.Size = new Size(38, 20);
            lbColorRepoLogTitle.TabIndex = 60;
            lbColorRepoLogTitle.Text = "Title";
            // 
            // btnColorRepoLogError
            // 
            btnColorRepoLogError.Location = new Point(8, 160);
            btnColorRepoLogError.Margin = new Padding(3, 4, 3, 4);
            btnColorRepoLogError.Name = "btnColorRepoLogError";
            btnColorRepoLogError.Size = new Size(232, 32);
            btnColorRepoLogError.TabIndex = 2;
            btnColorRepoLogError.UseVisualStyleBackColor = true;
            // 
            // lbColorRepoLogError
            // 
            lbColorRepoLogError.AutoSize = true;
            lbColorRepoLogError.Location = new Point(6, 139);
            lbColorRepoLogError.Name = "lbColorRepoLogError";
            lbColorRepoLogError.Size = new Size(41, 20);
            lbColorRepoLogError.TabIndex = 61;
            lbColorRepoLogError.Text = "Error";
            // 
            // BoxThemeAppLog
            // 
            BoxThemeAppLog.Controls.Add(btnColorAppLogStop);
            BoxThemeAppLog.Controls.Add(btnColorAppLogNormal);
            BoxThemeAppLog.Controls.Add(lbColorAppLogNormal);
            BoxThemeAppLog.Controls.Add(lbColorAppLogStop);
            BoxThemeAppLog.Controls.Add(btnColorAppLogError);
            BoxThemeAppLog.Controls.Add(lbColorAppLogError);
            BoxThemeAppLog.Controls.Add(btnColorAppLogDynError);
            BoxThemeAppLog.Controls.Add(lbColorAppLogDynError);
            BoxThemeAppLog.Controls.Add(btnColorAppLogDynWarn);
            BoxThemeAppLog.Controls.Add(lbColorAppLogDynWarn);
            BoxThemeAppLog.Location = new Point(512, 72);
            BoxThemeAppLog.Name = "BoxThemeAppLog";
            BoxThemeAppLog.Size = new Size(248, 320);
            BoxThemeAppLog.TabIndex = 16;
            BoxThemeAppLog.TabStop = false;
            BoxThemeAppLog.Text = "Applications Log";
            // 
            // btnColorAppLogStop
            // 
            btnColorAppLogStop.Location = new Point(8, 272);
            btnColorAppLogStop.Margin = new Padding(3, 4, 3, 4);
            btnColorAppLogStop.Name = "btnColorAppLogStop";
            btnColorAppLogStop.Size = new Size(232, 32);
            btnColorAppLogStop.TabIndex = 4;
            btnColorAppLogStop.UseVisualStyleBackColor = true;
            // 
            // btnColorAppLogNormal
            // 
            btnColorAppLogNormal.Location = new Point(8, 48);
            btnColorAppLogNormal.Margin = new Padding(3, 4, 3, 4);
            btnColorAppLogNormal.Name = "btnColorAppLogNormal";
            btnColorAppLogNormal.Size = new Size(232, 32);
            btnColorAppLogNormal.TabIndex = 0;
            btnColorAppLogNormal.UseVisualStyleBackColor = true;
            // 
            // lbColorAppLogNormal
            // 
            lbColorAppLogNormal.AutoSize = true;
            lbColorAppLogNormal.Location = new Point(6, 27);
            lbColorAppLogNormal.Name = "lbColorAppLogNormal";
            lbColorAppLogNormal.Size = new Size(59, 20);
            lbColorAppLogNormal.TabIndex = 45;
            lbColorAppLogNormal.Text = "Normal";
            // 
            // lbColorAppLogStop
            // 
            lbColorAppLogStop.AutoSize = true;
            lbColorAppLogStop.Location = new Point(6, 251);
            lbColorAppLogStop.Name = "lbColorAppLogStop";
            lbColorAppLogStop.Size = new Size(40, 20);
            lbColorAppLogStop.TabIndex = 46;
            lbColorAppLogStop.Text = "Stop";
            // 
            // btnColorAppLogError
            // 
            btnColorAppLogError.Location = new Point(8, 104);
            btnColorAppLogError.Margin = new Padding(3, 4, 3, 4);
            btnColorAppLogError.Name = "btnColorAppLogError";
            btnColorAppLogError.Size = new Size(232, 32);
            btnColorAppLogError.TabIndex = 1;
            btnColorAppLogError.UseVisualStyleBackColor = true;
            // 
            // lbColorAppLogError
            // 
            lbColorAppLogError.AutoSize = true;
            lbColorAppLogError.Location = new Point(6, 83);
            lbColorAppLogError.Name = "lbColorAppLogError";
            lbColorAppLogError.Size = new Size(41, 20);
            lbColorAppLogError.TabIndex = 47;
            lbColorAppLogError.Text = "Error";
            // 
            // btnColorAppLogDynError
            // 
            btnColorAppLogDynError.Location = new Point(8, 216);
            btnColorAppLogDynError.Margin = new Padding(3, 4, 3, 4);
            btnColorAppLogDynError.Name = "btnColorAppLogDynError";
            btnColorAppLogDynError.Size = new Size(232, 32);
            btnColorAppLogDynError.TabIndex = 3;
            btnColorAppLogDynError.UseVisualStyleBackColor = true;
            // 
            // lbColorAppLogDynError
            // 
            lbColorAppLogDynError.AutoSize = true;
            lbColorAppLogDynError.Location = new Point(6, 195);
            lbColorAppLogDynError.Name = "lbColorAppLogDynError";
            lbColorAppLogDynError.Size = new Size(103, 20);
            lbColorAppLogDynError.TabIndex = 48;
            lbColorAppLogDynError.Text = "Dynamic Error";
            // 
            // btnColorAppLogDynWarn
            // 
            btnColorAppLogDynWarn.Location = new Point(8, 160);
            btnColorAppLogDynWarn.Margin = new Padding(3, 4, 3, 4);
            btnColorAppLogDynWarn.Name = "btnColorAppLogDynWarn";
            btnColorAppLogDynWarn.Size = new Size(232, 32);
            btnColorAppLogDynWarn.TabIndex = 2;
            btnColorAppLogDynWarn.UseVisualStyleBackColor = true;
            // 
            // lbColorAppLogDynWarn
            // 
            lbColorAppLogDynWarn.AutoSize = true;
            lbColorAppLogDynWarn.Location = new Point(6, 139);
            lbColorAppLogDynWarn.Name = "lbColorAppLogDynWarn";
            lbColorAppLogDynWarn.Size = new Size(126, 20);
            lbColorAppLogDynWarn.TabIndex = 49;
            lbColorAppLogDynWarn.Text = "Dynamic Warning";
            // 
            // btnResetColors
            // 
            btnResetColors.Location = new Point(864, 16);
            btnResetColors.Name = "btnResetColors";
            btnResetColors.Size = new Size(152, 48);
            btnResetColors.TabIndex = 1;
            btnResetColors.TabStop = false;
            btnResetColors.Text = "Reset Colors";
            btnResetColors.UseVisualStyleBackColor = true;
            btnResetColors.Click += btnResetColors_Click;
            // 
            // lbColorGridDataBack
            // 
            lbColorGridDataBack.AutoSize = true;
            lbColorGridDataBack.Location = new Point(22, 235);
            lbColorGridDataBack.Name = "lbColorGridDataBack";
            lbColorGridDataBack.Size = new Size(154, 20);
            lbColorGridDataBack.TabIndex = 39;
            lbColorGridDataBack.Text = "Grid data background";
            // 
            // btnColorGridDataBack
            // 
            btnColorGridDataBack.Location = new Point(24, 256);
            btnColorGridDataBack.Margin = new Padding(3, 4, 3, 4);
            btnColorGridDataBack.Name = "btnColorGridDataBack";
            btnColorGridDataBack.Size = new Size(232, 32);
            btnColorGridDataBack.TabIndex = 8;
            btnColorGridDataBack.UseVisualStyleBackColor = true;
            // 
            // lbColorGridLines
            // 
            lbColorGridLines.AutoSize = true;
            lbColorGridLines.Location = new Point(262, 179);
            lbColorGridLines.Name = "lbColorGridLines";
            lbColorGridLines.Size = new Size(71, 20);
            lbColorGridLines.TabIndex = 37;
            lbColorGridLines.Text = "Grid lines";
            // 
            // btnColorGridLines
            // 
            btnColorGridLines.Location = new Point(264, 200);
            btnColorGridLines.Margin = new Padding(3, 4, 3, 4);
            btnColorGridLines.Name = "btnColorGridLines";
            btnColorGridLines.Size = new Size(232, 32);
            btnColorGridLines.TabIndex = 7;
            btnColorGridLines.UseVisualStyleBackColor = true;
            // 
            // lbColorStatusFore
            // 
            lbColorStatusFore.AutoSize = true;
            lbColorStatusFore.Location = new Point(262, 347);
            lbColorStatusFore.Name = "lbColorStatusFore";
            lbColorStatusFore.Size = new Size(154, 20);
            lbColorStatusFore.TabIndex = 35;
            lbColorStatusFore.Text = "Status bar foreground";
            // 
            // btnColorStatusFore
            // 
            btnColorStatusFore.Location = new Point(264, 368);
            btnColorStatusFore.Margin = new Padding(3, 4, 3, 4);
            btnColorStatusFore.Name = "btnColorStatusFore";
            btnColorStatusFore.Size = new Size(232, 32);
            btnColorStatusFore.TabIndex = 13;
            btnColorStatusFore.UseVisualStyleBackColor = true;
            // 
            // lbColorGridHeadBack
            // 
            lbColorGridHeadBack.AutoSize = true;
            lbColorGridHeadBack.Location = new Point(22, 123);
            lbColorGridHeadBack.Name = "lbColorGridHeadBack";
            lbColorGridHeadBack.Size = new Size(170, 20);
            lbColorGridHeadBack.TabIndex = 33;
            lbColorGridHeadBack.Text = "Grid header background";
            // 
            // btnColorGridHeadBack
            // 
            btnColorGridHeadBack.Location = new Point(24, 144);
            btnColorGridHeadBack.Margin = new Padding(3, 4, 3, 4);
            btnColorGridHeadBack.Name = "btnColorGridHeadBack";
            btnColorGridHeadBack.Size = new Size(232, 32);
            btnColorGridHeadBack.TabIndex = 4;
            btnColorGridHeadBack.UseVisualStyleBackColor = true;
            // 
            // lbColorSplitterBack
            // 
            lbColorSplitterBack.AutoSize = true;
            lbColorSplitterBack.Location = new Point(22, 403);
            lbColorSplitterBack.Name = "lbColorSplitterBack";
            lbColorSplitterBack.Size = new Size(140, 20);
            lbColorSplitterBack.TabIndex = 31;
            lbColorSplitterBack.Text = "Splitter background";
            // 
            // btnColorSplitterBack
            // 
            btnColorSplitterBack.Location = new Point(24, 424);
            btnColorSplitterBack.Margin = new Padding(3, 4, 3, 4);
            btnColorSplitterBack.Name = "btnColorSplitterBack";
            btnColorSplitterBack.Size = new Size(232, 32);
            btnColorSplitterBack.TabIndex = 14;
            btnColorSplitterBack.UseVisualStyleBackColor = true;
            // 
            // lbColorStatusBack
            // 
            lbColorStatusBack.AutoSize = true;
            lbColorStatusBack.Location = new Point(22, 347);
            lbColorStatusBack.Name = "lbColorStatusBack";
            lbColorStatusBack.Size = new Size(158, 20);
            lbColorStatusBack.TabIndex = 29;
            lbColorStatusBack.Text = "Status bar background";
            // 
            // btnColorStatusBack
            // 
            btnColorStatusBack.Location = new Point(24, 368);
            btnColorStatusBack.Margin = new Padding(3, 4, 3, 4);
            btnColorStatusBack.Name = "btnColorStatusBack";
            btnColorStatusBack.Size = new Size(232, 32);
            btnColorStatusBack.TabIndex = 12;
            btnColorStatusBack.UseVisualStyleBackColor = true;
            // 
            // lbColorGridSelBack
            // 
            lbColorGridSelBack.AutoSize = true;
            lbColorGridSelBack.Location = new Point(22, 291);
            lbColorGridSelBack.Name = "lbColorGridSelBack";
            lbColorGridSelBack.Size = new Size(179, 20);
            lbColorGridSelBack.TabIndex = 27;
            lbColorGridSelBack.Text = "Grid selected background";
            // 
            // btnColorGridSelBack
            // 
            btnColorGridSelBack.Location = new Point(24, 312);
            btnColorGridSelBack.Margin = new Padding(3, 4, 3, 4);
            btnColorGridSelBack.Name = "btnColorGridSelBack";
            btnColorGridSelBack.Size = new Size(232, 32);
            btnColorGridSelBack.TabIndex = 10;
            btnColorGridSelBack.UseVisualStyleBackColor = true;
            // 
            // lbColorGridDataFore
            // 
            lbColorGridDataFore.AutoSize = true;
            lbColorGridDataFore.Location = new Point(262, 235);
            lbColorGridDataFore.Name = "lbColorGridDataFore";
            lbColorGridDataFore.Size = new Size(150, 20);
            lbColorGridDataFore.TabIndex = 25;
            lbColorGridDataFore.Text = "Grid data foreground";
            // 
            // btnColorGridDataFore
            // 
            btnColorGridDataFore.Location = new Point(264, 256);
            btnColorGridDataFore.Margin = new Padding(3, 4, 3, 4);
            btnColorGridDataFore.Name = "btnColorGridDataFore";
            btnColorGridDataFore.Size = new Size(232, 32);
            btnColorGridDataFore.TabIndex = 9;
            btnColorGridDataFore.UseVisualStyleBackColor = true;
            // 
            // lbColorGridHeadFore
            // 
            lbColorGridHeadFore.AutoSize = true;
            lbColorGridHeadFore.Location = new Point(262, 123);
            lbColorGridHeadFore.Name = "lbColorGridHeadFore";
            lbColorGridHeadFore.Size = new Size(166, 20);
            lbColorGridHeadFore.TabIndex = 23;
            lbColorGridHeadFore.Text = "Grid header foreground";
            // 
            // btnColorGridHeadFore
            // 
            btnColorGridHeadFore.Location = new Point(264, 144);
            btnColorGridHeadFore.Margin = new Padding(3, 4, 3, 4);
            btnColorGridHeadFore.Name = "btnColorGridHeadFore";
            btnColorGridHeadFore.Size = new Size(232, 32);
            btnColorGridHeadFore.TabIndex = 5;
            btnColorGridHeadFore.UseVisualStyleBackColor = true;
            // 
            // lbColorGridSelFore
            // 
            lbColorGridSelFore.AutoSize = true;
            lbColorGridSelFore.Location = new Point(262, 291);
            lbColorGridSelFore.Name = "lbColorGridSelFore";
            lbColorGridSelFore.Size = new Size(175, 20);
            lbColorGridSelFore.TabIndex = 21;
            lbColorGridSelFore.Text = "Grid selected foreground";
            // 
            // btnColorGridSelFore
            // 
            btnColorGridSelFore.Location = new Point(264, 312);
            btnColorGridSelFore.Margin = new Padding(3, 4, 3, 4);
            btnColorGridSelFore.Name = "btnColorGridSelFore";
            btnColorGridSelFore.Size = new Size(232, 32);
            btnColorGridSelFore.TabIndex = 11;
            btnColorGridSelFore.UseVisualStyleBackColor = true;
            // 
            // lbColorGridBack
            // 
            lbColorGridBack.AutoSize = true;
            lbColorGridBack.Location = new Point(22, 179);
            lbColorGridBack.Name = "lbColorGridBack";
            lbColorGridBack.Size = new Size(120, 20);
            lbColorGridBack.TabIndex = 19;
            lbColorGridBack.Text = "Grid background";
            // 
            // btnColorGridBack
            // 
            btnColorGridBack.Location = new Point(24, 200);
            btnColorGridBack.Margin = new Padding(3, 4, 3, 4);
            btnColorGridBack.Name = "btnColorGridBack";
            btnColorGridBack.Size = new Size(232, 32);
            btnColorGridBack.TabIndex = 6;
            btnColorGridBack.UseVisualStyleBackColor = true;
            // 
            // lbColorToolbarFore
            // 
            lbColorToolbarFore.AutoSize = true;
            lbColorToolbarFore.Location = new Point(262, 67);
            lbColorToolbarFore.Name = "lbColorToolbarFore";
            lbColorToolbarFore.Size = new Size(143, 20);
            lbColorToolbarFore.TabIndex = 17;
            lbColorToolbarFore.Text = "Tool bar foreground";
            // 
            // btnColorToolbarFore
            // 
            btnColorToolbarFore.Location = new Point(264, 88);
            btnColorToolbarFore.Margin = new Padding(3, 4, 3, 4);
            btnColorToolbarFore.Name = "btnColorToolbarFore";
            btnColorToolbarFore.Size = new Size(232, 32);
            btnColorToolbarFore.TabIndex = 3;
            btnColorToolbarFore.UseVisualStyleBackColor = true;
            // 
            // lbColorToolbarBack
            // 
            lbColorToolbarBack.AutoSize = true;
            lbColorToolbarBack.Location = new Point(22, 67);
            lbColorToolbarBack.Name = "lbColorToolbarBack";
            lbColorToolbarBack.Size = new Size(147, 20);
            lbColorToolbarBack.TabIndex = 15;
            lbColorToolbarBack.Text = "Tool bar background";
            // 
            // btnColorToolbarBack
            // 
            btnColorToolbarBack.Location = new Point(24, 88);
            btnColorToolbarBack.Margin = new Padding(3, 4, 3, 4);
            btnColorToolbarBack.Name = "btnColorToolbarBack";
            btnColorToolbarBack.Size = new Size(232, 32);
            btnColorToolbarBack.TabIndex = 2;
            btnColorToolbarBack.UseVisualStyleBackColor = true;
            // 
            // ckThemeDarkTitle
            // 
            ckThemeDarkTitle.AutoSize = true;
            ckThemeDarkTitle.Location = new Point(24, 24);
            ckThemeDarkTitle.Name = "ckThemeDarkTitle";
            ckThemeDarkTitle.Size = new Size(121, 24);
            ckThemeDarkTitle.TabIndex = 0;
            ckThemeDarkTitle.Text = "Dark Title Bar";
            ckThemeDarkTitle.UseVisualStyleBackColor = true;
            // 
            // tabApplications
            // 
            tabApplications.Controls.Add(ckClearLogWhenStartApp);
            tabApplications.Controls.Add(ckCalcAppResources);
            tabApplications.Controls.Add(edAppLogMaxSize);
            tabApplications.Controls.Add(lbAppsLinesLog);
            tabApplications.Controls.Add(ckDontNotifyWhenAppsActive);
            tabApplications.Controls.Add(ckNotifyWhenAppStops);
            tabApplications.Location = new Point(4, 29);
            tabApplications.Margin = new Padding(3, 4, 3, 4);
            tabApplications.Name = "tabApplications";
            tabApplications.Padding = new Padding(3, 4, 3, 4);
            tabApplications.Size = new Size(1039, 732);
            tabApplications.TabIndex = 0;
            tabApplications.Text = "Applications";
            tabApplications.UseVisualStyleBackColor = true;
            // 
            // ckClearLogWhenStartApp
            // 
            ckClearLogWhenStartApp.AutoSize = true;
            ckClearLogWhenStartApp.Location = new Point(16, 208);
            ckClearLogWhenStartApp.Name = "ckClearLogWhenStartApp";
            ckClearLogWhenStartApp.Size = new Size(323, 24);
            ckClearLogWhenStartApp.TabIndex = 13;
            ckClearLogWhenStartApp.Text = "Clear previous log when starting application";
            ckClearLogWhenStartApp.UseVisualStyleBackColor = true;
            // 
            // ckCalcAppResources
            // 
            ckCalcAppResources.AutoSize = true;
            ckCalcAppResources.Location = new Point(16, 16);
            ckCalcAppResources.Name = "ckCalcAppResources";
            ckCalcAppResources.Size = new Size(237, 24);
            ckCalcAppResources.TabIndex = 0;
            ckCalcAppResources.Text = "Calculate application resources";
            ckCalcAppResources.UseVisualStyleBackColor = true;
            // 
            // edAppLogMaxSize
            // 
            edAppLogMaxSize.Location = new Point(16, 160);
            edAppLogMaxSize.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            edAppLogMaxSize.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            edAppLogMaxSize.Name = "edAppLogMaxSize";
            edAppLogMaxSize.Size = new Size(184, 27);
            edAppLogMaxSize.TabIndex = 3;
            edAppLogMaxSize.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lbAppsLinesLog
            // 
            lbAppsLinesLog.AutoSize = true;
            lbAppsLinesLog.Location = new Point(14, 136);
            lbAppsLinesLog.Name = "lbAppsLinesLog";
            lbAppsLinesLog.Size = new Size(130, 20);
            lbAppsLinesLog.TabIndex = 12;
            lbAppsLinesLog.Text = "Maximum log size";
            // 
            // ckDontNotifyWhenAppsActive
            // 
            ckDontNotifyWhenAppsActive.AutoSize = true;
            ckDontNotifyWhenAppsActive.Location = new Point(40, 88);
            ckDontNotifyWhenAppsActive.Margin = new Padding(3, 4, 3, 4);
            ckDontNotifyWhenAppsActive.Name = "ckDontNotifyWhenAppsActive";
            ckDontNotifyWhenAppsActive.Size = new Size(273, 24);
            ckDontNotifyWhenAppsActive.TabIndex = 2;
            ckDontNotifyWhenAppsActive.Text = "Do not notify when apps form active";
            ckDontNotifyWhenAppsActive.UseVisualStyleBackColor = true;
            // 
            // ckNotifyWhenAppStops
            // 
            ckNotifyWhenAppStops.AutoSize = true;
            ckNotifyWhenAppStops.Location = new Point(16, 56);
            ckNotifyWhenAppStops.Margin = new Padding(3, 4, 3, 4);
            ckNotifyWhenAppStops.Name = "ckNotifyWhenAppStops";
            ckNotifyWhenAppStops.Size = new Size(229, 24);
            ckNotifyWhenAppStops.TabIndex = 1;
            ckNotifyWhenAppStops.Text = "Notify when application stops";
            ckNotifyWhenAppStops.UseVisualStyleBackColor = true;
            // 
            // tabRepos
            // 
            tabRepos.Controls.Add(lbRestartGitWndRemember);
            tabRepos.Controls.Add(btnDelGitGroup);
            tabRepos.Controls.Add(btnEditGitGroup);
            tabRepos.Controls.Add(btnAddGitGroup);
            tabRepos.Controls.Add(label1);
            tabRepos.Controls.Add(listGitGroups);
            tabRepos.Controls.Add(ckGitAutoCRLF);
            tabRepos.Controls.Add(btnCustomCommandsHelp);
            tabRepos.Controls.Add(edGitCustomCommands);
            tabRepos.Controls.Add(lbCustomCommands);
            tabRepos.Controls.Add(lbDifProgramArgs);
            tabRepos.Controls.Add(edDiffProgramArguments);
            tabRepos.Controls.Add(lbDifProgramArgsInfo);
            tabRepos.Controls.Add(btnSelDiffProgram);
            tabRepos.Controls.Add(lbShellProgram);
            tabRepos.Controls.Add(edDiffProgram);
            tabRepos.Controls.Add(lbDiffProgram);
            tabRepos.Controls.Add(lbCommitMsgInfo);
            tabRepos.Controls.Add(edCommitMessage);
            tabRepos.Controls.Add(lbCommitMsg);
            tabRepos.Controls.Add(ckGitAutoFetch);
            tabRepos.Controls.Add(lbMemoInfo);
            tabRepos.Controls.Add(edGitNewBranchPrefixList);
            tabRepos.Controls.Add(lbNewBranchPrefix);
            tabRepos.Controls.Add(btnSelShellProgram);
            tabRepos.Controls.Add(edShellProgram);
            tabRepos.Location = new Point(4, 29);
            tabRepos.Margin = new Padding(3, 4, 3, 4);
            tabRepos.Name = "tabRepos";
            tabRepos.Padding = new Padding(3, 4, 3, 4);
            tabRepos.Size = new Size(1039, 732);
            tabRepos.TabIndex = 1;
            tabRepos.Text = "Git Repositories";
            tabRepos.UseVisualStyleBackColor = true;
            // 
            // btnDelGitGroup
            // 
            btnDelGitGroup.Location = new Point(536, 136);
            btnDelGitGroup.Name = "btnDelGitGroup";
            btnDelGitGroup.Size = new Size(104, 40);
            btnDelGitGroup.TabIndex = 3;
            btnDelGitGroup.Text = "Delete";
            btnDelGitGroup.UseVisualStyleBackColor = true;
            btnDelGitGroup.Click += btnDelGitGroup_Click;
            // 
            // btnEditGitGroup
            // 
            btnEditGitGroup.Location = new Point(536, 88);
            btnEditGitGroup.Name = "btnEditGitGroup";
            btnEditGitGroup.Size = new Size(104, 40);
            btnEditGitGroup.TabIndex = 2;
            btnEditGitGroup.Text = "Edit";
            btnEditGitGroup.UseVisualStyleBackColor = true;
            btnEditGitGroup.Click += btnEditGitGroup_Click;
            // 
            // btnAddGitGroup
            // 
            btnAddGitGroup.Location = new Point(536, 40);
            btnAddGitGroup.Name = "btnAddGitGroup";
            btnAddGitGroup.Size = new Size(104, 40);
            btnAddGitGroup.TabIndex = 1;
            btnAddGitGroup.Text = "New";
            btnAddGitGroup.UseVisualStyleBackColor = true;
            btnAddGitGroup.Click += btnAddGitGroup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 22;
            label1.Text = "Git Repositories Groups";
            // 
            // listGitGroups
            // 
            listGitGroups.FormattingEnabled = true;
            listGitGroups.IntegralHeight = false;
            listGitGroups.Location = new Point(16, 40);
            listGitGroups.Name = "listGitGroups";
            listGitGroups.Size = new Size(504, 208);
            listGitGroups.TabIndex = 0;
            listGitGroups.SelectedIndexChanged += listGitGroups_SelectedIndexChanged;
            // 
            // ckGitAutoCRLF
            // 
            ckGitAutoCRLF.AutoSize = true;
            ckGitAutoCRLF.Location = new Point(16, 552);
            ckGitAutoCRLF.Name = "ckGitAutoCRLF";
            ckGitAutoCRLF.Size = new Size(545, 24);
            ckGitAutoCRLF.TabIndex = 13;
            ckGitAutoCRLF.Text = "Auto enable CR+LF config in repositories (ensures diff between Unix and Win)";
            ckGitAutoCRLF.UseVisualStyleBackColor = true;
            // 
            // btnCustomCommandsHelp
            // 
            btnCustomCommandsHelp.AutoSize = true;
            btnCustomCommandsHelp.Cursor = Cursors.Hand;
            btnCustomCommandsHelp.Location = new Point(992, 408);
            btnCustomCommandsHelp.Name = "btnCustomCommandsHelp";
            btnCustomCommandsHelp.Size = new Size(34, 20);
            btnCustomCommandsHelp.TabIndex = 20;
            btnCustomCommandsHelp.Text = "[ ? ]";
            btnCustomCommandsHelp.Click += btnCustomCommandsHelp_Click;
            // 
            // edGitCustomCommands
            // 
            edGitCustomCommands.Location = new Point(536, 432);
            edGitCustomCommands.Margin = new Padding(3, 4, 3, 4);
            edGitCustomCommands.Multiline = true;
            edGitCustomCommands.Name = "edGitCustomCommands";
            edGitCustomCommands.ScrollBars = ScrollBars.Vertical;
            edGitCustomCommands.Size = new Size(488, 95);
            edGitCustomCommands.TabIndex = 12;
            // 
            // lbCustomCommands
            // 
            lbCustomCommands.AutoSize = true;
            lbCustomCommands.Location = new Point(536, 408);
            lbCustomCommands.Name = "lbCustomCommands";
            lbCustomCommands.Size = new Size(174, 20);
            lbCustomCommands.TabIndex = 19;
            lbCustomCommands.Text = "Custom Shell Commands";
            // 
            // lbDifProgramArgs
            // 
            lbDifProgramArgs.AutoSize = true;
            lbDifProgramArgs.Location = new Point(534, 344);
            lbDifProgramArgs.Name = "lbDifProgramArgs";
            lbDifProgramArgs.Size = new Size(81, 20);
            lbDifProgramArgs.TabIndex = 18;
            lbDifProgramArgs.Text = "Arguments";
            // 
            // edDiffProgramArguments
            // 
            edDiffProgramArguments.Location = new Point(536, 368);
            edDiffProgramArguments.Margin = new Padding(3, 4, 3, 4);
            edDiffProgramArguments.Name = "edDiffProgramArguments";
            edDiffProgramArguments.Size = new Size(488, 27);
            edDiffProgramArguments.TabIndex = 10;
            // 
            // lbDifProgramArgsInfo
            // 
            lbDifProgramArgsInfo.AutoSize = true;
            lbDifProgramArgsInfo.ForeColor = Color.Gray;
            lbDifProgramArgsInfo.Location = new Point(656, 344);
            lbDifProgramArgsInfo.Name = "lbDifProgramArgsInfo";
            lbDifProgramArgsInfo.Size = new Size(227, 20);
            lbDifProgramArgsInfo.TabIndex = 16;
            lbDifProgramArgsInfo.Text = "[old] = old file / [new] = new file";
            // 
            // btnSelDiffProgram
            // 
            btnSelDiffProgram.Location = new Point(496, 368);
            btnSelDiffProgram.Margin = new Padding(3, 4, 3, 4);
            btnSelDiffProgram.Name = "btnSelDiffProgram";
            btnSelDiffProgram.Size = new Size(27, 33);
            btnSelDiffProgram.TabIndex = 9;
            btnSelDiffProgram.TabStop = false;
            btnSelDiffProgram.Text = "...";
            btnSelDiffProgram.UseVisualStyleBackColor = true;
            btnSelDiffProgram.Click += btnSelDiffProgram_Click;
            // 
            // lbShellProgram
            // 
            lbShellProgram.AutoSize = true;
            lbShellProgram.Location = new Point(12, 272);
            lbShellProgram.Name = "lbShellProgram";
            lbShellProgram.Size = new Size(103, 20);
            lbShellProgram.TabIndex = 5;
            lbShellProgram.Text = "Shell program";
            // 
            // edDiffProgram
            // 
            edDiffProgram.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            edDiffProgram.AutoCompleteSource = AutoCompleteSource.FileSystem;
            edDiffProgram.Location = new Point(16, 368);
            edDiffProgram.Margin = new Padding(3, 4, 3, 4);
            edDiffProgram.Name = "edDiffProgram";
            edDiffProgram.Size = new Size(480, 27);
            edDiffProgram.TabIndex = 8;
            // 
            // lbDiffProgram
            // 
            lbDiffProgram.AutoSize = true;
            lbDiffProgram.Location = new Point(12, 344);
            lbDiffProgram.Name = "lbDiffProgram";
            lbDiffProgram.Size = new Size(96, 20);
            lbDiffProgram.TabIndex = 15;
            lbDiffProgram.Text = "Diff program";
            // 
            // lbCommitMsgInfo
            // 
            lbCommitMsgInfo.AutoSize = true;
            lbCommitMsgInfo.ForeColor = Color.Gray;
            lbCommitMsgInfo.Location = new Point(240, 632);
            lbCommitMsgInfo.Name = "lbCommitMsgInfo";
            lbCommitMsgInfo.Size = new Size(205, 20);
            lbCommitMsgInfo.TabIndex = 14;
            lbCommitMsgInfo.Text = "Use [branch] for branch name";
            // 
            // edCommitMessage
            // 
            edCommitMessage.Location = new Point(16, 656);
            edCommitMessage.Margin = new Padding(3, 4, 3, 4);
            edCommitMessage.Name = "edCommitMessage";
            edCommitMessage.Size = new Size(504, 27);
            edCommitMessage.TabIndex = 15;
            // 
            // lbCommitMsg
            // 
            lbCommitMsg.AutoSize = true;
            lbCommitMsg.Location = new Point(14, 632);
            lbCommitMsg.Name = "lbCommitMsg";
            lbCommitMsg.Size = new Size(124, 20);
            lbCommitMsg.TabIndex = 12;
            lbCommitMsg.Text = "Commit message";
            // 
            // ckGitAutoFetch
            // 
            ckGitAutoFetch.AutoSize = true;
            ckGitAutoFetch.Location = new Point(16, 584);
            ckGitAutoFetch.Margin = new Padding(3, 4, 3, 4);
            ckGitAutoFetch.Name = "ckGitAutoFetch";
            ckGitAutoFetch.Size = new Size(249, 24);
            ckGitAutoFetch.TabIndex = 14;
            ckGitAutoFetch.Text = "Auto Fetch in Remote operations";
            ckGitAutoFetch.UseVisualStyleBackColor = true;
            // 
            // lbMemoInfo
            // 
            lbMemoInfo.ForeColor = Color.Gray;
            lbMemoInfo.Location = new Point(792, 536);
            lbMemoInfo.Name = "lbMemoInfo";
            lbMemoInfo.Size = new Size(232, 20);
            lbMemoInfo.TabIndex = 10;
            lbMemoInfo.Text = "CTRL+ENTER = New line";
            lbMemoInfo.TextAlign = ContentAlignment.TopRight;
            // 
            // edGitNewBranchPrefixList
            // 
            edGitNewBranchPrefixList.Location = new Point(16, 432);
            edGitNewBranchPrefixList.Margin = new Padding(3, 4, 3, 4);
            edGitNewBranchPrefixList.Multiline = true;
            edGitNewBranchPrefixList.Name = "edGitNewBranchPrefixList";
            edGitNewBranchPrefixList.ScrollBars = ScrollBars.Vertical;
            edGitNewBranchPrefixList.Size = new Size(502, 95);
            edGitNewBranchPrefixList.TabIndex = 11;
            // 
            // lbNewBranchPrefix
            // 
            lbNewBranchPrefix.AutoSize = true;
            lbNewBranchPrefix.Location = new Point(14, 408);
            lbNewBranchPrefix.Name = "lbNewBranchPrefix";
            lbNewBranchPrefix.Size = new Size(153, 20);
            lbNewBranchPrefix.TabIndex = 8;
            lbNewBranchPrefix.Text = "New Branch prefix list";
            // 
            // btnSelShellProgram
            // 
            btnSelShellProgram.Location = new Point(1000, 296);
            btnSelShellProgram.Margin = new Padding(3, 4, 3, 4);
            btnSelShellProgram.Name = "btnSelShellProgram";
            btnSelShellProgram.Size = new Size(27, 33);
            btnSelShellProgram.TabIndex = 7;
            btnSelShellProgram.TabStop = false;
            btnSelShellProgram.Text = "...";
            btnSelShellProgram.UseVisualStyleBackColor = true;
            btnSelShellProgram.Click += btnSelShellProgram_Click;
            // 
            // edShellProgram
            // 
            edShellProgram.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            edShellProgram.AutoCompleteSource = AutoCompleteSource.FileSystem;
            edShellProgram.Location = new Point(16, 296);
            edShellProgram.Margin = new Padding(3, 4, 3, 4);
            edShellProgram.Name = "edShellProgram";
            edShellProgram.Size = new Size(984, 27);
            edShellProgram.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(427, 780);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(101, 40);
            btnOK.TabIndex = 98;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(536, 780);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 40);
            btnCancel.TabIndex = 99;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbRestartGitWndRemember
            // 
            lbRestartGitWndRemember.ForeColor = Color.Gray;
            lbRestartGitWndRemember.Location = new Point(720, 32);
            lbRestartGitWndRemember.Name = "lbRestartGitWndRemember";
            lbRestartGitWndRemember.Size = new Size(304, 56);
            lbRestartGitWndRemember.TabIndex = 23;
            lbRestartGitWndRemember.Text = "Restart Git window message";
            // 
            // FrmConfig
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1065, 830);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(pages);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings - Digao Desk";
            FormClosed += FrmConfig_FormClosed;
            Load += FrmConfig_Load;
            pages.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            tabGeneral.PerformLayout();
            tabTheme.ResumeLayout(false);
            tabTheme.PerformLayout();
            BoxThemeConsole.ResumeLayout(false);
            BoxThemeConsole.PerformLayout();
            BoxThemeRepoLog.ResumeLayout(false);
            BoxThemeRepoLog.PerformLayout();
            BoxThemeAppLog.ResumeLayout(false);
            BoxThemeAppLog.PerformLayout();
            tabApplications.ResumeLayout(false);
            tabApplications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edAppLogMaxSize).EndInit();
            tabRepos.ResumeLayout(false);
            tabRepos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckNotifyWhenAppStops;
        private System.Windows.Forms.TabPage tabRepos;
        private System.Windows.Forms.TabPage tabTheme;
        private System.Windows.Forms.Button btnLogFont;
        private System.Windows.Forms.CheckBox ckLogWordWrap;
        private System.Windows.Forms.Label lbColorConsoleBack;
        private System.Windows.Forms.CheckBox ckLogShowTs;
        private System.Windows.Forms.Button btnColorConsoleBack;
        private System.Windows.Forms.Label lbConsoleFont;
        private System.Windows.Forms.CheckBox ckDontNotifyWhenAppsActive;
        private System.Windows.Forms.TextBox edShellProgram;
        private System.Windows.Forms.Label lbShellProgram;
        private System.Windows.Forms.Button btnSelShellProgram;
        private System.Windows.Forms.TextBox edGitNewBranchPrefixList;
        private System.Windows.Forms.Label lbNewBranchPrefix;
        private System.Windows.Forms.Label lbMemoInfo;
        private System.Windows.Forms.CheckBox ckGitAutoFetch;
        private System.Windows.Forms.TextBox edCommitMessage;
        private System.Windows.Forms.Label lbCommitMsg;
        private System.Windows.Forms.Label lbCommitMsgInfo;
        private System.Windows.Forms.Button btnSelDiffProgram;
        private System.Windows.Forms.TextBox edDiffProgram;
        private System.Windows.Forms.Label lbDiffProgram;
        private System.Windows.Forms.Label lbDifProgramArgsInfo;
        private System.Windows.Forms.TextBox edDiffProgramArguments;
        private System.Windows.Forms.Label lbDifProgramArgs;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.ComboBox edLanguage;
        private System.Windows.Forms.Label lbLanguageInfo;
        private System.Windows.Forms.CheckBox ckThemeDarkTitle;
        private System.Windows.Forms.Label lbColorGridHeadBack;
        private System.Windows.Forms.Button btnColorGridHeadBack;
        private System.Windows.Forms.Label lbColorSplitterBack;
        private System.Windows.Forms.Button btnColorSplitterBack;
        private System.Windows.Forms.Label lbColorStatusBack;
        private System.Windows.Forms.Button btnColorStatusBack;
        private System.Windows.Forms.Label lbColorGridSelBack;
        private System.Windows.Forms.Button btnColorGridSelBack;
        private System.Windows.Forms.Label lbColorGridDataFore;
        private System.Windows.Forms.Button btnColorGridDataFore;
        private System.Windows.Forms.Label lbColorGridHeadFore;
        private System.Windows.Forms.Button btnColorGridHeadFore;
        private System.Windows.Forms.Label lbColorGridSelFore;
        private System.Windows.Forms.Button btnColorGridSelFore;
        private System.Windows.Forms.Label lbColorGridBack;
        private System.Windows.Forms.Button btnColorGridBack;
        private System.Windows.Forms.Label lbColorToolbarFore;
        private System.Windows.Forms.Button btnColorToolbarFore;
        private System.Windows.Forms.Label lbColorToolbarBack;
        private System.Windows.Forms.Button btnColorToolbarBack;
        private System.Windows.Forms.Label lbColorStatusFore;
        private System.Windows.Forms.Button btnColorStatusFore;
        private System.Windows.Forms.Label lbColorGridLines;
        private System.Windows.Forms.Button btnColorGridLines;
        private System.Windows.Forms.Label lbColorGridDataBack;
        private System.Windows.Forms.Button btnColorGridDataBack;
        private System.Windows.Forms.Button btnResetColors;
        private System.Windows.Forms.NumericUpDown edAppLogMaxSize;
        private System.Windows.Forms.Label lbAppsLinesLog;
        private System.Windows.Forms.CheckBox ckCalcAppResources;
        private System.Windows.Forms.TextBox edGitCustomCommands;
        private System.Windows.Forms.Label lbCustomCommands;
        private System.Windows.Forms.Label btnCustomCommandsHelp;
        private System.Windows.Forms.CheckBox ckGitAutoCRLF;
        private System.Windows.Forms.Label lbColorAppLogDynWarn;
        private System.Windows.Forms.Button btnColorAppLogDynWarn;
        private System.Windows.Forms.Label lbColorAppLogDynError;
        private System.Windows.Forms.Button btnColorAppLogDynError;
        private System.Windows.Forms.Label lbColorAppLogError;
        private System.Windows.Forms.Button btnColorAppLogError;
        private System.Windows.Forms.Label lbColorAppLogStop;
        private System.Windows.Forms.Button btnColorAppLogStop;
        private System.Windows.Forms.Label lbColorAppLogNormal;
        private System.Windows.Forms.Button btnColorAppLogNormal;
        private System.Windows.Forms.Label lbColorLogTimestampFore;
        private System.Windows.Forms.Button btnColorTimestampFore;
        private System.Windows.Forms.Label lbColorRepoLogError;
        private System.Windows.Forms.Button btnColorRepoLogError;
        private System.Windows.Forms.Label lbColorRepoLogTitle;
        private System.Windows.Forms.Button btnColorRepoLogTitle;
        private System.Windows.Forms.Label lbColorRepoLogAlert;
        private System.Windows.Forms.Button btnColorRepoLogAlert;
        private System.Windows.Forms.Label lbColorRepoLogAggProcessing;
        private System.Windows.Forms.Button btnColorRepoLogAggProcessing;
        private System.Windows.Forms.Label lbColorRepoLogNormal;
        private System.Windows.Forms.Button btnColorRepoLogNormal;
        private System.Windows.Forms.Label lbColorRepoLogDone;
        private System.Windows.Forms.Button btnColorRepoLogDone;
        private System.Windows.Forms.Label lbColorRepoLogProcessing;
        private System.Windows.Forms.Button btnColorRepoLogProcessing;
        private System.Windows.Forms.GroupBox BoxThemeRepoLog;
        private System.Windows.Forms.GroupBox BoxThemeAppLog;
        private System.Windows.Forms.Button btnColorRepoLogStatusOK;
        private System.Windows.Forms.Label lbColorRepoLogStatusOK;
        private System.Windows.Forms.Button btnColorRepoLogLabelCaption;
        private System.Windows.Forms.Label lbColorRepoLogLabelCaption;
        private System.Windows.Forms.Label lbColorRepoLogLabelValue;
        private System.Windows.Forms.Button btnColorRepoLogLabelValue;
        private System.Windows.Forms.Button btnColorRepoLogStatusNone;
        private System.Windows.Forms.Label lbColorRepoLogStatusNone;
        private System.Windows.Forms.Button btnColorRepoLogStatusWarn;
        private System.Windows.Forms.Label lbColorRepoLogStatusWarn;
        private System.Windows.Forms.GroupBox BoxThemeConsole;
        private System.Windows.Forms.ListBox listGitGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelGitGroup;
        private System.Windows.Forms.Button btnEditGitGroup;
        private System.Windows.Forms.Button btnAddGitGroup;
        private System.Windows.Forms.CheckBox ckClearLogWhenStartApp;
        private Label lbRestartGitWndRemember;
    }
}