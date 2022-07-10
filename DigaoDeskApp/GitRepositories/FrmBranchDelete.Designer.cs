
namespace DigaoDeskApp
{
    partial class FrmBranchDelete
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
            this.lstBranches = new System.Windows.Forms.ComboBox();
            this.lbBranch = new System.Windows.Forms.Label();
            this.ckLocal = new System.Windows.Forms.CheckBox();
            this.ckRemote = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbConfirmation = new System.Windows.Forms.Label();
            this.edConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBranches
            // 
            this.lstBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lstBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lstBranches.FormattingEnabled = true;
            this.lstBranches.Location = new System.Drawing.Point(18, 43);
            this.lstBranches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBranches.Name = "lstBranches";
            this.lstBranches.Size = new System.Drawing.Size(612, 28);
            this.lstBranches.TabIndex = 0;
            this.lstBranches.TextChanged += new System.EventHandler(this.lstBranches_TextChanged);
            // 
            // lbBranch
            // 
            this.lbBranch.AutoSize = true;
            this.lbBranch.Location = new System.Drawing.Point(16, 21);
            this.lbBranch.Name = "lbBranch";
            this.lbBranch.Size = new System.Drawing.Size(54, 20);
            this.lbBranch.TabIndex = 1;
            this.lbBranch.Text = "Branch";
            // 
            // ckLocal
            // 
            this.ckLocal.AutoSize = true;
            this.ckLocal.Location = new System.Drawing.Point(18, 96);
            this.ckLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckLocal.Name = "ckLocal";
            this.ckLocal.Size = new System.Drawing.Size(114, 24);
            this.ckLocal.TabIndex = 2;
            this.ckLocal.Text = "Delete Local";
            this.ckLocal.UseVisualStyleBackColor = true;
            // 
            // ckRemote
            // 
            this.ckRemote.AutoSize = true;
            this.ckRemote.Location = new System.Drawing.Point(18, 128);
            this.ckRemote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckRemote.Name = "ckRemote";
            this.ckRemote.Size = new System.Drawing.Size(131, 24);
            this.ckRemote.TabIndex = 3;
            this.ckRemote.Text = "Delete Remote";
            this.ckRemote.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(219, 267);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 32);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(329, 267);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbConfirmation
            // 
            this.lbConfirmation.AutoSize = true;
            this.lbConfirmation.Location = new System.Drawing.Point(16, 181);
            this.lbConfirmation.Name = "lbConfirmation";
            this.lbConfirmation.Size = new System.Drawing.Size(259, 20);
            this.lbConfirmation.TabIndex = 6;
            this.lbConfirmation.Text = "Type \"CONFIRM\" to enable OK button";
            // 
            // edConfirm
            // 
            this.edConfirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edConfirm.Location = new System.Drawing.Point(18, 203);
            this.edConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edConfirm.Name = "edConfirm";
            this.edConfirm.Size = new System.Drawing.Size(612, 27);
            this.edConfirm.TabIndex = 7;
            this.edConfirm.TextChanged += new System.EventHandler(this.edConfirm_TextChanged);
            // 
            // FrmBranchDelete
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(650, 325);
            this.Controls.Add(this.edConfirm);
            this.Controls.Add(this.lbConfirmation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ckRemote);
            this.Controls.Add(this.ckLocal);
            this.Controls.Add(this.lbBranch);
            this.Controls.Add(this.lstBranches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBranchDelete";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Branch";
            this.Load += new System.EventHandler(this.FrmBranchDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstBranches;
        private System.Windows.Forms.Label lbBranch;
        private System.Windows.Forms.CheckBox ckLocal;
        private System.Windows.Forms.CheckBox ckRemote;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbConfirmation;
        private System.Windows.Forms.TextBox edConfirm;
    }
}