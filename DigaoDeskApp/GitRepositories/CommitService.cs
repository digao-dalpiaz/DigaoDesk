using LibGit2Sharp;
using System.Diagnostics;

namespace DigaoDeskApp
{
    public class CommitService
    {

        private const FileStatus ENUM_STAGED =
            FileStatus.NewInIndex |
            FileStatus.ModifiedInIndex |
            FileStatus.DeletedFromIndex |
            FileStatus.RenamedInIndex |
            FileStatus.TypeChangeInIndex;

        private const FileStatus ENUM_UNSTAGED =
            FileStatus.NewInWorkdir |
            FileStatus.ModifiedInWorkdir |
            FileStatus.DeletedFromWorkdir |
            FileStatus.RenamedInWorkdir |
            FileStatus.TypeChangeInWorkdir;

        private const FileStatus ENUM_UNSUPPORTED =
            FileStatus.TypeChangeInIndex |
            FileStatus.TypeChangeInWorkdir |
            FileStatus.RenamedInWorkdir;

        private readonly Repository _repository;

        public CommitService(Repository repository)
        {
            this._repository = repository;
        }

        private static List<FileStatus> MountListOfFileStatus(FileStatus agregatedFileStatus)
        {
            List<FileStatus> lst = [];

            foreach (FileStatus s in Enum.GetValues(typeof(FileStatus)))
            {
                if (s == FileStatus.Unaltered) continue; //unaltered is zero, so always contains this flag

                if (agregatedFileStatus.HasFlag(s))
                {
                    lst.Add(s);
                }
            }

            return lst;
        }

        public void LoadLists(CheckedListBoxEx lstStaged, CheckedListBoxEx lstDif, ListBox lstOther)
        {
            lstStaged.Items.Clear();
            lstDif.Items.Clear();
            lstOther.Items.Clear();

            StatusOptions so = new();
            so.IncludeIgnored = false;

            var lstInfo = _repository.RetrieveStatus(so);
            foreach (var item in lstInfo)
            {
                var flags = MountListOfFileStatus(item.State);

                List<FileStatus> flagsStaged = [];
                List<FileStatus> flagsUnstaged = [];
                List<FileStatus> flagsOther = [];

                foreach (var s in flags)
                {
                    if (ENUM_UNSUPPORTED.HasFlag(s)) throw new Exception("Unsupported file status: " + s.ToString());

                    if (ENUM_STAGED.HasFlag(s))
                    {
                        flagsStaged.Add(s);
                    }
                    else
                    if (ENUM_UNSTAGED.HasFlag(s))
                    {
                        flagsUnstaged.Add(s);
                    }
                    else
                    {
                        flagsOther.Add(s);
                    }
                }

                if (flagsStaged.Count > 0) lstStaged.SurroundAllowingCheck(() => lstStaged.Items.Add(new CommitItemView(item.FilePath, item.HeadToIndexRenameDetails, flagsStaged, null), true));
                if (flagsUnstaged.Count > 0) lstDif.SurroundAllowingCheck(() => lstDif.Items.Add(new CommitItemView(item.FilePath, /*item.IndexToWorkDirRenameDetails*/null, flagsUnstaged, flagsStaged.Count > 0), true));
                if (flagsOther.Count > 0) lstOther.Items.Add(new CommitItemView(item.FilePath, null, flagsOther, null));
            }
        }

        public void CompareItem(CommitItemView item, bool staged)
        {
            string pathOld = null;
            string pathNew = null;

            Blob blob;

            if (staged)
            {
                if (!item.LstStatus.Contains(FileStatus.NewInIndex))
                {
                    blob = GetBlobOfLastCommitByPath(item.GetPathOrOld());
                    pathOld = GetTempFileNameByPath(item.GetPathOrOld(), "commited");
                    SaveBlobToFile(blob, pathOld);
                }

                if (!item.LstStatus.Contains(FileStatus.DeletedFromIndex))
                {
                    blob = GetBlobOfIndexByPath(item.Path);
                    pathNew = GetTempFileNameByPath(item.Path, "staged");
                    SaveBlobToFile(blob, pathNew);
                }
            }
            else
            {
                if (!item.LstStatus.Contains(FileStatus.NewInWorkdir))
                {
                    blob = GetBlobOfIndexByPath(item.Path); //if the file is not in staged area, the index contains commited file
                    pathOld = GetTempFileNameByPath(item.Path, item.PresentInStagedArea.Value ? "staged" : "commited");
                    SaveBlobToFile(blob, pathOld);
                }

                if (!item.LstStatus.Contains(FileStatus.DeletedFromWorkdir))
                {
                    pathNew = Path.Combine(_repository.Info.WorkingDirectory, item.Path);
                    if (!File.Exists(pathNew)) Messages.ThrowMsg(Vars.Lang.CompareFile_NotFoundInWorkingDir);
                }
            }

            if (pathOld == null) pathOld = GetNullFile();
            if (pathNew == null) pathNew = GetNullFile();

            OpenDiff(pathOld, pathNew);
        }

        public void UndoFileByItem(CommitItemView item)
        {
            var path = Path.Combine(_repository.Info.WorkingDirectory, item.Path);

            if (!item.LstStatus.Contains(FileStatus.NewInWorkdir))
            {
                //file already exists in commit/staged
                try
                {
                    SaveBlobToFile(GetBlobOfIndexByPath(item.Path), path);
                }
                catch (Exception ex)
                {
                    Messages.ThrowMsg($"Error saving file '{path}': {ex.Message}");
                }
            }
            else
            {
                //file does not exist in commit/staged (new in working dir)
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    Messages.ThrowMsg($"Error deleting file '{path}': {ex.Message}");
                }
            }
        }

        private Blob GetBlobOfLastCommitByPath(string path)
        {
            var treeEntry = _repository.Head.Tip.Tree[path];
            if (treeEntry == null) Messages.ThrowMsg("File not found in last commit");
            return treeEntry.Target as Blob;
        }

        private Blob GetBlobOfIndexByPath(string path)
        {
            var indexEntry = _repository.Index[path];
            if (indexEntry == null) Messages.ThrowMsg("File not found in index");
            return _repository.Lookup<Blob>(indexEntry.Id);
        }

        private static string GetTempFileNameByPath(string path, string prefix)
        {
            return Path.GetTempFileName() + "_" + prefix + "_" + Path.GetFileName(path);
        }

        private static void SaveBlobToFile(Blob blob, string filePath)
        {
            FilteringOptions fo = new(""); //ensure correct CR/LF between Unix and Win
            Stream stmSource = blob.GetContentStream(fo);

            using (var stmDest = File.Create(filePath))
            {
                stmSource.CopyTo(stmDest);
            }
        }

        private static string GetNullFile()
        {
            string tmpFile = Path.GetTempFileName();
            string tmpFileFinal = tmpFile + "_null";
            File.Copy(tmpFile, tmpFileFinal);

            return tmpFileFinal;
        }

        private static void OpenDiff(string pathOld, string pathNew)
        {
            if (string.IsNullOrEmpty(Vars.Config.Repos.DiffProgram))
            {
                Messages.ThrowMsg(Vars.Lang.CompareFile_DiffProgramNotConfigured);
            }

            string args = Vars.Config.Repos.DiffProgramArguments;
            args = args.Replace("[old]", $"\"{pathOld}\"");
            args = args.Replace("[new]", $"\"{pathNew}\"");

            Messages.SurroundExceptionThenThrowMessageException(
                () => Process.Start(Vars.Config.Repos.DiffProgram, args));
        }

    }

}
