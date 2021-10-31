using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmRepos : Form
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\Repos";

        private List<DigaoRepository> _repos = new();
        private BindingSource _gridBind;

        public FrmRepos()
        {
            InitializeComponent();
        }

        private void FrmRepos_Load(object sender, EventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            g.Height = (int)r.GetValue("GridH", g.Height);
            Utils.StringToGridColumns((string)r.GetValue("GridCols", string.Empty), g);

            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position                      

            LoadConfig();
        }

        private void FrmRepos_FormClosed(object sender, FormClosedEventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            r.SetValue("GridH", g.Height);
            r.SetValue("GridCols", Utils.GridColumnsToString(g));

            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position

            Vars.FrmReposObj = null;            
        }

        public void LoadConfig()
        {
            edLog.Font = new Font(Vars.Config.Log.FontName, Vars.Config.Log.FontSize);
            edLog.ForeColor = Vars.Config.Log.TextColor;
            edLog.BackColor = Vars.Config.Log.BgColor;

            edLog.WordWrap = Vars.Config.Log.WordWrap;            
        }

        private void FrmRepos_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            BuildRepositories();

            _gridBind = new();
            _gridBind.DataSource = _repos;

            g.DataSource = _gridBind;
        }

        private void BuildRepositories()
        {
            var dir = Vars.Config.ReposDir;

            if (string.IsNullOrEmpty(dir)) return;

            if (!Directory.Exists(dir))
            {
                Messages.Error("Git repositories folder not found: " + dir);
                return;
            }

            var subfolderList = Directory.GetDirectories(dir);
            foreach (var subfolder in subfolderList)
            {
                if (!Directory.Exists(Path.Combine(subfolder, ".git"))) continue;

                DigaoRepository r = new(subfolder);
                _repos.Add(r);
            }            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Log(string.Empty, Color.Empty);
            Log("Refreshing all repositories...", Color.Yellow);
            foreach (var item in _repos)
            {
                item.Refresh();
            }
            Log("Done!", Color.Lime);

            _gridBind.ResetBindings(false);
        }

        private DigaoRepository GetSel()
        {
            if (g.CurrentRow == null) return null;
            return g.CurrentRow.DataBoundItem as DigaoRepository;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            var r = GetSel();
            r.Fetch();
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            var r = GetSel();
            r.Pull();
        }      

        public void ProcBackground(bool activate)
        {
            toolBar.Enabled = !activate;
            g.Enabled = !activate;
        }

        public void Log(string msg, Color color)
        {
            edLog.SuspendLayout();

            if (Vars.Config.Log.ShowTimestamp && !string.IsNullOrEmpty(msg))
            {
                edLog.SelectionStart = edLog.TextLength;
                edLog.SelectionColor = Color.Gray;
                edLog.SelectedText = DateTime.Now.ToString(Vars.DATETIME_FMT) + " - ";
            }

            edLog.SelectionStart = edLog.TextLength;
            edLog.SelectionColor = color;
            edLog.SelectedText = msg + Environment.NewLine;

            edLog.ResumePainting(false);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            edLog.Clear();
        }

        private void btnSwitchBranch_Click(object sender, EventArgs e)
        {
            var r = GetSel();
            r.SwitchBranch();
        }

        private void btnCheckoutRemote_Click(object sender, EventArgs e)
        {
            var r = GetSel();
            r.CheckoutRemoteBranch();
        }
    }
}
