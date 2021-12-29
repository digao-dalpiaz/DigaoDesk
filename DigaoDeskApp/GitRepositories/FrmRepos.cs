using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmRepos : Form
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\Repos";

        private List<DigaoRepository> _repos = new();
        private BindingSource _gridBind;

        public LogHighlight Log;

        public FrmRepos()
        {
            InitializeComponent();

            Utils.AdjustToolStrip(toolBar);

            Log = new(edLog);
        }

        private void FrmRepos_Load(object sender, EventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            g.Height = (int)r.GetValue("GridH", g.Height);
            Utils.StringToGridColumns((string)r.GetValue("GridCols", string.Empty), g);

            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position                      

            LoadConfig();

            //

            _gridBind = new();

            BuildRepositories();

            g.DataSource = _gridBind;

            if (_repos.Any())
            {
                btnRefresh.PerformClick();
            } 
            else
            {
                toolBar.Visible = false; //can't use "enabled" because is used to control if there is a process running
            }
        }

        private void FrmRepos_FormClosed(object sender, FormClosedEventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            r.SetValue("GridH", g.Height);
            r.SetValue("GridCols", Utils.GridColumnsToString(g));

            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position

            RepositoriesStore.Save(_repos);

            foreach (var repo in _repos)
            {
                repo.FreeCtrl();
            }

            Vars.FrmReposObj = null;            
        }

        private void FrmRepos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!toolBar.Enabled)
            {
                Messages.Error("There is a process in execution right now");
                e.Cancel = true;
            }
        }

        public void LoadConfig()
        {
            edLog.Font = new Font(Vars.Config.Log.FontName, Vars.Config.Log.FontSize);
            edLog.ForeColor = Vars.Config.Log.TextColor;
            edLog.BackColor = Vars.Config.Log.BgColor;

            edLog.WordWrap = Vars.Config.Log.WordWrap;            
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

            var lstConfigItems = RepositoriesStore.Load();

            var subfolderList = Directory.GetDirectories(dir);
            foreach (var subfolder in subfolderList)
            {
                if (!Directory.Exists(Path.Combine(subfolder, ".git"))) continue;

                DigaoRepository r = new(subfolder);
                _repos.Add(r);

                var configItem = lstConfigItems.Find(x => x.Name.Equals(r.Name, StringComparison.InvariantCultureIgnoreCase));
                if (configItem != null)
                {
                    r.Config = configItem.Config;
                } 
                else
                {
                    r.Config = new();
                }
            }

            ReorderGrid();
        }

        private void ReorderGrid()
        {
            _repos = _repos.OrderBy(x => x.Config.Order).ToList();

            _gridBind.DataSource = _repos;
        }

        private void g_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var col = g.Columns[e.ColumnIndex];

            if (Utils.IsSameGridColumn(col, colBranch))
            {
                var repo = GetRepositoryOfRow(g.Rows[e.RowIndex]);
                if (GitUtils.IsBranchMaster(repo._repoCtrl.Head)) 
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                }
            }
            else if (Utils.IsSameGridColumn(col, colOperation))
            {
                var repo = GetRepositoryOfRow(g.Rows[e.RowIndex]);
                if (repo._repoCtrl.Info.CurrentOperation != CurrentOperation.None)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                }
            }
        }

        private void g_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var col = g.Columns[e.ColumnIndex];

            if (Utils.IsSameGridColumn(col, colUp) || Utils.IsSameGridColumn(col, colDown))
            {
                if (e.Value != null)
                {
                    e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                    images.Draw(e.Graphics, e.CellBounds.X+2, e.CellBounds.Y + ((e.CellBounds.Height - images.ImageSize.Height) / 2), Utils.IsSameGridColumn(col, colUp) ? 0 : 1);

                    e.Handled = true;
                }
            }
        }

        public void DoBackground(Action proc)
        {
            Log.Log();
            this.ProcBackground(true);

            Task.Run(() => {
                try
                {
                    proc();
                }
                catch (Exception ex)
                {
                    Log.Log("ERROR: " + ex.Message, Color.Red);
                }

                this.Invoke(new MethodInvoker(() =>
                {
                    this.ProcBackground(false);
                }));
            });
        }

        private void ProcBackground(bool activate)
        {
            toolBar.Enabled = !activate;
            g.Enabled = !activate;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DoBackground(() => {
                Log.Log("Refreshing all repositories...", Color.Yellow, true);

                foreach (var item in _repos)
                {
                    item.Refresh();
                }

                Log.Log("Done!", Color.Lime);

                this.Invoke(new MethodInvoker(() =>
                {
                    _gridBind.ResetBindings(false);
                }));
            });            
        }

        private void btnFetchAll_Click(object sender, EventArgs e)
        {
            DoBackground(() => {
                Log.Log("Fetch All Repositories", Color.Yellow, true);

                foreach (var item in _repos)
                {
                    Log.Log($"Fetching {item.Name}...", Color.White);
                    item.FetchDirectly();
                    item.Refresh();
                }

                Log.Log("Done!", Color.Lime);

                this.Invoke(new MethodInvoker(() =>
                {
                    _gridBind.ResetBindings(false);
                }));
            });            
        }

        private DigaoRepository GetRepositoryOfRow(DataGridViewRow row)
        {
            return row.DataBoundItem as DigaoRepository;
        }

        private DigaoRepository GetSel()
        {
            if (g.CurrentRow == null) return null;
            return GetRepositoryOfRow(g.CurrentRow);
        }

        private void CheckForAutoFetch()
        {
            if (Vars.Config.GitAutoFetch)
            {
                Messages.SurroundMessageException(() =>
                {
                    FrmWait.Start("Fetching...");
                    try
                    {
                        var r = GetSel();
                        Messages.SurroundExceptionThenThrowMessageException(() => r.FetchDirectly());
                        _gridBind.ResetBindings(false);
                    }
                    finally
                    {
                        FrmWait.Stop();
                    }
                });
            }
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
        
        private void btnSwitchBranch_Click(object sender, EventArgs e)
        {
            var r = GetSel();
            r.SwitchBranch();
        }

        private void btnCheckoutRemote_Click(object sender, EventArgs e)
        {
            CheckForAutoFetch();
            var r = GetSel();
            r.CheckoutRemoteBranch();
        }

        private void btnCreateBranch_Click(object sender, EventArgs e)
        {
            CheckForAutoFetch();
            var r = GetSel();
            r.CreateBranch();
        }

        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            CheckForAutoFetch();
            var r = GetSel();
            r.DeleteBranch();
        }

        private void btnCherryPick_Click(object sender, EventArgs e)
        {
            CheckForAutoFetch();
            var r = GetSel();
            r.CherryPick();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            CheckForAutoFetch();
            var r = GetSel();
            r.Merge();
        }

        private void btnSyncWithMaster_Click(object sender, EventArgs e)
        {
            var r = GetSel();

            if (Messages.SurroundMessageException(() =>
            {
                if (string.IsNullOrEmpty(r.Config.MasterBranch)) Messages.ThrowMsg("Master branch is not configured");
                if (r.MasterBranchCompare == "???") Messages.ThrowMsg("Invalid Master branch");
                if (r.MasterBranchCompare == "self") Messages.ThrowMsg("It's not possible to sync because you are already on master branch");
            })) return;            

            if (Messages.Question($"Confirm merge from branch '{r.Config.MasterBranch}'?"))
            {
                r.SyncWithMaster();
            }            
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (!Messages.Question("Confirm Push?")) return;

            var r = GetSel();
            r.Push();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            var r = GetSel();
            r.CancelOperation();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            var r = GetSel();
            r.Commit();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            var r = GetSel();
            r.OpenShell();
        }

        private void btnRepoConfig_Click(object sender, EventArgs e)
        {
            var r = GetSel();

            FrmRepositoryConfig f = new(r.Config);
            if (f.ShowDialog() == DialogResult.OK)
            {
                r.Refresh();

                ReorderGrid();

                foreach (DataGridViewRow row in g.Rows)
                {
                    if (row.DataBoundItem == r)
                    {
                        g.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            edLog.Clear();
        }

    }
}
