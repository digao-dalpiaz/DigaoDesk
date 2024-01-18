
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
            components = new System.ComponentModel.Container();
            tray = new System.Windows.Forms.NotifyIcon(components);
            menu = new System.Windows.Forms.ContextMenuStrip(components);
            miDigaoDesk = new System.Windows.Forms.ToolStripMenuItem();
            miVersion = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            miDonate = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            miApplications = new System.Windows.Forms.ToolStripMenuItem();
            miRepos = new System.Windows.Forms.ToolStripMenuItem();
            miConfig = new System.Windows.Forms.ToolStripMenuItem();
            miSeparator = new System.Windows.Forms.ToolStripSeparator();
            miExit = new System.Windows.Forms.ToolStripMenuItem();
            timerApps = new System.Windows.Forms.Timer(components);
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // tray
            // 
            tray.ContextMenuStrip = menu;
            tray.Text = "Digao Desk";
            tray.Visible = true;
            // 
            // menu
            // 
            menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miDigaoDesk, miVersion, toolStripSeparator1, miDonate, toolStripMenuItem1, miApplications, miRepos, miConfig, miSeparator, miExit });
            menu.Name = "Menu";
            menu.Size = new System.Drawing.Size(200, 288);
            // 
            // miDigaoDesk
            // 
            miDigaoDesk.Image = Properties.Resources.menu_title;
            miDigaoDesk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            miDigaoDesk.Name = "miDigaoDesk";
            miDigaoDesk.Size = new System.Drawing.Size(199, 38);
            miDigaoDesk.Text = "Digao Desk";
            miDigaoDesk.Click += miDigaoDesk_Click;
            // 
            // miVersion
            // 
            miVersion.Name = "miVersion";
            miVersion.Size = new System.Drawing.Size(199, 38);
            miVersion.Text = "Version";
            miVersion.Click += miVersion_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // miDonate
            // 
            miDonate.Image = Properties.Resources.menu_donate;
            miDonate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            miDonate.Name = "miDonate";
            miDonate.Size = new System.Drawing.Size(199, 38);
            miDonate.Text = "Donate";
            miDonate.Click += miDonate_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
            // 
            // miApplications
            // 
            miApplications.Image = Properties.Resources.menu_applications;
            miApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            miApplications.Name = "miApplications";
            miApplications.Size = new System.Drawing.Size(199, 38);
            miApplications.Text = "Applications";
            miApplications.Click += miApplications_Click;
            // 
            // miRepos
            // 
            miRepos.Image = Properties.Resources.menu_repos;
            miRepos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            miRepos.Name = "miRepos";
            miRepos.Size = new System.Drawing.Size(199, 38);
            miRepos.Text = "Git Repositories";
            miRepos.Click += miRepos_Click;
            // 
            // miConfig
            // 
            miConfig.Image = Properties.Resources.menu_config;
            miConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            miConfig.Name = "miConfig";
            miConfig.Size = new System.Drawing.Size(199, 38);
            miConfig.Text = "Settings";
            miConfig.Click += miConfig_Click;
            // 
            // miSeparator
            // 
            miSeparator.Name = "miSeparator";
            miSeparator.Size = new System.Drawing.Size(196, 6);
            // 
            // miExit
            // 
            miExit.Image = Properties.Resources.menu_exit;
            miExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            miExit.Name = "miExit";
            miExit.Size = new System.Drawing.Size(199, 38);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // timerApps
            // 
            timerApps.Enabled = true;
            timerApps.Interval = 5000;
            timerApps.Tick += timerApps_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(709, 381);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmMain";
            FormClosing += FrmMain_FormClosing;
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            Shown += FrmMain_Shown;
            menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miApplications;
        private System.Windows.Forms.ToolStripSeparator miSeparator;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miDigaoDesk;
        private System.Windows.Forms.ToolStripMenuItem miVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miConfig;
        public System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ToolStripMenuItem miRepos;
        private System.Windows.Forms.Timer timerApps;
        private System.Windows.Forms.ToolStripMenuItem miDonate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

