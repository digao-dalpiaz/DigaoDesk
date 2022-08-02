using LibGit2Sharp;

namespace DigaoDeskApp
{
    internal class BranchSelectorItem
    {

        private Branch _branch;

        public BranchSelectorItem(Branch branch)
        {
            _branch = branch;
        }

        public Branch GetBranch()
        {
            return _branch;
        }

        public string Name
        {
            get
            {
                return GitUtils.GetBranchDisplayName(_branch);
            }
        }

        public string Location
        {
            get
            {
                return _branch.IsRemote ? Vars.Lang.BranchSelector_Remote : Vars.Lang.BranchSelector_Local;
            }
        }

        public string Author
        {
            get
            {
                return _branch.Tip.Author.Name;
            }
        }

        public string Timestamp
        {
            get
            {
                return _branch.Tip.Author.When.ToLocalTime().ToString(Vars.DATETIME_FMT);
            }
        }

    }
}
