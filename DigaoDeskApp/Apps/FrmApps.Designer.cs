
namespace DigaoDeskApp
{
    partial class FrmApps
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApps));
            g = new System.Windows.Forms.DataGridView();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRunningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colProcessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colProcCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLastLogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLogLines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLogSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLogHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTcpStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            edLog = new RichTextBoxEx();
            toolBar = new System.Windows.Forms.ToolStrip();
            btnAdd = new System.Windows.Forms.ToolStripButton();
            btnEdit = new System.Windows.Forms.ToolStripButton();
            btnDelete = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            btnReorder = new System.Windows.Forms.ToolStripButton();
            btnDownloadDefs = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            btnFilter = new System.Windows.Forms.ToolStripDropDownButton();
            miFilterAll = new System.Windows.Forms.ToolStripMenuItem();
            miFilterRunning = new System.Windows.Forms.ToolStripMenuItem();
            miFilterStopped = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnStart = new System.Windows.Forms.ToolStripButton();
            btnStop = new System.Windows.Forms.ToolStripButton();
            btnStopForced = new System.Windows.Forms.ToolStripButton();
            btnStopAll = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            btnFindLog = new System.Windows.Forms.ToolStripButton();
            btnClearLog = new System.Windows.Forms.ToolStripButton();
            splitter = new System.Windows.Forms.Splitter();
            timerMonitor = new System.Windows.Forms.Timer(components);
            statusBar = new System.Windows.Forms.StatusStrip();
            stFunInfo = new System.Windows.Forms.ToolStripStatusLabel();
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
            g.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colName, colStatus, colStartTime, colRunningTime, colMemory, colProcessor, colProcCount, colLastLogTime, colLogLines, colLogSize, colLogHealth, colTcpStatus });
            g.Dock = System.Windows.Forms.DockStyle.Top;
            g.Location = new System.Drawing.Point(0, 39);
            g.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            g.MultiSelect = false;
            g.Name = "g";
            g.ReadOnly = true;
            g.RowHeadersVisible = false;
            g.RowHeadersWidth = 51;
            g.RowTemplate.Height = 25;
            g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            g.Size = new System.Drawing.Size(1355, 200);
            g.TabIndex = 1;
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
            colName.Width = 300;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 80;
            // 
            // colStartTime
            // 
            colStartTime.DataPropertyName = "StartTime";
            colStartTime.HeaderText = "Start Time";
            colStartTime.MinimumWidth = 6;
            colStartTime.Name = "colStartTime";
            colStartTime.ReadOnly = true;
            colStartTime.Width = 120;
            // 
            // colRunningTime
            // 
            colRunningTime.DataPropertyName = "RunningTime";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colRunningTime.DefaultCellStyle = dataGridViewCellStyle1;
            colRunningTime.HeaderText = "Running Time";
            colRunningTime.MinimumWidth = 6;
            colRunningTime.Name = "colRunningTime";
            colRunningTime.ReadOnly = true;
            colRunningTime.Width = 80;
            // 
            // colMemory
            // 
            colMemory.DataPropertyName = "Memory";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colMemory.DefaultCellStyle = dataGridViewCellStyle2;
            colMemory.HeaderText = "Memory";
            colMemory.MinimumWidth = 6;
            colMemory.Name = "colMemory";
            colMemory.ReadOnly = true;
            colMemory.Width = 80;
            // 
            // colProcessor
            // 
            colProcessor.DataPropertyName = "Processor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colProcessor.DefaultCellStyle = dataGridViewCellStyle3;
            colProcessor.HeaderText = "Processor";
            colProcessor.MinimumWidth = 6;
            colProcessor.Name = "colProcessor";
            colProcessor.ReadOnly = true;
            colProcessor.Width = 80;
            // 
            // colProcCount
            // 
            colProcCount.DataPropertyName = "ProcCount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colProcCount.DefaultCellStyle = dataGridViewCellStyle4;
            colProcCount.HeaderText = "Thread Count";
            colProcCount.MinimumWidth = 6;
            colProcCount.Name = "colProcCount";
            colProcCount.ReadOnly = true;
            colProcCount.Width = 80;
            // 
            // colLastLogTime
            // 
            colLastLogTime.DataPropertyName = "LastLogTime";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colLastLogTime.DefaultCellStyle = dataGridViewCellStyle5;
            colLastLogTime.HeaderText = "Last Log Time";
            colLastLogTime.MinimumWidth = 6;
            colLastLogTime.Name = "colLastLogTime";
            colLastLogTime.ReadOnly = true;
            colLastLogTime.Width = 120;
            // 
            // colLogLines
            // 
            colLogLines.DataPropertyName = "LogLines";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colLogLines.DefaultCellStyle = dataGridViewCellStyle6;
            colLogLines.HeaderText = "Log Lines";
            colLogLines.MinimumWidth = 6;
            colLogLines.Name = "colLogLines";
            colLogLines.ReadOnly = true;
            colLogLines.Width = 80;
            // 
            // colLogSize
            // 
            colLogSize.DataPropertyName = "LogSize";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colLogSize.DefaultCellStyle = dataGridViewCellStyle7;
            colLogSize.HeaderText = "Log Size";
            colLogSize.MinimumWidth = 6;
            colLogSize.Name = "colLogSize";
            colLogSize.ReadOnly = true;
            colLogSize.Width = 125;
            // 
            // colLogHealth
            // 
            colLogHealth.DataPropertyName = "LogHealth";
            colLogHealth.HeaderText = "Log Health";
            colLogHealth.MinimumWidth = 6;
            colLogHealth.Name = "colLogHealth";
            colLogHealth.ReadOnly = true;
            colLogHealth.Width = 80;
            // 
            // colTcpStatus
            // 
            colTcpStatus.DataPropertyName = "TcpStatus";
            colTcpStatus.HeaderText = "TCP Status";
            colTcpStatus.MinimumWidth = 6;
            colTcpStatus.Name = "colTcpStatus";
            colTcpStatus.ReadOnly = true;
            colTcpStatus.Width = 75;
            // 
            // edLog
            // 
            edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            edLog.DetectUrls = false;
            edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            edLog.HideSelection = false;
            edLog.Location = new System.Drawing.Point(0, 247);
            edLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            edLog.Name = "edLog";
            edLog.ReadOnly = true;
            edLog.Size = new System.Drawing.Size(1355, 327);
            edLog.TabIndex = 3;
            edLog.Text = "";
            // 
            // toolBar
            // 
            toolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAdd, btnEdit, btnDelete, toolStripSeparator4, btnReorder, btnDownloadDefs, toolStripSeparator3, btnFilter, toolStripSeparator1, btnStart, btnStop, btnStopForced, btnStopAll, toolStripSeparator2, btnFindLog, btnClearLog });
            toolBar.Location = new System.Drawing.Point(0, 0);
            toolBar.Name = "toolBar";
            toolBar.ShowItemToolTips = false;
            toolBar.Size = new System.Drawing.Size(1355, 39);
            toolBar.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.app_add;
            btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(73, 36);
            btnAdd.Text = "Add";
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.app_edit;
            btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(71, 36);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.app_del;
            btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(89, 36);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // btnReorder
            // 
            btnReorder.Image = Properties.Resources.app_reorder;
            btnReorder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReorder.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReorder.Name = "btnReorder";
            btnReorder.Size = new System.Drawing.Size(98, 36);
            btnReorder.Text = "Reorder";
            btnReorder.Click += btnReorder_Click;
            // 
            // btnDownloadDefs
            // 
            btnDownloadDefs.Image = Properties.Resources.app_dowload_defs;
            btnDownloadDefs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDownloadDefs.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDownloadDefs.Name = "btnDownloadDefs";
            btnDownloadDefs.Size = new System.Drawing.Size(148, 36);
            btnDownloadDefs.Text = "Download Defs";
            btnDownloadDefs.Click += btnDownloadDefs_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnFilter
            // 
            btnFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miFilterAll, miFilterRunning, miFilterStopped });
            btnFilter.Image = Properties.Resources.app_filter;
            btnFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(88, 36);
            btnFilter.Text = "Filter";
            // 
            // miFilterAll
            // 
            miFilterAll.Checked = true;
            miFilterAll.CheckState = System.Windows.Forms.CheckState.Checked;
            miFilterAll.Name = "miFilterAll";
            miFilterAll.Size = new System.Drawing.Size(197, 26);
            miFilterAll.Text = "All Applications";
            miFilterAll.Click += ApplyFilter;
            // 
            // miFilterRunning
            // 
            miFilterRunning.Name = "miFilterRunning";
            miFilterRunning.Size = new System.Drawing.Size(197, 26);
            miFilterRunning.Text = "Only Running";
            miFilterRunning.Click += ApplyFilter;
            // 
            // miFilterStopped
            // 
            miFilterStopped.Name = "miFilterStopped";
            miFilterStopped.Size = new System.Drawing.Size(197, 26);
            miFilterStopped.Text = "Only Stopped";
            miFilterStopped.Click += ApplyFilter;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnStart
            // 
            btnStart.Image = Properties.Resources.app_start;
            btnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(76, 36);
            btnStart.Text = "Start";
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Image = Properties.Resources.app_stop;
            btnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(76, 36);
            btnStop.Text = "Stop";
            btnStop.Click += btnStop_Click;
            // 
            // btnStopForced
            // 
            btnStopForced.Image = Properties.Resources.app_stop_forced;
            btnStopForced.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnStopForced.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnStopForced.Name = "btnStopForced";
            btnStopForced.Size = new System.Drawing.Size(66, 36);
            btnStopForced.Text = "Kill";
            btnStopForced.Click += btnStop_Click;
            // 
            // btnStopAll
            // 
            btnStopAll.Image = Properties.Resources.app_stop_all;
            btnStopAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnStopAll.Name = "btnStopAll";
            btnStopAll.Size = new System.Drawing.Size(98, 36);
            btnStopAll.Text = "Stop All";
            btnStopAll.Click += btnStopAll_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnFindLog
            // 
            btnFindLog.Image = Properties.Resources.app_find_log;
            btnFindLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnFindLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnFindLog.Name = "btnFindLog";
            btnFindLog.Size = new System.Drawing.Size(118, 36);
            btnFindLog.Text = "Find in Log";
            btnFindLog.Click += btnFindLog_Click;
            // 
            // btnClearLog
            // 
            btnClearLog.Image = Properties.Resources.app_clear_log;
            btnClearLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new System.Drawing.Size(108, 36);
            btnClearLog.Text = "Clear Log";
            btnClearLog.Click += btnClearLog_Click;
            // 
            // splitter
            // 
            splitter.Dock = System.Windows.Forms.DockStyle.Top;
            splitter.Location = new System.Drawing.Point(0, 239);
            splitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            splitter.Name = "splitter";
            splitter.Size = new System.Drawing.Size(1355, 8);
            splitter.TabIndex = 2;
            splitter.TabStop = false;
            // 
            // timerMonitor
            // 
            timerMonitor.Enabled = true;
            timerMonitor.Interval = 2000;
            timerMonitor.Tick += timerMonitor_Tick;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { stFunInfo });
            statusBar.Location = new System.Drawing.Point(0, 574);
            statusBar.Name = "statusBar";
            statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusBar.Size = new System.Drawing.Size(1355, 26);
            statusBar.TabIndex = 4;
            statusBar.Text = "statusStrip1";
            // 
            // stFunInfo
            // 
            stFunInfo.Image = Properties.Resources.bar_emoji;
            stFunInfo.Name = "stFunInfo";
            stFunInfo.Size = new System.Drawing.Size(374, 20);
            stFunInfo.Text = "Have a coffee! I am taking care of your applications.";
            // 
            // FrmApps
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1355, 600);
            Controls.Add(edLog);
            Controls.Add(statusBar);
            Controls.Add(splitter);
            Controls.Add(g);
            Controls.Add(toolBar);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmApps";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Applications - Digao Desk";
            Activated += FrmApps_Activated;
            FormClosed += FrmApps_FormClosed;
            Load += FrmApps_Load;
            KeyDown += FrmApps_KeyDown;
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
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.ToolStripButton btnClearLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timerMonitor;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel stFunInfo;
        private System.Windows.Forms.ToolStripButton btnStopAll;
        private System.Windows.Forms.ToolStripDropDownButton btnFilter;
        private System.Windows.Forms.ToolStripMenuItem miFilterAll;
        private System.Windows.Forms.ToolStripMenuItem miFilterRunning;
        private System.Windows.Forms.ToolStripMenuItem miFilterStopped;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnFindLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRunningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastLogTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTcpStatus;
        private System.Windows.Forms.ToolStripButton btnDownloadDefs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnReorder;
        private System.Windows.Forms.ToolStripButton btnStopForced;
    }
}