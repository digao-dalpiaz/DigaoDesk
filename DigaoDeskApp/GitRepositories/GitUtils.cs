using LibGit2Sharp;

namespace DigaoDeskApp
{
    class GitUtils
    {

        public static bool IsBranchOriginHead(Branch branch)
        {
            return branch.FriendlyName.Equals("origin/HEAD");
        }

        public static bool IsBranchMaster(Branch branch)
        {
            var name = "/" + branch.FriendlyName;

            return name.EndsWith("/master") || name.EndsWith("/main");
        }

        public static string GetBranchDisplayName(Branch branch)
        {
            return (!branch.IsRemote && !branch.IsTracking ? "[untracked] " : "") + branch.FriendlyName;
        }

        public static bool IsSameBranch(Branch branch1, Branch branch2)
        {
            return branch1.FriendlyName.Equals(branch2.FriendlyName);
        }

    }
}
