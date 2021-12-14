
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.colOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMasterCompare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edLog = new DigaoDeskApp.RichTextBoxEx();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnFetchAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFetch = new System.Windows.Forms.ToolStripButton();
            this.btnPull = new System.Windows.Forms.ToolStripButton();
            this.btnSwitchBranch = new System.Windows.Forms.ToolStripButton();
            this.btnCheckoutRemote = new System.Windows.Forms.ToolStripButton();
            this.btnCreateBranch = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteBranch = new System.Windows.Forms.ToolStripButton();
            this.btnCherryPick = new System.Windows.Forms.ToolStripButton();
            this.btnMerge = new System.Windows.Forms.ToolStripButton();
            this.btnSyncWithMaster = new System.Windows.Forms.ToolStripButton();
            this.btnPush = new System.Windows.Forms.ToolStripButton();
            this.btnCancelOperation = new System.Windows.Forms.ToolStripButton();
            this.btnDifs = new System.Windows.Forms.ToolStripButton();
            this.btnShell = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRepoConfig = new System.Windows.Forms.ToolStripButton();
            this.btnClearLog = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
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
            this.colLastFetch,
            this.colOperation,
            this.colMasterCompare});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g.DefaultCellStyle = dataGridViewCellStyle2;
            this.g.Dock = System.Windows.Forms.DockStyle.Top;
            this.g.Location = new System.Drawing.Point(0, 47);
            this.g.MultiSelect = false;
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(1419, 256);
            this.g.StandardTab = true;
            this.g.TabIndex = 0;
            this.g.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.g_CellFormatting);
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
            // colOperation
            // 
            this.colOperation.DataPropertyName = "CurrentOperation";
            this.colOperation.HeaderText = "Operation";
            this.colOperation.Name = "colOperation";
            this.colOperation.ReadOnly = true;
            // 
            // colMasterCompare
            // 
            this.colMasterCompare.DataPropertyName = "MasterBranchCompare";
            this.colMasterCompare.HeaderText = "Master Branch Compare";
            this.colMasterCompare.Name = "colMasterCompare";
            this.colMasterCompare.ReadOnly = true;
            this.colMasterCompare.Width = 150;
            // 
            // edLog
            // 
            this.edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLog.HideSelection = false;
            this.edLog.Location = new System.Drawing.Point(0, 311);
            this.edLog.Name = "edLog";
            this.edLog.ReadOnly = true;
            this.edLog.Size = new System.Drawing.Size(1419, 337);
            this.edLog.TabIndex = 1;
            this.edLog.Text = "";
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnFetchAll,
            this.toolStripSeparator1,
            this.btnCreateBranch,
            this.btnDeleteBranch,
            this.btnSwitchBranch,
            this.btnCheckoutRemote,
            this.toolStripSeparator3,
            this.btnFetch,
            this.btnPull,
            this.btnCherryPick,
            this.btnMerge,
            this.btnSyncWithMaster,
            this.btnDifs,
            this.btnCancelOperation,
            this.btnPush,
            this.toolStripSeparator2,
            this.btnShell,
            this.btnRepoConfig,
            this.btnClearLog});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1419, 47);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 44);
            this.btnRefresh.Text = "Refresh All";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFetchAll
            // 
            this.btnFetchAll.AutoSize = false;
            this.btnFetchAll.Image = ((System.Drawing.Image)(resources.GetObject("btnFetchAll.Image")));
            this.btnFetchAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFetchAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFetchAll.Name = "btnFetchAll";
            this.btnFetchAll.Size = new System.Drawing.Size(67, 44);
            this.btnFetchAll.Text = "Fetch All";
            this.btnFetchAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFetchAll.Click += new System.EventHandler(this.btnFetchAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // btnFetch
            // 
            this.btnFetch.AutoSize = false;
            this.btnFetch.Image = ((System.Drawing.Image)(resources.GetObject("btnFetch.Image")));
            this.btnFetch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFetch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(67, 44);
            this.btnFetch.Text = "Fetch";
            this.btnFetch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnPull
            // 
            this.btnPull.AutoSize = false;
            this.btnPull.Image = ((System.Drawing.Image)(resources.GetObject("btnPull.Image")));
            this.btnPull.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(67, 44);
            this.btnPull.Text = "Pull";
            this.btnPull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // btnSwitchBranch
            // 
            this.btnSwitchBranch.AutoSize = false;
            this.btnSwitchBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchBranch.Image")));
            this.btnSwitchBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSwitchBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSwitchBranch.Name = "btnSwitchBranch";
            this.btnSwitchBranch.Size = new System.Drawing.Size(67, 44);
            this.btnSwitchBranch.Text = "Switch";
            this.btnSwitchBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSwitchBranch.Click += new System.EventHandler(this.btnSwitchBranch_Click);
            // 
            // btnCheckoutRemote
            // 
            this.btnCheckoutRemote.AutoSize = false;
            this.btnCheckoutRemote.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckoutRemote.Image")));
            this.btnCheckoutRemote.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCheckoutRemote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckoutRemote.Name = "btnCheckoutRemote";
            this.btnCheckoutRemote.Size = new System.Drawing.Size(67, 44);
            this.btnCheckoutRemote.Text = "Checkout";
            this.btnCheckoutRemote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckoutRemote.Click += new System.EventHandler(this.btnCheckoutRemote_Click);
            // 
            // btnCreateBranch
            // 
            this.btnCreateBranch.AutoSize = false;
            this.btnCreateBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBranch.Image")));
            this.btnCreateBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCreateBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateBranch.Name = "btnCreateBranch";
            this.btnCreateBranch.Size = new System.Drawing.Size(67, 44);
            this.btnCreateBranch.Text = "New Branch";
            this.btnCreateBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreateBranch.Click += new System.EventHandler(this.btnCreateBranch_Click);
            // 
            // btnDeleteBranch
            // 
            this.btnDeleteBranch.AutoSize = false;
            this.btnDeleteBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBranch.Image")));
            this.btnDeleteBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(67, 44);
            this.btnDeleteBranch.Text = "Del Branch";
            this.btnDeleteBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteBranch.Click += new System.EventHandler(this.btnDeleteBranch_Click);
            // 
            // btnCherryPick
            // 
            this.btnCherryPick.AutoSize = false;
            this.btnCherryPick.Image = ((System.Drawing.Image)(resources.GetObject("btnCherryPick.Image")));
            this.btnCherryPick.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCherryPick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCherryPick.Name = "btnCherryPick";
            this.btnCherryPick.Size = new System.Drawing.Size(67, 44);
            this.btnCherryPick.Text = "Cherry Pick";
            this.btnCherryPick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCherryPick.Click += new System.EventHandler(this.btnCherryPick_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.AutoSize = false;
            this.btnMerge.Image = ((System.Drawing.Image)(resources.GetObject("btnMerge.Image")));
            this.btnMerge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMerge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(67, 44);
            this.btnMerge.Text = "Merge";
            this.btnMerge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnSyncWithMaster
            // 
            this.btnSyncWithMaster.AutoSize = false;
            this.btnSyncWithMaster.Image = ((System.Drawing.Image)(resources.GetObject("btnSyncWithMaster.Image")));
            this.btnSyncWithMaster.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSyncWithMaster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSyncWithMaster.Name = "btnSyncWithMaster";
            this.btnSyncWithMaster.Size = new System.Drawing.Size(67, 44);
            this.btnSyncWithMaster.Text = "Sync";
            this.btnSyncWithMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSyncWithMaster.Click += new System.EventHandler(this.btnSyncWithMaster_Click);
            // 
            // btnPush
            // 
            this.btnPush.AutoSize = false;
            this.btnPush.Image = ((System.Drawing.Image)(resources.GetObject("btnPush.Image")));
            this.btnPush.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(67, 44);
            this.btnPush.Text = "Push";
            this.btnPush.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.AutoSize = false;
            this.btnCancelOperation.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelOperation.Image")));
            this.btnCancelOperation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelOperation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(67, 44);
            this.btnCancelOperation.Text = "Cancel Op";
            this.btnCancelOperation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnDifs
            // 
            this.btnDifs.AutoSize = false;
            this.btnDifs.Image = ((System.Drawing.Image)(resources.GetObject("btnDifs.Image")));
            this.btnDifs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDifs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDifs.Name = "btnDifs";
            this.btnDifs.Size = new System.Drawing.Size(67, 44);
            this.btnDifs.Text = "Difs";
            this.btnDifs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDifs.Click += new System.EventHandler(this.btnDifs_Click);
            // 
            // btnShell
            // 
            this.btnShell.AutoSize = false;
            this.btnShell.Image = ((System.Drawing.Image)(resources.GetObject("btnShell.Image")));
            this.btnShell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(67, 44);
            this.btnShell.Text = "Shell";
            this.btnShell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // btnRepoConfig
            // 
            this.btnRepoConfig.AutoSize = false;
            this.btnRepoConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnRepoConfig.Image")));
            this.btnRepoConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRepoConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRepoConfig.Name = "btnRepoConfig";
            this.btnRepoConfig.Size = new System.Drawing.Size(67, 44);
            this.btnRepoConfig.Text = "Config";
            this.btnRepoConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRepoConfig.Click += new System.EventHandler(this.btnRepoConfig_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.AutoSize = false;
            this.btnClearLog.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLog.Image")));
            this.btnClearLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(67, 44);
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 303);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1419, 8);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // FrmRepos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 648);
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
        private System.Windows.Forms.ToolStripButton btnDifs;
        private System.Windows.Forms.ToolStripButton btnDeleteBranch;
        private System.Windows.Forms.ToolStripButton btnShell;
        private System.Windows.Forms.ToolStripButton btnCreateBranch;
        private System.Windows.Forms.ToolStripButton btnCherryPick;
        private System.Windows.Forms.ToolStripButton btnPush;
        private System.Windows.Forms.ToolStripButton btnCancelOperation;
        private System.Windows.Forms.ToolStripButton btnMerge;
        private System.Windows.Forms.ToolStripButton btnRepoConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranchesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherBranchesDifs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastFetch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMasterCompare;
        private System.Windows.Forms.ToolStripButton btnSyncWithMaster;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}