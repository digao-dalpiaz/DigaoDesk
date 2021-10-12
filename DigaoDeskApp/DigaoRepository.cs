using LibGit2Sharp;
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

        private Repository _repoCtrl;

        //private FileSystemWatcher _mon = new();

        public DigaoRepository(string path)
        {
            _name = Path.GetFileName(path);
            _repoCtrl = new(path);            
        }

        private void EnableMonitoring()
        {
            //_mon.
        }

        private void UpdateStatus()
        {
            //Commands.Pull(_repoCtrl, Signature, PullOptions)
        }
    }
}
