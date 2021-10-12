
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
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.ckNotifyWhenAppStops = new System.Windows.Forms.CheckBox();
            this.boxLog = new System.Windows.Forms.GroupBox();
            this.btnLogFont = new System.Windows.Forms.Button();
            this.ckLogAutoScroll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckLogWordWrap = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckLogShowTs = new System.Windows.Forms.CheckBox();
            this.btnLogTextColor = new System.Windows.Forms.Button();
            this.btnLogBgColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selColor = new System.Windows.Forms.ColorDialog();
            this.selFont = new System.Windows.Forms.FontDialog();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabRepos = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.edReposDir = new System.Windows.Forms.TextBox();
            this.btnSelReposDir = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pages.SuspendLayout();
            this.tabApplications.SuspendLayout();
            this.boxLog.SuspendLayout();
            this.tabRepos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.tabApplications);
            this.pages.Controls.Add(this.tabRepos);
            this.pages.Location = new System.Drawing.Point(8, 8);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(616, 408);
            this.pages.TabIndex = 0;
            // 
            // tabApplications
            // 
            this.tabApplications.Controls.Add(this.ckNotifyWhenAppStops);
            this.tabApplications.Controls.Add(this.boxLog);
            this.tabApplications.Location = new System.Drawing.Point(4, 24);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(608, 380);
            this.tabApplications.TabIndex = 0;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // ckNotifyWhenAppStops
            // 
            this.ckNotifyWhenAppStops.AutoSize = true;
            this.ckNotifyWhenAppStops.Location = new System.Drawing.Point(16, 312);
            this.ckNotifyWhenAppStops.Name = "ckNotifyWhenAppStops";
            this.ckNotifyWhenAppStops.Size = new System.Drawing.Size(184, 19);
            this.ckNotifyWhenAppStops.TabIndex = 10;
            this.ckNotifyWhenAppStops.Text = "Notify when application stops";
            this.ckNotifyWhenAppStops.UseVisualStyleBackColor = true;
            // 
            // boxLog
            // 
            this.boxLog.Controls.Add(this.btnLogFont);
            this.boxLog.Controls.Add(this.ckLogAutoScroll);
            this.boxLog.Controls.Add(this.label1);
            this.boxLog.Controls.Add(this.ckLogWordWrap);
            this.boxLog.Controls.Add(this.label2);
            this.boxLog.Controls.Add(this.ckLogShowTs);
            this.boxLog.Controls.Add(this.btnLogTextColor);
            this.boxLog.Controls.Add(this.btnLogBgColor);
            this.boxLog.Controls.Add(this.label3);
            this.boxLog.Location = new System.Drawing.Point(16, 16);
            this.boxLog.Name = "boxLog";
            this.boxLog.Size = new System.Drawing.Size(336, 280);
            this.boxLog.TabIndex = 9;
            this.boxLog.TabStop = false;
            this.boxLog.Text = "Log";
            // 
            // btnLogFont
            // 
            this.btnLogFont.Location = new System.Drawing.Point(16, 40);
            this.btnLogFont.Name = "btnLogFont";
            this.btnLogFont.Size = new System.Drawing.Size(304, 32);
            this.btnLogFont.TabIndex = 0;
            this.btnLogFont.UseVisualStyleBackColor = true;
            this.btnLogFont.Click += new System.EventHandler(this.btnLogFont_Click);
            // 
            // ckLogAutoScroll
            // 
            this.ckLogAutoScroll.AutoSize = true;
            this.ckLogAutoScroll.Location = new System.Drawing.Point(16, 248);
            this.ckLogAutoScroll.Name = "ckLogAutoScroll";
            this.ckLogAutoScroll.Size = new System.Drawing.Size(83, 19);
            this.ckLogAutoScroll.TabIndex = 5;
            this.ckLogAutoScroll.Text = "Auto scroll";
            this.ckLogAutoScroll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text color";
            // 
            // ckLogWordWrap
            // 
            this.ckLogWordWrap.AutoSize = true;
            this.ckLogWordWrap.Location = new System.Drawing.Point(16, 224);
            this.ckLogWordWrap.Name = "ckLogWordWrap";
            this.ckLogWordWrap.Size = new System.Drawing.Size(84, 19);
            this.ckLogWordWrap.TabIndex = 4;
            this.ckLogWordWrap.Text = "Word wrap";
            this.ckLogWordWrap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Background color";
            // 
            // ckLogShowTs
            // 
            this.ckLogShowTs.AutoSize = true;
            this.ckLogShowTs.Location = new System.Drawing.Point(16, 200);
            this.ckLogShowTs.Name = "ckLogShowTs";
            this.ckLogShowTs.Size = new System.Drawing.Size(188, 19);
            this.ckLogShowTs.TabIndex = 3;
            this.ckLogShowTs.Text = "Show date/time in each record";
            this.ckLogShowTs.UseVisualStyleBackColor = true;
            // 
            // btnLogTextColor
            // 
            this.btnLogTextColor.Location = new System.Drawing.Point(16, 96);
            this.btnLogTextColor.Name = "btnLogTextColor";
            this.btnLogTextColor.Size = new System.Drawing.Size(304, 32);
            this.btnLogTextColor.TabIndex = 1;
            this.btnLogTextColor.UseVisualStyleBackColor = false;
            this.btnLogTextColor.Click += new System.EventHandler(this.btnLogTextColor_Click);
            // 
            // btnLogBgColor
            // 
            this.btnLogBgColor.Location = new System.Drawing.Point(16, 152);
            this.btnLogBgColor.Name = "btnLogBgColor";
            this.btnLogBgColor.Size = new System.Drawing.Size(304, 32);
            this.btnLogBgColor.TabIndex = 2;
            this.btnLogBgColor.UseVisualStyleBackColor = true;
            this.btnLogBgColor.Click += new System.EventHandler(this.btnLogBgColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Font";
            // 
            // selFont
            // 
            this.selFont.ShowEffects = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 32);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabRepos
            // 
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Repositories folder";
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
            this.tabApplications.ResumeLayout(false);
            this.tabApplications.PerformLayout();
            this.boxLog.ResumeLayout(false);
            this.boxLog.PerformLayout();
            this.tabRepos.ResumeLayout(false);
            this.tabRepos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.Button btnLogBgColor;
        private System.Windows.Forms.Button btnLogTextColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog selColor;
        private System.Windows.Forms.Button btnLogFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog selFont;
        private System.Windows.Forms.CheckBox ckLogShowTs;
        private System.Windows.Forms.CheckBox ckLogAutoScroll;
        private System.Windows.Forms.CheckBox ckLogWordWrap;
        private System.Windows.Forms.GroupBox boxLog;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckNotifyWhenAppStops;
        private System.Windows.Forms.TabPage tabRepos;
        private System.Windows.Forms.TextBox edReposDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelReposDir;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
    }
}