using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmCommit : Form
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\Commit";

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

        private Repository _repository;

        private int _itemTextHeight;

        public string ReturnMessage;

        private class ItemView
        {
            public string Path;
            public string OldPath;
            public List<FileStatus> LstStatus;
            public bool? PresentInStagedArea; //this propery is only used for unstaged item

            public ItemView(string path, RenameDetails renameDetails, List<FileStatus> lstStatus, bool? presentInStagedArea)
            {
                this.Path = path;
                if (renameDetails != null) this.OldPath = renameDetails.OldFilePath;
                this.LstStatus = lstStatus;
                this.PresentInStagedArea = presentInStagedArea;
            }

            public string DisplayText { get { return (OldPath != null ? OldPath + " > " : "") + Path; } }

            public override string ToString()
            {
                return "[" + string.Join(", ", LstStatus.Select(x => GitUtils.GetFileStatusAsString(x)))  + "] " + DisplayText;
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

        public FrmCommit(DigaoRepository repository)
        {
            InitializeComponent();

            edMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCommit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCommitAndPush.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this._repository = repository._repoCtrl;

            lbRepository.Text = repository.Name;
            lbBranch.Text = repository._repoCtrl.Head.FriendlyName;

            InitListsDrawItem();
        }

        private void FrmCommit_Load(object sender, EventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            lstStaged.Height = (int)r.GetValue("ListH", lstStaged.Height);

            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position                      

            AutoFillMessageHashtag();

            LoadLists();
        }

        private void FrmCommit_FormClosed(object sender, FormClosedEventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            r.SetValue("ListH", lstStaged.Height);

            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position
        }

        private void AutoFillMessageHashtag()
        {
            ParseCommitMessage p = new(_repository);
            edMessage.Text = p.GetMessage();
        }

        private void InitListsDrawItem()
        {
            _itemTextHeight = Font.Height;
            int h = Math.Max(_itemTextHeight, images.ImageSize.Height) + 5;
            lstStaged.SetItemHeight(h);
            lstDif.SetItemHeight(h);

            lstStaged.CustomDrawItem += OnDrawItem;
            lstDif.CustomDrawItem += OnDrawItem;
        }

        private void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            var control = sender as CheckedListBoxEx;
            var item = control.Items[e.Index] as ItemView;

            List<int> lstImages = new();
            if (item.ContainsFlagNew) lstImages.Add(0);
            if (item.ContainsFlagModified) lstImages.Add(1);
            if (item.ContainsFlagDeleted) lstImages.Add(2);
            if (item.ContainsFlagRenamed) lstImages.Add(3);

            int lastX = e.Bounds.X + control.BoxAreaWidth + 4;
            foreach (var idx in lstImages)
            {
                images.Draw(e.Graphics, lastX, e.Bounds.Y + ((e.Bounds.Height - images.ImageSize.Height)/2), idx);
                lastX += images.ImageSize.Width + 4;
            }

            e.Graphics.DrawString(item.DisplayText, control.Font, Brushes.Black, lastX, e.Bounds.Y + ((e.Bounds.Height - _itemTextHeight)/2));
        }

        private List<FileStatus> MountListOfFileStatus(FileStatus agregatedFileStatus)
        {
            List<FileStatus> lst = new();

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

        private void LoadLists()
        {
            lstStaged.Items.Clear();
            lstDif.Items.Clear();

            StatusOptions so = new();
            so.IncludeIgnored = false;

            var lstInfo = _repository.RetrieveStatus(so);
            foreach (var item in lstInfo)
            {
                var flags = MountListOfFileStatus(item.State);
                
                List<FileStatus> flagsStaged = new();
                List<FileStatus> flagsUnstaged = new();
                List<FileStatus> flagsOther = new();

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

                if (flagsStaged.Any()) lstStaged.SurroundAllowingCheck(() => lstStaged.Items.Add(new ItemView(item.FilePath, item.HeadToIndexRenameDetails, flagsStaged, null), true));
                if (flagsUnstaged.Any()) lstDif.SurroundAllowingCheck(() => lstDif.Items.Add(new ItemView(item.FilePath, /*item.IndexToWorkDirRenameDetails*/null, flagsUnstaged, flagsStaged.Any()), true));
                if (flagsOther.Any()) lstOther.Items.Add(new ItemView(item.FilePath, null, flagsOther, null));
            }

            lbCountStaged.Text = lstStaged.Items.Count.ToString();
            lbCountDif.Text = lstDif.Items.Count.ToString();

            lstOther.Visible = lstOther.Items.Count > 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLists();
        }

        private void btnStage_Click(object sender, EventArgs e)
        {
            if (lstDif.CheckedItems.Count == 0) return;

            foreach (ItemView item in lstDif.CheckedItems)
            {
                Commands.Stage(_repository, item.Path);
            }

            LoadLists();
        }

        private void btnUnstage_Click(object sender, EventArgs e)
        {
            if (lstStaged.CheckedItems.Count == 0) return;

            foreach (ItemView item in lstStaged.CheckedItems)
            {
                Commands.Unstage(_repository, item.Path);
            }

            LoadLists();
        }

        private void btnGroupSelection_Click(object sender, EventArgs e)
        {
            if (sender == btnAllStaged) { GroupSelection(lstStaged, true); return; }
            if (sender == btnNoneStaged) { GroupSelection(lstStaged, false); return; }
            if (sender == btnInvertStaged) { GroupSelection(lstStaged, null); return; }

            if (sender == btnAllDif) { GroupSelection(lstDif, true); return; }
            if (sender == btnNoneDif) { GroupSelection(lstDif, false); return; }
            if (sender == btnInvertDif) { GroupSelection(lstDif, null); return; }

            throw new Exception("Invalid control");
        }

        private void GroupSelection(CheckedListBoxEx lst, bool? op)
        {
            for (int i = 0; i < lst.Items.Count; i++)
            {
                bool v = (op == null) ? !lst.GetItemChecked(i) : op.Value;
                lst.SurroundAllowingCheck(() => lst.SetItemChecked(i, v));                
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (lstStaged.Items.Count == 0)
            {
                Messages.Error("There is no file in stage area");
                return;
            }

            edMessage.Text = edMessage.Text.Trim();
            if (edMessage.Text == string.Empty)
            {
                Messages.Error("Type a message to this commit");
                edMessage.Select();
                return;
            }

            //

            if (!Messages.Question("Confirm commit?")) return;

            ReturnMessage = edMessage.Text;

            DialogResult = (sender == btnCommitAndPush) ? DialogResult.Continue : DialogResult.OK;
        }

        private void lstItem_Click(object sender, EventArgs e)
        {
            var lst = sender as CheckedListBoxEx;
            var item = lst.SelectedItem as ItemView;
            if (item == null) return;

            //ensure click in item area
            Point loc = lst.PointToClient(Cursor.Position);
            Rectangle rec = lst.GetItemRectangle(lst.SelectedIndex);
            if (!rec.Contains(loc)) return;

            Messages.SurroundMessageException(() =>
            {
                string pathOld = null;
                string pathNew = null;

                Stream stm;

                if (lst == lstStaged)
                {
                    if (!item.LstStatus.Contains(FileStatus.NewInIndex))
                    {
                        stm = GetBlobOfLastCommitByPath(item.GetPathOrOld()).GetContentStream();
                        pathOld = GetTempFileNameByPath(item.GetPathOrOld(), "commited");
                        StreamToFile(stm, pathOld);
                    }

                    if (!item.LstStatus.Contains(FileStatus.DeletedFromIndex))
                    {
                        stm = GetBlobOfIndexByPath(item.Path).GetContentStream();
                        pathNew = GetTempFileNameByPath(item.Path, "staged");
                        StreamToFile(stm, pathNew);
                    }
                }
                else if (lst == lstDif)
                {
                    if (!item.LstStatus.Contains(FileStatus.NewInWorkdir))
                    {
                        stm = GetBlobOfIndexByPath(item.Path).GetContentStream(); //if the file is not in staged area, the index contains commited file
                        pathOld = GetTempFileNameByPath(item.Path, item.PresentInStagedArea.Value ? "staged" : "commited");
                        StreamToFile(stm, pathOld);
                    }

                    if (!item.LstStatus.Contains(FileStatus.DeletedFromWorkdir))
                    {
                        pathNew = Path.Combine(_repository.Info.WorkingDirectory, item.Path);
                        if (!File.Exists(pathNew)) Messages.ThrowMsg("File not found in working directory");
                    }
                }
                else
                    throw new Exception("Invalid control");

                if (pathOld == null) pathOld = GetNullFile();
                if (pathNew == null) pathNew = GetNullFile();

                OpenDiff(pathOld, pathNew);
            });            
        }

        private void btnUndoDif_Click(object sender, EventArgs e)
        {
            if (lstDif.CheckedItems.Count == 0) return;
            if (!Messages.Question("Confirm undo checked files?")) return;

            Messages.SurroundMessageException(() =>
            {
                foreach (ItemView item in lstDif.CheckedItems)
                {
                    var path = Path.Combine(_repository.Info.WorkingDirectory, item.Path);

                    if (!item.LstStatus.Contains(FileStatus.NewInWorkdir))
                    {
                        //file already exists in commit/staged
                        try
                        {
                            StreamToFile(GetBlobOfIndexByPath(item.Path).GetContentStream(), path);
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
            });

            LoadLists(); //reload even if error occurred
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

        private string GetTempFileNameByPath(string path, string prefix)
        {
            return Path.GetTempFileName() + "_" + prefix + "_" + Path.GetFileName(path);
        }

        private void StreamToFile(Stream stmSource, string filePath)
        {
            using (var stmDest = File.Create(filePath))
            {
                stmSource.CopyTo(stmDest);
            }
        }

        private string GetNullFile()
        {
            string tmpFile = Path.GetTempFileName();
            string tmpFileFinal = tmpFile + "_null";
            File.Copy(tmpFile, tmpFileFinal);

            return tmpFileFinal;
        }

        private void OpenDiff(string pathOld, string pathNew) {
            if (string.IsNullOrEmpty(Vars.Config.DiffProgram))
            {
                Messages.ThrowMsg("Diff program is not configured. Please check settings!");
            }

            string args = Vars.Config.DiffProgramArguments;
            args = args.Replace("[old]", $"\"{pathOld}\"");
            args = args.Replace("[new]", $"\"{pathNew}\"");

            Messages.SurroundExceptionThenThrowMessageException(
                () => Process.Start(Vars.Config.DiffProgram, args));
        }

    }
}
