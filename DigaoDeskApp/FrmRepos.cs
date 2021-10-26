using System;
using System.Collections.Generic;
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
            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position                      

            BuildRepositories();

            _gridBind = new();
            _gridBind.DataSource = _repos;

            g.DataSource = _gridBind;
        }

        private void FrmRepos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position

            Vars.FrmReposObj = null;            
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
            foreach (var item in _repos)
            {
                item.Refresh();
            }

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

        public void Log(string msg)
        {
            edLog.AppendText(msg + Environment.NewLine);
        }

    }
}
