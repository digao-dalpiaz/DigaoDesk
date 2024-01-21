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
            return (!branch.IsRemote && !branch.IsTracking ? string.Format("[{0}] ", Vars.Lang.UntrackedTag) : "") + branch.FriendlyName;
        }

        public static bool IsSameBranch(Branch branch1, Branch branch2)
        {
            return branch1.FriendlyName.Equals(branch2.FriendlyName);
        }

        public static bool IsBranchLocalAndRemoteLinked(Branch local, Branch remote)
        {
            return local.IsTracking && local.TrackedBranch != null && remote.IsRemote && IsSameBranch(local.TrackedBranch, remote);
        }

        public static string ExtractBranchNameFromOrigin(string remoteBranchName)
        {
            const string PREFIX = "origin/";

            if (!remoteBranchName.StartsWith(PREFIX))
            {
                throw new Exception("Invalid remote branch name: " + remoteBranchName);
            }

            return remoteBranchName[PREFIX.Length..];
        }

        public static string GetFileStatusAsString(FileStatus s)
        {
            return s switch
            {
                FileStatus.Nonexistent => "Non-existent",
                FileStatus.Unaltered => "Unaltered",
                FileStatus.NewInIndex or FileStatus.NewInWorkdir => "New",
                FileStatus.ModifiedInIndex or FileStatus.ModifiedInWorkdir => "Modified",
                FileStatus.DeletedFromIndex or FileStatus.DeletedFromWorkdir => "Deleted",
                FileStatus.RenamedInIndex or FileStatus.RenamedInWorkdir => "Renamed",
                FileStatus.TypeChangeInIndex or FileStatus.TypeChangeInWorkdir => "Type change",
                FileStatus.Unreadable => "Unreadable",
                FileStatus.Ignored => "Ignored",
                FileStatus.Conflicted => "Conflicted",
                _ => throw new Exception("Invalid git file status"),
            };
        }

        public static bool IsGitFolder(string path)
        {
            return Directory.Exists(Path.Combine(path, ".git"));
        }

    }
}
