
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
            this.label1 = new System.Windows.Forms.Label();
            this.edName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edCmd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edArgs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelCmd = new System.Windows.Forms.Button();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.dlgFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.edEnv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Name";
            // 
            // edName
            // 
            this.edName.Location = new System.Drawing.Point(16, 32);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(648, 23);
            this.edName.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(240, 408);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 32);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(344, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // edCmd
            // 
            this.edCmd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edCmd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.edCmd.Location = new System.Drawing.Point(16, 88);
            this.edCmd.Name = "edCmd";
            this.edCmd.Size = new System.Drawing.Size(624, 23);
            this.edCmd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command line";
            // 
            // edArgs
            // 
            this.edArgs.Location = new System.Drawing.Point(16, 144);
            this.edArgs.Name = "edArgs";
            this.edArgs.Size = new System.Drawing.Size(648, 23);
            this.edArgs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arguments";
            // 
            // edDir
            // 
            this.edDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.edDir.Location = new System.Drawing.Point(16, 200);
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(624, 23);
            this.edDir.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Working directory";
            // 
            // btnSelCmd
            // 
            this.btnSelCmd.Location = new System.Drawing.Point(640, 87);
            this.btnSelCmd.Name = "btnSelCmd";
            this.btnSelCmd.Size = new System.Drawing.Size(24, 25);
            this.btnSelCmd.TabIndex = 2;
            this.btnSelCmd.TabStop = false;
            this.btnSelCmd.Text = "...";
            this.btnSelCmd.UseVisualStyleBackColor = true;
            this.btnSelCmd.Click += new System.EventHandler(this.btnSelCmd_Click);
            // 
            // btnSelDir
            // 
            this.btnSelDir.Location = new System.Drawing.Point(640, 199);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(24, 25);
            this.btnSelDir.TabIndex = 5;
            this.btnSelDir.TabStop = false;
            this.btnSelDir.Text = "...";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // dlgFile
            // 
            this.dlgFile.FileName = "openFileDialog1";
            // 
            // edEnv
            // 
            this.edEnv.Location = new System.Drawing.Point(16, 256);
            this.edEnv.Multiline = true;
            this.edEnv.Name = "edEnv";
            this.edEnv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edEnv.Size = new System.Drawing.Size(648, 136);
            this.edEnv.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Environment variables";
            // 
            // FrmAppEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(681, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edEnv);
            this.Controls.Add(this.btnSelDir);
            this.Controls.Add(this.btnSelCmd);
            this.Controls.Add(this.edDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edArgs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edCmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAppEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Application";
            this.Load += new System.EventHandler(this.FrmAppEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox edCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edArgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelCmd;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.OpenFileDialog dlgFile;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.TextBox edEnv;
        private System.Windows.Forms.Label label5;
    }
}