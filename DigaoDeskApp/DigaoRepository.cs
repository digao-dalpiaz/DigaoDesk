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

        private string _path;

        public string Branch
        {
            get
            {
                return _repoCtrl.Head.FriendlyName;
            }
        }

        private Repository _repoCtrl;

        //private FileSystemWatcher _mon = new();

        public DigaoRepository(string path)
        {
            _name = Path.GetFileName(path);
            _path = path;

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
