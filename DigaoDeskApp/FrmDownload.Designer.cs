namespace DigaoDeskApp
{
    partial class FrmDownload
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
            this.lblbVersion = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lblbTimestamp = new System.Windows.Forms.Label();
            this.lbTimestamp = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lbNewVersionAvailable = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbDownloading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblbVersion
            // 
            this.lblbVersion.Location = new System.Drawing.Point(16, 56);
            this.lblbVersion.Name = "lblbVersion";
            this.lblbVersion.Size = new System.Drawing.Size(128, 20);
            this.lblbVersion.TabIndex = 0;
            this.lblbVersion.Text = "Version:";
            this.lblbVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbVersion.Location = new System.Drawing.Point(144, 56);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(36, 20);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "nnn";
            // 
            // lblbTimestamp
            // 
            this.lblbTimestamp.Location = new System.Drawing.Point(16, 88);
            this.lblbTimestamp.Name = "lblbTimestamp";
            this.lblbTimestamp.Size = new System.Drawing.Size(128, 20);
            this.lblbTimestamp.TabIndex = 2;
            this.lblbTimestamp.Text = "Timestamp:";
            this.lblbTimestamp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTimestamp
            // 
            this.lbTimestamp.AutoSize = true;
            this.lbTimestamp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbTimestamp.Location = new System.Drawing.Point(144, 88);
            this.lbTimestamp.Name = "lbTimestamp";
            this.lbTimestamp.Size = new System.Drawing.Size(33, 20);
            this.lbTimestamp.TabIndex = 3;
            this.lbTimestamp.Text = "nnn";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(128, 184);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(168, 48);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Update Now";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lbNewVersionAvailable
            // 
            this.lbNewVersionAvailable.AutoSize = true;
            this.lbNewVersionAvailable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNewVersionAvailable.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbNewVersionAvailable.Location = new System.Drawing.Point(16, 16);
            this.lbNewVersionAvailable.Name = "lbNewVersionAvailable";
            this.lbNewVersionAvailable.Size = new System.Drawing.Size(295, 20);
            this.lbNewVersionAvailable.TabIndex = 5;
            this.lbNewVersionAvailable.Text = "A new version of Digao Desk is available!";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 48);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Leave me alone";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbDownloading
            // 
            this.lbDownloading.AutoSize = true;
            this.lbDownloading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDownloading.ForeColor = System.Drawing.Color.IndianRed;
            this.lbDownloading.Location = new System.Drawing.Point(16, 136);
            this.lbDownloading.Name = "lbDownloading";
            this.lbDownloading.Size = new System.Drawing.Size(114, 20);
            this.lbDownloading.TabIndex = 8;
            this.lbDownloading.Text = "Downloading...";
            this.lbDownloading.Visible = false;
            // 
            // FrmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 253);
            this.Controls.Add(this.lbDownloading);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbNewVersionAvailable);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lbTimestamp);
            this.Controls.Add(this.lblbTimestamp);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lblbVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbVersion;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lblbTimestamp;
        private System.Windows.Forms.Label lbTimestamp;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lbNewVersionAvailable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbDownloading;
    }
}