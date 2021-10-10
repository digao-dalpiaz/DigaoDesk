
namespace DigaoDeskApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDigaoDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.miVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.menu;
            this.tray.Text = "Digao Desk";
            this.tray.Visible = true;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDigaoDesk,
            this.miVersion,
            this.toolStripMenuItem1,
            this.miApplications,
            this.miConfig,
            this.miSeparator,
            this.miExit});
            this.menu.Name = "Menu";
            this.menu.Size = new System.Drawing.Size(157, 206);
            // 
            // miDigaoDesk
            // 
            this.miDigaoDesk.Image = ((System.Drawing.Image)(resources.GetObject("miDigaoDesk.Image")));
            this.miDigaoDesk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miDigaoDesk.Name = "miDigaoDesk";
            this.miDigaoDesk.Size = new System.Drawing.Size(156, 38);
            this.miDigaoDesk.Text = "Digao Desk";
            this.miDigaoDesk.Click += new System.EventHandler(this.miDigaoDesk_Click);
            // 
            // miVersion
            // 
            this.miVersion.Name = "miVersion";
            this.miVersion.Size = new System.Drawing.Size(156, 38);
            this.miVersion.Text = "Version";
            this.miVersion.Click += new System.EventHandler(this.miVersion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // miApplications
            // 
            this.miApplications.Image = ((System.Drawing.Image)(resources.GetObject("miApplications.Image")));
            this.miApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miApplications.Name = "miApplications";
            this.miApplications.Size = new System.Drawing.Size(156, 38);
            this.miApplications.Text = "Applications";
            this.miApplications.Click += new System.EventHandler(this.miApplications_Click);
            // 
            // miSeparator
            // 
            this.miSeparator.Name = "miSeparator";
            this.miSeparator.Size = new System.Drawing.Size(153, 6);
            // 
            // miExit
            // 
            this.miExit.Image = ((System.Drawing.Image)(resources.GetObject("miExit.Image")));
            this.miExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(156, 38);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miConfig
            // 
            this.miConfig.Name = "miConfig";
            this.miConfig.Size = new System.Drawing.Size(156, 38);
            this.miConfig.Text = "Settings";
            this.miConfig.Click += new System.EventHandler(this.miConfig_Click);
            // 
            // images
            // 
            this.images.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "off");
            this.images.Images.SetKeyName(1, "on");
            this.images.Images.SetKeyName(2, "error");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 286);
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miApplications;
        private System.Windows.Forms.ToolStripSeparator miSeparator;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.ToolStripMenuItem miDigaoDesk;
        private System.Windows.Forms.ToolStripMenuItem miVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miConfig;
    }
}

