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

        private LogHighlight Log
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

        private string _masterBranchCompare;
        public string MasterBranchCompare
        {
            get
            {
                return _masterBranchCompare;
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

            _branchesCount =
                "Local: " + _repoCtrl.Branches.Count(x => !x.IsRemote) + 
                " / Remote: " + _repoCtrl.Branches.Count(x => x.IsRemote && !GitUtils.IsBranchOriginHead(x));

            _othersBranchesDifs = GetOtherBranchesDifs();

            _currentOperation = _repoCtrl.Info.CurrentOperation.ToString();

            string masterComp = null;
            if (!string.IsNullOrEmpty(Config.MasterBranch))
            {
                var masterBranch = _repoCtrl.Branches[Config.MasterBranch];
                if (masterBranch == null)
                {
                    masterComp= "???";
                } else
                if (GitUtils.IsSameBranch(_repoCtrl.Head, masterBranch) || GitUtils.IsBranchLocalAndRemoteLinked(_repoCtrl.Head, masterBranch))
                {
                    masterComp = "self";
                }
                else
                {
                    var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(_repoCtrl.Head.Tip, masterBranch.Tip);

                    List<string> props = new();

                    if (divergence.AheadBy.Value > 0) props.Add($"Ahead: {divergence.AheadBy.Value}");
                    if (divergence.BehindBy.Value > 0) props.Add($"Behind: {divergence.BehindBy.Value}");

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
                Log.Log($"Branch '{branch.FriendlyName}' is no longer tracked", Color.Fuchsia);
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
                Log.Log(cmdName, Color.Yellow, true);
                proc();
                Log.Log("Done!", Color.Lime);

                if (performRefresh)
                {
                    Log.Log("Refreshing...", Color.BlueViolet);
                    Refresh();
                    Log.Log("Done!", Color.MediumPurple);
                }
            });                   
        }

        private bool OnCheckoutNotify(string path, CheckoutNotifyFlags notify)
        {
            Log.Log(notify.ToString() + " : " + path, Color.Orange);
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
            if (string.IsNullOrEmpty(Vars.Config.Git.Name)) throw new Exception("Git signature name is empty. Please check Settings!");
            if (string.IsNullOrEmpty(Vars.Config.Git.Email)) throw new Exception("Git signature email is empty. Please check Settings!");

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
                Log.LogLabel("Branch", _repoCtrl.Head.FriendlyName);

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
            Log.Log(msgResult, Color.White);
        }

        public void SwitchBranch()
        {
            var lst = _repoCtrl.Branches.Where(x => !x.IsRemote && !x.IsCurrentRepositoryHead);
            if (!lst.Any())
            {
                Messages.Error("There are no other local branches to switch");
                return;
            }

            FrmBranchSelector f = new("Switch Local Branch", false);
            f.AddBranches(lst);

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Switch Local Branch", () =>
                {
                    var branch = f.ResultBranch;
                    Log.LogLabel("Branch", branch.FriendlyName);

                    Commands.Checkout(_repoCtrl, branch, GetCheckoutOptions());
                }, true);
            }
        }

        public void CheckoutRemoteBranch()
        {
            var lstRemainingRemoteBranches = _repoCtrl.Branches.Where(x => x.IsRemote && !GitUtils.IsBranchOriginHead(x) && _repoCtrl.Branches[GitUtils.ExtractBranchNameFromOrigin(x.FriendlyName)] == null);
            if (!lstRemainingRemoteBranches.Any())
            {
                Messages.Error("There are no other remote branches to checkout");
                return;
            }

            FrmBranchSelector f = new("Checkout Remote Branch", false);
            f.AddBranches(lstRemainingRemoteBranches);

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Checkout Remote Branch", () =>
                {
                    var remoteBranch = f.ResultBranch;
                    Log.LogLabel("Branch", remoteBranch.FriendlyName);

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
                DoBackground("Create New Branch", () =>
                {
                    var name = f.ResultParams.Name;
                    Log.LogLabel("Branch", name);

                    Branch b;

                    if (f.ResultParams.Tag != null)                    
                    {
                        Log.Log("Creating branch based on tag " + f.ResultParams.Tag.FriendlyName, Color.MediumAquamarine);
                        b = _repoCtrl.CreateBranch(name, f.ResultParams.Tag.Target as Commit); //cast already validated in form dialog
                    } else
                    {
                        Log.Log("Creating branch based on branch " + _repoCtrl.Head.FriendlyName, Color.MediumAquamarine);
                        b = _repoCtrl.CreateBranch(name);
                    }

                    if (f.ResultParams.Switch)
                    {
                        Log.Log("Switching to new branch", Color.Tan);
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
                    Log.LogLabel("Branch", f.FormParams.Branch.FriendlyName);

                    if (f.FormParams.Remote)
                    {
                        Log.Log("Deleting remote branch...", Color.Orange);
                        _repoCtrl.Network.Push(GetRemoteOrigin(), "+:" + f.FormParams.Branch.UpstreamBranchCanonicalName, GetPushOptions());
                        _repoCtrl.Branches.Update(f.FormParams.Branch, b => b.TrackedBranch = null);
                    }
                    if (f.FormParams.Local)
                    {
                        Log.Log("Deleting local branch...", Color.Orange);
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
                    Log.LogLabel("Into Branch", _repoCtrl.Head.FriendlyName);

                    var lst = f.ResultCommits;
                    lst.Reverse();
                    foreach (var item in lst)
                    {
                        Log.LogLabel("Commit", item.Id.Sha);
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
                Messages.Error("There are no other branches to merge from");
                return;
            }

            FrmBranchSelector f = new("Merge From Branch", true);
            f.AddBranches(lstBranches);

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Merge", () =>
                {
                    InternalMerge(f.ResultBranch);
                }, true);
            }
        }

        public void SyncWithMaster()
        {
            DoBackground("Merge (Sync from Master Branch)", () =>
            {
                var masterBranch = _repoCtrl.Branches[Config.MasterBranch];
                if (masterBranch == null) throw new Exception("Master branch not found");

                if (Vars.Config.GitAutoFetch && masterBranch.IsRemote)
                {
                    Log.Log("Fetching...", Color.Cyan);
                    FetchDirectly();
                }

                Log.Log("Calculating divergence...", Color.Cyan);                
                var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(_repoCtrl.Head.Tip, masterBranch.Tip);

                int behind = divergence.BehindBy.Value;
                if (behind == 0)
                {
                    Log.Log("Current branch is not behind master branch", Color.Orange);
                    return; //allow update previous fetch
                }

                Log.Log($"Current branch is behind master by {behind} commit(s)", Color.Violet);

                Log.Log("Merging...", Color.Cyan);
                InternalMerge(masterBranch);
            }, true);
        }

        private void InternalMerge(Branch from)
        {
            Log.LogLabel("From Branch", from.FriendlyName);
            Log.LogLabel("Into Branch", _repoCtrl.Head.FriendlyName);

            var res = _repoCtrl.Merge(from, GetSignature(), GetMergeOptions());

            LogMergeResult(res);
        }

        public void Commit()
        {
            FrmCommit f = new(this);
            DialogResult dr = f.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Continue)
            {
                DoBackground("Commit", () =>
                {
                    string message = f.ReturnMessage;
                    Log.LogLabel("Branch", _repoCtrl.Head.FriendlyName);
                    Log.LogLabel("Message", message);
                    Commit commit = _repoCtrl.Commit(message, GetSignature(), GetSignature());
                    Log.LogLabel("Commit Id", commit.Sha);

                    if (dr == DialogResult.Continue)
                    {
                        InternalPush();
                    }
                }, true);
            }
        }

        public void Push()
        {
            DoBackground("Push", () =>
            {
                Log.LogLabel("Branch", _repoCtrl.Head.FriendlyName);
                InternalPush();
            }, true);
        }

        private void InternalPush()
        {
            var localBranch = _repoCtrl.Head;

            if (!localBranch.IsTracking)
            {
                Log.Log("The branch is not currently linked to a remote one. Making the link now...", Color.Orange);

                _repoCtrl.Branches.Update(localBranch,
                    b => b.Remote = GetRemoteOrigin().Name,
                    b => b.UpstreamBranch = localBranch.CanonicalName);
            }

            Log.Log("Pushing...", Color.Cyan);
            _repoCtrl.Network.Push(localBranch, GetPushOptions());
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
                Log.LogLabel("Branch", _repoCtrl.Head.FriendlyName);
                Log.LogLabel("Current Operation", _repoCtrl.Info.CurrentOperation.ToString());

                _repoCtrl.Reset(ResetMode.Hard);
            }, true);
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
