
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppEditor));
            lbName=new System.Windows.Forms.Label();
            edName=new System.Windows.Forms.TextBox();
            btnOK=new System.Windows.Forms.Button();
            btnCancel=new System.Windows.Forms.Button();
            edCmd=new System.Windows.Forms.TextBox();
            lbCmd=new System.Windows.Forms.Label();
            edArgs=new System.Windows.Forms.TextBox();
            lbArgs=new System.Windows.Forms.Label();
            edDir=new System.Windows.Forms.TextBox();
            lbDir=new System.Windows.Forms.Label();
            btnSelCmd=new System.Windows.Forms.Button();
            btnSelDir=new System.Windows.Forms.Button();
            edEnv=new System.Windows.Forms.TextBox();
            lbEnv=new System.Windows.Forms.Label();
            lbEnvInfo=new System.Windows.Forms.Label();
            lbTcpPort=new System.Windows.Forms.Label();
            edTcpPort=new System.Windows.Forms.NumericUpDown();
            btnHelp=new System.Windows.Forms.Button();
            pages=new System.Windows.Forms.TabControl();
            tabGeneral=new System.Windows.Forms.TabPage();
            tabMore=new System.Windows.Forms.TabPage();
            edRestartWait=new System.Windows.Forms.NumericUpDown();
            lbRestartWait=new System.Windows.Forms.Label();
            ckAutoRestart=new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)edTcpPort).BeginInit();
            pages.SuspendLayout();
            tabGeneral.SuspendLayout();
            tabMore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edRestartWait).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize=true;
            lbName.ForeColor=System.Drawing.Color.Red;
            lbName.Location=new System.Drawing.Point(14, 16);
            lbName.Name="lbName";
            lbName.Size=new System.Drawing.Size(130, 20);
            lbName.TabIndex=0;
            lbName.Text="Application Name";
            // 
            // edName
            // 
            edName.Location=new System.Drawing.Point(16, 40);
            edName.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edName.Name="edName";
            edName.Size=new System.Drawing.Size(648, 27);
            edName.TabIndex=0;
            // 
            // btnOK
            // 
            btnOK.Location=new System.Drawing.Point(296, 568);
            btnOK.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnOK.Name="btnOK";
            btnOK.Size=new System.Drawing.Size(104, 40);
            btnOK.TabIndex=11;
            btnOK.Text="OK";
            btnOK.UseVisualStyleBackColor=true;
            btnOK.Click+=btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location=new System.Drawing.Point(408, 568);
            btnCancel.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name="btnCancel";
            btnCancel.Size=new System.Drawing.Size(104, 40);
            btnCancel.TabIndex=12;
            btnCancel.Text="Cancel";
            btnCancel.UseVisualStyleBackColor=true;
            // 
            // edCmd
            // 
            edCmd.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            edCmd.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.FileSystem;
            edCmd.Location=new System.Drawing.Point(16, 104);
            edCmd.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edCmd.Name="edCmd";
            edCmd.Size=new System.Drawing.Size(720, 27);
            edCmd.TabIndex=2;
            // 
            // lbCmd
            // 
            lbCmd.AutoSize=true;
            lbCmd.ForeColor=System.Drawing.Color.Red;
            lbCmd.Location=new System.Drawing.Point(14, 80);
            lbCmd.Name="lbCmd";
            lbCmd.Size=new System.Drawing.Size(106, 20);
            lbCmd.TabIndex=4;
            lbCmd.Text="Command line";
            // 
            // edArgs
            // 
            edArgs.Location=new System.Drawing.Point(16, 168);
            edArgs.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edArgs.Name="edArgs";
            edArgs.Size=new System.Drawing.Size(752, 27);
            edArgs.TabIndex=4;
            // 
            // lbArgs
            // 
            lbArgs.AutoSize=true;
            lbArgs.Location=new System.Drawing.Point(14, 144);
            lbArgs.Name="lbArgs";
            lbArgs.Size=new System.Drawing.Size(81, 20);
            lbArgs.TabIndex=6;
            lbArgs.Text="Arguments";
            // 
            // edDir
            // 
            edDir.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            edDir.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            edDir.Location=new System.Drawing.Point(16, 232);
            edDir.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edDir.Name="edDir";
            edDir.Size=new System.Drawing.Size(720, 27);
            edDir.TabIndex=5;
            // 
            // lbDir
            // 
            lbDir.AutoSize=true;
            lbDir.Location=new System.Drawing.Point(14, 208);
            lbDir.Name="lbDir";
            lbDir.Size=new System.Drawing.Size(127, 20);
            lbDir.TabIndex=8;
            lbDir.Text="Working directory";
            // 
            // btnSelCmd
            // 
            btnSelCmd.Location=new System.Drawing.Point(736, 104);
            btnSelCmd.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSelCmd.Name="btnSelCmd";
            btnSelCmd.Size=new System.Drawing.Size(32, 33);
            btnSelCmd.TabIndex=3;
            btnSelCmd.TabStop=false;
            btnSelCmd.Text="...";
            btnSelCmd.UseVisualStyleBackColor=true;
            btnSelCmd.Click+=btnSelCmd_Click;
            // 
            // btnSelDir
            // 
            btnSelDir.Location=new System.Drawing.Point(736, 232);
            btnSelDir.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSelDir.Name="btnSelDir";
            btnSelDir.Size=new System.Drawing.Size(32, 34);
            btnSelDir.TabIndex=6;
            btnSelDir.TabStop=false;
            btnSelDir.Text="...";
            btnSelDir.UseVisualStyleBackColor=true;
            btnSelDir.Click+=btnSelDir_Click;
            // 
            // edEnv
            // 
            edEnv.Font=new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            edEnv.Location=new System.Drawing.Point(16, 296);
            edEnv.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edEnv.Multiline=true;
            edEnv.Name="edEnv";
            edEnv.ScrollBars=System.Windows.Forms.ScrollBars.Vertical;
            edEnv.Size=new System.Drawing.Size(752, 168);
            edEnv.TabIndex=7;
            // 
            // lbEnv
            // 
            lbEnv.AutoSize=true;
            lbEnv.Location=new System.Drawing.Point(14, 272);
            lbEnv.Name="lbEnv";
            lbEnv.Size=new System.Drawing.Size(155, 20);
            lbEnv.TabIndex=14;
            lbEnv.Text="Environment variables";
            // 
            // lbEnvInfo
            // 
            lbEnvInfo.AutoSize=true;
            lbEnvInfo.ForeColor=System.Drawing.Color.Gray;
            lbEnvInfo.Location=new System.Drawing.Point(14, 472);
            lbEnvInfo.Name="lbEnvInfo";
            lbEnvInfo.Size=new System.Drawing.Size(165, 40);
            lbEnvInfo.TabIndex=15;
            lbEnvInfo.Text="Format: NAME=VALUE\r\nNew line: CTRL+ENTER ";
            // 
            // lbTcpPort
            // 
            lbTcpPort.AutoSize=true;
            lbTcpPort.Location=new System.Drawing.Point(670, 16);
            lbTcpPort.Name="lbTcpPort";
            lbTcpPort.Size=new System.Drawing.Size(63, 20);
            lbTcpPort.TabIndex=16;
            lbTcpPort.Text="TCP Port";
            // 
            // edTcpPort
            // 
            edTcpPort.Location=new System.Drawing.Point(672, 40);
            edTcpPort.Name="edTcpPort";
            edTcpPort.Size=new System.Drawing.Size(96, 27);
            edTcpPort.TabIndex=1;
            edTcpPort.TabStop=false;
            // 
            // btnHelp
            // 
            btnHelp.Image=(System.Drawing.Image)resources.GetObject("btnHelp.Image");
            btnHelp.Location=new System.Drawing.Point(16, 568);
            btnHelp.Name="btnHelp";
            btnHelp.Size=new System.Drawing.Size(40, 32);
            btnHelp.TabIndex=20;
            btnHelp.TabStop=false;
            btnHelp.UseVisualStyleBackColor=true;
            btnHelp.Click+=btnHelp_Click;
            // 
            // pages
            // 
            pages.Controls.Add(tabGeneral);
            pages.Controls.Add(tabMore);
            pages.Location=new System.Drawing.Point(8, 8);
            pages.Name="pages";
            pages.SelectedIndex=0;
            pages.Size=new System.Drawing.Size(792, 552);
            pages.TabIndex=0;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(edEnv);
            tabGeneral.Controls.Add(lbName);
            tabGeneral.Controls.Add(lbEnvInfo);
            tabGeneral.Controls.Add(edTcpPort);
            tabGeneral.Controls.Add(edName);
            tabGeneral.Controls.Add(lbTcpPort);
            tabGeneral.Controls.Add(lbCmd);
            tabGeneral.Controls.Add(edCmd);
            tabGeneral.Controls.Add(lbEnv);
            tabGeneral.Controls.Add(lbArgs);
            tabGeneral.Controls.Add(edArgs);
            tabGeneral.Controls.Add(btnSelDir);
            tabGeneral.Controls.Add(lbDir);
            tabGeneral.Controls.Add(btnSelCmd);
            tabGeneral.Controls.Add(edDir);
            tabGeneral.Location=new System.Drawing.Point(4, 29);
            tabGeneral.Name="tabGeneral";
            tabGeneral.Padding=new System.Windows.Forms.Padding(3);
            tabGeneral.Size=new System.Drawing.Size(784, 519);
            tabGeneral.TabIndex=0;
            tabGeneral.Text="General";
            tabGeneral.UseVisualStyleBackColor=true;
            // 
            // tabMore
            // 
            tabMore.Controls.Add(edRestartWait);
            tabMore.Controls.Add(lbRestartWait);
            tabMore.Controls.Add(ckAutoRestart);
            tabMore.Location=new System.Drawing.Point(4, 29);
            tabMore.Name="tabMore";
            tabMore.Padding=new System.Windows.Forms.Padding(3);
            tabMore.Size=new System.Drawing.Size(784, 519);
            tabMore.TabIndex=1;
            tabMore.Text="More";
            tabMore.UseVisualStyleBackColor=true;
            // 
            // edRestartWait
            // 
            edRestartWait.Location=new System.Drawing.Point(40, 80);
            edRestartWait.Name="edRestartWait";
            edRestartWait.Size=new System.Drawing.Size(168, 27);
            edRestartWait.TabIndex=2;
            // 
            // lbRestartWait
            // 
            lbRestartWait.AutoSize=true;
            lbRestartWait.Location=new System.Drawing.Point(38, 56);
            lbRestartWait.Name="lbRestartWait";
            lbRestartWait.Size=new System.Drawing.Size(175, 20);
            lbRestartWait.TabIndex=1;
            lbRestartWait.Text="Wait for restart (seconds)";
            // 
            // ckAutoRestart
            // 
            ckAutoRestart.AutoSize=true;
            ckAutoRestart.Location=new System.Drawing.Point(16, 16);
            ckAutoRestart.Name="ckAutoRestart";
            ckAutoRestart.Size=new System.Drawing.Size(246, 24);
            ckAutoRestart.TabIndex=0;
            ckAutoRestart.Text="Restart the application if it stops";
            ckAutoRestart.UseVisualStyleBackColor=true;
            // 
            // FrmAppEditor
            // 
            AcceptButton=btnOK;
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            CancelButton=btnCancel;
            ClientSize=new System.Drawing.Size(806, 617);
            Controls.Add(pages);
            Controls.Add(btnHelp);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmAppEditor";
            ShowInTaskbar=false;
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="New Application";
            Load+=FrmAppEditor_Load;
            ((System.ComponentModel.ISupportInitialize)edTcpPort).EndInit();
            pages.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            tabGeneral.PerformLayout();
            tabMore.ResumeLayout(false);
            tabMore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edRestartWait).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label lbTcpPort;
        private System.Windows.Forms.NumericUpDown edTcpPort;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabMore;
        private System.Windows.Forms.CheckBox ckAutoRestart;
        private System.Windows.Forms.Label lbRestartWait;
        private System.Windows.Forms.NumericUpDown edRestartWait;
    }
}