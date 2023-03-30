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
            EventAudit.Do("Load Repos form");

            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            g.Height = (int)r.GetValue("GridH", g.Height);
            Utils.StringToGridColumns((string)r.GetValue("GridCols", string.Empty), g);

            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position                      

            LoadConfig();

            BuildShellCustomCommands();

            //

            BuildRepositories();

            _gridBind = new();
            _gridBind.DataSource = _repos;
            g.DataSource = _gridBind;

            if (!_repos.Any())
            {
                toolBar.Visible = false; //can't use "enabled" because is used to control if there is a process running
            }
        }

        private void FrmRepos_Shown(object sender, EventArgs e)
        {
            if (_repos.Any())
            {
                CheckAutoCRLF();

                btnRefresh.PerformClick();
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

            EventAudit.Do("Closed Repos form");
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
            btnConfig.Text = Vars.Lang.Repos_BtnConfig;
            btnRepositorySettings.Text = Vars.Lang.Repos_BtnRepositoryConfig;
            btnReorderList.Text = Vars.Lang.Repos_BtnReorderList;
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

        private void BuildShellCustomCommands()
        {
            var lstStr = Vars.Config.GitCustomCommands;
            if (lstStr == null) return;

            var lst = lstStr.Split(Environment.NewLine);

            foreach (var item in lst)
            {
                var text = item.Trim();
                if (text == string.Empty) continue;

                var parts = text.Split("|");

                CustomCommand cmd = new();
                cmd.Cmd = parts.Length > 1 ? parts[1] : parts[0];
                cmd.Parameters = parts.Length > 2 ? parts[2] : null;
                btnShell.DropDownItems.Add(parts[0], null, btnShellCustomItem_Click).Tag = cmd;
            }

            if (btnShell.DropDownItems.Count > 0)
            {
                ToolStripMenuItem item = new();
                item.Text = Vars.Lang.Repos_BtnShell;
                item.Click += btnShell_Click;
                btnShell.DropDownItems.Insert(0, item);
                btnShell.DropDownItems.Insert(1, new ToolStripSeparator());
            }
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

            var realReposList = Directory.GetDirectories(dir).Where(x => GitUtils.IsGitFolder(x)).Select(x => Path.GetFileName(x)).ToList();

            //Add repositories by stored order
            var lstConfigItems = RepositoriesStore.Load();
            foreach (var item in lstConfigItems)
            {
                var index = realReposList.FindIndex(x => x.Equals(item.Name, StringComparison.InvariantCultureIgnoreCase));
                if (index == -1) continue; //repository no longer exists

                AddRepository(Path.Combine(dir, realReposList[index]), item.Config);
                realReposList.RemoveAt(index);
            }

            //Add new repositories in git folder in the bottom of the list
            foreach (var repoName in realReposList)
            {
                AddRepository(Path.Combine(dir, repoName), new RepositoryConfigContents());
            }
        }

        private void AddRepository(string folder, RepositoryConfigContents configContents)
        {
            DigaoRepository r = new(folder);
            r.Config = configContents;
            _repos.Add(r);
        }

        private void CheckAutoCRLF()
        {
            if (!Vars.Config.GitAutoCRLF) return;
            //ensure all repos have auto-crlf config enable to work with Unix x Win diffs

            const string CFG_AUTOCRLF = "core.autocrlf";

            foreach (var r in _repos)
            {
                if (!r._repoCtrl.Config.Get<bool>(CFG_AUTOCRLF).Value)
                {
                    r._repoCtrl.Config.Set(CFG_AUTOCRLF, true);
                    Log.Log(string.Format(Vars.Lang.Repos_CRLFEnabled, r.Name), LogHighlightType.ALERT);
                }
            }
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
                    e.CellStyle.ForeColor = Color.Cyan;
                    e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                }
            }
            else if (Utils.IsSameGridColumn(col, colOperation))
            {
                var repo = GetRepositoryOfRow(g.Rows[e.RowIndex]);
                if (repo._repoCtrl.Info.CurrentOperation != CurrentOperation.None)
                {
                    e.CellStyle.ForeColor = Color.PaleVioletRed;
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

            Task.Run(() =>
            {
                try
                {
                    proc();
                }
                catch (Exception ex)
                {
                    Log.Log("ERROR: " + ex.Message, LogHighlightType.ERROR);
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
            DoBackground(() =>
            {
                Log.Log(Vars.Lang.Repos_RefreshingAll, LogHighlightType.TITLE);

                foreach (var item in _repos)
                {
                    item.Refresh();
                }

                Log.Log(Vars.Lang.Repos_ProcessDone, LogHighlightType.DONE);
            });
        }

        private void btnFetchAll_Click(object sender, EventArgs e)
        {
            DoBackground(() =>
            {
                Log.Log(Vars.Lang.Repos_FetchingAll, LogHighlightType.TITLE);

                foreach (var item in _repos)
                {
                    if (!item.Config.Fetch) continue;

                    Log.Log(string.Format(Vars.Lang.Repos_FetchingRepo, item.Name), LogHighlightType.PROCESSING);
                    item.FetchDirectly();
                    item.Refresh();
                }

                Log.Log(Vars.Lang.Repos_ProcessDone, LogHighlightType.DONE);
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
            if (sender == btnShell && btnShell.DropDownItems.Count > 0) return;

            var r = GetSel();
            r.OpenShell();
        }

        private void btnShellCustomItem_Click(object sender, EventArgs e)
        {
            var cmd = (CustomCommand)((ToolStripDropDownItem)sender).Tag;

            var r = GetSel();
            r.RunCustomCommand(cmd.Cmd, cmd.Parameters);
        }

        private void btnRepositorySettings_Click(object sender, EventArgs e)
        {
            var r = GetSel();

            FrmRepositoryConfig f = new(r.Config);
            if (f.ShowDialog() == DialogResult.OK)
            {
                r.Refresh();
                _gridBind.ResetBindings(false);
            }
        }

        private void btnReorderList_Click(object sender, EventArgs e)
        {
            if (FrmReorder.ReorderList(_repos, Vars.Lang.Reorder_GitRepositories_Title))
            {
                _gridBind.ResetBindings(false);
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            edLog.Clear();
        }

    }
}
