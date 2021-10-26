using LibGit2Sharp;
using System;
using System.IO;
using System.Linq;

namespace DigaoDeskApp
{
    class DigaoRepository
    {
        
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

        public int Difs
        {
            get
            {
                return _repoCtrl.Diff.Compare<TreeChanges>().Count;
            }
        }

        private HistoryDivergence divergence;

        public int PendingUp
        {
            get
            {
                return divergence.AheadBy.Value;
            }
        }

        public int PedingDown
        {
            get
            {
                return divergence.BehindBy.Value;
            }
        }

        private DateTime _lastFetchTS;
        public string LastFetchTS
        {
            get
            {
                return _lastFetchTS.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        public Repository _repoCtrl;

        public DigaoRepository(string path)
        {
            _name = Path.GetFileName(path);
            _repoCtrl = new(path);

            _lastFetchTS = File.GetLastWriteTime(Path.Combine(path, ".git", "FETCH_HEAD"));

            divergence = _repoCtrl.ObjectDatabase.CalculateHistoryDivergence(_repoCtrl.Head.Tip, _repoCtrl.Head.TrackedBranch.Tip);
        }

        public void Fetch()
        {
            var remote = _repoCtrl.Network.Remotes["origin"];
            var refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);

            FetchOptions fo = new();
            fo.Prune = true;

            Commands.Fetch(_repoCtrl, remote.Name, refSpecs, fo, string.Empty);
        }

        public MergeStatus Pull()
        {
            Signature s = new(Vars.Config.Git.Name, Vars.Config.Git.Email, DateTimeOffset.Now);
            PullOptions po = new();

            var res = Commands.Pull(_repoCtrl, s, po);
            return res.Status;
        }
    }
}
