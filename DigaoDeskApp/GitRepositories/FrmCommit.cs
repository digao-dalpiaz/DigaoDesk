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


        private Repository _repository;

        public string ReturnMessage;

        private class ItemView
        {
            public string Path;
            public List<FileStatus> LstStatus;

            public ItemView(string path, List<FileStatus> lstStatus)
            {
                this.Path = path;
                this.LstStatus = lstStatus;
            }

            public override string ToString()
            {
                return "[" + string.Join(", ", LstStatus.Select(x => GitUtils.GetFileStatusAsString(x)))  + "] " + Path;
            }
        }

        public FrmCommit(Repository repository)
        {
            InitializeComponent();

            edMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCommit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCommitAndPush.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this._repository = repository;
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

        private void LoadLists()
        {
            lstStaged.Items.Clear();
            lstDif.Items.Clear();

            StatusOptions so = new();
            so.IncludeIgnored = false;

            var lstInfo = _repository.RetrieveStatus(so);
            foreach (var item in lstInfo)
            {
                List<FileStatus> flags = new();
                foreach (FileStatus s in Enum.GetValues(typeof(FileStatus)))
                {
                    if (s == FileStatus.Unaltered) continue; //unaltered is zero, so always contains this flag

                    if (item.State.HasFlag(s))
                    {
                        flags.Add(s);
                    }
                }

                List<FileStatus> flagsStaged = new();
                List<FileStatus> flagsUnstaged = new();
                List<FileStatus> flagsOther = new();

                foreach (var s in flags)
                {
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

                if (flagsStaged.Any()) lstStaged.SurroundAllowingCheck(() => lstStaged.Items.Add(new ItemView(item.FilePath, flagsStaged), true));
                if (flagsUnstaged.Any()) lstDif.SurroundAllowingCheck(() => lstDif.Items.Add(new ItemView(item.FilePath, flagsUnstaged), true));
                if (flagsOther.Any()) lstOther.Items.Add(new ItemView(item.FilePath, flagsOther));
            }

            lbCountStaged.Text = lstStaged.Items.Count.ToString();
            lbCountDif.Text = lstDif.Items.Count.ToString();

            lstOther.Visible = lstOther.Items.Count > 0;
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

            string pathOld;
            string pathNew;

            Stream stmSource;

            var index = _repository.Index[item.Path];

            if (lst == lstStaged)
            {                
                stmSource = GetBlobOfLastCommitByItemView(item).GetContentStream();
                pathOld = GetTempFileNameByItemView(item, "commited");
                StreamToFile(stmSource, pathOld);

                stmSource = GetBlobOfIndexEntry(index).GetContentStream();
                pathNew = GetTempFileNameByItemView(item, "staged");
                StreamToFile(stmSource, pathNew);
            }
            else if (lst == lstDif)
            {
                if (index != null)
                {
                    stmSource = GetBlobOfIndexEntry(index).GetContentStream();
                    pathOld = GetTempFileNameByItemView(item, "staged");
                } else
                {
                    stmSource = GetBlobOfLastCommitByItemView(item).GetContentStream();
                    pathOld = GetTempFileNameByItemView(item, "commited");
                }
                StreamToFile(stmSource, pathOld);

                pathNew = Path.Combine(_repository.Info.WorkingDirectory, item.Path);
            }
            else
                throw new Exception("Invalid control");

            Process.Start(@"c:\Program Files\WinMerge\winmergeu.exe", $"\"{pathOld}\" \"{pathNew}\"");
        }

        private Blob GetBlobOfLastCommitByItemView(ItemView item)
        {
            return _repository.Head.Tip.Tree[item.Path].Target as Blob;
        }

        private Blob GetBlobOfIndexEntry(IndexEntry index)
        {
            return _repository.Lookup<Blob>(index.Id);
        }

        private string GetTempFileNameByItemView(ItemView item, string prefix)
        {
            return Path.GetTempFileName() + "_" + prefix + "_" + Path.GetFileName(item.Path);
        }

        private void StreamToFile(Stream stmSource, string filePath)
        {
            using (var stmDest = File.Create(filePath))
            {
                stmSource.CopyTo(stmDest);
            }
        }
    }
}
