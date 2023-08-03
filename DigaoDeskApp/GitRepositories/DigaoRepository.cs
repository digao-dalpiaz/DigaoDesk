using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public class DigaoRepository
    {

        private const CheckoutNotifyFlags CHECKOUT_NOTIFY_FLAGS = 
            CheckoutNotifyFlags.None |
            CheckoutNotifyFlags.Dirty |
            //CheckoutNotifyFlags.Ignored |
            CheckoutNotifyFlags.Conflict |
            //CheckoutNotifyFlags.Untracked |
            CheckoutNotifyFlags.Updated;

        private string _path;
        public Repository _repoCtrl;

        public RepositoryConfigContents Config;

        private RepositoryLogCtrl Log
        {
            get
            {
                return Vars.FrmReposObj.Log;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        private string _branch;
        public string Branch
        {
            get
            {
                return _branch;
            }
        }

        private string _branchesCount;
        public string BranchesCount
        {
            get
            {
                return _branchesCount;
            }
        }

        private int _difs;
        public string Difs
        {
            get
            {
                return _difs > 0 ? _difs.ToString() : null;
            }
        }

        private int _pendingUp;
        public string PendingUp
        {
            get
            {
                return _pendingUp > 0 ? _pendingUp.ToString() : null;
            }
        }

        private int _pendingDown;
        public string PendingDown
        {
            get
            {
                return _pendingDown > 0 ? _pendingDown.ToString() : null;
            }
        }

        private string _othersBranchesDifs;
        public string OthersBranchesDifs
        {
            get
            {
                return _othersBranchesDifs;
            }
        }

        private DateTime? _lastFetchTS;
        public string LastFetchTS
        {
            get
            {
                if (!_lastFetchTS.HasValue) return null;

                var span = DateTime.Now - _lastFetchTS.Value;
                if (span.TotalMinutes < 1) return Vars.Lang.Time_Now;
                if (span.TotalHours < 1) return string.Format(Vars.Lang.Time_MinutesAgo, span.Minutes);
                if (span.TotalDays < 1) return string.Format(Vars.Lang.Time_HoursAgo, span.Hours);
                return string.Format(Vars.Lang.Time_DaysAgo, span.Days);
            }
        }

        private string _currentOperation;
        public string CurrentOperation
        {
            get
            {
                return _currentOperation;
            }
        }

        private string _masterBranchCompare;
        public string MasterBranchCompare
        {
            get
            {
                return _masterBranchCompare;
            }
        }

        public bool DoingBackgroundTask;
        public LogGroup _logGroup;

        public override string ToString()
        {
            return Name;
        }

        public DigaoRepository(string path)
        {
            _path = path;

            _name = Path.GetFileName(path);
            _repoCtrl = new(path);
        }

        public void FreeCtrl()
        {
            _repoCtrl.Dispose();
        }

        public void RefreshDirectly()
        {
            _branch = GitUtils.GetBranchDisplayName(_repoCtrl.Head);

            var fetchFile = Path.Combine(_path, ".git", "FETCH_HEAD");
            if (File.Exists(fetchFile))
            {
                _lastFetchTS = File.GetLastWriteTime(fetchFile);
            } 
            else
            {
                _lastFetchTS = null;
            }

            if (_repoCtrl.Head.IsTracking && _repoCtrl.Head.TrackedBranch.Tip != null)
            {
                var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(_repoCtrl.Head.Tip, _repoCtrl.Head.TrackedBranch.Tip);
                _pendingUp = divergence.AheadBy.Value;
                _pendingDown = divergence.BehindBy.Value;
            } else
            {
                _pendingUp = 0;
                _pendingDown = 0;
            }            

            _difs = GetRepositoryStatus().Count();

            _branchesCount = string.Format(Vars.Lang.Repos_BranchCountFormat,
                _repoCtrl.Branches.Count(x => !x.IsRemote), 
                _repoCtrl.Branches.Count(x => x.IsRemote && !GitUtils.IsBranchOriginHead(x)));

            _othersBranchesDifs = GetOtherBranchesDifs();

            _currentOperation = _repoCtrl.Info.CurrentOperation.ToString();

            string masterComp = null;
            if (!string.IsNullOrEmpty(Config.MasterBranch))
            {
                var masterBranch = _repoCtrl.Branches[Config.MasterBranch];
                if (masterBranch == null)
                {
                    masterComp = "???";
                } else
                if (GitUtils.IsSameBranch(_repoCtrl.Head, masterBranch) || GitUtils.IsBranchLocalAndRemoteLinked(_repoCtrl.Head, masterBranch))
                {
                    masterComp = "self";
                }
                else
                {
                    var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(_repoCtrl.Head.Tip, masterBranch.Tip);

                    List<string> props = new();

                    if (divergence.AheadBy.Value > 0) props.Add(string.Format(Vars.Lang.Repos_AheadFormat, divergence.AheadBy.Value));
                    if (divergence.BehindBy.Value > 0) props.Add(string.Format(Vars.Lang.Repos_BehindFormat, divergence.BehindBy.Value));

                    masterComp = string.Join(", ", props);
                }
            }
            _masterBranchCompare = masterComp;
        }

        private void UntrackBranchIfNeeded(Branch branch)
        {
            if (branch.IsTracking && branch.TrackedBranch.Tip == null)
            {
                _repoCtrl.Branches.Update(branch, b => b.TrackedBranch = null);
                if (_logGroup != null) //if using Auto Fetch, modals trigger fetch without task running
                {
                    _logGroup.Log(string.Format(Vars.Lang.Repos_BranchNoLongerTracked, branch.FriendlyName), LogHighlightType.ALERT);
                }
            }
        }

        private string GetOtherBranchesDifs()
        {
            List<string> difs = new();

            foreach (var item in _repoCtrl.Branches.Where(x => !x.IsRemote && x.IsTracking && !x.IsCurrentRepositoryHead))
            {
                if (item.TrackedBranch.Tip == null) continue;
                var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(item.Tip, item.TrackedBranch.Tip);

                List<string> props = new();

                if (divergence.AheadBy > 0) props.Add(string.Format(Vars.Lang.BranchDivergenceUp, divergence.AheadBy));
                if (divergence.BehindBy > 0) props.Add(string.Format(Vars.Lang.BranchDivergenceDown, divergence.BehindBy));

                if (props.Any())
                {
                    difs.Add(item.FriendlyName + $" ({string.Join(", ", props)})");
                }
            }

            return string.Join(", ", difs);
        }

        private RepositoryStatus GetRepositoryStatus()
        {
            StatusOptions so = new();
            so.IncludeIgnored = false;

            return _repoCtrl.RetrieveStatus(so);
        }

        private void DoCommand(string cmdName, Action proc, bool performRefresh, bool hiddenLog = false)
        {
            if (DoingBackgroundTask) throw new Exception("Already running repository task");

            if (!hiddenLog)
            {
                _logGroup = Log.InitGroup(); //keep in main thread due to sync
            }
            DoingBackgroundTask = true;
            Vars.FrmReposObj.UpdateButtons();
            Vars.FrmReposObj.UpdateRowOfRepository(this);

            Task.Run(() =>
            {
                try
                {
                    if (!hiddenLog)
                    {
                        _logGroup.Log(cmdName, LogHighlightType.TITLE);
                        _logGroup.LogLabel(Vars.Lang.LogLabelRepository, this.Name);
                    }

                    proc();

                    if (performRefresh)
                    {
                        RefreshDirectly();
                    }

                    if (!hiddenLog)
                    {
                        _logGroup.Log(Vars.Lang.LogDone, LogHighlightType.DONE);
                    }
                }
                catch (Exception ex)
                {
                    if (hiddenLog)
                    {
                        Log.FastLog(g => g.Log(string.Format(Vars.Lang.LogRepositoryProcErrorHidden,
                            cmdName, Vars.Config.Theme.RepoLogTitle, ex.Message), LogHighlightType.ERROR));
                    } 
                    else
                    {
                        _logGroup.Log(string.Format(Vars.Lang.LogRepositoryProcError, ex.Message), LogHighlightType.ERROR);
                    }
                }

                Vars.FrmReposObj.Invoke(new MethodInvoker(() =>
                {
                    if (!hiddenLog)
                    {
                        Log.TerminateGroup(_logGroup); //keep in main thread due to sync
                        _logGroup = null;
                    }
                    DoingBackgroundTask = false;
                    Vars.FrmReposObj.UpdateButtons();
                    Vars.FrmReposObj.UpdateRowOfRepository(this);
                }));
            });
        }

        private bool OnCheckoutNotify(string path, CheckoutNotifyFlags notify)
        {
            Color colorFlag = Vars.Config.Theme.RepoLogNormal;
            if (notify.HasFlag(CheckoutNotifyFlags.Updated))
            {
                colorFlag = Vars.Config.Theme.RepoLogStatusOK;
            }
            else if (notify.HasFlag(CheckoutNotifyFlags.Conflict))
            {
                colorFlag = Vars.Config.Theme.RepoLogStatusWarn;
            } 
            else if (notify.HasFlag(CheckoutNotifyFlags.Dirty))
            {
                colorFlag = Vars.Config.Theme.RepoLogStatusNone;
            }

            _logGroup.Log(new LogPart[] { 
                new LogPart($"[{notify.ToString()}] ", colorFlag), 
                new LogPart(path, Vars.Config.Theme.RepoLogNormal) 
            });
            return true;
        }

        private Credentials OnCredentialsProvider(string url, string usernameFromUrl, SupportedCredentialTypes types)
        {
            if (string.IsNullOrEmpty(Vars.Config.Git.CredUsername)) return null;

            UsernamePasswordCredentials c = new();
            c.Username = Vars.Config.Git.CredUsername;
            c.Password = Vars.Config.Git.CredPassword;
            return c;
        }

        private Signature GetSignature()
        {
            if (string.IsNullOrEmpty(Vars.Config.Git.Name)) throw new Exception(Vars.Lang.GitSignatureNameEmpty);
            if (string.IsNullOrEmpty(Vars.Config.Git.Email)) throw new Exception(Vars.Lang.GitSignatureEmailEmpty);

            return new(Vars.Config.Git.Name, Vars.Config.Git.Email, DateTimeOffset.Now);
        }

        private FetchOptions GetFetchOptions()
        {
            FetchOptions fo = new();
            fo.Prune = true;
            fo.TagFetchMode = TagFetchMode.All;
            fo.CredentialsProvider = OnCredentialsProvider;
            return fo;
        }

        private PushOptions GetPushOptions()
        {
            PushOptions po = new();
            po.CredentialsProvider = OnCredentialsProvider;
            return po;
        }

        private MergeOptions GetMergeOptions()
        {
            MergeOptions mo = new();
            mo.OnCheckoutNotify = OnCheckoutNotify;
            mo.CheckoutNotifyFlags = CHECKOUT_NOTIFY_FLAGS;
            return mo;
        }

        private CheckoutOptions GetCheckoutOptions()
        {
            CheckoutOptions co = new();
            co.OnCheckoutNotify = OnCheckoutNotify;
            co.CheckoutNotifyFlags = CHECKOUT_NOTIFY_FLAGS;
            return co;
        }        

        private Remote GetRemoteOrigin()
        {
            return _repoCtrl.Network.Remotes["origin"];
        }

        public void FetchDirectly()
        {
            var remote = GetRemoteOrigin();
            var refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);

            Commands.Fetch(_repoCtrl, remote.Name, refSpecs, GetFetchOptions(), string.Empty);

            foreach (var branch in _repoCtrl.Branches.Where(x => !x.IsRemote))
            {
                UntrackBranchIfNeeded(branch);
            }
        }

        public void RefreshSurrounded()
        {
            DoCommand(null, () =>
            {
                RefreshDirectly();
            }, false, true);
        }

        public void FetchSurrounded()
        {
            DoCommand(null, () =>
            {
                FetchDirectly();
            }, true, true);
        }        

        public void Pull()
        {
            DoCommand(Vars.Lang.LogPull, () =>
            {
                _logGroup.LogLabel(Vars.Lang.LogLabelBranch, _repoCtrl.Head.FriendlyName);

                PullOptions po = new();
                po.FetchOptions = GetFetchOptions();
                po.MergeOptions = GetMergeOptions();                

                var res = Commands.Pull(_repoCtrl, GetSignature(), po);

                LogMergeResult(res);
            }, true);
        }

        private void LogMergeResult(MergeResult res)
        {
            string msg;
            Color color;
            switch (res.Status)
            {
                case MergeStatus.UpToDate:
                    msg = Vars.Lang.LogMergeResult_UpToDate;
                    color = Vars.Config.Theme.RepoLogStatusNone;
                    break;
                case MergeStatus.Conflicts:
                    msg = Vars.Lang.LogMergeResult_Conflicts;
                    color = Vars.Config.Theme.RepoLogStatusWarn;
                    break;
                case MergeStatus.FastForward:
                    msg = Vars.Lang.LogMergeResult_FastForward;
                    color = Vars.Config.Theme.RepoLogStatusOK;
                    break;
                case MergeStatus.NonFastForward:
                    msg = Vars.Lang.LogMergeResult_NonFastForward;
                    color = Vars.Config.Theme.RepoLogStatusOK;
                    break;
                default:
                    throw new Exception("Unknown merge result status");
            }
            _logGroup.Log(new LogPart[] {
                new LogPart(msg, color)
            });
        }

        public void SwitchBranch()
        {
            var lst = _repoCtrl.Branches.Where(x => !x.IsRemote && !x.IsCurrentRepositoryHead);
            if (!lst.Any())
            {
                Messages.Error(Vars.Lang.SwitchBranch_NoOthersLocalBranches);
                return;
            }

            FrmBranchSelector f = new(Vars.Lang.SwitchBranch_Title, false);
            f.AddBranches(lst);

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoCommand(Vars.Lang.LogSwitch, () =>
                {
                    var branch = f.ResultBranch;
                    _logGroup.LogLabel(Vars.Lang.LogLabelBranch, branch.FriendlyName);

                    Commands.Checkout(_repoCtrl, branch, GetCheckoutOptions());
                }, true);
            }
        }

        public void CheckoutRemoteBranch()
        {
            var lstRemainingRemoteBranches = _repoCtrl.Branches.Where(x => x.IsRemote && !GitUtils.IsBranchOriginHead(x) && _repoCtrl.Branches[GitUtils.ExtractBranchNameFromOrigin(x.FriendlyName)] == null);
            if (!lstRemainingRemoteBranches.Any())
            {
                Messages.Error(Vars.Lang.CheckoutBranch_NoOthersRemoteBranches);
                return;
            }

            FrmBranchSelector f = new(Vars.Lang.CheckoutBranch_Title, false);
            f.AddBranches(lstRemainingRemoteBranches);

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoCommand(Vars.Lang.LogCheckout, () =>
                {
                    var remoteBranch = f.ResultBranch;
                    _logGroup.LogLabel(Vars.Lang.LogLabelBranch, remoteBranch.FriendlyName);

                    var localBranchName = GitUtils.ExtractBranchNameFromOrigin(remoteBranch.FriendlyName);
                    var localBranch = _repoCtrl.CreateBranch(localBranchName, remoteBranch.Tip);
                    _repoCtrl.Branches.Update(localBranch, b => b.TrackedBranch = remoteBranch.CanonicalName);

                    Commands.Checkout(_repoCtrl, localBranch, GetCheckoutOptions());
                }, true);
            }
        }

        public void CreateBranch()
        {
            FrmBranchCreate f = new(_repoCtrl);
            if (f.ShowDialog() == DialogResult.OK)
            {
                DoCommand(Vars.Lang.LogCreateBranch, () =>
                {
                    var name = f.ResultParams.Name;
                    _logGroup.LogLabel(Vars.Lang.LogLabelBranch, name);

                    Branch b;

                    if (f.ResultParams.Tag != null)                    
                    {
                        _logGroup.Log(string.Format(Vars.Lang.CreateBranch_CreatingBasedOnTag, f.ResultParams.Tag.FriendlyName), LogHighlightType.PROCESSING);
                        b = _repoCtrl.CreateBranch(name, f.ResultParams.Tag.Target as Commit); //cast already validated in form dialog
                    } else
                    {
                        _logGroup.Log(string.Format(Vars.Lang.CreateBranch_CreatingBasedOnBranch, _repoCtrl.Head.FriendlyName), LogHighlightType.PROCESSING);
                        b = _repoCtrl.CreateBranch(name);
                    }

                    if (f.ResultParams.Switch)
                    {
                        _logGroup.Log(Vars.Lang.CreateBranch_Switching, LogHighlightType.AGG_PROCESSING);
                        Commands.Checkout(_repoCtrl, b, GetCheckoutOptions());
                    }
                }, true);
            }
        }

        public void DeleteBranch()
        {
            var lstBranches = _repoCtrl.Branches.Where(x => !x.IsCurrentRepositoryHead && !GitUtils.IsBranchOriginHead(x) && !GitUtils.IsBranchLocalAndRemoteLinked(_repoCtrl.Head, x));

            if (!lstBranches.Any())
            {
                Messages.Error(Vars.Lang.DeleteBranch_NoOthersBranches);
                return;
            }

            FrmBranchDelete f = new(_repoCtrl);
            f.AddBranches(lstBranches);

            if (f.ShowDialog() == DialogResult.OK)
            {              
                DoCommand(Vars.Lang.LogDeleteBranch, () =>
                {
                    var lst = f.GetListBranchesForDeletion();

                    foreach (var bfd in lst)
                    {
                        _logGroup.LogLabel(Vars.Lang.LogLabelBranch, bfd.Branch.FriendlyName);

                        if (bfd.DelRemote)
                        {
                            _logGroup.Log(Vars.Lang.DeleteBranch_DeletingRemote, LogHighlightType.PROCESSING);
                            _repoCtrl.Network.Push(GetRemoteOrigin(), "+:" + bfd.Branch.UpstreamBranchCanonicalName, GetPushOptions());
                            if (!bfd.Branch.IsRemote)
                            {
                                _repoCtrl.Branches.Update(bfd.Branch, b => b.TrackedBranch = null);
                            }
                        }
                        if (bfd.DelLocal)
                        {
                            _logGroup.Log(Vars.Lang.DeleteBranch_DeletingLocal, LogHighlightType.PROCESSING);
                            _repoCtrl.Branches.Remove(bfd.Branch);
                        }
                    }
                }, true);
            }
        }

        public void CherryPick()
        {
            FrmCherryPick f = new(_repoCtrl);
            if (f.ShowDialog() == DialogResult.OK)
            {
                DoCommand(Vars.Lang.LogCherryPick, () =>
                {
                    _logGroup.LogLabel(Vars.Lang.LogLabelIntoBranch, _repoCtrl.Head.FriendlyName);

                    var lst = f.ResultCommits;
                    lst.Reverse();
                    foreach (var item in lst)
                    {
                        _logGroup.LogLabel(Vars.Lang.LogLabelCommit, item.Id.Sha);
                        _repoCtrl.CherryPick(item, GetSignature());
                    }
                }, true);
            }
        }

        public void Merge()
        {
            var lstBranches = _repoCtrl.Branches.Where(x => !x.IsCurrentRepositoryHead && !GitUtils.IsBranchOriginHead(x) && !GitUtils.IsBranchLocalAndRemoteLinked(_repoCtrl.Head, x));
            if (!lstBranches.Any())
            {
                Messages.Error(Vars.Lang.MergeBranch_NoOtherBranches);
                return;
            }

            FrmBranchSelector f = new(Vars.Lang.MergeBranch_Title, true);
            f.AddBranches(lstBranches);

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoCommand(Vars.Lang.LogMerge, () =>
                {
                    InternalMerge(f.ResultBranch);
                }, true);
            }
        }

        public void SyncWithMaster()
        {
            DoCommand(Vars.Lang.LogSync, () =>
            {
                var masterBranch = _repoCtrl.Branches[Config.MasterBranch];
                if (masterBranch == null) throw new Exception(Vars.Lang.SyncBranch_MasterBranchNotFound);

                if (Vars.Config.GitAutoFetch && masterBranch.IsRemote)
                {
                    _logGroup.Log(Vars.Lang.LogFetching, LogHighlightType.AGG_PROCESSING);
                    FetchDirectly();
                }

                _logGroup.Log(Vars.Lang.SyncBranch_CalculatingDivergence, LogHighlightType.AGG_PROCESSING);                
                var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(_repoCtrl.Head.Tip, masterBranch.Tip);

                int behind = divergence.BehindBy.Value;
                if (behind == 0)
                {
                    _logGroup.Log(Vars.Lang.SyncBrancj_NotBehindMasterBranch, LogHighlightType.ERROR);
                    return; //allow update previous fetch
                }

                _logGroup.Log(string.Format(Vars.Lang.SyncBranch_BehindMasterByCommits, behind), LogHighlightType.NORMAL);

                _logGroup.Log(Vars.Lang.LogMerging, LogHighlightType.PROCESSING);
                InternalMerge(masterBranch);
            }, true);
        }

        private void InternalMerge(Branch from)
        {
            _logGroup.LogLabel(Vars.Lang.LogLabelFromBranch, from.FriendlyName);
            _logGroup.LogLabel(Vars.Lang.LogLabelIntoBranch, _repoCtrl.Head.FriendlyName);

            var res = _repoCtrl.Merge(from, GetSignature(), GetMergeOptions());

            LogMergeResult(res);
        }

        public bool Commit()
        {
            FrmCommit f = new(this);
            DialogResult dr = f.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Continue)
            {
                DoCommand(Vars.Lang.LogCommit, () =>
                {
                    string message = f.ReturnMessage;
                    _logGroup.LogLabel(Vars.Lang.LogLabelBranch, _repoCtrl.Head.FriendlyName);
                    _logGroup.LogLabel(Vars.Lang.LogLabelMessage, message);
                    Commit commit = _repoCtrl.Commit(message, GetSignature(), GetSignature());
                    _logGroup.LogLabel(Vars.Lang.LogLabelCommitId, commit.Sha);

                    if (dr == DialogResult.Continue)
                    {
                        InternalPush();
                    }
                }, true);

                return true;
            }

            return false;
        }

        public void Push()
        {
            DoCommand(Vars.Lang.LogPush, () =>
            {
                _logGroup.LogLabel(Vars.Lang.LogLabelBranch, _repoCtrl.Head.FriendlyName);
                InternalPush();
            }, true);
        }

        private void InternalPush()
        {
            var localBranch = _repoCtrl.Head;

            if (!localBranch.IsTracking)
            {
                _logGroup.Log(Vars.Lang.LogPushLinking, LogHighlightType.ALERT);

                _repoCtrl.Branches.Update(localBranch,
                    b => b.Remote = GetRemoteOrigin().Name,
                    b => b.UpstreamBranch = localBranch.CanonicalName);
            }

            _logGroup.Log(Vars.Lang.LogPushing, LogHighlightType.PROCESSING);
            _repoCtrl.Network.Push(localBranch, GetPushOptions());
        }

        public void CancelOperation()
        {
            if (_repoCtrl.Info.CurrentOperation == LibGit2Sharp.CurrentOperation.None)
            {
                Messages.Error(Vars.Lang.LogNoCurrentOperationToAbort);
                return;
            }

            DoCommand(Vars.Lang.LogReset, () =>
            {
                _logGroup.LogLabel(Vars.Lang.LogLabelBranch, _repoCtrl.Head.FriendlyName);
                _logGroup.LogLabel(Vars.Lang.LogLabelCurrentOperation, _repoCtrl.Info.CurrentOperation.ToString());

                _repoCtrl.Reset(ResetMode.Hard);
            }, true);
        }

        public void OpenShell()
        {
            var cmd = Vars.Config.ShellProgram;
            if (string.IsNullOrEmpty(cmd))
            {
                Messages.Error(Vars.Lang.ShellProgramNotConfigured);
                return;
            }

            RunCustomCommand(cmd, null);   
        }

        public void RunCustomCommand(string cmd, string parameters)
        {
            ProcessStartInfo info = new();
            info.FileName = cmd;
            info.Arguments = parameters;
            info.WorkingDirectory = _path;
            try
            {
                Process.Start(info);
            }
            catch (Exception ex)
            {
                Messages.Error(ex.Message);
            }
        }

    }
}
