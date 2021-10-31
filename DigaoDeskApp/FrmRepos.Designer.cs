
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
            this.colBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastFetch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edLog = new System.Windows.Forms.RichTextBox();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnFetch = new System.Windows.Forms.ToolStripButton();
            this.btnPull = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnClearLog = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
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
            this.colBranch,
            this.colUp,
            this.colDown,
            this.colDifs,
            this.colLastFetch});
            this.g.Dock = System.Windows.Forms.DockStyle.Top;
            this.g.Location = new System.Drawing.Point(0, 31);
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(1052, 256);
            this.g.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colBranch
            // 
            this.colBranch.DataPropertyName = "Branch";
            this.colBranch.HeaderText = "Current Branch";
            this.colBranch.Name = "colBranch";
            this.colBranch.ReadOnly = true;
            this.colBranch.Width = 250;
            // 
            // colUp
            // 
            this.colUp.DataPropertyName = "PendingUp";
            this.colUp.HeaderText = "Pending Up";
            this.colUp.Name = "colUp";
            this.colUp.ReadOnly = true;
            // 
            // colDown
            // 
            this.colDown.DataPropertyName = "PendingDown";
            this.colDown.HeaderText = "Pending Down";
            this.colDown.Name = "colDown";
            this.colDown.ReadOnly = true;
            // 
            // colDifs
            // 
            this.colDifs.DataPropertyName = "Difs";
            this.colDifs.HeaderText = "Difs";
            this.colDifs.Name = "colDifs";
            this.colDifs.ReadOnly = true;
            // 
            // colLastFetch
            // 
            this.colLastFetch.DataPropertyName = "LastFetchTS";
            this.colLastFetch.HeaderText = "Last Fetch";
            this.colLastFetch.Name = "colLastFetch";
            this.colLastFetch.ReadOnly = true;
            // 
            // edLog
            // 
            this.edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLog.Location = new System.Drawing.Point(0, 295);
            this.edLog.Name = "edLog";
            this.edLog.ReadOnly = true;
            this.edLog.Size = new System.Drawing.Size(1052, 353);
            this.edLog.TabIndex = 1;
            this.edLog.Text = "";
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnFetch,
            this.btnPull,
            this.btnClearLog});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1052, 31);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 28);
            this.btnRefresh.Text = "Refresh All";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Image = ((System.Drawing.Image)(resources.GetObject("btnFetch.Image")));
            this.btnFetch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFetch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(64, 28);
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnPull
            // 
            this.btnPull.Image = ((System.Drawing.Image)(resources.GetObject("btnPull.Image")));
            this.btnPull.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(55, 28);
            this.btnPull.Text = "Pull";
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 287);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1052, 8);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLog.Image")));
            this.btnClearLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(85, 28);
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // FrmRepos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 648);
            this.Controls.Add(this.edLog);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.g);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepos";
            this.Text = "Git Repositories - Digao Desk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRepos_FormClosed);
            this.Load += new System.EventHandler(this.FrmRepos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView g;
        private System.Windows.Forms.RichTextBox edLog;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnPull;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripButton btnFetch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastFetch;
        private System.Windows.Forms.ToolStripButton btnClearLog;
    }
}