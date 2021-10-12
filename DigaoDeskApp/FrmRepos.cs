using LibGit2Sharp;
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

            _gridBind = new();
            _gridBind.DataSource = _repos;

            g.DataSource = _gridBind;

            BuildRepositories();
        }

        private void FrmRepos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position

            Vars.FrmReposObj = null;
        }

        private void BuildRepositories()
        {
            var dir = Vars.Config.ReposDir;

            _repos.Clear();
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

                foreach (var item in r._repoCtrl.RetrieveStatus())
                {
                    edLog.AppendText(item.FilePath + "/" + item.State.ToString() + Environment.NewLine);
                }
            }

            _gridBind.ResetBindings(false);
        }
        
    }
}
