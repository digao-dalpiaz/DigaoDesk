
namespace DigaoDeskApp
{
    partial class FrmCherryPick
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
            this.edSearch = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edStartDate = new System.Windows.Forms.DateTimePicker();
            this.edEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edBranch = new System.Windows.Forms.ComboBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.boxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // edSearch
            // 
            this.edSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edSearch.Location = new System.Drawing.Point(8, 72);
            this.edSearch.Name = "edSearch";
            this.edSearch.Size = new System.Drawing.Size(616, 23);
            this.edSearch.TabIndex = 1;
            this.edSearch.TextChanged += new System.EventHandler(this.edSearch_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(8, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 32);
            this.btnOK.TabIndex = 21;
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
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // edStartDate
            // 
            this.edStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edStartDate.Location = new System.Drawing.Point(632, 72);
            this.edStartDate.Name = "edStartDate";
            this.edStartDate.ShowCheckBox = true;
            this.edStartDate.Size = new System.Drawing.Size(112, 23);
            this.edStartDate.TabIndex = 4;
            this.edStartDate.ValueChanged += new System.EventHandler(this.edDates_ValueChanged);
            // 
            // edEndDate
            // 
            this.edEndDate.Checked = false;
            this.edEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edEndDate.Location = new System.Drawing.Point(752, 72);
            this.edEndDate.Name = "edEndDate";
            this.edEndDate.ShowCheckBox = true;
            this.edEndDate.Size = new System.Drawing.Size(112, 23);
            this.edEndDate.TabIndex = 5;
            this.edEndDate.ValueChanged += new System.EventHandler(this.edDates_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Commit message or id";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(630, 56);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(57, 15);
            this.lbStartDate.TabIndex = 7;
            this.lbStartDate.Text = "Start date";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(750, 56);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(53, 15);
            this.lbEndDate.TabIndex = 8;
            this.lbEndDate.Text = "End date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Remote Branch";
            // 
            // edBranch
            // 
            this.edBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.edBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.edBranch.FormattingEnabled = true;
            this.edBranch.Location = new System.Drawing.Point(8, 24);
            this.edBranch.Name = "edBranch";
            this.edBranch.Size = new System.Drawing.Size(856, 23);
            this.edBranch.TabIndex = 0;
            this.edBranch.TextChanged += new System.EventHandler(this.edBranch_TextChanged);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(8, 488);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(40, 15);
            this.lbCount.TabIndex = 24;
            this.lbCount.Text = "Count";
            // 
            // g
            // 
            this.g.AllowUserToAddRows = false;
            this.g.AllowUserToDeleteRows = false;
            this.g.AllowUserToResizeRows = false;
            this.g.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colMessage,
            this.colAuthor,
            this.colDateTime});
            this.g.Location = new System.Drawing.Point(8, 104);
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(856, 376);
            this.g.StandardTab = true;
            this.g.TabIndex = 25;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colMessage
            // 
            this.colMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMessage.DataPropertyName = "Message";
            this.colMessage.HeaderText = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 150;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "DateTime";
            this.colDateTime.HeaderText = "Date/Time";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 150;
            // 
            // boxButtons
            // 
            this.boxButtons.Controls.Add(this.btnCancel);
            this.boxButtons.Controls.Add(this.btnOK);
            this.boxButtons.Location = new System.Drawing.Point(344, 480);
            this.boxButtons.Name = "boxButtons";
            this.boxButtons.Size = new System.Drawing.Size(184, 48);
            this.boxButtons.TabIndex = 26;
            // 
            // FrmCherryPick
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(872, 528);
            this.Controls.Add(this.boxButtons);
            this.Controls.Add(this.g);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.edBranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edEndDate);
            this.Controls.Add(this.edStartDate);
            this.Controls.Add(this.edSearch);
            this.MinimizeBox = false;
            this.Name = "FrmCherryPick";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cherry Pick";
            this.Load += new System.EventHandler(this.FrmCherryPick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.boxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox edSearch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker edStartDate;
        private System.Windows.Forms.DateTimePicker edEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox edBranch;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.DataGridView g;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.Panel boxButtons;
    }
}