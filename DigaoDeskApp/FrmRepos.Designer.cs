
namespace DigaoDeskApp
{
    partial class FrmRepos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepos));
            this.g = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edLog = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPull = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.AllowUserToAddRows = false;
            this.g.AllowUserToDeleteRows = false;
            this.g.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName});
            this.g.Dock = System.Windows.Forms.DockStyle.Top;
            this.g.Location = new System.Drawing.Point(0, 25);
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(800, 256);
            this.g.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // edLog
            // 
            this.edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLog.Location = new System.Drawing.Point(0, 281);
            this.edLog.Name = "edLog";
            this.edLog.ReadOnly = true;
            this.edLog.Size = new System.Drawing.Size(800, 367);
            this.edLog.TabIndex = 1;
            this.edLog.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnPull});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 22);
            this.btnRefresh.Text = "Refresh";
            // 
            // btnPull
            // 
            this.btnPull.Image = ((System.Drawing.Image)(resources.GetObject("btnPull.Image")));
            this.btnPull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(47, 22);
            this.btnPull.Text = "Pull";
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // FrmRepos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.edLog);
            this.Controls.Add(this.g);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepos";
            this.Text = "Git Repositories - Digao Desk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRepos_FormClosed);
            this.Load += new System.EventHandler(this.FrmRepos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView g;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.RichTextBox edLog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnPull;
    }
}