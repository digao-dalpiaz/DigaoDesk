
namespace DigaoDeskApp
{
    partial class FrmFind
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
            this.lbText = new System.Windows.Forms.Label();
            this.edText = new System.Windows.Forms.TextBox();
            this.ckCaseSensitive = new System.Windows.Forms.CheckBox();
            this.ckFromCurrentPos = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckWholeWord = new System.Windows.Forms.CheckBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(7, 11);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(36, 20);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Text";
            // 
            // edText
            // 
            this.edText.Location = new System.Drawing.Point(9, 32);
            this.edText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edText.Name = "edText";
            this.edText.Size = new System.Drawing.Size(557, 27);
            this.edText.TabIndex = 1;
            this.edText.TextChanged += new System.EventHandler(this.edText_TextChanged);
            // 
            // ckCaseSensitive
            // 
            this.ckCaseSensitive.AutoSize = true;
            this.ckCaseSensitive.Location = new System.Drawing.Point(9, 85);
            this.ckCaseSensitive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckCaseSensitive.Name = "ckCaseSensitive";
            this.ckCaseSensitive.Size = new System.Drawing.Size(122, 24);
            this.ckCaseSensitive.TabIndex = 2;
            this.ckCaseSensitive.Text = "Case sensitive";
            this.ckCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // ckFromCurrentPos
            // 
            this.ckFromCurrentPos.AutoSize = true;
            this.ckFromCurrentPos.Location = new System.Drawing.Point(9, 149);
            this.ckFromCurrentPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckFromCurrentPos.Name = "ckFromCurrentPos";
            this.ckFromCurrentPos.Size = new System.Drawing.Size(173, 24);
            this.ckFromCurrentPos.TabIndex = 4;
            this.ckFromCurrentPos.Text = "From current position";
            this.ckFromCurrentPos.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(183, 203);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 43);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(293, 203);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 43);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ckWholeWord
            // 
            this.ckWholeWord.AutoSize = true;
            this.ckWholeWord.Location = new System.Drawing.Point(9, 117);
            this.ckWholeWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckWholeWord.Name = "ckWholeWord";
            this.ckWholeWord.Size = new System.Drawing.Size(112, 24);
            this.ckWholeWord.TabIndex = 3;
            this.ckWholeWord.Text = "Whole word";
            this.ckWholeWord.UseVisualStyleBackColor = true;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.ForeColor = System.Drawing.Color.Gray;
            this.lbInfo.Location = new System.Drawing.Point(329, 160);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(240, 20);
            this.lbInfo.TabIndex = 13;
            this.lbInfo.Text = "Use F3 key to find next occurrences";
            // 
            // FrmFind
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(577, 260);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.ckWholeWord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ckFromCurrentPos);
            this.Controls.Add(this.ckCaseSensitive);
            this.Controls.Add(this.edText);
            this.Controls.Add(this.lbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFind";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find in Log";
            this.Load += new System.EventHandler(this.FrmFind_Load);
            this.Shown += new System.EventHandler(this.FrmFind_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox edText;
        private System.Windows.Forms.CheckBox ckCaseSensitive;
        private System.Windows.Forms.CheckBox ckFromCurrentPos;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckWholeWord;
        private System.Windows.Forms.Label lbInfo;
    }
}