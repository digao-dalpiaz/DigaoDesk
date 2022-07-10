
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
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbBranch = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxButtons = new System.Windows.Forms.Panel();
            this.edBranch = new System.Windows.Forms.TextBox();
            this.btnSelBranch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.boxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // edSearch
            // 
            this.edSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edSearch.Location = new System.Drawing.Point(9, 96);
            this.edSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edSearch.Name = "edSearch";
            this.edSearch.Size = new System.Drawing.Size(703, 27);
            this.edSearch.TabIndex = 2;
            this.edSearch.TextChanged += new System.EventHandler(this.edSearch_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(9, 11);
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
            this.btnCancel.Location = new System.Drawing.Point(110, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 43);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // edStartDate
            // 
            this.edStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edStartDate.Location = new System.Drawing.Point(722, 96);
            this.edStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edStartDate.Name = "edStartDate";
            this.edStartDate.ShowCheckBox = true;
            this.edStartDate.Size = new System.Drawing.Size(127, 27);
            this.edStartDate.TabIndex = 3;
            this.edStartDate.ValueChanged += new System.EventHandler(this.edDates_ValueChanged);
            // 
            // edEndDate
            // 
            this.edEndDate.Checked = false;
            this.edEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edEndDate.Location = new System.Drawing.Point(859, 96);
            this.edEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edEndDate.Name = "edEndDate";
            this.edEndDate.ShowCheckBox = true;
            this.edEndDate.Size = new System.Drawing.Size(127, 27);
            this.edEndDate.TabIndex = 4;
            this.edEndDate.ValueChanged += new System.EventHandler(this.edDates_ValueChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(7, 75);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(159, 20);
            this.lbSearch.TabIndex = 6;
            this.lbSearch.Text = "Commit message or id";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(720, 75);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(74, 20);
            this.lbStartDate.TabIndex = 7;
            this.lbStartDate.Text = "Start date";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(857, 75);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(68, 20);
            this.lbEndDate.TabIndex = 8;
            this.lbEndDate.Text = "End date";
            // 
            // lbBranch
            // 
            this.lbBranch.AutoSize = true;
            this.lbBranch.Location = new System.Drawing.Point(7, 11);
            this.lbBranch.Name = "lbBranch";
            this.lbBranch.Size = new System.Drawing.Size(54, 20);
            this.lbBranch.TabIndex = 23;
            this.lbBranch.Text = "Branch";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(9, 651);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(48, 20);
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
            this.g.Location = new System.Drawing.Point(9, 139);
            this.g.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowHeadersWidth = 51;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(978, 501);
            this.g.StandardTab = true;
            this.g.TabIndex = 5;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colMessage
            // 
            this.colMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMessage.DataPropertyName = "Message";
            this.colMessage.HeaderText = "Message";
            this.colMessage.MinimumWidth = 6;
            this.colMessage.Name = "colMessage";
            this.colMessage.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 150;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "DateTime";
            this.colDateTime.HeaderText = "Date/Time";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 150;
            // 
            // boxButtons
            // 
            this.boxButtons.Controls.Add(this.btnCancel);
            this.boxButtons.Controls.Add(this.btnOK);
            this.boxButtons.Location = new System.Drawing.Point(393, 640);
            this.boxButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxButtons.Name = "boxButtons";
            this.boxButtons.Size = new System.Drawing.Size(210, 64);
            this.boxButtons.TabIndex = 11;
            // 
            // edBranch
            // 
            this.edBranch.BackColor = System.Drawing.SystemColors.Info;
            this.edBranch.Location = new System.Drawing.Point(9, 32);
            this.edBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edBranch.Name = "edBranch";
            this.edBranch.ReadOnly = true;
            this.edBranch.Size = new System.Drawing.Size(868, 27);
            this.edBranch.TabIndex = 0;
            // 
            // btnSelBranch
            // 
            this.btnSelBranch.Location = new System.Drawing.Point(878, 31);
            this.btnSelBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelBranch.Name = "btnSelBranch";
            this.btnSelBranch.Size = new System.Drawing.Size(110, 33);
            this.btnSelBranch.TabIndex = 1;
            this.btnSelBranch.Text = "Select Branch";
            this.btnSelBranch.UseVisualStyleBackColor = true;
            this.btnSelBranch.Click += new System.EventHandler(this.btnSelBranch_Click);
            // 
            // FrmCherryPick
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(997, 704);
            this.Controls.Add(this.btnSelBranch);
            this.Controls.Add(this.edBranch);
            this.Controls.Add(this.boxButtons);
            this.Controls.Add(this.g);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbBranch);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.edEndDate);
            this.Controls.Add(this.edStartDate);
            this.Controls.Add(this.edSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbBranch;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.DataGridView g;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.Panel boxButtons;
        private System.Windows.Forms.TextBox edBranch;
        private System.Windows.Forms.Button btnSelBranch;
    }
}