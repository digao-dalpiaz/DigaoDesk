
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
            this.lbMasterBranch = new System.Windows.Forms.Label();
            this.edMasterBranch = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.Label();
            this.edOrder = new System.Windows.Forms.TextBox();
            this.ckFetch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbMasterBranch
            // 
            this.lbMasterBranch.AutoSize = true;
            this.lbMasterBranch.Location = new System.Drawing.Point(14, 80);
            this.lbMasterBranch.Name = "lbMasterBranch";
            this.lbMasterBranch.Size = new System.Drawing.Size(103, 20);
            this.lbMasterBranch.TabIndex = 0;
            this.lbMasterBranch.Text = "Master branch";
            // 
            // edMasterBranch
            // 
            this.edMasterBranch.Location = new System.Drawing.Point(16, 104);
            this.edMasterBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edMasterBranch.Name = "edMasterBranch";
            this.edMasterBranch.Size = new System.Drawing.Size(520, 27);
            this.edMasterBranch.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(161, 200);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 43);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 200);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 43);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Location = new System.Drawing.Point(14, 16);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(47, 20);
            this.lbOrder.TabIndex = 4;
            this.lbOrder.Text = "Order";
            // 
            // edOrder
            // 
            this.edOrder.Location = new System.Drawing.Point(16, 40);
            this.edOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edOrder.Name = "edOrder";
            this.edOrder.Size = new System.Drawing.Size(114, 27);
            this.edOrder.TabIndex = 0;
            // 
            // ckFetch
            // 
            this.ckFetch.AutoSize = true;
            this.ckFetch.Location = new System.Drawing.Point(16, 152);
            this.ckFetch.Name = "ckFetch";
            this.ckFetch.Size = new System.Drawing.Size(156, 24);
            this.ckFetch.TabIndex = 5;
            this.ckFetch.TabStop = false;
            this.ckFetch.Text = "Include in Fetch All";
            this.ckFetch.UseVisualStyleBackColor = true;
            // 
            // FrmRepositoryConfig
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(553, 256);
            this.Controls.Add(this.ckFetch);
            this.Controls.Add(this.edOrder);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.edMasterBranch);
            this.Controls.Add(this.lbMasterBranch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRepositoryConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repository Settings";
            this.Load += new System.EventHandler(this.FrmRepositoryConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMasterBranch;
        private System.Windows.Forms.TextBox edMasterBranch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.TextBox edOrder;
        private System.Windows.Forms.CheckBox ckFetch;
    }
}