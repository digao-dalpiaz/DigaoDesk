
namespace DigaoDeskApp
{
    partial class FrmBranchCreate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranchCreate));
            this.btnPrefix = new System.Windows.Forms.Button();
            this.lbBranchName = new System.Windows.Forms.Label();
            this.edName = new System.Windows.Forms.TextBox();
            this.boxBasedOn = new System.Windows.Forms.GroupBox();
            this.edCurrentBranch = new System.Windows.Forms.TextBox();
            this.edTag = new System.Windows.Forms.ComboBox();
            this.ckTag = new System.Windows.Forms.RadioButton();
            this.ckCurrentBranch = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuPrefix = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ckSwitch = new System.Windows.Forms.CheckBox();
            this.boxBasedOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrefix
            // 
            this.btnPrefix.Image = ((System.Drawing.Image)(resources.GetObject("btnPrefix.Image")));
            this.btnPrefix.Location = new System.Drawing.Point(9, 11);
            this.btnPrefix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrefix.Name = "btnPrefix";
            this.btnPrefix.Size = new System.Drawing.Size(143, 41);
            this.btnPrefix.TabIndex = 0;
            this.btnPrefix.TabStop = false;
            this.btnPrefix.Text = "Insert Prefix";
            this.btnPrefix.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrefix.UseVisualStyleBackColor = true;
            this.btnPrefix.Click += new System.EventHandler(this.btnPrefix_Click);
            // 
            // lbBranchName
            // 
            this.lbBranchName.AutoSize = true;
            this.lbBranchName.Location = new System.Drawing.Point(7, 64);
            this.lbBranchName.Name = "lbBranchName";
            this.lbBranchName.Size = new System.Drawing.Size(95, 20);
            this.lbBranchName.TabIndex = 1;
            this.lbBranchName.Text = "Branch name";
            // 
            // edName
            // 
            this.edName.Location = new System.Drawing.Point(9, 85);
            this.edName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(466, 27);
            this.edName.TabIndex = 2;
            // 
            // boxBasedOn
            // 
            this.boxBasedOn.Controls.Add(this.edCurrentBranch);
            this.boxBasedOn.Controls.Add(this.edTag);
            this.boxBasedOn.Controls.Add(this.ckTag);
            this.boxBasedOn.Controls.Add(this.ckCurrentBranch);
            this.boxBasedOn.Location = new System.Drawing.Point(9, 128);
            this.boxBasedOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxBasedOn.Name = "boxBasedOn";
            this.boxBasedOn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxBasedOn.Size = new System.Drawing.Size(814, 203);
            this.boxBasedOn.TabIndex = 3;
            this.boxBasedOn.TabStop = false;
            this.boxBasedOn.Text = "Based on";
            // 
            // edCurrentBranch
            // 
            this.edCurrentBranch.BackColor = System.Drawing.SystemColors.Info;
            this.edCurrentBranch.Location = new System.Drawing.Point(37, 64);
            this.edCurrentBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edCurrentBranch.Name = "edCurrentBranch";
            this.edCurrentBranch.ReadOnly = true;
            this.edCurrentBranch.Size = new System.Drawing.Size(457, 27);
            this.edCurrentBranch.TabIndex = 3;
            this.edCurrentBranch.TabStop = false;
            // 
            // edTag
            // 
            this.edTag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.edTag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.edTag.FormattingEnabled = true;
            this.edTag.Location = new System.Drawing.Point(37, 149);
            this.edTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edTag.Name = "edTag";
            this.edTag.Size = new System.Drawing.Size(767, 28);
            this.edTag.TabIndex = 2;
            // 
            // ckTag
            // 
            this.ckTag.AutoSize = true;
            this.ckTag.Location = new System.Drawing.Point(9, 117);
            this.ckTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckTag.Name = "ckTag";
            this.ckTag.Size = new System.Drawing.Size(109, 24);
            this.ckTag.TabIndex = 1;
            this.ckTag.Text = "Specific Tag";
            this.ckTag.UseVisualStyleBackColor = true;
            this.ckTag.Click += new System.EventHandler(this.ckBasedOnOption_Click);
            // 
            // ckCurrentBranch
            // 
            this.ckCurrentBranch.AutoSize = true;
            this.ckCurrentBranch.Checked = true;
            this.ckCurrentBranch.Location = new System.Drawing.Point(9, 32);
            this.ckCurrentBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckCurrentBranch.Name = "ckCurrentBranch";
            this.ckCurrentBranch.Size = new System.Drawing.Size(127, 24);
            this.ckCurrentBranch.TabIndex = 0;
            this.ckCurrentBranch.TabStop = true;
            this.ckCurrentBranch.Text = "Current Branch";
            this.ckCurrentBranch.UseVisualStyleBackColor = true;
            this.ckCurrentBranch.Click += new System.EventHandler(this.ckBasedOnOption_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(320, 405);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 43);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(421, 405);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 43);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // menuPrefix
            // 
            this.menuPrefix.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrefix.Name = "menuPrefix";
            this.menuPrefix.Size = new System.Drawing.Size(61, 4);
            // 
            // ckSwitch
            // 
            this.ckSwitch.AutoSize = true;
            this.ckSwitch.Checked = true;
            this.ckSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSwitch.Location = new System.Drawing.Point(9, 352);
            this.ckSwitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckSwitch.Name = "ckSwitch";
            this.ckSwitch.Size = new System.Drawing.Size(259, 24);
            this.ckSwitch.TabIndex = 6;
            this.ckSwitch.Text = "Switch to new branch immediately";
            this.ckSwitch.UseVisualStyleBackColor = true;
            // 
            // FrmBranchCreate
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(833, 457);
            this.Controls.Add(this.ckSwitch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.boxBasedOn);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.lbBranchName);
            this.Controls.Add(this.btnPrefix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBranchCreate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Branch";
            this.Load += new System.EventHandler(this.FrmBranchCreate_Load);
            this.boxBasedOn.ResumeLayout(false);
            this.boxBasedOn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrefix;
        private System.Windows.Forms.Label lbBranchName;
        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.GroupBox boxBasedOn;
        private System.Windows.Forms.RadioButton ckCurrentBranch;
        private System.Windows.Forms.RadioButton ckTag;
        private System.Windows.Forms.ComboBox edTag;
        private System.Windows.Forms.TextBox edCurrentBranch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip menuPrefix;
        private System.Windows.Forms.CheckBox ckSwitch;
    }
}