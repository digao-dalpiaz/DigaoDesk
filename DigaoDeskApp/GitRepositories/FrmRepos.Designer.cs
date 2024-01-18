
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepos));
            g = new System.Windows.Forms.DataGridView();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBranchesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDifs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOtherBranchesDifs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLastFetch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMasterCompare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            edLog = new RichTextBoxEx();
            toolBar = new System.Windows.Forms.ToolStrip();
            btnRefresh = new System.Windows.Forms.ToolStripButton();
            btnFetchAll = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnCreateBranch = new System.Windows.Forms.ToolStripButton();
            btnDeleteBranch = new System.Windows.Forms.ToolStripButton();
            btnCheckoutRemote = new System.Windows.Forms.ToolStripButton();
            btnSwitchBranch = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            btnFetch = new System.Windows.Forms.ToolStripButton();
            btnPull = new System.Windows.Forms.ToolStripButton();
            btnCommit = new System.Windows.Forms.ToolStripButton();
            btnCherryPick = new System.Windows.Forms.ToolStripButton();
            btnMerge = new System.Windows.Forms.ToolStripButton();
            btnSyncWithMaster = new System.Windows.Forms.ToolStripButton();
            btnCancelOperation = new System.Windows.Forms.ToolStripButton();
            btnPush = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            btnShell = new System.Windows.Forms.ToolStripDropDownButton();
            btnConfig = new System.Windows.Forms.ToolStripDropDownButton();
            btnRepositorySettings = new System.Windows.Forms.ToolStripMenuItem();
            btnReorderList = new System.Windows.Forms.ToolStripMenuItem();
            btnClearLog = new System.Windows.Forms.ToolStripButton();
            splitter = new System.Windows.Forms.Splitter();
            statusBar = new System.Windows.Forms.StatusStrip();
            stFunInfo = new System.Windows.Forms.ToolStripStatusLabel();
            menuGroup = new System.Windows.Forms.ToolStripDropDownButton();
            stRepositories = new System.Windows.Forms.ToolStripStatusLabel();
            menuLogManager = new System.Windows.Forms.ToolStripDropDownButton();
            btnCurrentLogFileSize = new System.Windows.Forms.ToolStripMenuItem();
            btnOpenCurrentLogFile = new System.Windows.Forms.ToolStripMenuItem();
            btnDeleteLogFile = new System.Windows.Forms.ToolStripMenuItem();
            stDoing = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)g).BeginInit();
            toolBar.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // g
            // 
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.BorderStyle = System.Windows.Forms.BorderStyle.None;
            g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            g.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colName, colBranch, colBranchesCount, colUp, colDown, colDifs, colOtherBranchesDifs, colLastFetch, colOperation, colMasterCompare });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            g.DefaultCellStyle = dataGridViewCellStyle4;
            g.Dock = System.Windows.Forms.DockStyle.Top;
            g.Location = new System.Drawing.Point(0, 51);
            g.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            g.Name = "g";
            g.ReadOnly = true;
            g.RowHeadersVisible = false;
            g.RowHeadersWidth = 51;
            g.RowTemplate.Height = 25;
            g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            g.Size = new System.Drawing.Size(1622, 341);
            g.StandardTab = true;
            g.TabIndex = 0;
            g.CellFormatting += g_CellFormatting;
            g.CellPainting += g_CellPainting;
            g.SelectionChanged += g_SelectionChanged;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 250;
            // 
            // colBranch
            // 
            colBranch.DataPropertyName = "Branch";
            colBranch.HeaderText = "Current Branch";
            colBranch.MinimumWidth = 6;
            colBranch.Name = "colBranch";
            colBranch.ReadOnly = true;
            colBranch.Width = 250;
            // 
            // colBranchesCount
            // 
            colBranchesCount.DataPropertyName = "BranchesCount";
            colBranchesCount.HeaderText = "Branches Count";
            colBranchesCount.MinimumWidth = 6;
            colBranchesCount.Name = "colBranchesCount";
            colBranchesCount.ReadOnly = true;
            colBranchesCount.Width = 150;
            // 
            // colUp
            // 
            colUp.DataPropertyName = "PendingUp";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colUp.DefaultCellStyle = dataGridViewCellStyle1;
            colUp.HeaderText = "Pending Up";
            colUp.MinimumWidth = 6;
            colUp.Name = "colUp";
            colUp.ReadOnly = true;
            colUp.Width = 80;
            // 
            // colDown
            // 
            colDown.DataPropertyName = "PendingDown";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colDown.DefaultCellStyle = dataGridViewCellStyle2;
            colDown.HeaderText = "Pending Down";
            colDown.MinimumWidth = 6;
            colDown.Name = "colDown";
            colDown.ReadOnly = true;
            colDown.Width = 80;
            // 
            // colDifs
            // 
            colDifs.DataPropertyName = "Difs";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colDifs.DefaultCellStyle = dataGridViewCellStyle3;
            colDifs.HeaderText = "Difs";
            colDifs.MinimumWidth = 6;
            colDifs.Name = "colDifs";
            colDifs.ReadOnly = true;
            colDifs.Width = 60;
            // 
            // colOtherBranchesDifs
            // 
            colOtherBranchesDifs.DataPropertyName = "OthersBranchesDifs";
            colOtherBranchesDifs.HeaderText = "Other Branches Pending";
            colOtherBranchesDifs.MinimumWidth = 6;
            colOtherBranchesDifs.Name = "colOtherBranchesDifs";
            colOtherBranchesDifs.ReadOnly = true;
            colOtherBranchesDifs.Width = 150;
            // 
            // colLastFetch
            // 
            colLastFetch.DataPropertyName = "LastFetchTS";
            colLastFetch.HeaderText = "Last Fetch";
            colLastFetch.MinimumWidth = 6;
            colLastFetch.Name = "colLastFetch";
            colLastFetch.ReadOnly = true;
            colLastFetch.Width = 150;
            // 
            // colOperation
            // 
            colOperation.DataPropertyName = "CurrentOperation";
            colOperation.HeaderText = "Operation";
            colOperation.MinimumWidth = 6;
            colOperation.Name = "colOperation";
            colOperation.ReadOnly = true;
            colOperation.Width = 125;
            // 
            // colMasterCompare
            // 
            colMasterCompare.DataPropertyName = "MasterBranchCompare";
            colMasterCompare.HeaderText = "Master Branch Compare";
            colMasterCompare.MinimumWidth = 6;
            colMasterCompare.Name = "colMasterCompare";
            colMasterCompare.ReadOnly = true;
            colMasterCompare.Width = 150;
            // 
            // edLog
            // 
            edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            edLog.HideSelection = false;
            edLog.Location = new System.Drawing.Point(0, 400);
            edLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            edLog.Name = "edLog";
            edLog.ReadOnly = true;
            edLog.Size = new System.Drawing.Size(1622, 438);
            edLog.TabIndex = 1;
            edLog.Text = "";
            // 
            // toolBar
            // 
            toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnRefresh, btnFetchAll, toolStripSeparator1, btnCreateBranch, btnDeleteBranch, btnCheckoutRemote, btnSwitchBranch, toolStripSeparator3, btnFetch, btnPull, btnCommit, btnCherryPick, btnMerge, btnSyncWithMaster, btnCancelOperation, btnPush, toolStripSeparator2, btnShell, btnConfig, btnClearLog });
            toolBar.Location = new System.Drawing.Point(0, 0);
            toolBar.Name = "toolBar";
            toolBar.ShowItemToolTips = false;
            toolBar.Size = new System.Drawing.Size(1622, 51);
            toolBar.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.repos_refresh;
            btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(84, 48);
            btnRefresh.Text = "Refresh All";
            btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFetchAll
            // 
            btnFetchAll.Image = Properties.Resources.repos_fetch_all;
            btnFetchAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnFetchAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnFetchAll.Name = "btnFetchAll";
            btnFetchAll.Size = new System.Drawing.Size(70, 48);
            btnFetchAll.Text = "Fetch All";
            btnFetchAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnFetchAll.Click += btnFetchAll_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // btnCreateBranch
            // 
            btnCreateBranch.Image = Properties.Resources.repos_new_branch;
            btnCreateBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCreateBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCreateBranch.Name = "btnCreateBranch";
            btnCreateBranch.Size = new System.Drawing.Size(92, 48);
            btnCreateBranch.Text = "New Branch";
            btnCreateBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCreateBranch.Click += btnCreateBranch_Click;
            // 
            // btnDeleteBranch
            // 
            btnDeleteBranch.Image = Properties.Resources.repos_del_branch;
            btnDeleteBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteBranch.Name = "btnDeleteBranch";
            btnDeleteBranch.Size = new System.Drawing.Size(85, 48);
            btnDeleteBranch.Text = "Del Branch";
            btnDeleteBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteBranch.Click += btnDeleteBranch_Click;
            // 
            // btnCheckoutRemote
            // 
            btnCheckoutRemote.Image = Properties.Resources.repos_checkout;
            btnCheckoutRemote.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCheckoutRemote.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCheckoutRemote.Name = "btnCheckoutRemote";
            btnCheckoutRemote.Size = new System.Drawing.Size(74, 48);
            btnCheckoutRemote.Text = "Checkout";
            btnCheckoutRemote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCheckoutRemote.Click += btnCheckoutRemote_Click;
            // 
            // btnSwitchBranch
            // 
            btnSwitchBranch.Image = Properties.Resources.repos_switch_branch;
            btnSwitchBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSwitchBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSwitchBranch.Name = "btnSwitchBranch";
            btnSwitchBranch.Size = new System.Drawing.Size(56, 48);
            btnSwitchBranch.Text = "Switch";
            btnSwitchBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSwitchBranch.Click += btnSwitchBranch_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 51);
            // 
            // btnFetch
            // 
            btnFetch.Image = Properties.Resources.repos_fetch;
            btnFetch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnFetch.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new System.Drawing.Size(48, 48);
            btnFetch.Text = "Fetch";
            btnFetch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnFetch.Click += btnFetch_Click;
            // 
            // btnPull
            // 
            btnPull.Image = Properties.Resources.repos_pull;
            btnPull.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPull.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPull.Name = "btnPull";
            btnPull.Size = new System.Drawing.Size(37, 48);
            btnPull.Text = "Pull";
            btnPull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPull.Click += btnPull_Click;
            // 
            // btnCommit
            // 
            btnCommit.Image = Properties.Resources.repos_commit;
            btnCommit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new System.Drawing.Size(66, 48);
            btnCommit.Text = "Commit";
            btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCommit.Click += btnCommit_Click;
            // 
            // btnCherryPick
            // 
            btnCherryPick.Image = Properties.Resources.repos_cherrypick;
            btnCherryPick.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCherryPick.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCherryPick.Name = "btnCherryPick";
            btnCherryPick.Size = new System.Drawing.Size(85, 48);
            btnCherryPick.Text = "Cherry Pick";
            btnCherryPick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCherryPick.Click += btnCherryPick_Click;
            // 
            // btnMerge
            // 
            btnMerge.Image = Properties.Resources.repos_merge;
            btnMerge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnMerge.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new System.Drawing.Size(56, 48);
            btnMerge.Text = "Merge";
            btnMerge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnMerge.Click += btnMerge_Click;
            // 
            // btnSyncWithMaster
            // 
            btnSyncWithMaster.Image = Properties.Resources.repos_sync_with_master;
            btnSyncWithMaster.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSyncWithMaster.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSyncWithMaster.Name = "btnSyncWithMaster";
            btnSyncWithMaster.Size = new System.Drawing.Size(43, 48);
            btnSyncWithMaster.Text = "Sync";
            btnSyncWithMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSyncWithMaster.Click += btnSyncWithMaster_Click;
            // 
            // btnCancelOperation
            // 
            btnCancelOperation.Image = Properties.Resources.repos_cancel_op;
            btnCancelOperation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCancelOperation.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCancelOperation.Name = "btnCancelOperation";
            btnCancelOperation.Size = new System.Drawing.Size(81, 48);
            btnCancelOperation.Text = "Cancel Op";
            btnCancelOperation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCancelOperation.Click += btnCancelOperation_Click;
            // 
            // btnPush
            // 
            btnPush.Image = Properties.Resources.repos_push;
            btnPush.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPush.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPush.Name = "btnPush";
            btnPush.Size = new System.Drawing.Size(43, 48);
            btnPush.Text = "Push";
            btnPush.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPush.Click += btnPush_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // btnShell
            // 
            btnShell.Image = Properties.Resources.repos_shell;
            btnShell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnShell.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnShell.Name = "btnShell";
            btnShell.Size = new System.Drawing.Size(55, 48);
            btnShell.Text = "Shell";
            btnShell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnShell.Click += btnShell_Click;
            // 
            // btnConfig
            // 
            btnConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnRepositorySettings, btnReorderList });
            btnConfig.Image = Properties.Resources.repos_config;
            btnConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new System.Drawing.Size(67, 48);
            btnConfig.Text = "Config";
            btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRepositorySettings
            // 
            btnRepositorySettings.Image = Properties.Resources.repos_settings;
            btnRepositorySettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnRepositorySettings.Name = "btnRepositorySettings";
            btnRepositorySettings.Size = new System.Drawing.Size(224, 30);
            btnRepositorySettings.Text = "Repository Settings";
            btnRepositorySettings.Click += btnRepositorySettings_Click;
            // 
            // btnReorderList
            // 
            btnReorderList.Image = Properties.Resources.repos_reorder;
            btnReorderList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReorderList.Name = "btnReorderList";
            btnReorderList.Size = new System.Drawing.Size(224, 30);
            btnReorderList.Text = "Reorder List";
            btnReorderList.Click += btnReorderList_Click;
            // 
            // btnClearLog
            // 
            btnClearLog.Image = Properties.Resources.repos_clear_log;
            btnClearLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new System.Drawing.Size(76, 48);
            btnClearLog.Text = "Clear Log";
            btnClearLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // splitter
            // 
            splitter.Dock = System.Windows.Forms.DockStyle.Top;
            splitter.Location = new System.Drawing.Point(0, 392);
            splitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            splitter.Name = "splitter";
            splitter.Size = new System.Drawing.Size(1622, 8);
            splitter.TabIndex = 3;
            splitter.TabStop = false;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { stFunInfo, menuGroup, stRepositories, menuLogManager, stDoing });
            statusBar.Location = new System.Drawing.Point(0, 838);
            statusBar.Name = "statusBar";
            statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusBar.Size = new System.Drawing.Size(1622, 26);
            statusBar.TabIndex = 5;
            // 
            // stFunInfo
            // 
            stFunInfo.Image = Properties.Resources.bar_emoji;
            stFunInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            stFunInfo.Margin = new System.Windows.Forms.Padding(0, 4, 10, 2);
            stFunInfo.Name = "stFunInfo";
            stFunInfo.Size = new System.Drawing.Size(237, 20);
            stFunInfo.Text = "I see your work will be amazing!";
            // 
            // menuGroup
            // 
            menuGroup.Image = Properties.Resources.repos_menu_group;
            menuGroup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            menuGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            menuGroup.Margin = new System.Windows.Forms.Padding(0, 2, 10, 0);
            menuGroup.Name = "menuGroup";
            menuGroup.Size = new System.Drawing.Size(166, 24);
            menuGroup.Text = "Repositories Group";
            // 
            // stRepositories
            // 
            stRepositories.Image = Properties.Resources.repos_repositories_menu;
            stRepositories.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            stRepositories.Margin = new System.Windows.Forms.Padding(0, 4, 10, 2);
            stRepositories.Name = "stRepositories";
            stRepositories.Size = new System.Drawing.Size(107, 20);
            stRepositories.Text = "Repositories";
            // 
            // menuLogManager
            // 
            menuLogManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnCurrentLogFileSize, btnOpenCurrentLogFile, btnDeleteLogFile });
            menuLogManager.Image = Properties.Resources.repos_menu_log_manager;
            menuLogManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            menuLogManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            menuLogManager.Margin = new System.Windows.Forms.Padding(0, 2, 10, 0);
            menuLogManager.Name = "menuLogManager";
            menuLogManager.Size = new System.Drawing.Size(127, 24);
            menuLogManager.Text = "Log Manager";
            menuLogManager.DropDownOpening += menuLogManager_DropDownOpening;
            // 
            // btnCurrentLogFileSize
            // 
            btnCurrentLogFileSize.Enabled = false;
            btnCurrentLogFileSize.Name = "btnCurrentLogFileSize";
            btnCurrentLogFileSize.Size = new System.Drawing.Size(240, 30);
            btnCurrentLogFileSize.Text = "File Size";
            // 
            // btnOpenCurrentLogFile
            // 
            btnOpenCurrentLogFile.Image = Properties.Resources.repos_open_log_file;
            btnOpenCurrentLogFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnOpenCurrentLogFile.Name = "btnOpenCurrentLogFile";
            btnOpenCurrentLogFile.Size = new System.Drawing.Size(240, 30);
            btnOpenCurrentLogFile.Text = "Open Current Log File";
            btnOpenCurrentLogFile.Click += btnOpenCurrentLogFile_Click;
            // 
            // btnDeleteLogFile
            // 
            btnDeleteLogFile.Image = Properties.Resources.repos_del_log_file;
            btnDeleteLogFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteLogFile.Name = "btnDeleteLogFile";
            btnDeleteLogFile.Size = new System.Drawing.Size(240, 30);
            btnDeleteLogFile.Text = "Delete Log File";
            btnDeleteLogFile.Click += btnDeleteLogFile_Click;
            // 
            // stDoing
            // 
            stDoing.Image = Properties.Resources.repos_status_doing;
            stDoing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            stDoing.Margin = new System.Windows.Forms.Padding(0, 4, 10, 2);
            stDoing.Name = "stDoing";
            stDoing.Size = new System.Drawing.Size(75, 20);
            stDoing.Text = "Doing...";
            // 
            // FrmRepos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1622, 864);
            Controls.Add(edLog);
            Controls.Add(statusBar);
            Controls.Add(splitter);
            Controls.Add(g);
            Controls.Add(toolBar);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmRepos";
            Text = "Git Repositories - Digao Desk";
            FormClosing += FrmRepos_FormClosing;
            FormClosed += FrmRepos_FormClosed;
            Load += FrmRepos_Load;
            Shown += FrmRepos_Shown;
            KeyDown += FrmRepos_KeyDown;
            ((System.ComponentModel.ISupportInitialize)g).EndInit();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripButton btnCreateBranch;
        private System.Windows.Forms.ToolStripButton btnCherryPick;
        private System.Windows.Forms.ToolStripButton btnPush;
        private System.Windows.Forms.ToolStripButton btnCancelOperation;
        private System.Windows.Forms.ToolStripButton btnMerge;
        private System.Windows.Forms.ToolStripButton btnSyncWithMaster;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel stFunInfo;
        private System.Windows.Forms.ToolStripDropDownButton btnShell;
        private System.Windows.Forms.ToolStripDropDownButton btnConfig;
        private System.Windows.Forms.ToolStripMenuItem btnRepositorySettings;
        private System.Windows.Forms.ToolStripMenuItem btnReorderList;
        private System.Windows.Forms.ToolStripDropDownButton menuGroup;
        private System.Windows.Forms.ToolStripStatusLabel stRepositories;
        private System.Windows.Forms.ToolStripStatusLabel stDoing;
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
        private System.Windows.Forms.ToolStripDropDownButton menuLogManager;
        private System.Windows.Forms.ToolStripMenuItem btnOpenCurrentLogFile;
        private System.Windows.Forms.ToolStripMenuItem btnCurrentLogFileSize;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteLogFile;
    }
}