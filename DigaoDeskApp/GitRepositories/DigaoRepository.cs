using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    class DigaoRepository
    {

        private const string ORIGIN_HEAD = "origin/HEAD";

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

        public DigaoRepository(string path)
        {
            _path = path;

            _name = Path.GetFileName(path);
            _repoCtrl = new(path);
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

            if (_repoCtrl.Head.IsTracking)
            {
                var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(_repoCtrl.Head.Tip, _repoCtrl.Head.TrackedBranch.Tip);
                _pendingUp = divergence.AheadBy.Value;
                _pendingDown = divergence.BehindBy.Value;
            } else
            {
                _pendingUp = 0;
                _pendingUp = 0;
            }            

            _difs = _repoCtrl.Diff.Compare<TreeChanges>().Count;

            _branchesCount =
                "Local: " + _repoCtrl.Branches.Count(x => !x.IsRemote) + 
                " / Remote: " + _repoCtrl.Branches.Count(x => x.IsRemote && !x.FriendlyName.Equals(ORIGIN_HEAD));

            _othersBranchesDifs = GetOtherBranchesDifs();
        }

        private string GetOtherBranchesDifs()
        {
            List<string> difs = new();

            foreach (var item in _repoCtrl.Branches.Where(x => !x.IsRemote && x.IsTracking && !x.FriendlyName.Equals(_repoCtrl.Head.FriendlyName)))
            {
                var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(item.Tip, item.TrackedBranch.Tip);

                List<string> props = new();

                if (divergence.AheadBy > 0) props.Add("Ahead: " + divergence.AheadBy);
                if (divergence.BehindBy > 0) props.Add("Behind: " + divergence.BehindBy);

                if (props.Any())
                {
                    difs.Add(item.FriendlyName + $" ({string.Join(", ", props)})");
                }
            }

            return string.Join(", ", difs);
        }

        private void DoBackground(string cmdName, Action proc, bool performRefresh)
        {
            Vars.FrmReposObj.DoBackground(() =>
            {
                Log(string.Empty, Color.Empty);
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

        public void Fetch()
        {
            DoBackground("Fetch", () =>
            {
                var remote = _repoCtrl.Network.Remotes["origin"];
                var refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);

                FetchOptions fo = new();
                fo.Prune = true;

                Commands.Fetch(_repoCtrl, remote.Name, refSpecs, fo, string.Empty);
            }, true);
        }        

        public void Pull()
        {
            DoBackground("Pull", () =>
            {
                Signature s = new(Vars.Config.Git.Name, Vars.Config.Git.Email, DateTimeOffset.Now);
                PullOptions po = new();
                po.MergeOptions = new();
                po.MergeOptions.OnCheckoutNotify = OnCheckoutNotify;
                po.MergeOptions.CheckoutNotifyFlags = CHECKOUT_NOTIFY_FLAGS;

                var res = Commands.Pull(_repoCtrl, s, po);

                /*if (res.Commit != null)
                {
                    StringBuilder sb = new();
                    foreach (var item in res.Commit.Tree)
                    {
                        sb.AppendLine(item.ToString());
                    }
                    Log(sb.ToString());
                }*/

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
                        throw new Exception("Unknowk pull result status");
                }
                Log(msgResult, Color.White);

            }, true);
        }

        public void SwitchBranch()
        {
            var lst = _repoCtrl.Branches.Where(x => !x.IsRemote && !x.FriendlyName.Equals(_repoCtrl.Head.FriendlyName));
            if (!lst.Any())
            {
                Messages.Error("There are no other local branches to switch");
                return;
            }

            FrmBranchCheckout f = new();

            foreach (var item in lst)
            {
                f.l.Items.Add(item.FriendlyName);
            }

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Switch Local Branch", () =>
                {
                    var branch = _repoCtrl.Branches[(string)f.l.SelectedItem];

                    CheckoutOptions co = new();
                    co.OnCheckoutNotify = OnCheckoutNotify;
                    co.CheckoutNotifyFlags = CHECKOUT_NOTIFY_FLAGS;

                    Commands.Checkout(_repoCtrl, branch, co);
                }, true);
            }

        }

        public void CheckoutRemoteBranch()
        {
            var lstLocalBranchesTracked = _repoCtrl.Branches.Where(x => !x.IsRemote && x.IsTracking);
            var lstRemainingRemoteBranches = _repoCtrl.Branches.Where(x => x.IsRemote && !x.FriendlyName.Equals(ORIGIN_HEAD) && !lstLocalBranchesTracked.Any(y => y.TrackedBranch.FriendlyName.Equals(x.FriendlyName)));
            if (!lstRemainingRemoteBranches.Any())
            {
                Messages.Error("There are no other remote branches to checkout");
                return;
            }

            FrmBranchCheckout f = new();

            foreach (var item in lstRemainingRemoteBranches)
            {
                f.l.Items.Add(item.FriendlyName);
            }

            if (f.ShowDialog() == DialogResult.OK)
            {
                DoBackground("Checkout Remote Branch", () =>
                {
                    const string PREFIX = "origin/";
                    var remoteBranch = _repoCtrl.Branches[(string)f.l.SelectedItem];
                    if (!remoteBranch.FriendlyName.StartsWith(PREFIX))
                    {
                        throw new Exception("Invalid remote branch name");
                    }

                    var localBranch = _repoCtrl.CreateBranch(remoteBranch.FriendlyName.Substring(PREFIX.Length), remoteBranch.Tip);
                    _repoCtrl.Branches.Update(localBranch, b => b.TrackedBranch = remoteBranch.CanonicalName);

                    CheckoutOptions co = new();
                    co.OnCheckoutNotify = OnCheckoutNotify;
                    co.CheckoutNotifyFlags = CHECKOUT_NOTIFY_FLAGS;

                    Commands.Checkout(_repoCtrl, localBranch, co);
                }, true);
            }

        }

    }
}
