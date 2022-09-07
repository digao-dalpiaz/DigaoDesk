
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
            this.pages = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lbLanguageInfo = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.edLanguage = new System.Windows.Forms.ComboBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.btnColorGridDataBack = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnColorGridLines = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnColorStatusFore = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnColorGridHeadBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnColorSplitterBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnColorStatusBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnColorGridSelBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnColorGridDataFore = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColorGridHeadFore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColorGridSelFore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColorGridBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnColorToolbarFore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColorToolbarBack = new System.Windows.Forms.Button();
            this.ckThemeDarkTitle = new System.Windows.Forms.CheckBox();
            this.btnLogFont = new System.Windows.Forms.Button();
            this.lbTextColor = new System.Windows.Forms.Label();
            this.ckLogWordWrap = new System.Windows.Forms.CheckBox();
            this.lbBackgroundColor = new System.Windows.Forms.Label();
            this.ckLogShowTs = new System.Windows.Forms.CheckBox();
            this.btnColorConsoleFore = new System.Windows.Forms.Button();
            this.btnColorConsoleBack = new System.Windows.Forms.Button();
            this.lbFont = new System.Windows.Forms.Label();
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.CkDontNotifyWhenAppsActive = new System.Windows.Forms.CheckBox();
            this.ckNotifyWhenAppStops = new System.Windows.Forms.CheckBox();
            this.tabRepos = new System.Windows.Forms.TabPage();
            this.lbDifProgramArgs = new System.Windows.Forms.Label();
            this.edDiffProgramArguments = new System.Windows.Forms.TextBox();
            this.lbDifProgramArgsInfo = new System.Windows.Forms.Label();
            this.btnSelDiffProgram = new System.Windows.Forms.Button();
            this.lbShellProgram = new System.Windows.Forms.Label();
            this.edDiffProgram = new System.Windows.Forms.TextBox();
            this.lbDiffProgram = new System.Windows.Forms.Label();
            this.lbCommitMsgInfo = new System.Windows.Forms.Label();
            this.edCommitMessage = new System.Windows.Forms.TextBox();
            this.lbCommitMsg = new System.Windows.Forms.Label();
            this.ckGitAutoFetch = new System.Windows.Forms.CheckBox();
            this.lbNewBranchPrefixInfo = new System.Windows.Forms.Label();
            this.boxGitAuthor = new System.Windows.Forms.GroupBox();
            this.edGitName = new System.Windows.Forms.TextBox();
            this.lbAuthorName = new System.Windows.Forms.Label();
            this.lbAuthorEmail = new System.Windows.Forms.Label();
            this.edGitEmail = new System.Windows.Forms.TextBox();
            this.edGitNewBranchPrefixList = new System.Windows.Forms.TextBox();
            this.lbNewBranchPrefix = new System.Windows.Forms.Label();
            this.btnSelShellProgram = new System.Windows.Forms.Button();
            this.edShellProgram = new System.Windows.Forms.TextBox();
            this.boxGitCredentials = new System.Windows.Forms.GroupBox();
            this.edGitCredPassword = new System.Windows.Forms.TextBox();
            this.lbCredPassword = new System.Windows.Forms.Label();
            this.edGitCredUsername = new System.Windows.Forms.TextBox();
            this.lbCredUsername = new System.Windows.Forms.Label();
            this.btnSelReposDir = new System.Windows.Forms.Button();
            this.edReposDir = new System.Windows.Forms.TextBox();
            this.lbRepositoryFolder = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pages.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.tabApplications.SuspendLayout();
            this.tabRepos.SuspendLayout();
            this.boxGitAuthor.SuspendLayout();
            this.boxGitCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.tabGeneral);
            this.pages.Controls.Add(this.tabLogs);
            this.pages.Controls.Add(this.tabApplications);
            this.pages.Controls.Add(this.tabRepos);
            this.pages.Location = new System.Drawing.Point(9, 11);
            this.pages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1047, 693);
            this.pages.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.lbLanguageInfo);
            this.tabGeneral.Controls.Add(this.lbLanguage);
            this.tabGeneral.Controls.Add(this.edLanguage);
            this.tabGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(1039, 660);
            this.tabGeneral.TabIndex = 3;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lbLanguageInfo
            // 
            this.lbLanguageInfo.AutoSize = true;
            this.lbLanguageInfo.Location = new System.Drawing.Point(352, 44);
            this.lbLanguageInfo.Name = "lbLanguageInfo";
            this.lbLanguageInfo.Size = new System.Drawing.Size(119, 20);
            this.lbLanguageInfo.TabIndex = 2;
            this.lbLanguageInfo.Text = "* Restart needed";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(22, 16);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(74, 20);
            this.lbLanguage.TabIndex = 1;
            this.lbLanguage.Text = "Language";
            // 
            // edLanguage
            // 
            this.edLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edLanguage.FormattingEnabled = true;
            this.edLanguage.Location = new System.Drawing.Point(24, 40);
            this.edLanguage.Name = "edLanguage";
            this.edLanguage.Size = new System.Drawing.Size(304, 28);
            this.edLanguage.TabIndex = 0;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.label13);
            this.tabLogs.Controls.Add(this.btnColorGridDataBack);
            this.tabLogs.Controls.Add(this.label12);
            this.tabLogs.Controls.Add(this.btnColorGridLines);
            this.tabLogs.Controls.Add(this.label11);
            this.tabLogs.Controls.Add(this.btnColorStatusFore);
            this.tabLogs.Controls.Add(this.label10);
            this.tabLogs.Controls.Add(this.btnColorGridHeadBack);
            this.tabLogs.Controls.Add(this.label9);
            this.tabLogs.Controls.Add(this.btnColorSplitterBack);
            this.tabLogs.Controls.Add(this.label8);
            this.tabLogs.Controls.Add(this.btnColorStatusBack);
            this.tabLogs.Controls.Add(this.label7);
            this.tabLogs.Controls.Add(this.btnColorGridSelBack);
            this.tabLogs.Controls.Add(this.label6);
            this.tabLogs.Controls.Add(this.btnColorGridDataFore);
            this.tabLogs.Controls.Add(this.label5);
            this.tabLogs.Controls.Add(this.btnColorGridHeadFore);
            this.tabLogs.Controls.Add(this.label3);
            this.tabLogs.Controls.Add(this.btnColorGridSelFore);
            this.tabLogs.Controls.Add(this.label4);
            this.tabLogs.Controls.Add(this.btnColorGridBack);
            this.tabLogs.Controls.Add(this.label2);
            this.tabLogs.Controls.Add(this.btnColorToolbarFore);
            this.tabLogs.Controls.Add(this.label1);
            this.tabLogs.Controls.Add(this.btnColorToolbarBack);
            this.tabLogs.Controls.Add(this.ckThemeDarkTitle);
            this.tabLogs.Controls.Add(this.btnLogFont);
            this.tabLogs.Controls.Add(this.lbTextColor);
            this.tabLogs.Controls.Add(this.ckLogWordWrap);
            this.tabLogs.Controls.Add(this.lbBackgroundColor);
            this.tabLogs.Controls.Add(this.ckLogShowTs);
            this.tabLogs.Controls.Add(this.btnColorConsoleFore);
            this.tabLogs.Controls.Add(this.btnColorConsoleBack);
            this.tabLogs.Controls.Add(this.lbFont);
            this.tabLogs.Location = new System.Drawing.Point(4, 29);
            this.tabLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLogs.Size = new System.Drawing.Size(1039, 660);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "Log";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Grid data background";
            // 
            // btnColorGridDataBack
            // 
            this.btnColorGridDataBack.Location = new System.Drawing.Point(24, 304);
            this.btnColorGridDataBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorGridDataBack.Name = "btnColorGridDataBack";
            this.btnColorGridDataBack.Size = new System.Drawing.Size(347, 43);
            this.btnColorGridDataBack.TabIndex = 40;
            this.btnColorGridDataBack.UseVisualStyleBackColor = true;
            this.btnColorGridDataBack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Grid lines";
            // 
            // btnColorGridLines
            // 
            this.btnColorGridLines.Location = new System.Drawing.Point(384, 232);
            this.btnColorGridLines.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorGridLines.Name = "btnColorGridLines";
            this.btnColorGridLines.Size = new System.Drawing.Size(347, 43);
            this.btnColorGridLines.TabIndex = 38;
            this.btnColorGridLines.UseVisualStyleBackColor = true;
            this.btnColorGridLines.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Status bar foreground";
            // 
            // btnColorStatusFore
            // 
            this.btnColorStatusFore.Location = new System.Drawing.Point(384, 592);
            this.btnColorStatusFore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorStatusFore.Name = "btnColorStatusFore";
            this.btnColorStatusFore.Size = new System.Drawing.Size(347, 43);
            this.btnColorStatusFore.TabIndex = 36;
            this.btnColorStatusFore.UseVisualStyleBackColor = true;
            this.btnColorStatusFore.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Grid header background";
            // 
            // btnColorGridHeadBack
            // 
            this.btnColorGridHeadBack.Location = new System.Drawing.Point(24, 160);
            this.btnColorGridHeadBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorGridHeadBack.Name = "btnColorGridHeadBack";
            this.btnColorGridHeadBack.Size = new System.Drawing.Size(347, 43);
            this.btnColorGridHeadBack.TabIndex = 34;
            this.btnColorGridHeadBack.UseVisualStyleBackColor = true;
            this.btnColorGridHeadBack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Splitter background";
            // 
            // btnColorSplitterBack
            // 
            this.btnColorSplitterBack.Location = new System.Drawing.Point(24, 448);
            this.btnColorSplitterBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorSplitterBack.Name = "btnColorSplitterBack";
            this.btnColorSplitterBack.Size = new System.Drawing.Size(347, 43);
            this.btnColorSplitterBack.TabIndex = 32;
            this.btnColorSplitterBack.UseVisualStyleBackColor = true;
            this.btnColorSplitterBack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 571);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Status bar background";
            // 
            // btnColorStatusBack
            // 
            this.btnColorStatusBack.Location = new System.Drawing.Point(24, 592);
            this.btnColorStatusBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorStatusBack.Name = "btnColorStatusBack";
            this.btnColorStatusBack.Size = new System.Drawing.Size(347, 43);
            this.btnColorStatusBack.TabIndex = 30;
            this.btnColorStatusBack.UseVisualStyleBackColor = true;
            this.btnColorStatusBack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Grid selected background";
            // 
            // btnColorGridSelBack
            // 
            this.btnColorGridSelBack.Location = new System.Drawing.Point(24, 376);
            this.btnColorGridSelBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorGridSelBack.Name = "btnColorGridSelBack";
            this.btnColorGridSelBack.Size = new System.Drawing.Size(347, 43);
            this.btnColorGridSelBack.TabIndex = 28;
            this.btnColorGridSelBack.UseVisualStyleBackColor = true;
            this.btnColorGridSelBack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Grid data foreground";
            // 
            // btnColorGridDataFore
            // 
            this.btnColorGridDataFore.Location = new System.Drawing.Point(384, 304);
            this.btnColorGridDataFore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorGridDataFore.Name = "btnColorGridDataFore";
            this.btnColorGridDataFore.Size = new System.Drawing.Size(347, 43);
            this.btnColorGridDataFore.TabIndex = 26;
            this.btnColorGridDataFore.UseVisualStyleBackColor = true;
            this.btnColorGridDataFore.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Grid header foreground";
            // 
            // btnColorGridHeadFore
            // 
            this.btnColorGridHeadFore.Location = new System.Drawing.Point(384, 160);
            this.btnColorGridHeadFore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorGridHeadFore.Name = "btnColorGridHeadFore";
            this.btnColorGridHeadFore.Size = new System.Drawing.Size(347, 43);
            this.btnColorGridHeadFore.TabIndex = 24;
            this.btnColorGridHeadFore.UseVisualStyleBackColor = true;
            this.btnColorGridHeadFore.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Grid selected foreground";
            // 
            // btnColorGridSelFore
            // 
            this.btnColorGridSelFore.Location = new System.Drawing.Point(384, 376);
            this.btnColorGridSelFore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorGridSelFore.Name = "btnColorGridSelFore";
            this.btnColorGridSelFore.Size = new System.Drawing.Size(347, 43);
            this.btnColorGridSelFore.TabIndex = 22;
            this.btnColorGridSelFore.UseVisualStyleBackColor = true;
            this.btnColorGridSelFore.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Grid background";
            // 
            // btnColorGridBack
            // 
            this.btnColorGridBack.Location = new System.Drawing.Point(24, 232);
            this.btnColorGridBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorGridBack.Name = "btnColorGridBack";
            this.btnColorGridBack.Size = new System.Drawing.Size(347, 43);
            this.btnColorGridBack.TabIndex = 20;
            this.btnColorGridBack.UseVisualStyleBackColor = true;
            this.btnColorGridBack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tool bar foreground";
            // 
            // btnColorToolbarFore
            // 
            this.btnColorToolbarFore.Location = new System.Drawing.Point(384, 88);
            this.btnColorToolbarFore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorToolbarFore.Name = "btnColorToolbarFore";
            this.btnColorToolbarFore.Size = new System.Drawing.Size(347, 43);
            this.btnColorToolbarFore.TabIndex = 18;
            this.btnColorToolbarFore.UseVisualStyleBackColor = true;
            this.btnColorToolbarFore.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tool bar background";
            // 
            // btnColorToolbarBack
            // 
            this.btnColorToolbarBack.Location = new System.Drawing.Point(24, 88);
            this.btnColorToolbarBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorToolbarBack.Name = "btnColorToolbarBack";
            this.btnColorToolbarBack.Size = new System.Drawing.Size(347, 43);
            this.btnColorToolbarBack.TabIndex = 16;
            this.btnColorToolbarBack.UseVisualStyleBackColor = true;
            this.btnColorToolbarBack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // ckThemeDarkTitle
            // 
            this.ckThemeDarkTitle.AutoSize = true;
            this.ckThemeDarkTitle.Location = new System.Drawing.Point(24, 24);
            this.ckThemeDarkTitle.Name = "ckThemeDarkTitle";
            this.ckThemeDarkTitle.Size = new System.Drawing.Size(121, 24);
            this.ckThemeDarkTitle.TabIndex = 14;
            this.ckThemeDarkTitle.Text = "Dark Title Bar";
            this.ckThemeDarkTitle.UseVisualStyleBackColor = true;
            // 
            // btnLogFont
            // 
            this.btnLogFont.Location = new System.Drawing.Point(776, 136);
            this.btnLogFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogFont.Name = "btnLogFont";
            this.btnLogFont.Size = new System.Drawing.Size(179, 43);
            this.btnLogFont.TabIndex = 6;
            this.btnLogFont.UseVisualStyleBackColor = true;
            this.btnLogFont.Click += new System.EventHandler(this.btnLogFont_Click);
            // 
            // lbTextColor
            // 
            this.lbTextColor.AutoSize = true;
            this.lbTextColor.Location = new System.Drawing.Point(382, 499);
            this.lbTextColor.Name = "lbTextColor";
            this.lbTextColor.Size = new System.Drawing.Size(141, 20);
            this.lbTextColor.TabIndex = 7;
            this.lbTextColor.Text = "Console foreground";
            // 
            // ckLogWordWrap
            // 
            this.ckLogWordWrap.AutoSize = true;
            this.ckLogWordWrap.Location = new System.Drawing.Point(776, 232);
            this.ckLogWordWrap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckLogWordWrap.Name = "ckLogWordWrap";
            this.ckLogWordWrap.Size = new System.Drawing.Size(104, 24);
            this.ckLogWordWrap.TabIndex = 12;
            this.ckLogWordWrap.Text = "Word wrap";
            this.ckLogWordWrap.UseVisualStyleBackColor = true;
            // 
            // lbBackgroundColor
            // 
            this.lbBackgroundColor.AutoSize = true;
            this.lbBackgroundColor.Location = new System.Drawing.Point(22, 499);
            this.lbBackgroundColor.Name = "lbBackgroundColor";
            this.lbBackgroundColor.Size = new System.Drawing.Size(145, 20);
            this.lbBackgroundColor.TabIndex = 8;
            this.lbBackgroundColor.Text = "Console background";
            // 
            // ckLogShowTs
            // 
            this.ckLogShowTs.AutoSize = true;
            this.ckLogShowTs.Location = new System.Drawing.Point(776, 200);
            this.ckLogShowTs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckLogShowTs.Name = "ckLogShowTs";
            this.ckLogShowTs.Size = new System.Drawing.Size(235, 24);
            this.ckLogShowTs.TabIndex = 11;
            this.ckLogShowTs.Text = "Show date/time in each record";
            this.ckLogShowTs.UseVisualStyleBackColor = true;
            // 
            // btnColorConsoleFore
            // 
            this.btnColorConsoleFore.Location = new System.Drawing.Point(384, 520);
            this.btnColorConsoleFore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorConsoleFore.Name = "btnColorConsoleFore";
            this.btnColorConsoleFore.Size = new System.Drawing.Size(347, 43);
            this.btnColorConsoleFore.TabIndex = 9;
            this.btnColorConsoleFore.UseVisualStyleBackColor = false;
            this.btnColorConsoleFore.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColorConsoleBack
            // 
            this.btnColorConsoleBack.Location = new System.Drawing.Point(24, 520);
            this.btnColorConsoleBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorConsoleBack.Name = "btnColorConsoleBack";
            this.btnColorConsoleBack.Size = new System.Drawing.Size(347, 43);
            this.btnColorConsoleBack.TabIndex = 10;
            this.btnColorConsoleBack.UseVisualStyleBackColor = true;
            this.btnColorConsoleBack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lbFont
            // 
            this.lbFont.AutoSize = true;
            this.lbFont.Location = new System.Drawing.Point(774, 114);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(38, 20);
            this.lbFont.TabIndex = 13;
            this.lbFont.Text = "Font";
            // 
            // tabApplications
            // 
            this.tabApplications.Controls.Add(this.CkDontNotifyWhenAppsActive);
            this.tabApplications.Controls.Add(this.ckNotifyWhenAppStops);
            this.tabApplications.Location = new System.Drawing.Point(4, 29);
            this.tabApplications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabApplications.Size = new System.Drawing.Size(1039, 660);
            this.tabApplications.TabIndex = 0;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // CkDontNotifyWhenAppsActive
            // 
            this.CkDontNotifyWhenAppsActive.AutoSize = true;
            this.CkDontNotifyWhenAppsActive.Location = new System.Drawing.Point(46, 53);
            this.CkDontNotifyWhenAppsActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CkDontNotifyWhenAppsActive.Name = "CkDontNotifyWhenAppsActive";
            this.CkDontNotifyWhenAppsActive.Size = new System.Drawing.Size(273, 24);
            this.CkDontNotifyWhenAppsActive.TabIndex = 11;
            this.CkDontNotifyWhenAppsActive.Text = "Do not notify when apps form active";
            this.CkDontNotifyWhenAppsActive.UseVisualStyleBackColor = true;
            // 
            // ckNotifyWhenAppStops
            // 
            this.ckNotifyWhenAppStops.AutoSize = true;
            this.ckNotifyWhenAppStops.Location = new System.Drawing.Point(18, 21);
            this.ckNotifyWhenAppStops.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckNotifyWhenAppStops.Name = "ckNotifyWhenAppStops";
            this.ckNotifyWhenAppStops.Size = new System.Drawing.Size(229, 24);
            this.ckNotifyWhenAppStops.TabIndex = 10;
            this.ckNotifyWhenAppStops.Text = "Notify when application stops";
            this.ckNotifyWhenAppStops.UseVisualStyleBackColor = true;
            // 
            // tabRepos
            // 
            this.tabRepos.Controls.Add(this.lbDifProgramArgs);
            this.tabRepos.Controls.Add(this.edDiffProgramArguments);
            this.tabRepos.Controls.Add(this.lbDifProgramArgsInfo);
            this.tabRepos.Controls.Add(this.btnSelDiffProgram);
            this.tabRepos.Controls.Add(this.lbShellProgram);
            this.tabRepos.Controls.Add(this.edDiffProgram);
            this.tabRepos.Controls.Add(this.lbDiffProgram);
            this.tabRepos.Controls.Add(this.lbCommitMsgInfo);
            this.tabRepos.Controls.Add(this.edCommitMessage);
            this.tabRepos.Controls.Add(this.lbCommitMsg);
            this.tabRepos.Controls.Add(this.ckGitAutoFetch);
            this.tabRepos.Controls.Add(this.lbNewBranchPrefixInfo);
            this.tabRepos.Controls.Add(this.boxGitAuthor);
            this.tabRepos.Controls.Add(this.edGitNewBranchPrefixList);
            this.tabRepos.Controls.Add(this.lbNewBranchPrefix);
            this.tabRepos.Controls.Add(this.btnSelShellProgram);
            this.tabRepos.Controls.Add(this.edShellProgram);
            this.tabRepos.Controls.Add(this.boxGitCredentials);
            this.tabRepos.Controls.Add(this.btnSelReposDir);
            this.tabRepos.Controls.Add(this.edReposDir);
            this.tabRepos.Controls.Add(this.lbRepositoryFolder);
            this.tabRepos.Location = new System.Drawing.Point(4, 29);
            this.tabRepos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRepos.Name = "tabRepos";
            this.tabRepos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRepos.Size = new System.Drawing.Size(1039, 660);
            this.tabRepos.TabIndex = 1;
            this.tabRepos.Text = "Git Repositories";
            this.tabRepos.UseVisualStyleBackColor = true;
            // 
            // lbDifProgramArgs
            // 
            this.lbDifProgramArgs.AutoSize = true;
            this.lbDifProgramArgs.Location = new System.Drawing.Point(534, 336);
            this.lbDifProgramArgs.Name = "lbDifProgramArgs";
            this.lbDifProgramArgs.Size = new System.Drawing.Size(81, 20);
            this.lbDifProgramArgs.TabIndex = 18;
            this.lbDifProgramArgs.Text = "Arguments";
            // 
            // edDiffProgramArguments
            // 
            this.edDiffProgramArguments.Location = new System.Drawing.Point(536, 360);
            this.edDiffProgramArguments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edDiffProgramArguments.Name = "edDiffProgramArguments";
            this.edDiffProgramArguments.Size = new System.Drawing.Size(488, 27);
            this.edDiffProgramArguments.TabIndex = 10;
            // 
            // lbDifProgramArgsInfo
            // 
            this.lbDifProgramArgsInfo.AutoSize = true;
            this.lbDifProgramArgsInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbDifProgramArgsInfo.Location = new System.Drawing.Point(656, 336);
            this.lbDifProgramArgsInfo.Name = "lbDifProgramArgsInfo";
            this.lbDifProgramArgsInfo.Size = new System.Drawing.Size(227, 20);
            this.lbDifProgramArgsInfo.TabIndex = 16;
            this.lbDifProgramArgsInfo.Text = "[old] = old file / [new] = new file";
            // 
            // btnSelDiffProgram
            // 
            this.btnSelDiffProgram.Location = new System.Drawing.Point(496, 360);
            this.btnSelDiffProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelDiffProgram.Name = "btnSelDiffProgram";
            this.btnSelDiffProgram.Size = new System.Drawing.Size(27, 33);
            this.btnSelDiffProgram.TabIndex = 9;
            this.btnSelDiffProgram.TabStop = false;
            this.btnSelDiffProgram.Text = "...";
            this.btnSelDiffProgram.UseVisualStyleBackColor = true;
            this.btnSelDiffProgram.Click += new System.EventHandler(this.btnSelDiffProgram_Click);
            // 
            // lbShellProgram
            // 
            this.lbShellProgram.AutoSize = true;
            this.lbShellProgram.Location = new System.Drawing.Point(12, 264);
            this.lbShellProgram.Name = "lbShellProgram";
            this.lbShellProgram.Size = new System.Drawing.Size(103, 20);
            this.lbShellProgram.TabIndex = 5;
            this.lbShellProgram.Text = "Shell program";
            // 
            // edDiffProgram
            // 
            this.edDiffProgram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edDiffProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.edDiffProgram.Location = new System.Drawing.Point(16, 360);
            this.edDiffProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edDiffProgram.Name = "edDiffProgram";
            this.edDiffProgram.Size = new System.Drawing.Size(480, 27);
            this.edDiffProgram.TabIndex = 8;
            // 
            // lbDiffProgram
            // 
            this.lbDiffProgram.AutoSize = true;
            this.lbDiffProgram.Location = new System.Drawing.Point(12, 336);
            this.lbDiffProgram.Name = "lbDiffProgram";
            this.lbDiffProgram.Size = new System.Drawing.Size(96, 20);
            this.lbDiffProgram.TabIndex = 15;
            this.lbDiffProgram.Text = "Diff program";
            // 
            // lbCommitMsgInfo
            // 
            this.lbCommitMsgInfo.AutoSize = true;
            this.lbCommitMsgInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbCommitMsgInfo.Location = new System.Drawing.Point(240, 576);
            this.lbCommitMsgInfo.Name = "lbCommitMsgInfo";
            this.lbCommitMsgInfo.Size = new System.Drawing.Size(205, 20);
            this.lbCommitMsgInfo.TabIndex = 14;
            this.lbCommitMsgInfo.Text = "Use [branch] for branch name";
            // 
            // edCommitMessage
            // 
            this.edCommitMessage.Location = new System.Drawing.Point(16, 600);
            this.edCommitMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edCommitMessage.Name = "edCommitMessage";
            this.edCommitMessage.Size = new System.Drawing.Size(504, 27);
            this.edCommitMessage.TabIndex = 13;
            // 
            // lbCommitMsg
            // 
            this.lbCommitMsg.AutoSize = true;
            this.lbCommitMsg.Location = new System.Drawing.Point(14, 576);
            this.lbCommitMsg.Name = "lbCommitMsg";
            this.lbCommitMsg.Size = new System.Drawing.Size(124, 20);
            this.lbCommitMsg.TabIndex = 12;
            this.lbCommitMsg.Text = "Commit message";
            // 
            // ckGitAutoFetch
            // 
            this.ckGitAutoFetch.AutoSize = true;
            this.ckGitAutoFetch.Location = new System.Drawing.Point(16, 536);
            this.ckGitAutoFetch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckGitAutoFetch.Name = "ckGitAutoFetch";
            this.ckGitAutoFetch.Size = new System.Drawing.Size(249, 24);
            this.ckGitAutoFetch.TabIndex = 12;
            this.ckGitAutoFetch.Text = "Auto Fetch in Remote operations";
            this.ckGitAutoFetch.UseVisualStyleBackColor = true;
            // 
            // lbNewBranchPrefixInfo
            // 
            this.lbNewBranchPrefixInfo.AutoSize = true;
            this.lbNewBranchPrefixInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbNewBranchPrefixInfo.Location = new System.Drawing.Point(288, 400);
            this.lbNewBranchPrefixInfo.Name = "lbNewBranchPrefixInfo";
            this.lbNewBranchPrefixInfo.Size = new System.Drawing.Size(172, 20);
            this.lbNewBranchPrefixInfo.TabIndex = 10;
            this.lbNewBranchPrefixInfo.Text = "CTRL+ENTER = New line";
            // 
            // boxGitAuthor
            // 
            this.boxGitAuthor.Controls.Add(this.edGitName);
            this.boxGitAuthor.Controls.Add(this.lbAuthorName);
            this.boxGitAuthor.Controls.Add(this.lbAuthorEmail);
            this.boxGitAuthor.Controls.Add(this.edGitEmail);
            this.boxGitAuthor.Location = new System.Drawing.Point(16, 80);
            this.boxGitAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxGitAuthor.Name = "boxGitAuthor";
            this.boxGitAuthor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxGitAuthor.Size = new System.Drawing.Size(496, 171);
            this.boxGitAuthor.TabIndex = 3;
            this.boxGitAuthor.TabStop = false;
            this.boxGitAuthor.Text = "Author information";
            // 
            // edGitName
            // 
            this.edGitName.Location = new System.Drawing.Point(16, 56);
            this.edGitName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edGitName.Name = "edGitName";
            this.edGitName.Size = new System.Drawing.Size(464, 27);
            this.edGitName.TabIndex = 4;
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Location = new System.Drawing.Point(14, 32);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(49, 20);
            this.lbAuthorName.TabIndex = 3;
            this.lbAuthorName.Text = "Name";
            // 
            // lbAuthorEmail
            // 
            this.lbAuthorEmail.AutoSize = true;
            this.lbAuthorEmail.Location = new System.Drawing.Point(14, 96);
            this.lbAuthorEmail.Name = "lbAuthorEmail";
            this.lbAuthorEmail.Size = new System.Drawing.Size(46, 20);
            this.lbAuthorEmail.TabIndex = 5;
            this.lbAuthorEmail.Text = "Email";
            // 
            // edGitEmail
            // 
            this.edGitEmail.Location = new System.Drawing.Point(16, 120);
            this.edGitEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edGitEmail.Name = "edGitEmail";
            this.edGitEmail.Size = new System.Drawing.Size(464, 27);
            this.edGitEmail.TabIndex = 6;
            // 
            // edGitNewBranchPrefixList
            // 
            this.edGitNewBranchPrefixList.Location = new System.Drawing.Point(16, 424);
            this.edGitNewBranchPrefixList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edGitNewBranchPrefixList.Multiline = true;
            this.edGitNewBranchPrefixList.Name = "edGitNewBranchPrefixList";
            this.edGitNewBranchPrefixList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edGitNewBranchPrefixList.Size = new System.Drawing.Size(502, 95);
            this.edGitNewBranchPrefixList.TabIndex = 11;
            // 
            // lbNewBranchPrefix
            // 
            this.lbNewBranchPrefix.AutoSize = true;
            this.lbNewBranchPrefix.Location = new System.Drawing.Point(14, 400);
            this.lbNewBranchPrefix.Name = "lbNewBranchPrefix";
            this.lbNewBranchPrefix.Size = new System.Drawing.Size(153, 20);
            this.lbNewBranchPrefix.TabIndex = 8;
            this.lbNewBranchPrefix.Text = "New Branch prefix list";
            // 
            // btnSelShellProgram
            // 
            this.btnSelShellProgram.Location = new System.Drawing.Point(1000, 288);
            this.btnSelShellProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelShellProgram.Name = "btnSelShellProgram";
            this.btnSelShellProgram.Size = new System.Drawing.Size(27, 33);
            this.btnSelShellProgram.TabIndex = 7;
            this.btnSelShellProgram.TabStop = false;
            this.btnSelShellProgram.Text = "...";
            this.btnSelShellProgram.UseVisualStyleBackColor = true;
            this.btnSelShellProgram.Click += new System.EventHandler(this.btnSelShellProgram_Click);
            // 
            // edShellProgram
            // 
            this.edShellProgram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edShellProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.edShellProgram.Location = new System.Drawing.Point(16, 288);
            this.edShellProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edShellProgram.Name = "edShellProgram";
            this.edShellProgram.Size = new System.Drawing.Size(984, 27);
            this.edShellProgram.TabIndex = 6;
            // 
            // boxGitCredentials
            // 
            this.boxGitCredentials.Controls.Add(this.edGitCredPassword);
            this.boxGitCredentials.Controls.Add(this.lbCredPassword);
            this.boxGitCredentials.Controls.Add(this.edGitCredUsername);
            this.boxGitCredentials.Controls.Add(this.lbCredUsername);
            this.boxGitCredentials.Location = new System.Drawing.Point(528, 80);
            this.boxGitCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxGitCredentials.Name = "boxGitCredentials";
            this.boxGitCredentials.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxGitCredentials.Size = new System.Drawing.Size(496, 171);
            this.boxGitCredentials.TabIndex = 4;
            this.boxGitCredentials.TabStop = false;
            this.boxGitCredentials.Text = "Credentials";
            // 
            // edGitCredPassword
            // 
            this.edGitCredPassword.Location = new System.Drawing.Point(16, 120);
            this.edGitCredPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edGitCredPassword.Name = "edGitCredPassword";
            this.edGitCredPassword.PasswordChar = '●';
            this.edGitCredPassword.Size = new System.Drawing.Size(464, 27);
            this.edGitCredPassword.TabIndex = 10;
            // 
            // lbCredPassword
            // 
            this.lbCredPassword.AutoSize = true;
            this.lbCredPassword.Location = new System.Drawing.Point(14, 96);
            this.lbCredPassword.Name = "lbCredPassword";
            this.lbCredPassword.Size = new System.Drawing.Size(70, 20);
            this.lbCredPassword.TabIndex = 9;
            this.lbCredPassword.Text = "Password";
            // 
            // edGitCredUsername
            // 
            this.edGitCredUsername.Location = new System.Drawing.Point(16, 56);
            this.edGitCredUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edGitCredUsername.Name = "edGitCredUsername";
            this.edGitCredUsername.Size = new System.Drawing.Size(464, 27);
            this.edGitCredUsername.TabIndex = 8;
            // 
            // lbCredUsername
            // 
            this.lbCredUsername.AutoSize = true;
            this.lbCredUsername.Location = new System.Drawing.Point(14, 32);
            this.lbCredUsername.Name = "lbCredUsername";
            this.lbCredUsername.Size = new System.Drawing.Size(75, 20);
            this.lbCredUsername.TabIndex = 7;
            this.lbCredUsername.Text = "Username";
            // 
            // btnSelReposDir
            // 
            this.btnSelReposDir.Location = new System.Drawing.Point(992, 32);
            this.btnSelReposDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelReposDir.Name = "btnSelReposDir";
            this.btnSelReposDir.Size = new System.Drawing.Size(27, 33);
            this.btnSelReposDir.TabIndex = 2;
            this.btnSelReposDir.TabStop = false;
            this.btnSelReposDir.Text = "...";
            this.btnSelReposDir.UseVisualStyleBackColor = true;
            this.btnSelReposDir.Click += new System.EventHandler(this.btnSelReposDir_Click);
            // 
            // edReposDir
            // 
            this.edReposDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edReposDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.edReposDir.Location = new System.Drawing.Point(16, 32);
            this.edReposDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edReposDir.Name = "edReposDir";
            this.edReposDir.Size = new System.Drawing.Size(976, 27);
            this.edReposDir.TabIndex = 1;
            // 
            // lbRepositoryFolder
            // 
            this.lbRepositoryFolder.AutoSize = true;
            this.lbRepositoryFolder.Location = new System.Drawing.Point(14, 8);
            this.lbRepositoryFolder.Name = "lbRepositoryFolder";
            this.lbRepositoryFolder.Size = new System.Drawing.Size(135, 20);
            this.lbRepositoryFolder.TabIndex = 0;
            this.lbRepositoryFolder.Text = "Repositories folder";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(427, 712);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 43);
            this.btnOK.TabIndex = 98;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(536, 712);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 43);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmConfig
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1065, 765);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings - Digao Desk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfig_FormClosed);
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.pages.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.tabApplications.ResumeLayout(false);
            this.tabApplications.PerformLayout();
            this.tabRepos.ResumeLayout(false);
            this.tabRepos.PerformLayout();
            this.boxGitAuthor.ResumeLayout(false);
            this.boxGitAuthor.PerformLayout();
            this.boxGitCredentials.ResumeLayout(false);
            this.boxGitCredentials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckNotifyWhenAppStops;
        private System.Windows.Forms.TabPage tabRepos;
        private System.Windows.Forms.TextBox edReposDir;
        private System.Windows.Forms.Label lbRepositoryFolder;
        private System.Windows.Forms.Button btnSelReposDir;
        private System.Windows.Forms.TextBox edGitEmail;
        private System.Windows.Forms.Label lbAuthorEmail;
        private System.Windows.Forms.TextBox edGitName;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Button btnLogFont;
        private System.Windows.Forms.Label lbTextColor;
        private System.Windows.Forms.CheckBox ckLogWordWrap;
        private System.Windows.Forms.Label lbBackgroundColor;
        private System.Windows.Forms.CheckBox ckLogShowTs;
        private System.Windows.Forms.Button btnColorConsoleFore;
        private System.Windows.Forms.Button btnColorConsoleBack;
        private System.Windows.Forms.Label lbFont;
        private System.Windows.Forms.GroupBox boxGitCredentials;
        private System.Windows.Forms.TextBox edGitCredPassword;
        private System.Windows.Forms.Label lbCredPassword;
        private System.Windows.Forms.TextBox edGitCredUsername;
        private System.Windows.Forms.Label lbCredUsername;
        private System.Windows.Forms.CheckBox CkDontNotifyWhenAppsActive;
        private System.Windows.Forms.TextBox edShellProgram;
        private System.Windows.Forms.Label lbShellProgram;
        private System.Windows.Forms.Button btnSelShellProgram;
        private System.Windows.Forms.TextBox edGitNewBranchPrefixList;
        private System.Windows.Forms.Label lbNewBranchPrefix;
        private System.Windows.Forms.GroupBox boxGitAuthor;
        private System.Windows.Forms.Label lbNewBranchPrefixInfo;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnColorGridHeadBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnColorSplitterBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnColorStatusBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnColorGridSelBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnColorGridDataFore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnColorGridHeadFore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColorGridSelFore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColorGridBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColorToolbarFore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColorToolbarBack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnColorStatusFore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnColorGridLines;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnColorGridDataBack;
    }
}