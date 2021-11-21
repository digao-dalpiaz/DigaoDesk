using LibGit2Sharp;

namespace DigaoDeskApp
{
    class BranchView
    {
        private Branch _branch;
        public Branch BranchData
        {
            get
            {
                return _branch;
            }
        }

        public BranchView(Branch branch)
        {
            this._branch = branch;
        }

        public override string ToString()
        {
            return _branch.FriendlyName;
        }
    }
}
