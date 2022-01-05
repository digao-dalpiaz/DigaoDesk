using LibGit2Sharp;
using System.Collections.Generic;
using System.Linq;

namespace DigaoDeskApp
{
    public class CommitItemView
    {
        public string Path;
        public string OldPath;
        public List<FileStatus> LstStatus;
        public bool? PresentInStagedArea; //this propery is only used for unstaged item

        public CommitItemView(string path, RenameDetails renameDetails, List<FileStatus> lstStatus, bool? presentInStagedArea)
        {
            this.Path = path;
            if (renameDetails != null) this.OldPath = renameDetails.OldFilePath;
            this.LstStatus = lstStatus;
            this.PresentInStagedArea = presentInStagedArea;
        }

        public string DisplayText { get { return (OldPath != null ? OldPath + " > " : "") + Path; } }

        public override string ToString()
        {
            return "[" + string.Join(", ", LstStatus.Select(x => GitUtils.GetFileStatusAsString(x))) + "] " + DisplayText;
        }

        public string GetPathOrOld()
        {
            return OldPath != null ? OldPath : Path;
        }

        public bool ContainsFlagNew { get { return LstStatus.Any(x => x == FileStatus.NewInIndex || x == FileStatus.NewInWorkdir); } }
        public bool ContainsFlagModified { get { return LstStatus.Any(x => x == FileStatus.ModifiedInIndex || x == FileStatus.ModifiedInWorkdir); } }
        public bool ContainsFlagDeleted { get { return LstStatus.Any(x => x == FileStatus.DeletedFromIndex || x == FileStatus.DeletedFromWorkdir); } }
        public bool ContainsFlagRenamed { get { return LstStatus.Any(x => x == FileStatus.RenamedInIndex || x == FileStatus.RenamedInWorkdir); } }
    }

}
