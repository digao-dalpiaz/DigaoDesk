using LibGit2Sharp;
using System.IO;

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

        public Repository _repoCtrl;

        public DigaoRepository(string path)
        {
            _name = Path.GetFileName(path);
            _repoCtrl = new(path);
        }

        public MergeStatus Pull()
        {
            Signature s = new(Vars.Config.Git.Name, Vars.Config.Git.Email, System.DateTimeOffset.Now);
            PullOptions po = new();

            var res = Commands.Pull(_repoCtrl, s, po);
            return res.Status;
        }
    }
}
