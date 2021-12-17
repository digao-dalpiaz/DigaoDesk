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
            this.lstStaged = new System.Windows.Forms.CheckedListBox();
            this.lstDif = new System.Windows.Forms.CheckedListBox();
            this.btnStage = new System.Windows.Forms.Button();
            this.btnUnstage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInvertDif = new System.Windows.Forms.Label();
            this.btnNoneDif = new System.Windows.Forms.Label();
            this.btnAllDif = new System.Windows.Forms.Label();
            this.lbCountDif = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInvertStaged = new System.Windows.Forms.Label();
            this.btnNoneStaged = new System.Windows.Forms.Label();
            this.btnAllStaged = new System.Windows.Forms.Label();
            this.lbCountStaged = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStaged
            // 
            this.lstStaged.CheckOnClick = true;
            this.lstStaged.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstStaged.FormattingEnabled = true;
            this.lstStaged.IntegralHeight = false;
            this.lstStaged.Location = new System.Drawing.Point(0, 80);
            this.lstStaged.Name = "lstStaged";
            this.lstStaged.Size = new System.Drawing.Size(800, 200);
            this.lstStaged.TabIndex = 0;
            // 
            // lstDif
            // 
            this.lstDif.CheckOnClick = true;
            this.lstDif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDif.FormattingEnabled = true;
            this.lstDif.IntegralHeight = false;
            this.lstDif.Location = new System.Drawing.Point(0, 312);
            this.lstDif.Name = "lstDif";
            this.lstDif.Size = new System.Drawing.Size(800, 220);
            this.lstDif.TabIndex = 1;
            // 
            // btnStage
            // 
            this.btnStage.Image = ((System.Drawing.Image)(resources.GetObject("btnStage.Image")));
            this.btnStage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStage.Location = new System.Drawing.Point(8, 8);
            this.btnStage.Name = "btnStage";
            this.btnStage.Size = new System.Drawing.Size(120, 40);
            this.btnStage.TabIndex = 2;
            this.btnStage.Text = "Stage";
            this.btnStage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStage.UseVisualStyleBackColor = true;
            this.btnStage.Click += new System.EventHandler(this.btnStage_Click);
            // 
            // btnUnstage
            // 
            this.btnUnstage.Image = ((System.Drawing.Image)(resources.GetObject("btnUnstage.Image")));
            this.btnUnstage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnstage.Location = new System.Drawing.Point(136, 8);
            this.btnUnstage.Name = "btnUnstage";
            this.btnUnstage.Size = new System.Drawing.Size(120, 40);
            this.btnUnstage.TabIndex = 3;
            this.btnUnstage.Text = "Unstage";
            this.btnUnstage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnstage.UseVisualStyleBackColor = true;
            this.btnUnstage.Click += new System.EventHandler(this.btnUnstage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUnstage);
            this.panel1.Controls.Add(this.btnStage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 280);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(800, 8);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.btnInvertDif);
            this.panel2.Controls.Add(this.btnNoneDif);
            this.panel2.Controls.Add(this.btnAllDif);
            this.panel2.Controls.Add(this.lbCountDif);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 24);
            this.panel2.TabIndex = 4;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.btnInvertStaged);
            this.panel3.Controls.Add(this.btnNoneStaged);
            this.panel3.Controls.Add(this.btnAllStaged);
            this.panel3.Controls.Add(this.lbCountStaged);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 24);
            this.panel3.TabIndex = 6;
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
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.lstDif);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lstStaged);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "FrmCommit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCommit_FormClosed);
            this.Load += new System.EventHandler(this.FrmCommit_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstStaged;
        private System.Windows.Forms.CheckedListBox lstDif;
        private System.Windows.Forms.Button btnStage;
        private System.Windows.Forms.Button btnUnstage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountDif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCountStaged;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnInvertDif;
        private System.Windows.Forms.Label btnNoneDif;
        private System.Windows.Forms.Label btnAllDif;
        private System.Windows.Forms.Label btnInvertStaged;
        private System.Windows.Forms.Label btnNoneStaged;
        private System.Windows.Forms.Label btnAllStaged;
    }
}