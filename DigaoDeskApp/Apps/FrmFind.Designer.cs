
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
            this.label1 = new System.Windows.Forms.Label();
            this.edText = new System.Windows.Forms.TextBox();
            this.ckCaseSensitive = new System.Windows.Forms.CheckBox();
            this.ckFromCurrentPos = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckWholeWord = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // edText
            // 
            this.edText.Location = new System.Drawing.Point(8, 24);
            this.edText.Name = "edText";
            this.edText.Size = new System.Drawing.Size(488, 23);
            this.edText.TabIndex = 1;
            this.edText.TextChanged += new System.EventHandler(this.edText_TextChanged);
            // 
            // ckCaseSensitive
            // 
            this.ckCaseSensitive.AutoSize = true;
            this.ckCaseSensitive.Location = new System.Drawing.Point(8, 64);
            this.ckCaseSensitive.Name = "ckCaseSensitive";
            this.ckCaseSensitive.Size = new System.Drawing.Size(99, 19);
            this.ckCaseSensitive.TabIndex = 2;
            this.ckCaseSensitive.Text = "Case sensitive";
            this.ckCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // ckFromCurrentPos
            // 
            this.ckFromCurrentPos.AutoSize = true;
            this.ckFromCurrentPos.Location = new System.Drawing.Point(8, 112);
            this.ckFromCurrentPos.Name = "ckFromCurrentPos";
            this.ckFromCurrentPos.Size = new System.Drawing.Size(141, 19);
            this.ckFromCurrentPos.TabIndex = 4;
            this.ckFromCurrentPos.Text = "From current position";
            this.ckFromCurrentPos.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(160, 152);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 32);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ckWholeWord
            // 
            this.ckWholeWord.AutoSize = true;
            this.ckWholeWord.Location = new System.Drawing.Point(8, 88);
            this.ckWholeWord.Name = "ckWholeWord";
            this.ckWholeWord.Size = new System.Drawing.Size(90, 19);
            this.ckWholeWord.TabIndex = 3;
            this.ckWholeWord.Text = "Whole word";
            this.ckWholeWord.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(288, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Use F3 key to find next occurrences";
            // 
            // FrmFind
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(505, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckWholeWord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ckFromCurrentPos);
            this.Controls.Add(this.ckCaseSensitive);
            this.Controls.Add(this.edText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edText;
        private System.Windows.Forms.CheckBox ckCaseSensitive;
        private System.Windows.Forms.CheckBox ckFromCurrentPos;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckWholeWord;
        private System.Windows.Forms.Label label2;
    }
}