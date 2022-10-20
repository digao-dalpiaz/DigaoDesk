
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCreateBranch = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteBranch = new System.Windows.Forms.ToolStripButton();
            this.btnCheckoutRemote = new System.Windows.Forms.ToolStripButton();
            this.btnSwitchBranch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFetch = new System.Windows.Forms.ToolStripButton();
            this.btnPull = new System.Windows.Forms.ToolStripButton();
            this.btnCommit = new System.Windows.Forms.ToolStripButton();
            this.btnCherryPick = new System.Windows.Forms.ToolStripButton();
            this.btnMerge = new System.Windows.Forms.ToolStripButton();
            this.btnSyncWithMaster = new System.Windows.Forms.ToolStripButton();
            this.btnCancelOperation = new System.Windows.Forms.ToolStripButton();
            this.btnPush = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShell = new System.Windows.Forms.ToolStripButton();
            this.btnRepoConfig = new System.Windows.Forms.ToolStripButton();
            this.btnClearLog = new System.Windows.Forms.ToolStripButton();
            this.splitter = new System.Windows.Forms.Splitter();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.stFunInfo = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            this.toolBar.SuspendLayout();
            this.statusBar.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g.DefaultCellStyle = dataGridViewCellStyle4;
            this.g.Dock = System.Windows.Forms.DockStyle.Top;
            this.g.Location = new System.Drawing.Point(0, 51);
            this.g.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.g.MultiSelect = false;
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowHeadersWidth = 51;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(1622, 341);
            this.g.StandardTab = true;
            this.g.TabIndex = 0;
            this.g.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.g_CellFormatting);
            this.g.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.g_CellPainting);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colBranch
            // 
            this.colBranch.DataPropertyName = "Branch";
            this.colBranch.HeaderText = "Current Branch";
            this.colBranch.MinimumWidth = 6;
            this.colBranch.Name = "colBranch";
            this.colBranch.ReadOnly = true;
            this.colBranch.Width = 250;
            // 
            // colBranchesCount
            // 
            this.colBranchesCount.DataPropertyName = "BranchesCount";
            this.colBranchesCount.HeaderText = "Branches Count";
            this.colBranchesCount.MinimumWidth = 6;
            this.colBranchesCount.Name = "colBranchesCount";
            this.colBranchesCount.ReadOnly = true;
            this.colBranchesCount.Width = 120;
            // 
            // colUp
            // 
            this.colUp.DataPropertyName = "PendingUp";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUp.DefaultCellStyle = dataGridViewCellStyle1;
            this.colUp.HeaderText = "Pending Up";
            this.colUp.MinimumWidth = 6;
            this.colUp.Name = "colUp";
            this.colUp.ReadOnly = true;
            this.colUp.Width = 60;
            // 
            // colDown
            // 
            this.colDown.DataPropertyName = "PendingDown";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDown.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDown.HeaderText = "Pending Down";
            this.colDown.MinimumWidth = 6;
            this.colDown.Name = "colDown";
            this.colDown.ReadOnly = true;
            this.colDown.Width = 60;
            // 
            // colDifs
            // 
            this.colDifs.DataPropertyName = "Difs";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDifs.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDifs.HeaderText = "Difs";
            this.colDifs.MinimumWidth = 6;
            this.colDifs.Name = "colDifs";
            this.colDifs.ReadOnly = true;
            this.colDifs.Width = 60;
            // 
            // colOtherBranchesDifs
            // 
            this.colOtherBranchesDifs.DataPropertyName = "OthersBranchesDifs";
            this.colOtherBranchesDifs.HeaderText = "Other Branches Pending";
            this.colOtherBranchesDifs.MinimumWidth = 6;
            this.colOtherBranchesDifs.Name = "colOtherBranchesDifs";
            this.colOtherBranchesDifs.ReadOnly = true;
            this.colOtherBranchesDifs.Width = 150;
            // 
            // colLastFetch
            // 
            this.colLastFetch.DataPropertyName = "LastFetchTS";
            this.colLastFetch.HeaderText = "Last Fetch";
            this.colLastFetch.MinimumWidth = 6;
            this.colLastFetch.Name = "colLastFetch";
            this.colLastFetch.ReadOnly = true;
            this.colLastFetch.Width = 120;
            // 
            // colOperation
            // 
            this.colOperation.DataPropertyName = "CurrentOperation";
            this.colOperation.HeaderText = "Operation";
            this.colOperation.MinimumWidth = 6;
            this.colOperation.Name = "colOperation";
            this.colOperation.ReadOnly = true;
            this.colOperation.Width = 125;
            // 
            // colMasterCompare
            // 
            this.colMasterCompare.DataPropertyName = "MasterBranchCompare";
            this.colMasterCompare.HeaderText = "Master Branch Compare";
            this.colMasterCompare.MinimumWidth = 6;
            this.colMasterCompare.Name = "colMasterCompare";
            this.colMasterCompare.ReadOnly = true;
            this.colMasterCompare.Width = 150;
            // 
            // edLog
            // 
            this.edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLog.HideSelection = false;
            this.edLog.Location = new System.Drawing.Point(0, 400);
            this.edLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edLog.Name = "edLog";
            this.edLog.ReadOnly = true;
            this.edLog.Size = new System.Drawing.Size(1622, 438);
            this.edLog.TabIndex = 1;
            this.edLog.Text = "";
            // 
            // toolBar
            // 
            this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnFetchAll,
            this.toolStripSeparator1,
            this.btnCreateBranch,
            this.btnDeleteBranch,
            this.btnCheckoutRemote,
            this.btnSwitchBranch,
            this.toolStripSeparator3,
            this.btnFetch,
            this.btnPull,
            this.btnCommit,
            this.btnCherryPick,
            this.btnMerge,
            this.btnSyncWithMaster,
            this.btnCancelOperation,
            this.btnPush,
            this.toolStripSeparator2,
            this.btnShell,
            this.btnRepoConfig,
            this.btnClearLog});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowItemToolTips = false;
            this.toolBar.Size = new System.Drawing.Size(1622, 51);
            this.toolBar.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 48);
            this.btnRefresh.Text = "Refresh All";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFetchAll
            // 
            this.btnFetchAll.Image = ((System.Drawing.Image)(resources.GetObject("btnFetchAll.Image")));
            this.btnFetchAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFetchAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFetchAll.Name = "btnFetchAll";
            this.btnFetchAll.Size = new System.Drawing.Size(70, 48);
            this.btnFetchAll.Text = "Fetch All";
            this.btnFetchAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFetchAll.Click += new System.EventHandler(this.btnFetchAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // btnCreateBranch
            // 
            this.btnCreateBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBranch.Image")));
            this.btnCreateBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCreateBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateBranch.Name = "btnCreateBranch";
            this.btnCreateBranch.Size = new System.Drawing.Size(92, 48);
            this.btnCreateBranch.Text = "New Branch";
            this.btnCreateBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreateBranch.Click += new System.EventHandler(this.btnCreateBranch_Click);
            // 
            // btnDeleteBranch
            // 
            this.btnDeleteBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBranch.Image")));
            this.btnDeleteBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(85, 48);
            this.btnDeleteBranch.Text = "Del Branch";
            this.btnDeleteBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteBranch.Click += new System.EventHandler(this.btnDeleteBranch_Click);
            // 
            // btnCheckoutRemote
            // 
            this.btnCheckoutRemote.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckoutRemote.Image")));
            this.btnCheckoutRemote.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCheckoutRemote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckoutRemote.Name = "btnCheckoutRemote";
            this.btnCheckoutRemote.Size = new System.Drawing.Size(74, 48);
            this.btnCheckoutRemote.Text = "Checkout";
            this.btnCheckoutRemote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckoutRemote.Click += new System.EventHandler(this.btnCheckoutRemote_Click);
            // 
            // btnSwitchBranch
            // 
            this.btnSwitchBranch.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchBranch.Image")));
            this.btnSwitchBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSwitchBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSwitchBranch.Name = "btnSwitchBranch";
            this.btnSwitchBranch.Size = new System.Drawing.Size(56, 48);
            this.btnSwitchBranch.Text = "Switch";
            this.btnSwitchBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSwitchBranch.Click += new System.EventHandler(this.btnSwitchBranch_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 51);
            // 
            // btnFetch
            // 
            this.btnFetch.Image = ((System.Drawing.Image)(resources.GetObject("btnFetch.Image")));
            this.btnFetch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFetch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(48, 48);
            this.btnFetch.Text = "Fetch";
            this.btnFetch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnPull
            // 
            this.btnPull.Image = ((System.Drawing.Image)(resources.GetObject("btnPull.Image")));
            this.btnPull.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(37, 48);
            this.btnPull.Text = "Pull";
            this.btnPull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.Image")));
            this.btnCommit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(66, 48);
            this.btnCommit.Text = "Commit";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCherryPick
            // 
            this.btnCherryPick.Image = ((System.Drawing.Image)(resources.GetObject("btnCherryPick.Image")));
            this.btnCherryPick.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCherryPick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCherryPick.Name = "btnCherryPick";
            this.btnCherryPick.Size = new System.Drawing.Size(85, 48);
            this.btnCherryPick.Text = "Cherry Pick";
            this.btnCherryPick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCherryPick.Click += new System.EventHandler(this.btnCherryPick_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Image = ((System.Drawing.Image)(resources.GetObject("btnMerge.Image")));
            this.btnMerge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMerge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(56, 48);
            this.btnMerge.Text = "Merge";
            this.btnMerge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnSyncWithMaster
            // 
            this.btnSyncWithMaster.Image = ((System.Drawing.Image)(resources.GetObject("btnSyncWithMaster.Image")));
            this.btnSyncWithMaster.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSyncWithMaster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSyncWithMaster.Name = "btnSyncWithMaster";
            this.btnSyncWithMaster.Size = new System.Drawing.Size(43, 48);
            this.btnSyncWithMaster.Text = "Sync";
            this.btnSyncWithMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSyncWithMaster.Click += new System.EventHandler(this.btnSyncWithMaster_Click);
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelOperation.Image")));
            this.btnCancelOperation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelOperation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(81, 48);
            this.btnCancelOperation.Text = "Cancel Op";
            this.btnCancelOperation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnPush
            // 
            this.btnPush.Image = ((System.Drawing.Image)(resources.GetObject("btnPush.Image")));
            this.btnPush.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(43, 48);
            this.btnPush.Text = "Push";
            this.btnPush.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // btnShell
            // 
            this.btnShell.Image = ((System.Drawing.Image)(resources.GetObject("btnShell.Image")));
            this.btnShell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(45, 48);
            this.btnShell.Text = "Shell";
            this.btnShell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnRepoConfig
            // 
            this.btnRepoConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnRepoConfig.Image")));
            this.btnRepoConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRepoConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRepoConfig.Name = "btnRepoConfig";
            this.btnRepoConfig.Size = new System.Drawing.Size(57, 48);
            this.btnRepoConfig.Text = "Config";
            this.btnRepoConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRepoConfig.Click += new System.EventHandler(this.btnRepoConfig_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLog.Image")));
            this.btnClearLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(76, 48);
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 392);
            this.splitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1622, 8);
            this.splitter.TabIndex = 3;
            this.splitter.TabStop = false;
            // 
            // images
            // 
            this.images.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "up.png");
            this.images.Images.SetKeyName(1, "down.png");
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stFunInfo});
            this.statusBar.Location = new System.Drawing.Point(0, 838);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusBar.Size = new System.Drawing.Size(1622, 26);
            this.statusBar.TabIndex = 5;
            // 
            // stFunInfo
            // 
            this.stFunInfo.Image = ((System.Drawing.Image)(resources.GetObject("stFunInfo.Image")));
            this.stFunInfo.Name = "stFunInfo";
            this.stFunInfo.Size = new System.Drawing.Size(241, 20);
            this.stFunInfo.Text = "I see your work will be amazing!";
            // 
            // FrmRepos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 864);
            this.Controls.Add(this.edLog);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.g);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRepos";
            this.Text = "Git Repositories - Digao Desk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRepos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRepos_FormClosed);
            this.Load += new System.EventHandler(this.FrmRepos_Load);
            this.Shown += new System.EventHandler(this.FrmRepos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView g;
        private DigaoDeskApp.RichTextBoxEx edLog;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnPull;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.ToolStripButton btnFetch;
        private System.Windows.Forms.ToolStripButton btnClearLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSwitchBranch;
        private System.Windows.Forms.ToolStripButton btnCheckoutRemote;
        private System.Windows.Forms.ToolStripButton btnFetchAll;
        private System.Windows.Forms.ToolStripButton btnCommit;
        private System.Windows.Forms.ToolStripButton btnDeleteBranch;
        private System.Windows.Forms.ToolStripButton btnShell;
        private System.Windows.Forms.ToolStripButton btnCreateBranch;
        private System.Windows.Forms.ToolStripButton btnCherryPick;
        private System.Windows.Forms.ToolStripButton btnPush;
        private System.Windows.Forms.ToolStripButton btnCancelOperation;
        private System.Windows.Forms.ToolStripButton btnMerge;
        private System.Windows.Forms.ToolStripButton btnRepoConfig;
        private System.Windows.Forms.ToolStripButton btnSyncWithMaster;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList images;
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
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel stFunInfo;
    }
}