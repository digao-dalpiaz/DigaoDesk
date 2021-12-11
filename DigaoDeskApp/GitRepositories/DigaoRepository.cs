using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    class DigaoRepository
    {    

        public static bool IsBranchOriginHead(Branch branch)
        {
            return branch.FriendlyName.Equals("origin/HEAD");
        }

        private const CheckoutNotifyFlags CHECKOUT_NOTIFY_FLAGS = 
            CheckoutNotifyFlags.None |
            CheckoutNotifyFlags.Dirty |
            //CheckoutNotifyFlags.Ignored |
            CheckoutNotifyFlags.Conflict |
            //CheckoutNotifyFlags.Untracked |
            CheckoutNotifyFlags.Updated;

        private string _path;
        public Repository _repoCtrl;

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
                if (span.TotalMinutes < 1) return "Now";
                if (span.TotalHours < 1) return $"{span.Minutes} minute(s) ago";
                if (span.TotalDays < 1) return $"{span.Hours} hour(s) ago";
                return $"{span.Days} days ago";
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

        public void Refresh()
        {
            _branch = _repoCtrl.Head.FriendlyName;

            var fetchFile = Path.Combine(_path, ".git", "FETCH_HEAD");
            if (File.Exists(fetchFile))
            {
                _lastFetchTS = File.GetLastWriteTime(fetchFile);
            } 
            else
            {
                _lastFetchTS = null;
            }

            CheckIfUntrackedBranch();
            if (_repoCtrl.Head.IsTracking)
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

            _branchesCount =
                "Local: " + _repoCtrl.Branches.Count(x => !x.IsRemote) + 
                " / Remote: " + _repoCtrl.Branches.Count(x => x.IsRemote && !IsBranchOriginHead(x));

            _othersBranchesDifs = GetOtherBranchesDifs();

            _currentOperation = _repoCtrl.Info.CurrentOperation.ToString();
        }

        private void CheckIfUntrackedBranch()
        {
            if (_repoCtrl.Head.IsTracking && _repoCtrl.Head.TrackedBranch.Tip == null)
            {
                _repoCtrl.Branches.Update(_repoCtrl.Head, b => b.TrackedBranch = null);
                Log($"Branch '{_repoCtrl.Head.FriendlyName}' is no longer tracked", Color.Fuchsia);
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

                if (divergence.AheadBy > 0) props.Add("Up: " + divergence.AheadBy);
                if (divergence.BehindBy > 0) props.Add("Down: " + divergence.BehindBy);

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

        private void DoBackground(string cmdName, Action proc, bool performRefresh)
        {
            Vars.FrmReposObj.DoBackground(() =>
            {
                Log(cmdName, Color.Yellow);
                proc();
                Log("Done!", Color.Lime);

                if (performRefresh)
                {
                    Log("Refreshing...", Color.Purple);
                    Refresh();
                    Log("Done!", Color.MediumPurple);
                }
            });                   
        }

        private void Log(string msg, Color color)
        {
            Vars.FrmReposObj.Log(msg, color);
        }

        private bool OnCheckoutNotify(string path, CheckoutNotifyFlags notify)
        {
            Log(notify.ToString() + " : " + path, Color.Orange);
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
            return new(Vars.Config.Git.Name, Vars.Config.Git.Email, DateTimeOffset.Now);
        }

        private FetchOptions GetFetchOptions()
        {
            FetchOptions fo = new();
            fo.Prune = true;
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
        }

        public void Fetch()
        {
            DoBackground("Fetch", () =>
            {
                FetchDirectly();
            }, true);
        }        

        public void Pull()
        {
            DoBackground("Pull", () =>
            {
                PullOptions po = new();
                po.FetchOptions = GetFetchOptions();
                po.MergeOptions = GetMergeOptions();                

                var res = Commands.Pull(_repoCtrl, GetSignature(), po);

                LogMergeResult(res);
            }, true);
        }

        private void LogMergeResult(MergeResult res)
        {
            string msgResult;
            switch (res.Status)
            {
                case MergeStatus.UpToDate:
                    msgResult = "Nothing to change";
                    break;
                case MergeStatus.Conflicts:
                    msgResult = "Conflicts";
                    break;
                case MergeStatus.FastForward:
                    msgResult = "Fast forward";
                    break;
                case MergeStatus.NonFastForward:
                    msgResult = "Non fast forward";
                    break;
                default:
                    throw new Exception("Unknown pull result status");
            }
            Log(msgResult, Color.White);
        }

        public void SwitchBranch()
        {
            var lst = _repoCtrl.Branches.Where(x => !x.IsRemote && !x.IsCurrentRepositoryHead);
            if (!lst.Any())
            {
                Messages.Error("There are no other local branches to switch");
                return;
            }

            FrmBranchCheckout f = new("Switch Local Branch");
            f.AddBranches(lst);

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Switch Local Branch", () =>
                {
                    var branch = f.ResultBranch;

                    Commands.Checkout(_repoCtrl, branch, GetCheckoutOptions());
                }, true);
            }

        }

        public void CheckoutRemoteBranch()
        {
            var lstLocalBranchesTracked = _repoCtrl.Branches.Where(x => !x.IsRemote && x.IsTracking);
            var lstRemainingRemoteBranches = _repoCtrl.Branches.Where(x => x.IsRemote && !IsBranchOriginHead(x) && !lstLocalBranchesTracked.Any(y => y.TrackedBranch.FriendlyName.Equals(x.FriendlyName)));
            if (!lstRemainingRemoteBranches.Any())
            {
                Messages.Error("There are no other remote branches to checkout");
                return;
            }

            FrmBranchCheckout f = new("Checkout Remote Branch");
            f.AddBranches(lstRemainingRemoteBranches);

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Checkout Remote Branch", () =>
                {
                    const string PREFIX = "origin/";
                    var remoteBranch = f.ResultBranch;
                    if (!remoteBranch.FriendlyName.StartsWith(PREFIX))
                    {
                        throw new Exception("Invalid remote branch name");
                    }

                    var localBranch = _repoCtrl.CreateBranch(remoteBranch.FriendlyName.Substring(PREFIX.Length), remoteBranch.Tip);
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
                DoBackground("Create New Branch", () =>
                {
                    var name = f.ResultParams.Name;
                    Log("Name: " + name, Color.White);

                    Branch b;

                    if (f.ResultParams.Tag != null)                    
                    {
                        Log("Creating branch based on tag " + f.ResultParams.Tag.FriendlyName, Color.MediumAquamarine);
                        b = _repoCtrl.CreateBranch(name, f.ResultParams.Tag.Target as Commit); //cast already validated in form dialog
                    } else
                    {
                        Log("Creating branch based on branch " + _repoCtrl.Head.FriendlyName, Color.MediumAquamarine);
                        b = _repoCtrl.CreateBranch(name);
                    }

                    if (f.ResultParams.Switch)
                    {
                        Log("Switching to new branch", Color.Gray);
                        Commands.Checkout(_repoCtrl, b, GetCheckoutOptions());
                    }
                }, true);
            }
        }

        public void DeleteBranch()
        {
            var localBranches = _repoCtrl.Branches.Where(x => !x.IsRemote && !x.IsCurrentRepositoryHead);

            if (!localBranches.Any())
            {
                Messages.Error("There are no other local branches than the current one to delete");
                return;
            }

            FrmBranchDelete f = new();
            f.AddBranches(localBranches);

            if (f.ShowDialog() == DialogResult.OK)
            {              
                DoBackground("Delete Branch", () =>
                {
                    Log("Branch: " + f.FormParams.Branch.FriendlyName, Color.White);

                    if (f.FormParams.Remote)
                    {
                        Log("Deleting remote branch...", Color.Orange);
                        _repoCtrl.Network.Push(GetRemoteOrigin(), "+:" + f.FormParams.Branch.UpstreamBranchCanonicalName, GetPushOptions());
                        _repoCtrl.Branches.Update(f.FormParams.Branch, b => b.TrackedBranch = null);
                    }
                    if (f.FormParams.Local)
                    {
                        Log("Deleting local branch...", Color.Orange);
                        _repoCtrl.Branches.Remove(f.FormParams.Branch);
                    }
                }, true);
            }
        }

        public void CherryPick()
        {
            FrmCherryPick f = new(_repoCtrl);
            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Cherry Pick", () =>
                {
                    Log("Commit: " + f.ResultCommit.Id, Color.White);
                                        
                    _repoCtrl.CherryPick(f.ResultCommit, GetSignature());
                }, true);
            }
        }

        public void Merge()
        {
            FrmBranchCheckout f = new("Merge From Branch");
            f.AddBranches(_repoCtrl.Branches.Where(x => {
                if (IsBranchOriginHead(x)) return false;
                if (x.IsCurrentRepositoryHead) return false;
                if (_repoCtrl.Head.IsTracking)
                {
                    if (_repoCtrl.Head.TrackedBranch.FriendlyName.Equals(x.FriendlyName)) return false;
                }
                return true;
            }));

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Merge", () =>
                {
                    var from = f.ResultBranch;
                    Log("From Branch: " + from.FriendlyName, Color.White);
                    Log("Into Branch: " + _repoCtrl.Head.FriendlyName, Color.White);

                    var res = _repoCtrl.Merge(from, GetSignature(), GetMergeOptions());

                    LogMergeResult(res);

                }, true);
            }
        }

        public void Push()
        {
            DoBackground("Push", () =>
            {
                var localBranch = _repoCtrl.Head;
                Log("Branch: " + localBranch.FriendlyName, Color.White);

                if (!localBranch.IsTracking)
                {
                    Log("The branch is not currently linked to a remote one. Making the link now...", Color.Orange);

                    _repoCtrl.Branches.Update(localBranch,
                        b => b.Remote = GetRemoteOrigin().Name,
                        b => b.UpstreamBranch = localBranch.CanonicalName);
                }

                Log("Pushing...", Color.Cyan);
                _repoCtrl.Network.Push(localBranch, GetPushOptions());
            }, true);
        }

        public void CancelOperation()
        {
            if (_repoCtrl.Info.CurrentOperation == LibGit2Sharp.CurrentOperation.None)
            {
                Messages.Error("There is no current operation to abort");
                return;
            }

            DoBackground("Reset", () =>
            {
                _repoCtrl.Reset(ResetMode.Hard);
            }, true);
        }

        public void ShowDifs()
        {
            Log(string.Empty, Color.Empty);
            Log("Difs", Color.Yellow);

            var status = GetRepositoryStatus();

            if (status.Any())
            {
                foreach (var item in status)
                {
                    Log(item.State.ToString() + " : " + item.FilePath, Color.Cyan);
                }
            } 
            else
            {
                Log("There are no difs", Color.White);
            }
        }

        public void OpenShell()
        {
            var cmd = Vars.Config.ShellProgram;
            if (string.IsNullOrEmpty(cmd))
            {
                Messages.Error("Shell program is not configured. Please go to Settings dialog.");
                return;
            }

            ProcessStartInfo info = new();
            info.FileName = cmd;
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
