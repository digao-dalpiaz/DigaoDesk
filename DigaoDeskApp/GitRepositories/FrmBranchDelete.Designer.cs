
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranchDelete));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbConfirmation = new System.Windows.Forms.Label();
            this.edConfirm = new System.Windows.Forms.TextBox();
            this.edSearch = new System.Windows.Forms.TextBox();
            this.lbFilterBranches = new System.Windows.Forms.Label();
            this.ckDeleteLocal = new System.Windows.Forms.CheckBox();
            this.ckDeleteRemote = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxLocation = new System.Windows.Forms.Panel();
            this.ckFilterRemote = new System.Windows.Forms.RadioButton();
            this.ckFilterLocal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.boxLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(386, 768);
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
            this.btnCancel.Location = new System.Drawing.Point(496, 768);
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
            this.lbConfirmation.Location = new System.Drawing.Point(14, 704);
            this.lbConfirmation.Name = "lbConfirmation";
            this.lbConfirmation.Size = new System.Drawing.Size(259, 20);
            this.lbConfirmation.TabIndex = 6;
            this.lbConfirmation.Text = "Type \"CONFIRM\" to enable OK button";
            // 
            // edConfirm
            // 
            this.edConfirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edConfirm.Location = new System.Drawing.Point(16, 728);
            this.edConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edConfirm.Name = "edConfirm";
            this.edConfirm.Size = new System.Drawing.Size(952, 27);
            this.edConfirm.TabIndex = 8;
            this.edConfirm.TextChanged += new System.EventHandler(this.edConfirm_TextChanged);
            // 
            // edSearch
            // 
            this.edSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edSearch.Location = new System.Drawing.Point(16, 40);
            this.edSearch.Name = "edSearch";
            this.edSearch.Size = new System.Drawing.Size(672, 27);
            this.edSearch.TabIndex = 0;
            this.edSearch.TextChanged += new System.EventHandler(this.edSearch_TextChanged);
            // 
            // lbFilterBranches
            // 
            this.lbFilterBranches.AutoSize = true;
            this.lbFilterBranches.Location = new System.Drawing.Point(14, 16);
            this.lbFilterBranches.Name = "lbFilterBranches";
            this.lbFilterBranches.Size = new System.Drawing.Size(105, 20);
            this.lbFilterBranches.TabIndex = 17;
            this.lbFilterBranches.Text = "Filter Branches";
            // 
            // ckDeleteLocal
            // 
            this.ckDeleteLocal.AutoSize = true;
            this.ckDeleteLocal.Checked = true;
            this.ckDeleteLocal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDeleteLocal.Location = new System.Drawing.Point(24, 468);
            this.ckDeleteLocal.Name = "ckDeleteLocal";
            this.ckDeleteLocal.Size = new System.Drawing.Size(114, 24);
            this.ckDeleteLocal.TabIndex = 3;
            this.ckDeleteLocal.Text = "Delete Local";
            this.ckDeleteLocal.UseVisualStyleBackColor = true;
            // 
            // ckDeleteRemote
            // 
            this.ckDeleteRemote.AutoSize = true;
            this.ckDeleteRemote.Location = new System.Drawing.Point(176, 468);
            this.ckDeleteRemote.Name = "ckDeleteRemote";
            this.ckDeleteRemote.Size = new System.Drawing.Size(131, 24);
            this.ckDeleteRemote.TabIndex = 4;
            this.ckDeleteRemote.Text = "Delete Remote";
            this.ckDeleteRemote.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(480, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Mark for Deletion";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.IntegralHeight = false;
            this.lst.ItemHeight = 20;
            this.lst.Location = new System.Drawing.Point(16, 504);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(952, 192);
            this.lst.TabIndex = 7;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.Location = new System.Drawing.Point(728, 464);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(240, 32);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Remove from Deletion";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // g
            // 
            this.g.AllowUserToAddRows = false;
            this.g.AllowUserToDeleteRows = false;
            this.g.AllowUserToResizeRows = false;
            this.g.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLocation,
            this.colAuthor,
            this.colDateTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g.DefaultCellStyle = dataGridViewCellStyle2;
            this.g.Location = new System.Drawing.Point(16, 80);
            this.g.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.g.MultiSelect = false;
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowHeadersWidth = 51;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(952, 376);
            this.g.StandardTab = true;
            this.g.TabIndex = 2;
            this.g.SelectionChanged += new System.EventHandler(this.g_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "Location";
            this.colLocation.MinimumWidth = 6;
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 80;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Last Commit Author";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 150;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "Timestamp";
            this.colDateTime.HeaderText = "Last Commit Date/Time";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 150;
            // 
            // boxLocation
            // 
            this.boxLocation.Controls.Add(this.ckFilterRemote);
            this.boxLocation.Controls.Add(this.ckFilterLocal);
            this.boxLocation.Location = new System.Drawing.Point(736, 29);
            this.boxLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxLocation.Name = "boxLocation";
            this.boxLocation.Size = new System.Drawing.Size(192, 48);
            this.boxLocation.TabIndex = 1;
            // 
            // ckFilterRemote
            // 
            this.ckFilterRemote.AutoSize = true;
            this.ckFilterRemote.Location = new System.Drawing.Point(91, 11);
            this.ckFilterRemote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckFilterRemote.Name = "ckFilterRemote";
            this.ckFilterRemote.Size = new System.Drawing.Size(82, 24);
            this.ckFilterRemote.TabIndex = 1;
            this.ckFilterRemote.TabStop = true;
            this.ckFilterRemote.Text = "Remote";
            this.ckFilterRemote.UseVisualStyleBackColor = true;
            this.ckFilterRemote.Click += new System.EventHandler(this.edSearch_TextChanged);
            // 
            // ckFilterLocal
            // 
            this.ckFilterLocal.AutoSize = true;
            this.ckFilterLocal.Checked = true;
            this.ckFilterLocal.Location = new System.Drawing.Point(9, 11);
            this.ckFilterLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckFilterLocal.Name = "ckFilterLocal";
            this.ckFilterLocal.Size = new System.Drawing.Size(65, 24);
            this.ckFilterLocal.TabIndex = 0;
            this.ckFilterLocal.TabStop = true;
            this.ckFilterLocal.Text = "Local";
            this.ckFilterLocal.UseVisualStyleBackColor = true;
            this.ckFilterLocal.Click += new System.EventHandler(this.edSearch_TextChanged);
            // 
            // FrmBranchDelete
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(985, 816);
            this.Controls.Add(this.boxLocation);
            this.Controls.Add(this.g);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ckDeleteRemote);
            this.Controls.Add(this.ckDeleteLocal);
            this.Controls.Add(this.lbFilterBranches);
            this.Controls.Add(this.edSearch);
            this.Controls.Add(this.edConfirm);
            this.Controls.Add(this.lbConfirmation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBranchDelete";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Branch";
            this.Load += new System.EventHandler(this.FrmBranchDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.boxLocation.ResumeLayout(false);
            this.boxLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbConfirmation;
        private System.Windows.Forms.TextBox edConfirm;
        private System.Windows.Forms.TextBox edSearch;
        private System.Windows.Forms.Label lbFilterBranches;
        private System.Windows.Forms.CheckBox ckDeleteLocal;
        private System.Windows.Forms.CheckBox ckDeleteRemote;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView g;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.Panel boxLocation;
        private System.Windows.Forms.RadioButton ckFilterRemote;
        private System.Windows.Forms.RadioButton ckFilterLocal;
    }
}