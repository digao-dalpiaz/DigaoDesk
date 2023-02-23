using LibGit2Sharp;
using System;
using System.IO;

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

            return remoteBranchName.Substring(PREFIX.Length);
        }

        public static string GetFileStatusAsString(FileStatus s)
        {
            switch (s)
            {
                case FileStatus.Nonexistent:
                    return "Non-existent";
                case FileStatus.Unaltered:
                    return "Unaltered";
                case FileStatus.NewInIndex:
                case FileStatus.NewInWorkdir:
                    return "New";
                case FileStatus.ModifiedInIndex:
                case FileStatus.ModifiedInWorkdir:
                    return "Modified";
                case FileStatus.DeletedFromIndex:
                case FileStatus.DeletedFromWorkdir:
                    return "Deleted";
                case FileStatus.RenamedInIndex:
                case FileStatus.RenamedInWorkdir:
                    return "Renamed";
                case FileStatus.TypeChangeInIndex:
                case FileStatus.TypeChangeInWorkdir:
                    return "Type change";
                case FileStatus.Unreadable:
                    return "Unreadable";
                case FileStatus.Ignored:
                    return "Ignored";
                case FileStatus.Conflicted:
                    return "Conflicted";
                default:
                    throw new Exception("Invalid git file status");
            }
        }

        public static bool IsGitFolder(string path)
        {
            return Directory.Exists(Path.Combine(path, ".git"));
        }

    }
}
