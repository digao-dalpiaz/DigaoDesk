
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApps));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.g = new System.Windows.Forms.DataGridView();
            this.edLog = new DigaoDeskApp.RichTextBoxEx();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilter = new System.Windows.Forms.ToolStripDropDownButton();
            this.miFilterAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilterRunning = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilterStopped = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnStopAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFindLog = new System.Windows.Forms.ToolStripButton();
            this.btnClearLog = new System.Windows.Forms.ToolStripButton();
            this.splitter = new System.Windows.Forms.Splitter();
            this.timerMonitor = new System.Windows.Forms.Timer(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.stFunInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.stMonitoring = new System.Windows.Forms.ToolStripStatusLabel();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRunningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastLogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogStatistics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHttpStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colStatus,
            this.colStartTime,
            this.colRunningTime,
            this.colMemory,
            this.colProcessor,
            this.colProcCount,
            this.colLastLogTime,
            this.colLogStatistics,
            this.colLogHealth,
            this.colHttpStatus});
            this.g.Dock = System.Windows.Forms.DockStyle.Top;
            this.g.Location = new System.Drawing.Point(0, 39);
            this.g.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.g.MultiSelect = false;
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowHeadersWidth = 51;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(1355, 200);
            this.g.TabIndex = 1;
            this.g.SelectionChanged += new System.EventHandler(this.g_SelectionChanged);
            // 
            // edLog
            // 
            this.edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLog.HideSelection = false;
            this.edLog.Location = new System.Drawing.Point(0, 247);
            this.edLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edLog.Name = "edLog";
            this.edLog.ReadOnly = true;
            this.edLog.Size = new System.Drawing.Size(1355, 327);
            this.edLog.TabIndex = 3;
            this.edLog.Text = "";
            // 
            // toolBar
            // 
            this.toolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnFilter,
            this.toolStripSeparator1,
            this.btnStart,
            this.btnStop,
            this.btnStopAll,
            this.toolStripSeparator2,
            this.btnFindLog,
            this.btnClearLog});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowItemToolTips = false;
            this.toolBar.Size = new System.Drawing.Size(1355, 39);
            this.toolBar.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 36);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 36);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 36);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnFilter
            // 
            this.btnFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFilterAll,
            this.miFilterRunning,
            this.miFilterStopped});
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(88, 36);
            this.btnFilter.Text = "Filter";
            // 
            // miFilterAll
            // 
            this.miFilterAll.Checked = true;
            this.miFilterAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miFilterAll.Name = "miFilterAll";
            this.miFilterAll.Size = new System.Drawing.Size(197, 26);
            this.miFilterAll.Text = "All Applications";
            this.miFilterAll.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // miFilterRunning
            // 
            this.miFilterRunning.Name = "miFilterRunning";
            this.miFilterRunning.Size = new System.Drawing.Size(197, 26);
            this.miFilterRunning.Text = "Only Running";
            this.miFilterRunning.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // miFilterStopped
            // 
            this.miFilterStopped.Name = "miFilterStopped";
            this.miFilterStopped.Size = new System.Drawing.Size(197, 26);
            this.miFilterStopped.Text = "Only Stopped";
            this.miFilterStopped.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 36);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(76, 36);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.Image = ((System.Drawing.Image)(resources.GetObject("btnStopAll.Image")));
            this.btnStopAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(98, 36);
            this.btnStopAll.Text = "Stop All";
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnFindLog
            // 
            this.btnFindLog.Image = ((System.Drawing.Image)(resources.GetObject("btnFindLog.Image")));
            this.btnFindLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFindLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFindLog.Name = "btnFindLog";
            this.btnFindLog.Size = new System.Drawing.Size(118, 36);
            this.btnFindLog.Text = "Find in Log";
            this.btnFindLog.Click += new System.EventHandler(this.btnFindLog_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLog.Image")));
            this.btnClearLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(108, 36);
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 239);
            this.splitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1355, 8);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            // 
            // timerMonitor
            // 
            this.timerMonitor.Enabled = true;
            this.timerMonitor.Interval = 2000;
            this.timerMonitor.Tick += new System.EventHandler(this.timerMonitor_Tick);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stFunInfo,
            this.stMonitoring});
            this.statusBar.Location = new System.Drawing.Point(0, 574);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusBar.Size = new System.Drawing.Size(1355, 26);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // stFunInfo
            // 
            this.stFunInfo.Image = ((System.Drawing.Image)(resources.GetObject("stFunInfo.Image")));
            this.stFunInfo.Name = "stFunInfo";
            this.stFunInfo.Size = new System.Drawing.Size(374, 20);
            this.stFunInfo.Text = "Have a coffee! I am taking care of your applications.";
            // 
            // stMonitoring
            // 
            this.stMonitoring.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stMonitoring.ForeColor = System.Drawing.Color.Tomato;
            this.stMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("stMonitoring.Image")));
            this.stMonitoring.Name = "stMonitoring";
            this.stMonitoring.Size = new System.Drawing.Size(104, 20);
            this.stMonitoring.Text = "Scanning...";
            this.stMonitoring.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 300;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 80;
            // 
            // colStartTime
            // 
            this.colStartTime.DataPropertyName = "StartTime";
            this.colStartTime.HeaderText = "Start Time";
            this.colStartTime.MinimumWidth = 6;
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            this.colStartTime.Width = 120;
            // 
            // colRunningTime
            // 
            this.colRunningTime.DataPropertyName = "RunningTime";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRunningTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRunningTime.HeaderText = "Running Time";
            this.colRunningTime.MinimumWidth = 6;
            this.colRunningTime.Name = "colRunningTime";
            this.colRunningTime.ReadOnly = true;
            this.colRunningTime.Width = 80;
            // 
            // colMemory
            // 
            this.colMemory.DataPropertyName = "Memory";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMemory.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMemory.HeaderText = "Memory";
            this.colMemory.MinimumWidth = 6;
            this.colMemory.Name = "colMemory";
            this.colMemory.ReadOnly = true;
            this.colMemory.Width = 80;
            // 
            // colProcessor
            // 
            this.colProcessor.DataPropertyName = "Processor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProcessor.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProcessor.HeaderText = "Processor";
            this.colProcessor.MinimumWidth = 6;
            this.colProcessor.Name = "colProcessor";
            this.colProcessor.ReadOnly = true;
            this.colProcessor.Width = 80;
            // 
            // colProcCount
            // 
            this.colProcCount.DataPropertyName = "ProcCount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProcCount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colProcCount.HeaderText = "Thread Count";
            this.colProcCount.MinimumWidth = 6;
            this.colProcCount.Name = "colProcCount";
            this.colProcCount.ReadOnly = true;
            this.colProcCount.Width = 80;
            // 
            // colLastLogTime
            // 
            this.colLastLogTime.DataPropertyName = "LastLogTime";
            this.colLastLogTime.HeaderText = "Last Log Time";
            this.colLastLogTime.MinimumWidth = 6;
            this.colLastLogTime.Name = "colLastLogTime";
            this.colLastLogTime.ReadOnly = true;
            this.colLastLogTime.Width = 120;
            // 
            // colLogStatistics
            // 
            this.colLogStatistics.DataPropertyName = "LogStatistics";
            this.colLogStatistics.HeaderText = "Log Statistics";
            this.colLogStatistics.MinimumWidth = 6;
            this.colLogStatistics.Name = "colLogStatistics";
            this.colLogStatistics.ReadOnly = true;
            this.colLogStatistics.Width = 80;
            // 
            // colLogHealth
            // 
            this.colLogHealth.DataPropertyName = "LogHealth";
            this.colLogHealth.HeaderText = "Log Health";
            this.colLogHealth.MinimumWidth = 6;
            this.colLogHealth.Name = "colLogHealth";
            this.colLogHealth.ReadOnly = true;
            this.colLogHealth.Width = 80;
            // 
            // colHttpStatus
            // 
            this.colHttpStatus.DataPropertyName = "HttpStatus";
            this.colHttpStatus.HeaderText = "Http Status";
            this.colHttpStatus.MinimumWidth = 6;
            this.colHttpStatus.Name = "colHttpStatus";
            this.colHttpStatus.ReadOnly = true;
            this.colHttpStatus.Width = 75;
            // 
            // FrmApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 600);
            this.Controls.Add(this.edLog);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.g);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Applications - Digao Desk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmApps_FormClosed);
            this.Load += new System.EventHandler(this.FrmApps_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmApps_KeyDown);
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
        private System.Windows.Forms.ToolStripStatusLabel stMonitoring;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHttpStatus;
    }
}