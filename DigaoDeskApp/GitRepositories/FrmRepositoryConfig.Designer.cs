
namespace DigaoDeskApp
{
    partial class FrmRepositoryConfig
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
            lbMasterBranch=new System.Windows.Forms.Label();
            edMasterBranch=new System.Windows.Forms.TextBox();
            btnOK=new System.Windows.Forms.Button();
            btnCancel=new System.Windows.Forms.Button();
            ckFetch=new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // lbMasterBranch
            // 
            lbMasterBranch.AutoSize=true;
            lbMasterBranch.Location=new System.Drawing.Point(14, 16);
            lbMasterBranch.Name="lbMasterBranch";
            lbMasterBranch.Size=new System.Drawing.Size(103, 20);
            lbMasterBranch.TabIndex=0;
            lbMasterBranch.Text="Master branch";
            // 
            // edMasterBranch
            // 
            edMasterBranch.Location=new System.Drawing.Point(16, 40);
            edMasterBranch.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            edMasterBranch.Name="edMasterBranch";
            edMasterBranch.Size=new System.Drawing.Size(520, 27);
            edMasterBranch.TabIndex=1;
            // 
            // btnOK
            // 
            btnOK.Location=new System.Drawing.Point(161, 136);
            btnOK.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnOK.Name="btnOK";
            btnOK.Size=new System.Drawing.Size(110, 43);
            btnOK.TabIndex=2;
            btnOK.Text="OK";
            btnOK.UseVisualStyleBackColor=true;
            btnOK.Click+=btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location=new System.Drawing.Point(280, 136);
            btnCancel.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name="btnCancel";
            btnCancel.Size=new System.Drawing.Size(110, 43);
            btnCancel.TabIndex=3;
            btnCancel.Text="Cancel";
            btnCancel.UseVisualStyleBackColor=true;
            // 
            // ckFetch
            // 
            ckFetch.AutoSize=true;
            ckFetch.Location=new System.Drawing.Point(16, 88);
            ckFetch.Name="ckFetch";
            ckFetch.Size=new System.Drawing.Size(156, 24);
            ckFetch.TabIndex=5;
            ckFetch.TabStop=false;
            ckFetch.Text="Include in Fetch All";
            ckFetch.UseVisualStyleBackColor=true;
            // 
            // FrmRepositoryConfig
            // 
            AcceptButton=btnOK;
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            CancelButton=btnCancel;
            ClientSize=new System.Drawing.Size(553, 194);
            Controls.Add(ckFetch);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(edMasterBranch);
            Controls.Add(lbMasterBranch);
            FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox=false;
            MinimizeBox=false;
            Name="FrmRepositoryConfig";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="Repository Settings";
            Load+=FrmRepositoryConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMasterBranch;
        private System.Windows.Forms.TextBox edMasterBranch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckFetch;
    }
}