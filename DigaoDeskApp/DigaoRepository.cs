using LibGit2Sharp;
using System;
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

        private int _difs;
        public int Difs
        {
            get
            {
                return _difs;
            }
        }

        private int _pendingUp;
        public int PendingUp
        {
            get
            {
                return _pendingUp;
            }
        }

        private int _pendingDown;
        public int PedingDown
        {
            get
            {
                return _pendingDown;
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
        }

        private void DoBackground(string cmdName, Action proc, bool performRefresh)
        {
            _frm.ProcBackground(true);
            Log(cmdName);

            Task.Run(() => {
                try
                {
                    proc();
                    Log("Done!");

                    if (performRefresh)
                    {
                        Log("Refreshing...");
                        Refresh();
                        Log("Done!");
                    }
                }
                catch (Exception ex)
                {
                    Log("#ERROR: " + ex.Message);
                }

                _frm.Invoke(new MethodInvoker(() =>
                {
                    _frm.ProcBackground(false);
                }));
            });
        }

        private void Log(string msg)
        {
            _frm.Invoke(new MethodInvoker(() =>
            {
                _frm.Log(msg);
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

                var res = Commands.Pull(_repoCtrl, s, po);

                if (res.Commit != null)
                {
                    StringBuilder sb = new();
                    foreach (var item in res.Commit.Tree)
                    {
                        sb.AppendLine(item.ToString());
                    }
                    Log(sb.ToString());
                }

                switch (res.Status)
                {
                    case MergeStatus.UpToDate:
                        Log("Nothing to change");
                        break;
                    case MergeStatus.Conflicts:
                        Log("Conflicts");
                        break;
                    case MergeStatus.FastForward:
                        Log("Fast forward");
                        break;
                    case MergeStatus.NonFastForward:
                        Log("Non fast forward");
                        break;
                    default:
                        throw new Exception("Unknowk pull result status");
                }

            }, true);            
        }        

    }
}
