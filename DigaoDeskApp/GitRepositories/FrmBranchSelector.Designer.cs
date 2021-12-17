
namespace DigaoDeskApp
{
    partial class FrmBranchSelector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edSearch = new System.Windows.Forms.TextBox();
            this.g = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxButtons = new System.Windows.Forms.Panel();
            this.boxLocation = new System.Windows.Forms.Panel();
            this.ckRemote = new System.Windows.Forms.RadioButton();
            this.ckLocal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.boxButtons.SuspendLayout();
            this.boxLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(8, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(96, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // edSearch
            // 
            this.edSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edSearch.Location = new System.Drawing.Point(8, 8);
            this.edSearch.Name = "edSearch";
            this.edSearch.Size = new System.Drawing.Size(824, 23);
            this.edSearch.TabIndex = 0;
            this.edSearch.TextChanged += new System.EventHandler(this.edSearch_TextChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g.DefaultCellStyle = dataGridViewCellStyle1;
            this.g.Location = new System.Drawing.Point(8, 40);
            this.g.MultiSelect = false;
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(824, 384);
            this.g.StandardTab = true;
            this.g.TabIndex = 1;
            this.g.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.g_CellDoubleClick);
            this.g.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.g_CellFormatting);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 80;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Last Commit Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 150;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "Timestamp";
            this.colDateTime.HeaderText = "Last Commit Date/Time";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 150;
            // 
            // boxButtons
            // 
            this.boxButtons.Controls.Add(this.btnCancel);
            this.boxButtons.Controls.Add(this.btnOK);
            this.boxButtons.Location = new System.Drawing.Point(328, 424);
            this.boxButtons.Name = "boxButtons";
            this.boxButtons.Size = new System.Drawing.Size(184, 48);
            this.boxButtons.TabIndex = 3;
            // 
            // boxLocation
            // 
            this.boxLocation.Controls.Add(this.ckRemote);
            this.boxLocation.Controls.Add(this.ckLocal);
            this.boxLocation.Location = new System.Drawing.Point(8, 424);
            this.boxLocation.Name = "boxLocation";
            this.boxLocation.Size = new System.Drawing.Size(168, 40);
            this.boxLocation.TabIndex = 2;
            // 
            // ckRemote
            // 
            this.ckRemote.AutoSize = true;
            this.ckRemote.Location = new System.Drawing.Point(80, 8);
            this.ckRemote.Name = "ckRemote";
            this.ckRemote.Size = new System.Drawing.Size(66, 19);
            this.ckRemote.TabIndex = 1;
            this.ckRemote.TabStop = true;
            this.ckRemote.Text = "Remote";
            this.ckRemote.UseVisualStyleBackColor = true;
            this.ckRemote.Click += new System.EventHandler(this.edSearch_TextChanged);
            // 
            // ckLocal
            // 
            this.ckLocal.AutoSize = true;
            this.ckLocal.Checked = true;
            this.ckLocal.Location = new System.Drawing.Point(8, 8);
            this.ckLocal.Name = "ckLocal";
            this.ckLocal.Size = new System.Drawing.Size(53, 19);
            this.ckLocal.TabIndex = 0;
            this.ckLocal.TabStop = true;
            this.ckLocal.Text = "Local";
            this.ckLocal.UseVisualStyleBackColor = true;
            this.ckLocal.Click += new System.EventHandler(this.edSearch_TextChanged);
            // 
            // FrmBranchSelector
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.Controls.Add(this.boxLocation);
            this.Controls.Add(this.boxButtons);
            this.Controls.Add(this.g);
            this.Controls.Add(this.edSearch);
            this.MinimizeBox = false;
            this.Name = "FrmBranchSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a branch";
            this.Load += new System.EventHandler(this.FrmBranchCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.boxButtons.ResumeLayout(false);
            this.boxLocation.ResumeLayout(false);
            this.boxLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox edSearch;
        private System.Windows.Forms.DataGridView g;
        private System.Windows.Forms.Panel boxButtons;
        private System.Windows.Forms.Panel boxLocation;
        private System.Windows.Forms.RadioButton ckRemote;
        private System.Windows.Forms.RadioButton ckLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
    }
}