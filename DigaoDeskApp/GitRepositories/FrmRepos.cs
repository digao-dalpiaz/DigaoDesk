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

            LoadLang();

            Utils.SetGridDoubleBuffer(g);
            Utils.AdjustToolStrip(toolBar);

            Log = new(edLog, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gitrepos.log"));
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
                Messages.Error(Vars.Lang.Repos_DenyExitByProcess);
                e.Cancel = true;
            }
        }

        public void LoadLang()
        {
            this.Text = Vars.Lang.Repos_Title;
            btnRefresh.Text = Vars.Lang.Repos_BtnRefreshAll;
            btnFetchAll.Text = Vars.Lang.Repos_BtnFetchAll;
            btnCreateBranch.Text = Vars.Lang.Repos_BtnNewBranch;
            btnDeleteBranch.Text = Vars.Lang.Repos_BtnDelBranch;
            btnCheckoutRemote.Text = Vars.Lang.Repos_BtnCheckout;
            btnSwitchBranch.Text = Vars.Lang.Repos_BtnSwitch;
            btnFetch.Text = Vars.Lang.Repos_BtnFetch;
            btnPull.Text = Vars.Lang.Repos_BtnPull;
            btnCommit.Text = Vars.Lang.Repos_BtnCommit;
            btnCherryPick.Text = Vars.Lang.Repos_BtnCherryPick;
            btnMerge.Text = Vars.Lang.Repos_BtnMerge;
            btnSyncWithMaster.Text = Vars.Lang.Repos_BtnSync;
            btnCancelOperation.Text = Vars.Lang.Repos_BtnCancelOp;
            btnPush.Text = Vars.Lang.Repos_BtnPush;
            btnShell.Text = Vars.Lang.Repos_BtnShell;
            btnRepoConfig.Text = Vars.Lang.Repos_BtnConfig;
            btnClearLog.Text = Vars.Lang.Repos_BtnClearLog;

            stFunInfo.Text = Vars.Lang.Repos_StatusBar_Info;

            colName.HeaderText = Vars.Lang.Repos_ColName;
            colBranch.HeaderText = Vars.Lang.Repos_ColBranch;
            colBranchesCount.HeaderText = Vars.Lang.Repos_ColBranchesCount;
            colUp.HeaderText = Vars.Lang.Repos_ColPendingUp;
            colDown.HeaderText = Vars.Lang.Repos_ColPendingDown;
            colDifs.HeaderText = Vars.Lang.Repos_ColDifs;
            colOtherBranchesDifs.HeaderText = Vars.Lang.Repos_ColOtherBranchesPending;
            colLastFetch.HeaderText = Vars.Lang.Repos_ColLastFetch;
            colOperation.HeaderText = Vars.Lang.Repos_ColOperation;
            colMasterCompare.HeaderText = Vars.Lang.Repos_ColMasterBranchCompare;
        }

        public void LoadConfig()
        {
            Theme.UseImmersiveDarkMode(Handle);
            Theme.setToolStrip(toolBar);
            Theme.setGrid(g);
            Theme.setSplitter(splitter);
            Theme.setConsole(edLog);
            Theme.setStatusStrip(statusBar);
        }

        private void BuildRepositories()
        {
            var dir = Vars.Config.ReposDir;

            if (string.IsNullOrEmpty(dir)) return;

            if (!Directory.Exists(dir))
            {
                Messages.Error(string.Format(Vars.Lang.Repos_GitFolderNotFound, dir));
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
                    Utils.DrawGridImage(images, e, Utils.IsSameGridColumn(col, colUp) ? 0 : 1);

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
                Log.Log(Vars.Lang.Repos_RefreshingAll, Color.Yellow, true);

                foreach (var item in _repos)
                {
                    item.Refresh();
                }

                Log.Log(Vars.Lang.Repos_ProcessDone, Color.Lime);
            });            
        }

        private void btnFetchAll_Click(object sender, EventArgs e)
        {
            DoBackground(() => {
                Log.Log(Vars.Lang.Repos_FetchingAll, Color.Yellow, true);

                foreach (var item in _repos)
                {
                    if (!item.Config.Fetch) continue;

                    Log.Log(string.Format(Vars.Lang.Repos_FetchingRepo, item.Name), Color.White);
                    item.FetchDirectly();
                    item.Refresh();
                }

                Log.Log(Vars.Lang.Repos_ProcessDone, Color.Lime);
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
                    FrmWait.Start(Vars.Lang.Repos_Fetching);
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
                if (string.IsNullOrEmpty(r.Config.MasterBranch)) Messages.ThrowMsg(Vars.Lang.Repos_MasterBranchNotConfigured);
                if (r.MasterBranchCompare == "???") Messages.ThrowMsg(Vars.Lang.Repos_InvalidMasterBranch);
                if (r.MasterBranchCompare == "self") Messages.ThrowMsg(Vars.Lang.Repos_CantSyncAlreadyInMaster);
            })) return;            

            if (Messages.Question(string.Format(Vars.Lang.Repos_ConfirmMergeFromBranch, r.Config.MasterBranch)))
            {
                r.SyncWithMaster();
            }            
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (!Messages.Question(Vars.Lang.Repos_ConfirmPush)) return;

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
            if (!r.Commit())
            {
                r.Refresh();
                _gridBind.ResetBindings(false);
            }
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
