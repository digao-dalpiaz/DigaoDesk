
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
            this.colBranchesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherBranchesDifs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastFetch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edLog = new DigaoDeskApp.RichTextBoxEx();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnFetchAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFetch = new System.Windows.Forms.ToolStripButton();
            this.btnPull = new System.Windows.Forms.ToolStripButton();
            this.btnSwitchBranch = new System.Windows.Forms.ToolStripButton();
            this.btnCheckoutRemote = new System.Windows.Forms.ToolStripButton();
            this.btnDifs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearLog = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
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
            this.colBranchesCount,
            this.colUp,
            this.colDown,
            this.colDifs,
            this.colOtherBranchesDifs,
            this.colLastFetch});
            this.g.Dock = System.Windows.Forms.DockStyle.Top;
            this.g.Location = new System.Drawing.Point(0, 31);
            this.g.MultiSelect = false;
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(1208, 256);
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
            // colBranchesCount
            // 
            this.colBranchesCount.DataPropertyName = "BranchesCount";
            this.colBranchesCount.HeaderText = "Branches Count";
            this.colBranchesCount.Name = "colBranchesCount";
            this.colBranchesCount.ReadOnly = true;
            this.colBranchesCount.Width = 120;
            // 
            // colUp
            // 
            this.colUp.DataPropertyName = "PendingUp";
            this.colUp.HeaderText = "Pending Up";
            this.colUp.Name = "colUp";
            this.colUp.ReadOnly = true;
            this.colUp.Width = 60;
            // 
            // colDown
            // 
            this.colDown.DataPropertyName = "PendingDown";
            this.colDown.HeaderText = "Pending Down";
            this.colDown.Name = "colDown";
            this.colDown.ReadOnly = true;
            this.colDown.Width = 60;
            // 
            // colDifs
            // 
            this.colDifs.DataPropertyName = "Difs";
            this.colDifs.HeaderText = "Difs";
            this.colDifs.Name = "colDifs";
            this.colDifs.ReadOnly = true;
            this.colDifs.Width = 60;
            // 
            // colOtherBranchesDifs
            // 
            this.colOtherBranchesDifs.DataPropertyName = "OthersBranchesDifs";
            this.colOtherBranchesDifs.HeaderText = "Other Branches Pending";
            this.colOtherBranchesDifs.Name = "colOtherBranchesDifs";
            this.colOtherBranchesDifs.ReadOnly = true;
            this.colOtherBranchesDifs.Width = 150;
            // 
            // colLastFetch
            // 
            this.colLastFetch.DataPropertyName = "LastFetchTS";
            this.colLastFetch.HeaderText = "Last Fetch";
            this.colLastFetch.Name = "colLastFetch";
            this.colLastFetch.ReadOnly = true;
            this.colLastFetch.Width = 120;
            // 
            // edLog
            // 
            this.edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLog.HideSelection = false;
            this.edLog.Location = new System.Drawing.Point(0, 295);
            this.edLog.Name = "edLog";
            this.edLog.ReadOnly = true;
            this.edLog.Size = new System.Drawing.Size(1208, 353);
            this.edLog.TabIndex = 1;
            this.edLog.Text = "";
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnFetchAll,
            this.toolStripSeparator1,
            this.btnFetch,
            this.btnPull,
            this.btnSwitchBranch,
            this.btnCheckoutRemote,
            this.btnDifs,
            this.toolStripSeparator2,
            this.btnClearLog});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1208, 31);
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
            // btnFetchAll
            // 
            this.btnFetchAll.Image = ((System.Drawing.Image)(resources.GetObject("btnFetchAll.Image")));
            this.btnFetchAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFetchAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFetchAll.Name = "btnFetchAll";
            this.btnFetchAll.Size = new System.Drawing.Size(81, 28);
            this.btnFetchAll.Text = "Fetch All";
            this.btnFetchAll.Click += new System.EventHandler(this.btnFetchAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
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
            this.btnPull.Size = new System.Drawing.Size(138, 28);
            this.btnPull.Text = "Pull Current Branch";
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // btnSwitchBranch
            // 
            this.btnSwitchBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchBranch.Image")));
            this.btnSwitchBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSwitchBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSwitchBranch.Name = "btnSwitchBranch";
            this.btnSwitchBranch.Size = new System.Drawing.Size(138, 28);
            this.btnSwitchBranch.Text = "Switch Local Branch";
            this.btnSwitchBranch.Click += new System.EventHandler(this.btnSwitchBranch_Click);
            // 
            // btnCheckoutRemote
            // 
            this.btnCheckoutRemote.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckoutRemote.Image")));
            this.btnCheckoutRemote.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCheckoutRemote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckoutRemote.Name = "btnCheckoutRemote";
            this.btnCheckoutRemote.Size = new System.Drawing.Size(170, 28);
            this.btnCheckoutRemote.Text = "Checkout Remote Branch";
            this.btnCheckoutRemote.Click += new System.EventHandler(this.btnCheckoutRemote_Click);
            // 
            // btnDifs
            // 
            this.btnDifs.Image = ((System.Drawing.Image)(resources.GetObject("btnDifs.Image")));
            this.btnDifs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDifs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDifs.Name = "btnDifs";
            this.btnDifs.Size = new System.Drawing.Size(55, 28);
            this.btnDifs.Text = "Difs";
            this.btnDifs.Click += new System.EventHandler(this.btnDifs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
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
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 287);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1208, 8);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // FrmRepos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 648);
            this.Controls.Add(this.edLog);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.g);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepos";
            this.Text = "Git Repositories - Digao Desk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRepos_FormClosing);
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
        private DigaoDeskApp.RichTextBoxEx edLog;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnPull;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripButton btnFetch;
        private System.Windows.Forms.ToolStripButton btnClearLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSwitchBranch;
        private System.Windows.Forms.ToolStripButton btnCheckoutRemote;
        private System.Windows.Forms.ToolStripButton btnFetchAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranchesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherBranchesDifs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastFetch;
        private System.Windows.Forms.ToolStripButton btnDifs;
    }
}