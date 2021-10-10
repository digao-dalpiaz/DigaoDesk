
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApps));
            this.g = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRunningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastLogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edLog = new System.Windows.Forms.RichTextBox();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearLog = new System.Windows.Forms.ToolStripButton();
            this.splitter = new System.Windows.Forms.Splitter();
            this.timerMonitor = new System.Windows.Forms.Timer(this.components);
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
            this.colStatus,
            this.colStartTime,
            this.colRunningTime,
            this.colMemory,
            this.colProcessor,
            this.colProcCount,
            this.colLastLogTime,
            this.colError});
            this.g.Dock = System.Windows.Forms.DockStyle.Top;
            this.g.Location = new System.Drawing.Point(0, 31);
            this.g.MultiSelect = false;
            this.g.Name = "g";
            this.g.ReadOnly = true;
            this.g.RowHeadersVisible = false;
            this.g.RowTemplate.Height = 25;
            this.g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g.Size = new System.Drawing.Size(1186, 150);
            this.g.TabIndex = 1;
            this.g.SelectionChanged += new System.EventHandler(this.g_SelectionChanged);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 300;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "StrRunning";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colStartTime
            // 
            this.colStartTime.DataPropertyName = "StartTime";
            this.colStartTime.HeaderText = "Start Time";
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
            this.colRunningTime.Name = "colRunningTime";
            this.colRunningTime.ReadOnly = true;
            // 
            // colMemory
            // 
            this.colMemory.DataPropertyName = "Memory";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMemory.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMemory.HeaderText = "Memory";
            this.colMemory.Name = "colMemory";
            this.colMemory.ReadOnly = true;
            // 
            // colProcessor
            // 
            this.colProcessor.DataPropertyName = "Processor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProcessor.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProcessor.HeaderText = "Processor";
            this.colProcessor.Name = "colProcessor";
            this.colProcessor.ReadOnly = true;
            // 
            // colProcCount
            // 
            this.colProcCount.DataPropertyName = "ProcCount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProcCount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colProcCount.HeaderText = "Thread Count";
            this.colProcCount.Name = "colProcCount";
            this.colProcCount.ReadOnly = true;
            // 
            // colLastLogTime
            // 
            this.colLastLogTime.DataPropertyName = "LastLogTime";
            this.colLastLogTime.HeaderText = "Last Log Time";
            this.colLastLogTime.Name = "colLastLogTime";
            this.colLastLogTime.ReadOnly = true;
            this.colLastLogTime.Width = 120;
            // 
            // colError
            // 
            this.colError.DataPropertyName = "HasError";
            this.colError.HeaderText = "Log Health";
            this.colError.Name = "colError";
            this.colError.ReadOnly = true;
            // 
            // edLog
            // 
            this.edLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edLog.HideSelection = false;
            this.edLog.Location = new System.Drawing.Point(0, 184);
            this.edLog.Name = "edLog";
            this.edLog.ReadOnly = true;
            this.edLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.edLog.Size = new System.Drawing.Size(1186, 266);
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
            this.toolStripSeparator1,
            this.btnStart,
            this.btnStop,
            this.toolStripSeparator2,
            this.btnClearLog});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowItemToolTips = false;
            this.toolBar.Size = new System.Drawing.Size(1186, 31);
            this.toolBar.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 28);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 28);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 28);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(59, 28);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(59, 28);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 181);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1186, 3);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            // 
            // timerMonitor
            // 
            this.timerMonitor.Enabled = true;
            this.timerMonitor.Interval = 2000;
            this.timerMonitor.Tick += new System.EventHandler(this.timerMonitor_Tick);
            // 
            // FrmApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.edLog);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.g);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Applications";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmApps_FormClosed);
            this.Load += new System.EventHandler(this.FrmApps_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRunningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastLogTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colError;
    }
}