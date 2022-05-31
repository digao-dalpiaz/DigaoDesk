namespace DigaoDeskApp
{
    partial class FrmCommit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommit));
            this.btnStage = new System.Windows.Forms.Button();
            this.btnUnstage = new System.Windows.Forms.Button();
            this.boxTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.boxInfo = new System.Windows.Forms.Panel();
            this.lblbRepository = new System.Windows.Forms.Label();
            this.lbBranch = new System.Windows.Forms.Label();
            this.lbRepository = new System.Windows.Forms.Label();
            this.lblbBranch = new System.Windows.Forms.Label();
            this.btnCommitAndPush = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.lstOther = new System.Windows.Forms.ListBox();
            this.lstDif = new DigaoDeskApp.CheckedListBoxEx();
            this.boxTitleUnstaged = new System.Windows.Forms.Panel();
            this.btnUndoDif = new System.Windows.Forms.Label();
            this.btnInvertDif = new System.Windows.Forms.Label();
            this.btnNoneDif = new System.Windows.Forms.Label();
            this.btnAllDif = new System.Windows.Forms.Label();
            this.lbCountDif = new System.Windows.Forms.Label();
            this.lblbCountUnstaged = new System.Windows.Forms.Label();
            this.lbUnstaged = new System.Windows.Forms.Label();
            this.splitterLists = new System.Windows.Forms.Splitter();
            this.lstStaged = new DigaoDeskApp.CheckedListBoxEx();
            this.boxTitleStaged = new System.Windows.Forms.Panel();
            this.btnInvertStaged = new System.Windows.Forms.Label();
            this.btnNoneStaged = new System.Windows.Forms.Label();
            this.btnAllStaged = new System.Windows.Forms.Label();
            this.lbCountStaged = new System.Windows.Forms.Label();
            this.lblbCountStaged = new System.Windows.Forms.Label();
            this.lbStaged = new System.Windows.Forms.Label();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.boxTop.SuspendLayout();
            this.boxInfo.SuspendLayout();
            this.boxTitleUnstaged.SuspendLayout();
            this.boxTitleStaged.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStage
            // 
            this.btnStage.Image = ((System.Drawing.Image)(resources.GetObject("btnStage.Image")));
            this.btnStage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStage.Location = new System.Drawing.Point(128, 64);
            this.btnStage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStage.Name = "btnStage";
            this.btnStage.Size = new System.Drawing.Size(110, 64);
            this.btnStage.TabIndex = 2;
            this.btnStage.TabStop = false;
            this.btnStage.Text = "Stage";
            this.btnStage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStage.UseVisualStyleBackColor = true;
            this.btnStage.Click += new System.EventHandler(this.btnStage_Click);
            // 
            // btnUnstage
            // 
            this.btnUnstage.Image = ((System.Drawing.Image)(resources.GetObject("btnUnstage.Image")));
            this.btnUnstage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnstage.Location = new System.Drawing.Point(247, 64);
            this.btnUnstage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnstage.Name = "btnUnstage";
            this.btnUnstage.Size = new System.Drawing.Size(110, 64);
            this.btnUnstage.TabIndex = 3;
            this.btnUnstage.TabStop = false;
            this.btnUnstage.Text = "Unstage";
            this.btnUnstage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnstage.UseVisualStyleBackColor = true;
            this.btnUnstage.Click += new System.EventHandler(this.btnUnstage_Click);
            // 
            // boxTop
            // 
            this.boxTop.Controls.Add(this.btnRefresh);
            this.boxTop.Controls.Add(this.boxInfo);
            this.boxTop.Controls.Add(this.btnCommitAndPush);
            this.boxTop.Controls.Add(this.btnCommit);
            this.boxTop.Controls.Add(this.edMessage);
            this.boxTop.Controls.Add(this.btnUnstage);
            this.boxTop.Controls.Add(this.btnStage);
            this.boxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxTop.Location = new System.Drawing.Point(0, 0);
            this.boxTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxTop.Name = "boxTop";
            this.boxTop.Size = new System.Drawing.Size(990, 139);
            this.boxTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(9, 64);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 64);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // boxInfo
            // 
            this.boxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.boxInfo.Controls.Add(this.lblbRepository);
            this.boxInfo.Controls.Add(this.lbBranch);
            this.boxInfo.Controls.Add(this.lbRepository);
            this.boxInfo.Controls.Add(this.lblbBranch);
            this.boxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxInfo.Location = new System.Drawing.Point(0, 0);
            this.boxInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxInfo.Name = "boxInfo";
            this.boxInfo.Size = new System.Drawing.Size(990, 53);
            this.boxInfo.TabIndex = 0;
            // 
            // lblbRepository
            // 
            this.lblbRepository.Location = new System.Drawing.Point(9, 3);
            this.lblbRepository.Name = "lblbRepository";
            this.lblbRepository.Size = new System.Drawing.Size(91, 20);
            this.lblbRepository.TabIndex = 5;
            this.lblbRepository.Text = "Repository:";
            this.lblbRepository.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBranch
            // 
            this.lbBranch.AutoSize = true;
            this.lbBranch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBranch.Location = new System.Drawing.Point(101, 29);
            this.lbBranch.Name = "lbBranch";
            this.lbBranch.Size = new System.Drawing.Size(27, 20);
            this.lbBranch.TabIndex = 8;
            this.lbBranch.Text = "---";
            // 
            // lbRepository
            // 
            this.lbRepository.AutoSize = true;
            this.lbRepository.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRepository.Location = new System.Drawing.Point(101, 3);
            this.lbRepository.Name = "lbRepository";
            this.lbRepository.Size = new System.Drawing.Size(27, 20);
            this.lbRepository.TabIndex = 6;
            this.lbRepository.Text = "---";
            // 
            // lblbBranch
            // 
            this.lblbBranch.Location = new System.Drawing.Point(9, 29);
            this.lblbBranch.Name = "lblbBranch";
            this.lblbBranch.Size = new System.Drawing.Size(91, 20);
            this.lblbBranch.TabIndex = 7;
            this.lblbBranch.Text = "Branch:";
            this.lblbBranch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCommitAndPush
            // 
            this.btnCommitAndPush.Location = new System.Drawing.Point(832, 96);
            this.btnCommitAndPush.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCommitAndPush.Name = "btnCommitAndPush";
            this.btnCommitAndPush.Size = new System.Drawing.Size(146, 32);
            this.btnCommitAndPush.TabIndex = 6;
            this.btnCommitAndPush.Text = "Commit and Push";
            this.btnCommitAndPush.UseVisualStyleBackColor = true;
            this.btnCommitAndPush.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(832, 64);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(146, 32);
            this.btnCommit.TabIndex = 5;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(366, 64);
            this.edMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edMessage.Multiline = true;
            this.edMessage.Name = "edMessage";
            this.edMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edMessage.Size = new System.Drawing.Size(457, 63);
            this.edMessage.TabIndex = 4;
            // 
            // lstOther
            // 
            this.lstOther.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstOther.FormattingEnabled = true;
            this.lstOther.IntegralHeight = false;
            this.lstOther.ItemHeight = 20;
            this.lstOther.Location = new System.Drawing.Point(0, 722);
            this.lstOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOther.Name = "lstOther";
            this.lstOther.Size = new System.Drawing.Size(990, 175);
            this.lstOther.TabIndex = 12;
            // 
            // lstDif
            // 
            this.lstDif.CheckOnClick = true;
            this.lstDif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDif.FormattingEnabled = true;
            this.lstDif.IntegralHeight = false;
            this.lstDif.Location = new System.Drawing.Point(0, 476);
            this.lstDif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstDif.Name = "lstDif";
            this.lstDif.Size = new System.Drawing.Size(990, 246);
            this.lstDif.TabIndex = 11;
            this.lstDif.DoubleClick += new System.EventHandler(this.lstItem_Click);
            // 
            // boxTitleUnstaged
            // 
            this.boxTitleUnstaged.BackColor = System.Drawing.Color.Crimson;
            this.boxTitleUnstaged.Controls.Add(this.btnUndoDif);
            this.boxTitleUnstaged.Controls.Add(this.btnInvertDif);
            this.boxTitleUnstaged.Controls.Add(this.btnNoneDif);
            this.boxTitleUnstaged.Controls.Add(this.btnAllDif);
            this.boxTitleUnstaged.Controls.Add(this.lbCountDif);
            this.boxTitleUnstaged.Controls.Add(this.lblbCountUnstaged);
            this.boxTitleUnstaged.Controls.Add(this.lbUnstaged);
            this.boxTitleUnstaged.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxTitleUnstaged.Location = new System.Drawing.Point(0, 444);
            this.boxTitleUnstaged.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxTitleUnstaged.Name = "boxTitleUnstaged";
            this.boxTitleUnstaged.Size = new System.Drawing.Size(990, 32);
            this.boxTitleUnstaged.TabIndex = 10;
            // 
            // btnUndoDif
            // 
            this.btnUndoDif.AutoSize = true;
            this.btnUndoDif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndoDif.ForeColor = System.Drawing.Color.Gold;
            this.btnUndoDif.Location = new System.Drawing.Point(539, 5);
            this.btnUndoDif.Name = "btnUndoDif";
            this.btnUndoDif.Size = new System.Drawing.Size(45, 20);
            this.btnUndoDif.TabIndex = 9;
            this.btnUndoDif.Text = "Undo";
            this.btnUndoDif.Click += new System.EventHandler(this.btnUndoDif_Click);
            // 
            // btnInvertDif
            // 
            this.btnInvertDif.AutoSize = true;
            this.btnInvertDif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvertDif.ForeColor = System.Drawing.Color.Aqua;
            this.btnInvertDif.Location = new System.Drawing.Point(439, 5);
            this.btnInvertDif.Name = "btnInvertDif";
            this.btnInvertDif.Size = new System.Drawing.Size(46, 20);
            this.btnInvertDif.TabIndex = 8;
            this.btnInvertDif.Text = "Invert";
            this.btnInvertDif.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // btnNoneDif
            // 
            this.btnNoneDif.AutoSize = true;
            this.btnNoneDif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoneDif.ForeColor = System.Drawing.Color.Aqua;
            this.btnNoneDif.Location = new System.Drawing.Point(375, 5);
            this.btnNoneDif.Name = "btnNoneDif";
            this.btnNoneDif.Size = new System.Drawing.Size(45, 20);
            this.btnNoneDif.TabIndex = 7;
            this.btnNoneDif.Text = "None";
            this.btnNoneDif.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // btnAllDif
            // 
            this.btnAllDif.AutoSize = true;
            this.btnAllDif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllDif.ForeColor = System.Drawing.Color.Aqua;
            this.btnAllDif.Location = new System.Drawing.Point(320, 5);
            this.btnAllDif.Name = "btnAllDif";
            this.btnAllDif.Size = new System.Drawing.Size(27, 20);
            this.btnAllDif.TabIndex = 6;
            this.btnAllDif.Text = "All";
            this.btnAllDif.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // lbCountDif
            // 
            this.lbCountDif.AutoSize = true;
            this.lbCountDif.ForeColor = System.Drawing.Color.White;
            this.lbCountDif.Location = new System.Drawing.Point(219, 5);
            this.lbCountDif.Name = "lbCountDif";
            this.lbCountDif.Size = new System.Drawing.Size(33, 20);
            this.lbCountDif.TabIndex = 2;
            this.lbCountDif.Text = "000";
            // 
            // lblbCountUnstaged
            // 
            this.lblbCountUnstaged.AutoSize = true;
            this.lblbCountUnstaged.ForeColor = System.Drawing.Color.White;
            this.lblbCountUnstaged.Location = new System.Drawing.Point(165, 5);
            this.lblbCountUnstaged.Name = "lblbCountUnstaged";
            this.lblbCountUnstaged.Size = new System.Drawing.Size(51, 20);
            this.lblbCountUnstaged.TabIndex = 1;
            this.lblbCountUnstaged.Text = "Count:";
            // 
            // lbUnstaged
            // 
            this.lbUnstaged.AutoSize = true;
            this.lbUnstaged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnstaged.ForeColor = System.Drawing.Color.White;
            this.lbUnstaged.Location = new System.Drawing.Point(9, 5);
            this.lbUnstaged.Name = "lbUnstaged";
            this.lbUnstaged.Size = new System.Drawing.Size(111, 20);
            this.lbUnstaged.TabIndex = 0;
            this.lbUnstaged.Text = "Unstaged Files";
            // 
            // splitterLists
            // 
            this.splitterLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterLists.Location = new System.Drawing.Point(0, 436);
            this.splitterLists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterLists.Name = "splitterLists";
            this.splitterLists.Size = new System.Drawing.Size(990, 8);
            this.splitterLists.TabIndex = 13;
            this.splitterLists.TabStop = false;
            // 
            // lstStaged
            // 
            this.lstStaged.CheckOnClick = true;
            this.lstStaged.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstStaged.FormattingEnabled = true;
            this.lstStaged.IntegralHeight = false;
            this.lstStaged.Location = new System.Drawing.Point(0, 171);
            this.lstStaged.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstStaged.Name = "lstStaged";
            this.lstStaged.Size = new System.Drawing.Size(990, 265);
            this.lstStaged.TabIndex = 9;
            this.lstStaged.DoubleClick += new System.EventHandler(this.lstItem_Click);
            // 
            // boxTitleStaged
            // 
            this.boxTitleStaged.BackColor = System.Drawing.Color.MediumBlue;
            this.boxTitleStaged.Controls.Add(this.btnInvertStaged);
            this.boxTitleStaged.Controls.Add(this.btnNoneStaged);
            this.boxTitleStaged.Controls.Add(this.btnAllStaged);
            this.boxTitleStaged.Controls.Add(this.lbCountStaged);
            this.boxTitleStaged.Controls.Add(this.lblbCountStaged);
            this.boxTitleStaged.Controls.Add(this.lbStaged);
            this.boxTitleStaged.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxTitleStaged.Location = new System.Drawing.Point(0, 139);
            this.boxTitleStaged.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxTitleStaged.Name = "boxTitleStaged";
            this.boxTitleStaged.Size = new System.Drawing.Size(990, 32);
            this.boxTitleStaged.TabIndex = 8;
            // 
            // btnInvertStaged
            // 
            this.btnInvertStaged.AutoSize = true;
            this.btnInvertStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvertStaged.ForeColor = System.Drawing.Color.Aqua;
            this.btnInvertStaged.Location = new System.Drawing.Point(439, 5);
            this.btnInvertStaged.Name = "btnInvertStaged";
            this.btnInvertStaged.Size = new System.Drawing.Size(46, 20);
            this.btnInvertStaged.TabIndex = 5;
            this.btnInvertStaged.Text = "Invert";
            this.btnInvertStaged.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // btnNoneStaged
            // 
            this.btnNoneStaged.AutoSize = true;
            this.btnNoneStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoneStaged.ForeColor = System.Drawing.Color.Aqua;
            this.btnNoneStaged.Location = new System.Drawing.Point(375, 5);
            this.btnNoneStaged.Name = "btnNoneStaged";
            this.btnNoneStaged.Size = new System.Drawing.Size(45, 20);
            this.btnNoneStaged.TabIndex = 4;
            this.btnNoneStaged.Text = "None";
            this.btnNoneStaged.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // btnAllStaged
            // 
            this.btnAllStaged.AutoSize = true;
            this.btnAllStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllStaged.ForeColor = System.Drawing.Color.Aqua;
            this.btnAllStaged.Location = new System.Drawing.Point(320, 5);
            this.btnAllStaged.Name = "btnAllStaged";
            this.btnAllStaged.Size = new System.Drawing.Size(27, 20);
            this.btnAllStaged.TabIndex = 3;
            this.btnAllStaged.Text = "All";
            this.btnAllStaged.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // lbCountStaged
            // 
            this.lbCountStaged.AutoSize = true;
            this.lbCountStaged.ForeColor = System.Drawing.Color.White;
            this.lbCountStaged.Location = new System.Drawing.Point(219, 5);
            this.lbCountStaged.Name = "lbCountStaged";
            this.lbCountStaged.Size = new System.Drawing.Size(33, 20);
            this.lbCountStaged.TabIndex = 2;
            this.lbCountStaged.Text = "000";
            // 
            // lblbCountStaged
            // 
            this.lblbCountStaged.AutoSize = true;
            this.lblbCountStaged.ForeColor = System.Drawing.Color.White;
            this.lblbCountStaged.Location = new System.Drawing.Point(165, 5);
            this.lblbCountStaged.Name = "lblbCountStaged";
            this.lblbCountStaged.Size = new System.Drawing.Size(51, 20);
            this.lblbCountStaged.TabIndex = 1;
            this.lblbCountStaged.Text = "Count:";
            // 
            // lbStaged
            // 
            this.lbStaged.AutoSize = true;
            this.lbStaged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStaged.ForeColor = System.Drawing.Color.White;
            this.lbStaged.Location = new System.Drawing.Point(9, 5);
            this.lbStaged.Name = "lbStaged";
            this.lbStaged.Size = new System.Drawing.Size(92, 20);
            this.lbStaged.TabIndex = 0;
            this.lbStaged.Text = "Staged Files";
            // 
            // images
            // 
            this.images.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "new");
            this.images.Images.SetKeyName(1, "edit");
            this.images.Images.SetKeyName(2, "delete");
            this.images.Images.SetKeyName(3, "rename");
            // 
            // FrmCommit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 897);
            this.Controls.Add(this.lstDif);
            this.Controls.Add(this.boxTitleUnstaged);
            this.Controls.Add(this.splitterLists);
            this.Controls.Add(this.lstStaged);
            this.Controls.Add(this.boxTitleStaged);
            this.Controls.Add(this.boxTop);
            this.Controls.Add(this.lstOther);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmCommit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCommit_FormClosed);
            this.Load += new System.EventHandler(this.FrmCommit_Load);
            this.boxTop.ResumeLayout(false);
            this.boxTop.PerformLayout();
            this.boxInfo.ResumeLayout(false);
            this.boxInfo.PerformLayout();
            this.boxTitleUnstaged.ResumeLayout(false);
            this.boxTitleUnstaged.PerformLayout();
            this.boxTitleStaged.ResumeLayout(false);
            this.boxTitleStaged.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStage;
        private System.Windows.Forms.Button btnUnstage;
        private System.Windows.Forms.Panel boxTop;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.Button btnCommitAndPush;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.ListBox lstOther;
        private DigaoDeskApp.CheckedListBoxEx lstDif;
        private System.Windows.Forms.Panel boxTitleUnstaged;
        private System.Windows.Forms.Label btnInvertDif;
        private System.Windows.Forms.Label btnNoneDif;
        private System.Windows.Forms.Label btnAllDif;
        private System.Windows.Forms.Label lbCountDif;
        private System.Windows.Forms.Label lblbCountUnstaged;
        private System.Windows.Forms.Label lbUnstaged;
        private System.Windows.Forms.Splitter splitterLists;
        private DigaoDeskApp.CheckedListBoxEx lstStaged;
        private System.Windows.Forms.Panel boxTitleStaged;
        private System.Windows.Forms.Label btnInvertStaged;
        private System.Windows.Forms.Label btnNoneStaged;
        private System.Windows.Forms.Label btnAllStaged;
        private System.Windows.Forms.Label lbCountStaged;
        private System.Windows.Forms.Label lblbCountStaged;
        private System.Windows.Forms.Label lbStaged;
        private System.Windows.Forms.Label btnUndoDif;
        private System.Windows.Forms.Label lbBranch;
        private System.Windows.Forms.Label lblbBranch;
        private System.Windows.Forms.Label lbRepository;
        private System.Windows.Forms.Label lblbRepository;
        private System.Windows.Forms.Panel boxInfo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList images;
    }
}