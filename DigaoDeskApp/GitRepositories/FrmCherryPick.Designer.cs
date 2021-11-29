
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
            this.lstCommits = new System.Windows.Forms.ListBox();
            this.edSearch = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edStartDate = new System.Windows.Forms.DateTimePicker();
            this.edEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edBranch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstCommits
            // 
            this.lstCommits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstCommits.FormattingEnabled = true;
            this.lstCommits.IntegralHeight = false;
            this.lstCommits.ItemHeight = 15;
            this.lstCommits.Location = new System.Drawing.Point(8, 104);
            this.lstCommits.Name = "lstCommits";
            this.lstCommits.Size = new System.Drawing.Size(856, 376);
            this.lstCommits.TabIndex = 10;
            this.lstCommits.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstCommits_DrawItem);
            // 
            // edSearch
            // 
            this.edSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edSearch.Location = new System.Drawing.Point(8, 72);
            this.edSearch.Name = "edSearch";
            this.edSearch.Size = new System.Drawing.Size(632, 23);
            this.edSearch.TabIndex = 1;
            this.edSearch.TextChanged += new System.EventHandler(this.edSearch_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(352, 488);
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
            this.btnCancel.Location = new System.Drawing.Point(440, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // edStartDate
            // 
            this.edStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edStartDate.Location = new System.Drawing.Point(648, 72);
            this.edStartDate.Name = "edStartDate";
            this.edStartDate.ShowCheckBox = true;
            this.edStartDate.Size = new System.Drawing.Size(104, 23);
            this.edStartDate.TabIndex = 4;
            this.edStartDate.ValueChanged += new System.EventHandler(this.edDates_ValueChanged);
            // 
            // edEndDate
            // 
            this.edEndDate.Checked = false;
            this.edEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edEndDate.Location = new System.Drawing.Point(760, 72);
            this.edEndDate.Name = "edEndDate";
            this.edEndDate.ShowCheckBox = true;
            this.edEndDate.Size = new System.Drawing.Size(104, 23);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(758, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "End date";
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
            // FrmCherryPick
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(872, 528);
            this.Controls.Add(this.edBranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edEndDate);
            this.Controls.Add(this.edStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.edSearch);
            this.Controls.Add(this.lstCommits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCherryPick";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cherry Pick";
            this.Load += new System.EventHandler(this.FrmCherryPick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCommits;
        private System.Windows.Forms.TextBox edSearch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker edStartDate;
        private System.Windows.Forms.DateTimePicker edEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox edBranch;
    }
}