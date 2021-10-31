using LibGit2Sharp;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    class DigaoRepository
    {

        private string _path;
        public Repository _repoCtrl;

        private FrmRepos _frm
        {
            get
            {
                return Vars.FrmReposObj;
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

        public string Branch
        {
            get
            {
                return _repoCtrl.Head.FriendlyName;
            }
        }

        private int _branchesCount;
        public int BranchesCount
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

        private DateTime? _lastFetchTS;
        public string LastFetchTS
        {
            get
            {
                if (!_lastFetchTS.HasValue) return null;
                return _lastFetchTS.Value.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        public DigaoRepository(string path)
        {
            _path = path;

            _name = Path.GetFileName(path);
            _repoCtrl = new(path);

            Refresh();
        }

        public void Refresh()
        {
            var fetchFile = Path.Combine(_path, ".git", "FETCH_HEAD");
            if (File.Exists(fetchFile))
            {
                _lastFetchTS = File.GetLastWriteTime(fetchFile);
            } 
            else
            {
                _lastFetchTS = null;
            }

            var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(_repoCtrl.Head.Tip, _repoCtrl.Head.TrackedBranch.Tip);
            _pendingUp = divergence.AheadBy.Value;
            _pendingDown = divergence.BehindBy.Value;

            _difs = _repoCtrl.Diff.Compare<TreeChanges>().Count;

            _branchesCount = _repoCtrl.Branches.Count(x => !x.IsRemote);
        }

        private void DoBackground(string cmdName, Action proc, bool performRefresh)
        {
            _frm.ProcBackground(true);
            Log(string.Empty, Color.Empty);
            Log(cmdName, Color.Yellow);

            Task.Run(() => {
                try
                {
                    proc();
                    Log("Done!", Color.Lime);

                    if (performRefresh)
                    {
                        Log("Refreshing...", Color.Purple);
                        Refresh();
                        Log("Done!", Color.MediumPurple);
                    }
                }
                catch (Exception ex)
                {
                    Log("#ERROR: " + ex.Message, Color.Red);
                }

                _frm.Invoke(new MethodInvoker(() =>
                {
                    _frm.ProcBackground(false);
                }));
            });
        }

        private void Log(string msg, Color color)
        {
            _frm.Invoke(new MethodInvoker(() =>
            {
                _frm.Log(msg, color);
            }));
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
                po.MergeOptions.OnCheckoutNotify = (string path, CheckoutNotifyFlags notify) =>
                {
                    Log(notify.ToString() + " : " + path, Color.Orange);
                    return true;
                };
                po.MergeOptions.CheckoutNotifyFlags =
                    CheckoutNotifyFlags.None |
                    CheckoutNotifyFlags.Dirty |
                    //CheckoutNotifyFlags.Ignored |
                    CheckoutNotifyFlags.Conflict |
                    CheckoutNotifyFlags.Untracked |
                    CheckoutNotifyFlags.Updated;

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

        public void CompareLocalBranches()
        {
            bool someDiv = false;

            foreach (var item in _repoCtrl.Branches.Where(x => !x.IsRemote))
            {
                var divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(item.Tip, item.TrackedBranch.Tip);

                if (divergence.AheadBy > 0 || divergence.BehindBy > 0)
                {
                    Log(string.Empty, Color.Empty);
                    Log(item.FriendlyName, Color.LimeGreen);

                    if (divergence.AheadBy > 0) Log("Ahead: " + divergence.AheadBy, Color.White);
                    if (divergence.BehindBy > 0) Log("Behind: " + divergence.BehindBy, Color.White);

                    someDiv = true;
                }
            }

            if (!someDiv)
            {
                Log(string.Empty, Color.Empty);
                Log("All branches have equivalent commits", Color.Lime);
            }
        }

    }
}
