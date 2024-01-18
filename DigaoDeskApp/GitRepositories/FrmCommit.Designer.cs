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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommit));
            btnStage = new System.Windows.Forms.Button();
            btnUnstage = new System.Windows.Forms.Button();
            boxTop = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            boxInfo = new System.Windows.Forms.Panel();
            lblbRepository = new System.Windows.Forms.Label();
            lbBranch = new System.Windows.Forms.Label();
            lbRepository = new System.Windows.Forms.Label();
            lblbBranch = new System.Windows.Forms.Label();
            btnCommitAndPush = new System.Windows.Forms.Button();
            btnCommit = new System.Windows.Forms.Button();
            edMessage = new System.Windows.Forms.TextBox();
            lstOther = new System.Windows.Forms.ListBox();
            lstDif = new CheckedListBoxEx();
            boxTitleUnstaged = new System.Windows.Forms.Panel();
            btnUndoDif = new System.Windows.Forms.Label();
            btnInvertDif = new System.Windows.Forms.Label();
            btnNoneDif = new System.Windows.Forms.Label();
            btnAllDif = new System.Windows.Forms.Label();
            lbCountDif = new System.Windows.Forms.Label();
            lblbCountUnstaged = new System.Windows.Forms.Label();
            lbUnstaged = new System.Windows.Forms.Label();
            splitterLists = new System.Windows.Forms.Splitter();
            lstStaged = new CheckedListBoxEx();
            boxTitleStaged = new System.Windows.Forms.Panel();
            btnInvertStaged = new System.Windows.Forms.Label();
            btnNoneStaged = new System.Windows.Forms.Label();
            btnAllStaged = new System.Windows.Forms.Label();
            lbCountStaged = new System.Windows.Forms.Label();
            lblbCountStaged = new System.Windows.Forms.Label();
            lbStaged = new System.Windows.Forms.Label();
            boxTop.SuspendLayout();
            boxInfo.SuspendLayout();
            boxTitleUnstaged.SuspendLayout();
            boxTitleStaged.SuspendLayout();
            SuspendLayout();
            // 
            // btnStage
            // 
            btnStage.Image = (System.Drawing.Image)resources.GetObject("btnStage.Image");
            btnStage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnStage.Location = new System.Drawing.Point(128, 64);
            btnStage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStage.Name = "btnStage";
            btnStage.Size = new System.Drawing.Size(110, 64);
            btnStage.TabIndex = 2;
            btnStage.TabStop = false;
            btnStage.Text = "Stage";
            btnStage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnStage.UseVisualStyleBackColor = true;
            btnStage.Click += btnStage_Click;
            // 
            // btnUnstage
            // 
            btnUnstage.Image = (System.Drawing.Image)resources.GetObject("btnUnstage.Image");
            btnUnstage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnUnstage.Location = new System.Drawing.Point(247, 64);
            btnUnstage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUnstage.Name = "btnUnstage";
            btnUnstage.Size = new System.Drawing.Size(110, 64);
            btnUnstage.TabIndex = 3;
            btnUnstage.TabStop = false;
            btnUnstage.Text = "Unstage";
            btnUnstage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnUnstage.UseVisualStyleBackColor = true;
            btnUnstage.Click += btnUnstage_Click;
            // 
            // boxTop
            // 
            boxTop.Controls.Add(btnRefresh);
            boxTop.Controls.Add(boxInfo);
            boxTop.Controls.Add(btnCommitAndPush);
            boxTop.Controls.Add(btnCommit);
            boxTop.Controls.Add(edMessage);
            boxTop.Controls.Add(btnUnstage);
            boxTop.Controls.Add(btnStage);
            boxTop.Dock = System.Windows.Forms.DockStyle.Top;
            boxTop.Location = new System.Drawing.Point(0, 0);
            boxTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            boxTop.Name = "boxTop";
            boxTop.Size = new System.Drawing.Size(990, 139);
            boxTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = (System.Drawing.Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRefresh.Location = new System.Drawing.Point(9, 64);
            btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(110, 64);
            btnRefresh.TabIndex = 1;
            btnRefresh.TabStop = false;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // boxInfo
            // 
            boxInfo.BackColor = System.Drawing.SystemColors.Info;
            boxInfo.Controls.Add(lblbRepository);
            boxInfo.Controls.Add(lbBranch);
            boxInfo.Controls.Add(lbRepository);
            boxInfo.Controls.Add(lblbBranch);
            boxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            boxInfo.Location = new System.Drawing.Point(0, 0);
            boxInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            boxInfo.Name = "boxInfo";
            boxInfo.Size = new System.Drawing.Size(990, 53);
            boxInfo.TabIndex = 0;
            // 
            // lblbRepository
            // 
            lblbRepository.Location = new System.Drawing.Point(9, 3);
            lblbRepository.Name = "lblbRepository";
            lblbRepository.Size = new System.Drawing.Size(91, 20);
            lblbRepository.TabIndex = 5;
            lblbRepository.Text = "Repository:";
            lblbRepository.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBranch
            // 
            lbBranch.AutoSize = true;
            lbBranch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbBranch.Location = new System.Drawing.Point(101, 29);
            lbBranch.Name = "lbBranch";
            lbBranch.Size = new System.Drawing.Size(27, 20);
            lbBranch.TabIndex = 8;
            lbBranch.Text = "---";
            // 
            // lbRepository
            // 
            lbRepository.AutoSize = true;
            lbRepository.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbRepository.Location = new System.Drawing.Point(101, 3);
            lbRepository.Name = "lbRepository";
            lbRepository.Size = new System.Drawing.Size(27, 20);
            lbRepository.TabIndex = 6;
            lbRepository.Text = "---";
            // 
            // lblbBranch
            // 
            lblbBranch.Location = new System.Drawing.Point(9, 29);
            lblbBranch.Name = "lblbBranch";
            lblbBranch.Size = new System.Drawing.Size(91, 20);
            lblbBranch.TabIndex = 7;
            lblbBranch.Text = "Branch:";
            lblbBranch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCommitAndPush
            // 
            btnCommitAndPush.Location = new System.Drawing.Point(832, 96);
            btnCommitAndPush.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCommitAndPush.Name = "btnCommitAndPush";
            btnCommitAndPush.Size = new System.Drawing.Size(146, 32);
            btnCommitAndPush.TabIndex = 6;
            btnCommitAndPush.Text = "Commit and Push";
            btnCommitAndPush.UseVisualStyleBackColor = true;
            btnCommitAndPush.Click += btnCommit_Click;
            // 
            // btnCommit
            // 
            btnCommit.Location = new System.Drawing.Point(832, 64);
            btnCommit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new System.Drawing.Size(146, 32);
            btnCommit.TabIndex = 5;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // edMessage
            // 
            edMessage.Location = new System.Drawing.Point(366, 64);
            edMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            edMessage.Multiline = true;
            edMessage.Name = "edMessage";
            edMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            edMessage.Size = new System.Drawing.Size(457, 63);
            edMessage.TabIndex = 4;
            // 
            // lstOther
            // 
            lstOther.Dock = System.Windows.Forms.DockStyle.Bottom;
            lstOther.FormattingEnabled = true;
            lstOther.IntegralHeight = false;
            lstOther.Location = new System.Drawing.Point(0, 722);
            lstOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstOther.Name = "lstOther";
            lstOther.Size = new System.Drawing.Size(990, 175);
            lstOther.TabIndex = 12;
            // 
            // lstDif
            // 
            lstDif.CheckOnClick = true;
            lstDif.Dock = System.Windows.Forms.DockStyle.Fill;
            lstDif.FormattingEnabled = true;
            lstDif.IntegralHeight = false;
            lstDif.Location = new System.Drawing.Point(0, 476);
            lstDif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstDif.Name = "lstDif";
            lstDif.Size = new System.Drawing.Size(990, 246);
            lstDif.TabIndex = 11;
            lstDif.DoubleClick += lstItem_Click;
            // 
            // boxTitleUnstaged
            // 
            boxTitleUnstaged.BackColor = System.Drawing.Color.Crimson;
            boxTitleUnstaged.Controls.Add(btnUndoDif);
            boxTitleUnstaged.Controls.Add(btnInvertDif);
            boxTitleUnstaged.Controls.Add(btnNoneDif);
            boxTitleUnstaged.Controls.Add(btnAllDif);
            boxTitleUnstaged.Controls.Add(lbCountDif);
            boxTitleUnstaged.Controls.Add(lblbCountUnstaged);
            boxTitleUnstaged.Controls.Add(lbUnstaged);
            boxTitleUnstaged.Dock = System.Windows.Forms.DockStyle.Top;
            boxTitleUnstaged.Location = new System.Drawing.Point(0, 444);
            boxTitleUnstaged.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            boxTitleUnstaged.Name = "boxTitleUnstaged";
            boxTitleUnstaged.Size = new System.Drawing.Size(990, 32);
            boxTitleUnstaged.TabIndex = 10;
            // 
            // btnUndoDif
            // 
            btnUndoDif.AutoSize = true;
            btnUndoDif.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUndoDif.ForeColor = System.Drawing.Color.Gold;
            btnUndoDif.Location = new System.Drawing.Point(539, 5);
            btnUndoDif.Name = "btnUndoDif";
            btnUndoDif.Size = new System.Drawing.Size(45, 20);
            btnUndoDif.TabIndex = 9;
            btnUndoDif.Text = "Undo";
            btnUndoDif.Click += btnUndoDif_Click;
            // 
            // btnInvertDif
            // 
            btnInvertDif.AutoSize = true;
            btnInvertDif.Cursor = System.Windows.Forms.Cursors.Hand;
            btnInvertDif.ForeColor = System.Drawing.Color.Aqua;
            btnInvertDif.Location = new System.Drawing.Point(439, 5);
            btnInvertDif.Name = "btnInvertDif";
            btnInvertDif.Size = new System.Drawing.Size(46, 20);
            btnInvertDif.TabIndex = 8;
            btnInvertDif.Text = "Invert";
            btnInvertDif.Click += btnGroupSelection_Click;
            // 
            // btnNoneDif
            // 
            btnNoneDif.AutoSize = true;
            btnNoneDif.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNoneDif.ForeColor = System.Drawing.Color.Aqua;
            btnNoneDif.Location = new System.Drawing.Point(375, 5);
            btnNoneDif.Name = "btnNoneDif";
            btnNoneDif.Size = new System.Drawing.Size(45, 20);
            btnNoneDif.TabIndex = 7;
            btnNoneDif.Text = "None";
            btnNoneDif.Click += btnGroupSelection_Click;
            // 
            // btnAllDif
            // 
            btnAllDif.AutoSize = true;
            btnAllDif.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAllDif.ForeColor = System.Drawing.Color.Aqua;
            btnAllDif.Location = new System.Drawing.Point(320, 5);
            btnAllDif.Name = "btnAllDif";
            btnAllDif.Size = new System.Drawing.Size(27, 20);
            btnAllDif.TabIndex = 6;
            btnAllDif.Text = "All";
            btnAllDif.Click += btnGroupSelection_Click;
            // 
            // lbCountDif
            // 
            lbCountDif.AutoSize = true;
            lbCountDif.ForeColor = System.Drawing.Color.White;
            lbCountDif.Location = new System.Drawing.Point(238, 5);
            lbCountDif.Name = "lbCountDif";
            lbCountDif.Size = new System.Drawing.Size(33, 20);
            lbCountDif.TabIndex = 2;
            lbCountDif.Text = "000";
            // 
            // lblbCountUnstaged
            // 
            lblbCountUnstaged.AutoSize = true;
            lblbCountUnstaged.ForeColor = System.Drawing.Color.White;
            lblbCountUnstaged.Location = new System.Drawing.Point(184, 5);
            lblbCountUnstaged.Name = "lblbCountUnstaged";
            lblbCountUnstaged.Size = new System.Drawing.Size(51, 20);
            lblbCountUnstaged.TabIndex = 1;
            lblbCountUnstaged.Text = "Count:";
            // 
            // lbUnstaged
            // 
            lbUnstaged.AutoSize = true;
            lbUnstaged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbUnstaged.ForeColor = System.Drawing.Color.White;
            lbUnstaged.Location = new System.Drawing.Point(9, 5);
            lbUnstaged.Name = "lbUnstaged";
            lbUnstaged.Size = new System.Drawing.Size(111, 20);
            lbUnstaged.TabIndex = 0;
            lbUnstaged.Text = "Unstaged Files";
            // 
            // splitterLists
            // 
            splitterLists.Dock = System.Windows.Forms.DockStyle.Top;
            splitterLists.Location = new System.Drawing.Point(0, 436);
            splitterLists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            splitterLists.Name = "splitterLists";
            splitterLists.Size = new System.Drawing.Size(990, 8);
            splitterLists.TabIndex = 13;
            splitterLists.TabStop = false;
            // 
            // lstStaged
            // 
            lstStaged.CheckOnClick = true;
            lstStaged.Dock = System.Windows.Forms.DockStyle.Top;
            lstStaged.FormattingEnabled = true;
            lstStaged.IntegralHeight = false;
            lstStaged.Location = new System.Drawing.Point(0, 171);
            lstStaged.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstStaged.Name = "lstStaged";
            lstStaged.Size = new System.Drawing.Size(990, 265);
            lstStaged.TabIndex = 9;
            lstStaged.DoubleClick += lstItem_Click;
            // 
            // boxTitleStaged
            // 
            boxTitleStaged.BackColor = System.Drawing.Color.MediumBlue;
            boxTitleStaged.Controls.Add(btnInvertStaged);
            boxTitleStaged.Controls.Add(btnNoneStaged);
            boxTitleStaged.Controls.Add(btnAllStaged);
            boxTitleStaged.Controls.Add(lbCountStaged);
            boxTitleStaged.Controls.Add(lblbCountStaged);
            boxTitleStaged.Controls.Add(lbStaged);
            boxTitleStaged.Dock = System.Windows.Forms.DockStyle.Top;
            boxTitleStaged.Location = new System.Drawing.Point(0, 139);
            boxTitleStaged.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            boxTitleStaged.Name = "boxTitleStaged";
            boxTitleStaged.Size = new System.Drawing.Size(990, 32);
            boxTitleStaged.TabIndex = 8;
            // 
            // btnInvertStaged
            // 
            btnInvertStaged.AutoSize = true;
            btnInvertStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            btnInvertStaged.ForeColor = System.Drawing.Color.Aqua;
            btnInvertStaged.Location = new System.Drawing.Point(439, 5);
            btnInvertStaged.Name = "btnInvertStaged";
            btnInvertStaged.Size = new System.Drawing.Size(46, 20);
            btnInvertStaged.TabIndex = 5;
            btnInvertStaged.Text = "Invert";
            btnInvertStaged.Click += btnGroupSelection_Click;
            // 
            // btnNoneStaged
            // 
            btnNoneStaged.AutoSize = true;
            btnNoneStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNoneStaged.ForeColor = System.Drawing.Color.Aqua;
            btnNoneStaged.Location = new System.Drawing.Point(375, 5);
            btnNoneStaged.Name = "btnNoneStaged";
            btnNoneStaged.Size = new System.Drawing.Size(45, 20);
            btnNoneStaged.TabIndex = 4;
            btnNoneStaged.Text = "None";
            btnNoneStaged.Click += btnGroupSelection_Click;
            // 
            // btnAllStaged
            // 
            btnAllStaged.AutoSize = true;
            btnAllStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAllStaged.ForeColor = System.Drawing.Color.Aqua;
            btnAllStaged.Location = new System.Drawing.Point(320, 5);
            btnAllStaged.Name = "btnAllStaged";
            btnAllStaged.Size = new System.Drawing.Size(27, 20);
            btnAllStaged.TabIndex = 3;
            btnAllStaged.Text = "All";
            btnAllStaged.Click += btnGroupSelection_Click;
            // 
            // lbCountStaged
            // 
            lbCountStaged.AutoSize = true;
            lbCountStaged.ForeColor = System.Drawing.Color.White;
            lbCountStaged.Location = new System.Drawing.Point(238, 5);
            lbCountStaged.Name = "lbCountStaged";
            lbCountStaged.Size = new System.Drawing.Size(33, 20);
            lbCountStaged.TabIndex = 2;
            lbCountStaged.Text = "000";
            // 
            // lblbCountStaged
            // 
            lblbCountStaged.AutoSize = true;
            lblbCountStaged.ForeColor = System.Drawing.Color.White;
            lblbCountStaged.Location = new System.Drawing.Point(184, 5);
            lblbCountStaged.Name = "lblbCountStaged";
            lblbCountStaged.Size = new System.Drawing.Size(51, 20);
            lblbCountStaged.TabIndex = 1;
            lblbCountStaged.Text = "Count:";
            // 
            // lbStaged
            // 
            lbStaged.AutoSize = true;
            lbStaged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbStaged.ForeColor = System.Drawing.Color.White;
            lbStaged.Location = new System.Drawing.Point(9, 5);
            lbStaged.Name = "lbStaged";
            lbStaged.Size = new System.Drawing.Size(92, 20);
            lbStaged.TabIndex = 0;
            lbStaged.Text = "Staged Files";
            // 
            // FrmCommit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(990, 897);
            Controls.Add(lstDif);
            Controls.Add(boxTitleUnstaged);
            Controls.Add(splitterLists);
            Controls.Add(lstStaged);
            Controls.Add(boxTitleStaged);
            Controls.Add(boxTop);
            Controls.Add(lstOther);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "FrmCommit";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Commit";
            FormClosed += FrmCommit_FormClosed;
            Load += FrmCommit_Load;
            boxTop.ResumeLayout(false);
            boxTop.PerformLayout();
            boxInfo.ResumeLayout(false);
            boxInfo.PerformLayout();
            boxTitleUnstaged.ResumeLayout(false);
            boxTitleUnstaged.PerformLayout();
            boxTitleStaged.ResumeLayout(false);
            boxTitleStaged.PerformLayout();
            ResumeLayout(false);
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
    }
}