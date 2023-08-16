namespace DigaoDeskApp
{
    partial class FrmConfigGitGroup
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
            boxAuthor=new System.Windows.Forms.GroupBox();
            edAuthorName=new System.Windows.Forms.TextBox();
            lbAuthorName=new System.Windows.Forms.Label();
            lbAuthorEmail=new System.Windows.Forms.Label();
            edAuthorEmail=new System.Windows.Forms.TextBox();
            boxCredentials=new System.Windows.Forms.GroupBox();
            edCredPassword=new System.Windows.Forms.TextBox();
            lbCredPassword=new System.Windows.Forms.Label();
            edCredUsername=new System.Windows.Forms.TextBox();
            lbCredUsername=new System.Windows.Forms.Label();
            btnSelPath=new System.Windows.Forms.Button();
            edPath=new System.Windows.Forms.TextBox();
            lbPath=new System.Windows.Forms.Label();
            lbIdent=new System.Windows.Forms.Label();
            edIdent=new System.Windows.Forms.TextBox();
            btnOK=new System.Windows.Forms.Button();
            btnCancel=new System.Windows.Forms.Button();
            boxAuthor.SuspendLayout();
            boxCredentials.SuspendLayout();
            SuspendLayout();
            // 
            // boxAuthor
            // 
            boxAuthor.Controls.Add(edAuthorName);
            boxAuthor.Controls.Add(lbAuthorName);
            boxAuthor.Controls.Add(lbAuthorEmail);
            boxAuthor.Controls.Add(edAuthorEmail);
            boxAuthor.Location=new System.Drawing.Point(16, 144);
            boxAuthor.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            boxAuthor.Name="boxAuthor";
            boxAuthor.Padding=new System.Windows.Forms.Padding(3, 4, 3, 4);
            boxAuthor.Size=new System.Drawing.Size(496, 171);
            boxAuthor.TabIndex=3;
            boxAuthor.TabStop=false;
            boxAuthor.Text="Author information";
            // 
            // edAuthorName
            // 
            edAuthorName.Location=new System.Drawing.Point(16, 56);
            edAuthorName.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edAuthorName.Name="edAuthorName";
            edAuthorName.Size=new System.Drawing.Size(464, 27);
            edAuthorName.TabIndex=0;
            // 
            // lbAuthorName
            // 
            lbAuthorName.AutoSize=true;
            lbAuthorName.Location=new System.Drawing.Point(14, 33);
            lbAuthorName.Name="lbAuthorName";
            lbAuthorName.Size=new System.Drawing.Size(49, 20);
            lbAuthorName.TabIndex=3;
            lbAuthorName.Text="Name";
            // 
            // lbAuthorEmail
            // 
            lbAuthorEmail.AutoSize=true;
            lbAuthorEmail.Location=new System.Drawing.Point(14, 97);
            lbAuthorEmail.Name="lbAuthorEmail";
            lbAuthorEmail.Size=new System.Drawing.Size(46, 20);
            lbAuthorEmail.TabIndex=5;
            lbAuthorEmail.Text="Email";
            // 
            // edAuthorEmail
            // 
            edAuthorEmail.Location=new System.Drawing.Point(16, 120);
            edAuthorEmail.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edAuthorEmail.Name="edAuthorEmail";
            edAuthorEmail.Size=new System.Drawing.Size(464, 27);
            edAuthorEmail.TabIndex=1;
            // 
            // boxCredentials
            // 
            boxCredentials.Controls.Add(edCredPassword);
            boxCredentials.Controls.Add(lbCredPassword);
            boxCredentials.Controls.Add(edCredUsername);
            boxCredentials.Controls.Add(lbCredUsername);
            boxCredentials.Location=new System.Drawing.Point(520, 144);
            boxCredentials.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            boxCredentials.Name="boxCredentials";
            boxCredentials.Padding=new System.Windows.Forms.Padding(3, 4, 3, 4);
            boxCredentials.Size=new System.Drawing.Size(496, 171);
            boxCredentials.TabIndex=4;
            boxCredentials.TabStop=false;
            boxCredentials.Text="Credentials";
            // 
            // edCredPassword
            // 
            edCredPassword.Location=new System.Drawing.Point(16, 120);
            edCredPassword.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edCredPassword.Name="edCredPassword";
            edCredPassword.PasswordChar='●';
            edCredPassword.Size=new System.Drawing.Size(464, 27);
            edCredPassword.TabIndex=1;
            // 
            // lbCredPassword
            // 
            lbCredPassword.AutoSize=true;
            lbCredPassword.Location=new System.Drawing.Point(14, 97);
            lbCredPassword.Name="lbCredPassword";
            lbCredPassword.Size=new System.Drawing.Size(70, 20);
            lbCredPassword.TabIndex=9;
            lbCredPassword.Text="Password";
            // 
            // edCredUsername
            // 
            edCredUsername.Location=new System.Drawing.Point(16, 56);
            edCredUsername.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edCredUsername.Name="edCredUsername";
            edCredUsername.Size=new System.Drawing.Size(464, 27);
            edCredUsername.TabIndex=0;
            // 
            // lbCredUsername
            // 
            lbCredUsername.AutoSize=true;
            lbCredUsername.Location=new System.Drawing.Point(14, 33);
            lbCredUsername.Name="lbCredUsername";
            lbCredUsername.Size=new System.Drawing.Size(75, 20);
            lbCredUsername.TabIndex=7;
            lbCredUsername.Text="Username";
            // 
            // btnSelPath
            // 
            btnSelPath.Location=new System.Drawing.Point(992, 96);
            btnSelPath.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSelPath.Name="btnSelPath";
            btnSelPath.Size=new System.Drawing.Size(27, 33);
            btnSelPath.TabIndex=2;
            btnSelPath.TabStop=false;
            btnSelPath.Text="...";
            btnSelPath.UseVisualStyleBackColor=true;
            btnSelPath.Click+=btnSelPath_Click;
            // 
            // edPath
            // 
            edPath.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            edPath.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            edPath.Location=new System.Drawing.Point(16, 96);
            edPath.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edPath.Name="edPath";
            edPath.Size=new System.Drawing.Size(976, 27);
            edPath.TabIndex=1;
            // 
            // lbPath
            // 
            lbPath.AutoSize=true;
            lbPath.Location=new System.Drawing.Point(14, 72);
            lbPath.Name="lbPath";
            lbPath.Size=new System.Drawing.Size(135, 20);
            lbPath.TabIndex=5;
            lbPath.Text="Repositories folder";
            // 
            // lbIdent
            // 
            lbIdent.AutoSize=true;
            lbIdent.Location=new System.Drawing.Point(14, 16);
            lbIdent.Name="lbIdent";
            lbIdent.Size=new System.Drawing.Size(96, 20);
            lbIdent.TabIndex=10;
            lbIdent.Text="Identifier Tag";
            // 
            // edIdent
            // 
            edIdent.Location=new System.Drawing.Point(16, 40);
            edIdent.Name="edIdent";
            edIdent.Size=new System.Drawing.Size(648, 27);
            edIdent.TabIndex=0;
            // 
            // btnOK
            // 
            btnOK.Location=new System.Drawing.Point(408, 336);
            btnOK.Name="btnOK";
            btnOK.Size=new System.Drawing.Size(104, 32);
            btnOK.TabIndex=11;
            btnOK.Text="OK";
            btnOK.UseVisualStyleBackColor=true;
            btnOK.Click+=btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location=new System.Drawing.Point(520, 336);
            btnCancel.Name="btnCancel";
            btnCancel.Size=new System.Drawing.Size(104, 32);
            btnCancel.TabIndex=12;
            btnCancel.Text="Cancel";
            btnCancel.UseVisualStyleBackColor=true;
            // 
            // FrmConfigGitGroup
            // 
            AcceptButton=btnOK;
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            CancelButton=btnCancel;
            ClientSize=new System.Drawing.Size(1033, 377);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(edIdent);
            Controls.Add(lbIdent);
            Controls.Add(boxAuthor);
            Controls.Add(boxCredentials);
            Controls.Add(btnSelPath);
            Controls.Add(edPath);
            Controls.Add(lbPath);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmConfigGitGroup";
            ShowInTaskbar=false;
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="FrmConfigGitGroup";
            Shown+=FrmConfigGitGroup_Shown;
            boxAuthor.ResumeLayout(false);
            boxAuthor.PerformLayout();
            boxCredentials.ResumeLayout(false);
            boxCredentials.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox boxAuthor;
        private System.Windows.Forms.TextBox edAuthorName;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.Label lbAuthorEmail;
        private System.Windows.Forms.TextBox edAuthorEmail;
        private System.Windows.Forms.GroupBox boxCredentials;
        private System.Windows.Forms.TextBox edCredPassword;
        private System.Windows.Forms.Label lbCredPassword;
        private System.Windows.Forms.TextBox edCredUsername;
        private System.Windows.Forms.Label lbCredUsername;
        private System.Windows.Forms.Button btnSelPath;
        private System.Windows.Forms.TextBox edPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbIdent;
        private System.Windows.Forms.TextBox edIdent;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}