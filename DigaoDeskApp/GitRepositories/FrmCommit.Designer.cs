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
            this.btnStage = new System.Windows.Forms.Button();
            this.btnUnstage = new System.Windows.Forms.Button();
            this.boxTop = new System.Windows.Forms.Panel();
            this.boxInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBranch = new System.Windows.Forms.Label();
            this.lbRepository = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitterLists = new System.Windows.Forms.Splitter();
            this.lstStaged = new DigaoDeskApp.CheckedListBoxEx();
            this.boxTitleStaged = new System.Windows.Forms.Panel();
            this.btnInvertStaged = new System.Windows.Forms.Label();
            this.btnNoneStaged = new System.Windows.Forms.Label();
            this.btnAllStaged = new System.Windows.Forms.Label();
            this.lbCountStaged = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnStage.Location = new System.Drawing.Point(8, 48);
            this.btnStage.Name = "btnStage";
            this.btnStage.Size = new System.Drawing.Size(112, 48);
            this.btnStage.TabIndex = 0;
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
            this.btnUnstage.Location = new System.Drawing.Point(128, 48);
            this.btnUnstage.Name = "btnUnstage";
            this.btnUnstage.Size = new System.Drawing.Size(112, 48);
            this.btnUnstage.TabIndex = 1;
            this.btnUnstage.TabStop = false;
            this.btnUnstage.Text = "Unstage";
            this.btnUnstage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnstage.UseVisualStyleBackColor = true;
            this.btnUnstage.Click += new System.EventHandler(this.btnUnstage_Click);
            // 
            // boxTop
            // 
            this.boxTop.Controls.Add(this.boxInfo);
            this.boxTop.Controls.Add(this.btnCommitAndPush);
            this.boxTop.Controls.Add(this.btnCommit);
            this.boxTop.Controls.Add(this.edMessage);
            this.boxTop.Controls.Add(this.btnUnstage);
            this.boxTop.Controls.Add(this.btnStage);
            this.boxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxTop.Location = new System.Drawing.Point(0, 0);
            this.boxTop.Name = "boxTop";
            this.boxTop.Size = new System.Drawing.Size(866, 104);
            this.boxTop.TabIndex = 0;
            // 
            // boxInfo
            // 
            this.boxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.boxInfo.Controls.Add(this.label5);
            this.boxInfo.Controls.Add(this.lbBranch);
            this.boxInfo.Controls.Add(this.lbRepository);
            this.boxInfo.Controls.Add(this.label6);
            this.boxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxInfo.Location = new System.Drawing.Point(0, 0);
            this.boxInfo.Name = "boxInfo";
            this.boxInfo.Size = new System.Drawing.Size(866, 40);
            this.boxInfo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Repository:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBranch
            // 
            this.lbBranch.AutoSize = true;
            this.lbBranch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBranch.Location = new System.Drawing.Point(88, 22);
            this.lbBranch.Name = "lbBranch";
            this.lbBranch.Size = new System.Drawing.Size(22, 15);
            this.lbBranch.TabIndex = 8;
            this.lbBranch.Text = "---";
            // 
            // lbRepository
            // 
            this.lbRepository.AutoSize = true;
            this.lbRepository.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRepository.Location = new System.Drawing.Point(88, 2);
            this.lbRepository.Name = "lbRepository";
            this.lbRepository.Size = new System.Drawing.Size(22, 15);
            this.lbRepository.TabIndex = 6;
            this.lbRepository.Text = "---";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Branch:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCommitAndPush
            // 
            this.btnCommitAndPush.Location = new System.Drawing.Point(728, 72);
            this.btnCommitAndPush.Name = "btnCommitAndPush";
            this.btnCommitAndPush.Size = new System.Drawing.Size(128, 24);
            this.btnCommitAndPush.TabIndex = 4;
            this.btnCommitAndPush.Text = "Commit and Push";
            this.btnCommitAndPush.UseVisualStyleBackColor = true;
            this.btnCommitAndPush.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(728, 48);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(128, 24);
            this.btnCommit.TabIndex = 3;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(248, 48);
            this.edMessage.Multiline = true;
            this.edMessage.Name = "edMessage";
            this.edMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edMessage.Size = new System.Drawing.Size(472, 48);
            this.edMessage.TabIndex = 2;
            // 
            // lstOther
            // 
            this.lstOther.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstOther.FormattingEnabled = true;
            this.lstOther.IntegralHeight = false;
            this.lstOther.ItemHeight = 15;
            this.lstOther.Location = new System.Drawing.Point(0, 541);
            this.lstOther.Name = "lstOther";
            this.lstOther.Size = new System.Drawing.Size(866, 132);
            this.lstOther.TabIndex = 12;
            // 
            // lstDif
            // 
            this.lstDif.CheckOnClick = true;
            this.lstDif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDif.FormattingEnabled = true;
            this.lstDif.IntegralHeight = false;
            this.lstDif.Location = new System.Drawing.Point(0, 358);
            this.lstDif.Name = "lstDif";
            this.lstDif.Size = new System.Drawing.Size(866, 315);
            this.lstDif.TabIndex = 11;
            this.lstDif.DoubleClick += new System.EventHandler(this.lstItem_Click);
            // 
            // boxTitleUnstaged
            // 
            this.boxTitleUnstaged.BackColor = System.Drawing.Color.Orange;
            this.boxTitleUnstaged.Controls.Add(this.btnUndoDif);
            this.boxTitleUnstaged.Controls.Add(this.btnInvertDif);
            this.boxTitleUnstaged.Controls.Add(this.btnNoneDif);
            this.boxTitleUnstaged.Controls.Add(this.btnAllDif);
            this.boxTitleUnstaged.Controls.Add(this.lbCountDif);
            this.boxTitleUnstaged.Controls.Add(this.label4);
            this.boxTitleUnstaged.Controls.Add(this.label1);
            this.boxTitleUnstaged.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxTitleUnstaged.Location = new System.Drawing.Point(0, 334);
            this.boxTitleUnstaged.Name = "boxTitleUnstaged";
            this.boxTitleUnstaged.Size = new System.Drawing.Size(866, 24);
            this.boxTitleUnstaged.TabIndex = 10;
            // 
            // btnUndoDif
            // 
            this.btnUndoDif.AutoSize = true;
            this.btnUndoDif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndoDif.ForeColor = System.Drawing.Color.Red;
            this.btnUndoDif.Location = new System.Drawing.Point(472, 4);
            this.btnUndoDif.Name = "btnUndoDif";
            this.btnUndoDif.Size = new System.Drawing.Size(36, 15);
            this.btnUndoDif.TabIndex = 9;
            this.btnUndoDif.Text = "Undo";
            this.btnUndoDif.Click += new System.EventHandler(this.btnUndoDif_Click);
            // 
            // btnInvertDif
            // 
            this.btnInvertDif.AutoSize = true;
            this.btnInvertDif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvertDif.ForeColor = System.Drawing.Color.Blue;
            this.btnInvertDif.Location = new System.Drawing.Point(384, 4);
            this.btnInvertDif.Name = "btnInvertDif";
            this.btnInvertDif.Size = new System.Drawing.Size(37, 15);
            this.btnInvertDif.TabIndex = 8;
            this.btnInvertDif.Text = "Invert";
            this.btnInvertDif.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // btnNoneDif
            // 
            this.btnNoneDif.AutoSize = true;
            this.btnNoneDif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoneDif.ForeColor = System.Drawing.Color.Blue;
            this.btnNoneDif.Location = new System.Drawing.Point(328, 4);
            this.btnNoneDif.Name = "btnNoneDif";
            this.btnNoneDif.Size = new System.Drawing.Size(36, 15);
            this.btnNoneDif.TabIndex = 7;
            this.btnNoneDif.Text = "None";
            this.btnNoneDif.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // btnAllDif
            // 
            this.btnAllDif.AutoSize = true;
            this.btnAllDif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllDif.ForeColor = System.Drawing.Color.Blue;
            this.btnAllDif.Location = new System.Drawing.Point(280, 4);
            this.btnAllDif.Name = "btnAllDif";
            this.btnAllDif.Size = new System.Drawing.Size(21, 15);
            this.btnAllDif.TabIndex = 6;
            this.btnAllDif.Text = "All";
            this.btnAllDif.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // lbCountDif
            // 
            this.lbCountDif.AutoSize = true;
            this.lbCountDif.Location = new System.Drawing.Point(192, 4);
            this.lbCountDif.Name = "lbCountDif";
            this.lbCountDif.Size = new System.Drawing.Size(25, 15);
            this.lbCountDif.TabIndex = 2;
            this.lbCountDif.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unstaged Files";
            // 
            // splitterLists
            // 
            this.splitterLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterLists.Location = new System.Drawing.Point(0, 328);
            this.splitterLists.Name = "splitterLists";
            this.splitterLists.Size = new System.Drawing.Size(866, 6);
            this.splitterLists.TabIndex = 13;
            this.splitterLists.TabStop = false;
            // 
            // lstStaged
            // 
            this.lstStaged.CheckOnClick = true;
            this.lstStaged.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstStaged.FormattingEnabled = true;
            this.lstStaged.IntegralHeight = false;
            this.lstStaged.Location = new System.Drawing.Point(0, 128);
            this.lstStaged.Name = "lstStaged";
            this.lstStaged.Size = new System.Drawing.Size(866, 200);
            this.lstStaged.TabIndex = 9;
            this.lstStaged.DoubleClick += new System.EventHandler(this.lstItem_Click);
            // 
            // boxTitleStaged
            // 
            this.boxTitleStaged.BackColor = System.Drawing.Color.SkyBlue;
            this.boxTitleStaged.Controls.Add(this.btnInvertStaged);
            this.boxTitleStaged.Controls.Add(this.btnNoneStaged);
            this.boxTitleStaged.Controls.Add(this.btnAllStaged);
            this.boxTitleStaged.Controls.Add(this.lbCountStaged);
            this.boxTitleStaged.Controls.Add(this.label3);
            this.boxTitleStaged.Controls.Add(this.label2);
            this.boxTitleStaged.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxTitleStaged.Location = new System.Drawing.Point(0, 104);
            this.boxTitleStaged.Name = "boxTitleStaged";
            this.boxTitleStaged.Size = new System.Drawing.Size(866, 24);
            this.boxTitleStaged.TabIndex = 8;
            // 
            // btnInvertStaged
            // 
            this.btnInvertStaged.AutoSize = true;
            this.btnInvertStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvertStaged.ForeColor = System.Drawing.Color.Blue;
            this.btnInvertStaged.Location = new System.Drawing.Point(384, 4);
            this.btnInvertStaged.Name = "btnInvertStaged";
            this.btnInvertStaged.Size = new System.Drawing.Size(37, 15);
            this.btnInvertStaged.TabIndex = 5;
            this.btnInvertStaged.Text = "Invert";
            this.btnInvertStaged.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // btnNoneStaged
            // 
            this.btnNoneStaged.AutoSize = true;
            this.btnNoneStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoneStaged.ForeColor = System.Drawing.Color.Blue;
            this.btnNoneStaged.Location = new System.Drawing.Point(328, 4);
            this.btnNoneStaged.Name = "btnNoneStaged";
            this.btnNoneStaged.Size = new System.Drawing.Size(36, 15);
            this.btnNoneStaged.TabIndex = 4;
            this.btnNoneStaged.Text = "None";
            this.btnNoneStaged.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // btnAllStaged
            // 
            this.btnAllStaged.AutoSize = true;
            this.btnAllStaged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllStaged.ForeColor = System.Drawing.Color.Blue;
            this.btnAllStaged.Location = new System.Drawing.Point(280, 4);
            this.btnAllStaged.Name = "btnAllStaged";
            this.btnAllStaged.Size = new System.Drawing.Size(21, 15);
            this.btnAllStaged.TabIndex = 3;
            this.btnAllStaged.Text = "All";
            this.btnAllStaged.Click += new System.EventHandler(this.btnGroupSelection_Click);
            // 
            // lbCountStaged
            // 
            this.lbCountStaged.AutoSize = true;
            this.lbCountStaged.Location = new System.Drawing.Point(192, 4);
            this.lbCountStaged.Name = "lbCountStaged";
            this.lbCountStaged.Size = new System.Drawing.Size(25, 15);
            this.lbCountStaged.TabIndex = 2;
            this.lbCountStaged.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staged Files";
            // 
            // FrmCommit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 673);
            this.Controls.Add(this.lstOther);
            this.Controls.Add(this.lstDif);
            this.Controls.Add(this.boxTitleUnstaged);
            this.Controls.Add(this.splitterLists);
            this.Controls.Add(this.lstStaged);
            this.Controls.Add(this.boxTitleStaged);
            this.Controls.Add(this.boxTop);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitterLists;
        private DigaoDeskApp.CheckedListBoxEx lstStaged;
        private System.Windows.Forms.Panel boxTitleStaged;
        private System.Windows.Forms.Label btnInvertStaged;
        private System.Windows.Forms.Label btnNoneStaged;
        private System.Windows.Forms.Label btnAllStaged;
        private System.Windows.Forms.Label lbCountStaged;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnUndoDif;
        private System.Windows.Forms.Label lbBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRepository;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel boxInfo;
    }
}