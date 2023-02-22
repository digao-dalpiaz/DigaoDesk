namespace DigaoDeskApp
{
    partial class FrmReorder
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
            list=new System.Windows.Forms.ListBox();
            btnOK=new System.Windows.Forms.Button();
            btnCancel=new System.Windows.Forms.Button();
            panel1=new System.Windows.Forms.Panel();
            panel2=new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // list
            // 
            list.Dock=System.Windows.Forms.DockStyle.Fill;
            list.FormattingEnabled=true;
            list.IntegralHeight=false;
            list.ItemHeight=20;
            list.Location=new System.Drawing.Point(0, 0);
            list.Name="list";
            list.Size=new System.Drawing.Size(617, 400);
            list.TabIndex=0;
            list.DragDrop+=list_DragDrop;
            list.DragOver+=list_DragOver;
            list.MouseDown+=list_MouseDown;
            // 
            // btnOK
            // 
            btnOK.Location=new System.Drawing.Point(8, 8);
            btnOK.Name="btnOK";
            btnOK.Size=new System.Drawing.Size(112, 32);
            btnOK.TabIndex=1;
            btnOK.Text="OK";
            btnOK.UseVisualStyleBackColor=true;
            btnOK.Click+=btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location=new System.Drawing.Point(128, 8);
            btnCancel.Name="btnCancel";
            btnCancel.Size=new System.Drawing.Size(112, 32);
            btnCancel.TabIndex=2;
            btnCancel.Text="Cancel";
            btnCancel.UseVisualStyleBackColor=true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock=System.Windows.Forms.DockStyle.Bottom;
            panel1.Location=new System.Drawing.Point(0, 400);
            panel1.Name="panel1";
            panel1.Size=new System.Drawing.Size(617, 50);
            panel1.TabIndex=3;
            // 
            // panel2
            // 
            panel2.Anchor=System.Windows.Forms.AnchorStyles.Top;
            panel2.Controls.Add(btnOK);
            panel2.Controls.Add(btnCancel);
            panel2.Location=new System.Drawing.Point(184, 0);
            panel2.Name="panel2";
            panel2.Size=new System.Drawing.Size(248, 46);
            panel2.TabIndex=3;
            // 
            // FrmReorder
            // 
            AcceptButton=btnOK;
            AutoScaleDimensions=new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            CancelButton=btnCancel;
            ClientSize=new System.Drawing.Size(617, 450);
            Controls.Add(list);
            Controls.Add(panel1);
            MinimizeBox=false;
            Name="FrmReorder";
            ShowIcon=false;
            ShowInTaskbar=false;
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="Reorder";
            Load+=FrmReorder_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}