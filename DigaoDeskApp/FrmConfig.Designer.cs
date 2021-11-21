
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
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.btnLogFont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ckLogWordWrap = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckLogShowTs = new System.Windows.Forms.CheckBox();
            this.btnLogTextColor = new System.Windows.Forms.Button();
            this.btnLogBgColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.CkDontNotifyWhenAppsActive = new System.Windows.Forms.CheckBox();
            this.ckNotifyWhenAppStops = new System.Windows.Forms.CheckBox();
            this.tabRepos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edGitCredPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edGitCredUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edGitEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edGitName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelReposDir = new System.Windows.Forms.Button();
            this.edReposDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.edShellProgram = new System.Windows.Forms.TextBox();
            this.btnSelShellProgramDir = new System.Windows.Forms.Button();
            this.pages.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.tabApplications.SuspendLayout();
            this.tabRepos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.tabLogs);
            this.pages.Controls.Add(this.tabApplications);
            this.pages.Controls.Add(this.tabRepos);
            this.pages.Location = new System.Drawing.Point(8, 8);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(616, 408);
            this.pages.TabIndex = 0;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.btnLogFont);
            this.tabLogs.Controls.Add(this.label1);
            this.tabLogs.Controls.Add(this.ckLogWordWrap);
            this.tabLogs.Controls.Add(this.label2);
            this.tabLogs.Controls.Add(this.ckLogShowTs);
            this.tabLogs.Controls.Add(this.btnLogTextColor);
            this.tabLogs.Controls.Add(this.btnLogBgColor);
            this.tabLogs.Controls.Add(this.label3);
            this.tabLogs.Location = new System.Drawing.Point(4, 24);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(608, 380);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "Log";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // btnLogFont
            // 
            this.btnLogFont.Location = new System.Drawing.Point(16, 32);
            this.btnLogFont.Name = "btnLogFont";
            this.btnLogFont.Size = new System.Drawing.Size(304, 32);
            this.btnLogFont.TabIndex = 6;
            this.btnLogFont.UseVisualStyleBackColor = true;
            this.btnLogFont.Click += new System.EventHandler(this.btnLogFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text color";
            // 
            // ckLogWordWrap
            // 
            this.ckLogWordWrap.AutoSize = true;
            this.ckLogWordWrap.Location = new System.Drawing.Point(16, 216);
            this.ckLogWordWrap.Name = "ckLogWordWrap";
            this.ckLogWordWrap.Size = new System.Drawing.Size(84, 19);
            this.ckLogWordWrap.TabIndex = 12;
            this.ckLogWordWrap.Text = "Word wrap";
            this.ckLogWordWrap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Background color";
            // 
            // ckLogShowTs
            // 
            this.ckLogShowTs.AutoSize = true;
            this.ckLogShowTs.Location = new System.Drawing.Point(16, 192);
            this.ckLogShowTs.Name = "ckLogShowTs";
            this.ckLogShowTs.Size = new System.Drawing.Size(188, 19);
            this.ckLogShowTs.TabIndex = 11;
            this.ckLogShowTs.Text = "Show date/time in each record";
            this.ckLogShowTs.UseVisualStyleBackColor = true;
            // 
            // btnLogTextColor
            // 
            this.btnLogTextColor.Location = new System.Drawing.Point(16, 88);
            this.btnLogTextColor.Name = "btnLogTextColor";
            this.btnLogTextColor.Size = new System.Drawing.Size(304, 32);
            this.btnLogTextColor.TabIndex = 9;
            this.btnLogTextColor.UseVisualStyleBackColor = false;
            this.btnLogTextColor.Click += new System.EventHandler(this.btnLogTextColor_Click);
            // 
            // btnLogBgColor
            // 
            this.btnLogBgColor.Location = new System.Drawing.Point(16, 144);
            this.btnLogBgColor.Name = "btnLogBgColor";
            this.btnLogBgColor.Size = new System.Drawing.Size(304, 32);
            this.btnLogBgColor.TabIndex = 10;
            this.btnLogBgColor.UseVisualStyleBackColor = true;
            this.btnLogBgColor.Click += new System.EventHandler(this.btnLogBgColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Font";
            // 
            // tabApplications
            // 
            this.tabApplications.Controls.Add(this.CkDontNotifyWhenAppsActive);
            this.tabApplications.Controls.Add(this.ckNotifyWhenAppStops);
            this.tabApplications.Location = new System.Drawing.Point(4, 24);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(608, 380);
            this.tabApplications.TabIndex = 0;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // CkDontNotifyWhenAppsActive
            // 
            this.CkDontNotifyWhenAppsActive.AutoSize = true;
            this.CkDontNotifyWhenAppsActive.Location = new System.Drawing.Point(40, 40);
            this.CkDontNotifyWhenAppsActive.Name = "CkDontNotifyWhenAppsActive";
            this.CkDontNotifyWhenAppsActive.Size = new System.Drawing.Size(219, 19);
            this.CkDontNotifyWhenAppsActive.TabIndex = 11;
            this.CkDontNotifyWhenAppsActive.Text = "Do not notify when apps form active";
            this.CkDontNotifyWhenAppsActive.UseVisualStyleBackColor = true;
            // 
            // ckNotifyWhenAppStops
            // 
            this.ckNotifyWhenAppStops.AutoSize = true;
            this.ckNotifyWhenAppStops.Location = new System.Drawing.Point(16, 16);
            this.ckNotifyWhenAppStops.Name = "ckNotifyWhenAppStops";
            this.ckNotifyWhenAppStops.Size = new System.Drawing.Size(184, 19);
            this.ckNotifyWhenAppStops.TabIndex = 10;
            this.ckNotifyWhenAppStops.Text = "Notify when application stops";
            this.ckNotifyWhenAppStops.UseVisualStyleBackColor = true;
            // 
            // tabRepos
            // 
            this.tabRepos.Controls.Add(this.btnSelShellProgramDir);
            this.tabRepos.Controls.Add(this.edShellProgram);
            this.tabRepos.Controls.Add(this.label9);
            this.tabRepos.Controls.Add(this.groupBox1);
            this.tabRepos.Controls.Add(this.edGitEmail);
            this.tabRepos.Controls.Add(this.label6);
            this.tabRepos.Controls.Add(this.edGitName);
            this.tabRepos.Controls.Add(this.label5);
            this.tabRepos.Controls.Add(this.btnSelReposDir);
            this.tabRepos.Controls.Add(this.edReposDir);
            this.tabRepos.Controls.Add(this.label4);
            this.tabRepos.Location = new System.Drawing.Point(4, 24);
            this.tabRepos.Name = "tabRepos";
            this.tabRepos.Padding = new System.Windows.Forms.Padding(3);
            this.tabRepos.Size = new System.Drawing.Size(608, 380);
            this.tabRepos.TabIndex = 1;
            this.tabRepos.Text = "Git Repositories";
            this.tabRepos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edGitCredPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edGitCredUsername);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(16, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // edGitCredPassword
            // 
            this.edGitCredPassword.Location = new System.Drawing.Point(16, 88);
            this.edGitCredPassword.Name = "edGitCredPassword";
            this.edGitCredPassword.PasswordChar = '●';
            this.edGitCredPassword.Size = new System.Drawing.Size(336, 23);
            this.edGitCredPassword.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password";
            // 
            // edGitCredUsername
            // 
            this.edGitCredUsername.Location = new System.Drawing.Point(16, 40);
            this.edGitCredUsername.Name = "edGitCredUsername";
            this.edGitCredUsername.Size = new System.Drawing.Size(336, 23);
            this.edGitCredUsername.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Username";
            // 
            // edGitEmail
            // 
            this.edGitEmail.Location = new System.Drawing.Point(16, 136);
            this.edGitEmail.Name = "edGitEmail";
            this.edGitEmail.Size = new System.Drawing.Size(336, 23);
            this.edGitEmail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // edGitName
            // 
            this.edGitName.Location = new System.Drawing.Point(16, 88);
            this.edGitName.Name = "edGitName";
            this.edGitName.Size = new System.Drawing.Size(336, 23);
            this.edGitName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // btnSelReposDir
            // 
            this.btnSelReposDir.Location = new System.Drawing.Point(568, 31);
            this.btnSelReposDir.Name = "btnSelReposDir";
            this.btnSelReposDir.Size = new System.Drawing.Size(24, 25);
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
            this.edReposDir.Name = "edReposDir";
            this.edReposDir.Size = new System.Drawing.Size(552, 23);
            this.edReposDir.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Repositories folder";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 32);
            this.btnOK.TabIndex = 98;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Shell program";
            // 
            // edShellProgram
            // 
            this.edShellProgram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edShellProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.edShellProgram.Location = new System.Drawing.Point(16, 336);
            this.edShellProgram.Name = "edShellProgram";
            this.edShellProgram.Size = new System.Drawing.Size(552, 23);
            this.edShellProgram.TabIndex = 9;
            // 
            // btnSelShellProgramDir
            // 
            this.btnSelShellProgramDir.Location = new System.Drawing.Point(568, 335);
            this.btnSelShellProgramDir.Name = "btnSelShellProgramDir";
            this.btnSelShellProgramDir.Size = new System.Drawing.Size(24, 25);
            this.btnSelShellProgramDir.TabIndex = 10;
            this.btnSelShellProgramDir.Text = "...";
            this.btnSelShellProgramDir.UseVisualStyleBackColor = true;
            this.btnSelShellProgramDir.Click += new System.EventHandler(this.btnSelShellProgramDir_Click);
            // 
            // FrmConfig
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(628, 466);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings - Digao Desk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfig_FormClosed);
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.pages.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.tabApplications.ResumeLayout(false);
            this.tabApplications.PerformLayout();
            this.tabRepos.ResumeLayout(false);
            this.tabRepos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelReposDir;
        private System.Windows.Forms.TextBox edGitEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edGitName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Button btnLogFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckLogWordWrap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckLogShowTs;
        private System.Windows.Forms.Button btnLogTextColor;
        private System.Windows.Forms.Button btnLogBgColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edGitCredPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edGitCredUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CkDontNotifyWhenAppsActive;
        private System.Windows.Forms.TextBox edShellProgram;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelShellProgramDir;
    }
}