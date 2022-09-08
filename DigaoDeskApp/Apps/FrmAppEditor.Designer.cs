
namespace DigaoDeskApp
{
    partial class FrmAppEditor
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
            this.lbName = new System.Windows.Forms.Label();
            this.edName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edCmd = new System.Windows.Forms.TextBox();
            this.lbCmd = new System.Windows.Forms.Label();
            this.edArgs = new System.Windows.Forms.TextBox();
            this.lbArgs = new System.Windows.Forms.Label();
            this.edDir = new System.Windows.Forms.TextBox();
            this.lbDir = new System.Windows.Forms.Label();
            this.btnSelCmd = new System.Windows.Forms.Button();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.edEnv = new System.Windows.Forms.TextBox();
            this.lbEnv = new System.Windows.Forms.Label();
            this.lbEnvInfo = new System.Windows.Forms.Label();
            this.lbHttpPort = new System.Windows.Forms.Label();
            this.edHttpPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.edHttpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(16, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(130, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Application Name";
            // 
            // edName
            // 
            this.edName.Location = new System.Drawing.Point(18, 43);
            this.edName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(622, 27);
            this.edName.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(274, 544);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 43);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(393, 544);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 43);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // edCmd
            // 
            this.edCmd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edCmd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.edCmd.Location = new System.Drawing.Point(18, 117);
            this.edCmd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edCmd.Name = "edCmd";
            this.edCmd.Size = new System.Drawing.Size(713, 27);
            this.edCmd.TabIndex = 2;
            // 
            // lbCmd
            // 
            this.lbCmd.AutoSize = true;
            this.lbCmd.ForeColor = System.Drawing.Color.Red;
            this.lbCmd.Location = new System.Drawing.Point(16, 96);
            this.lbCmd.Name = "lbCmd";
            this.lbCmd.Size = new System.Drawing.Size(106, 20);
            this.lbCmd.TabIndex = 4;
            this.lbCmd.Text = "Command line";
            // 
            // edArgs
            // 
            this.edArgs.Location = new System.Drawing.Point(18, 192);
            this.edArgs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edArgs.Name = "edArgs";
            this.edArgs.Size = new System.Drawing.Size(740, 27);
            this.edArgs.TabIndex = 4;
            // 
            // lbArgs
            // 
            this.lbArgs.AutoSize = true;
            this.lbArgs.Location = new System.Drawing.Point(16, 171);
            this.lbArgs.Name = "lbArgs";
            this.lbArgs.Size = new System.Drawing.Size(81, 20);
            this.lbArgs.TabIndex = 6;
            this.lbArgs.Text = "Arguments";
            // 
            // edDir
            // 
            this.edDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.edDir.Location = new System.Drawing.Point(18, 267);
            this.edDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(713, 27);
            this.edDir.TabIndex = 5;
            // 
            // lbDir
            // 
            this.lbDir.AutoSize = true;
            this.lbDir.Location = new System.Drawing.Point(16, 245);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(127, 20);
            this.lbDir.TabIndex = 8;
            this.lbDir.Text = "Working directory";
            // 
            // btnSelCmd
            // 
            this.btnSelCmd.Location = new System.Drawing.Point(731, 117);
            this.btnSelCmd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelCmd.Name = "btnSelCmd";
            this.btnSelCmd.Size = new System.Drawing.Size(27, 33);
            this.btnSelCmd.TabIndex = 3;
            this.btnSelCmd.TabStop = false;
            this.btnSelCmd.Text = "...";
            this.btnSelCmd.UseVisualStyleBackColor = true;
            this.btnSelCmd.Click += new System.EventHandler(this.btnSelCmd_Click);
            // 
            // btnSelDir
            // 
            this.btnSelDir.Location = new System.Drawing.Point(731, 267);
            this.btnSelDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(27, 33);
            this.btnSelDir.TabIndex = 6;
            this.btnSelDir.TabStop = false;
            this.btnSelDir.Text = "...";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // edEnv
            // 
            this.edEnv.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edEnv.Location = new System.Drawing.Point(18, 341);
            this.edEnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edEnv.Multiline = true;
            this.edEnv.Name = "edEnv";
            this.edEnv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edEnv.Size = new System.Drawing.Size(740, 180);
            this.edEnv.TabIndex = 7;
            // 
            // lbEnv
            // 
            this.lbEnv.AutoSize = true;
            this.lbEnv.Location = new System.Drawing.Point(16, 320);
            this.lbEnv.Name = "lbEnv";
            this.lbEnv.Size = new System.Drawing.Size(155, 20);
            this.lbEnv.TabIndex = 14;
            this.lbEnv.Text = "Environment variables";
            // 
            // lbEnvInfo
            // 
            this.lbEnvInfo.AutoSize = true;
            this.lbEnvInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbEnvInfo.Location = new System.Drawing.Point(18, 533);
            this.lbEnvInfo.Name = "lbEnvInfo";
            this.lbEnvInfo.Size = new System.Drawing.Size(165, 40);
            this.lbEnvInfo.TabIndex = 15;
            this.lbEnvInfo.Text = "Format: NAME=VALUE\r\nNew line: CTRL+ENTER ";
            // 
            // lbHttpPort
            // 
            this.lbHttpPort.AutoSize = true;
            this.lbHttpPort.Location = new System.Drawing.Point(654, 21);
            this.lbHttpPort.Name = "lbHttpPort";
            this.lbHttpPort.Size = new System.Drawing.Size(69, 20);
            this.lbHttpPort.TabIndex = 16;
            this.lbHttpPort.Text = "Http Port";
            // 
            // edHttpPort
            // 
            this.edHttpPort.Location = new System.Drawing.Point(656, 43);
            this.edHttpPort.Name = "edHttpPort";
            this.edHttpPort.Size = new System.Drawing.Size(104, 27);
            this.edHttpPort.TabIndex = 1;
            this.edHttpPort.TabStop = false;
            // 
            // FrmAppEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(778, 604);
            this.Controls.Add(this.edHttpPort);
            this.Controls.Add(this.lbHttpPort);
            this.Controls.Add(this.lbEnvInfo);
            this.Controls.Add(this.lbEnv);
            this.Controls.Add(this.edEnv);
            this.Controls.Add(this.btnSelDir);
            this.Controls.Add(this.btnSelCmd);
            this.Controls.Add(this.edDir);
            this.Controls.Add(this.lbDir);
            this.Controls.Add(this.edArgs);
            this.Controls.Add(this.lbArgs);
            this.Controls.Add(this.edCmd);
            this.Controls.Add(this.lbCmd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAppEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Application";
            this.Load += new System.EventHandler(this.FrmAppEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edHttpPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox edCmd;
        private System.Windows.Forms.Label lbCmd;
        private System.Windows.Forms.TextBox edArgs;
        private System.Windows.Forms.Label lbArgs;
        private System.Windows.Forms.TextBox edDir;
        private System.Windows.Forms.Label lbDir;
        private System.Windows.Forms.Button btnSelCmd;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.TextBox edEnv;
        private System.Windows.Forms.Label lbEnv;
        private System.Windows.Forms.Label lbEnvInfo;
        private System.Windows.Forms.Label lbHttpPort;
        private System.Windows.Forms.NumericUpDown edHttpPort;
    }
}