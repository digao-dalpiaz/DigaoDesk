using LibGit2Sharp;
using System;
using System.Collections.Generic;
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

            this._repository = repository;
        }

        private void FrmCommit_Load(object sender, EventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            lstStaged.Height = (int)r.GetValue("ListH", lstStaged.Height);

            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position                      

            LoadLists();
        }

        private void FrmCommit_FormClosed(object sender, FormClosedEventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            r.SetValue("ListH", lstStaged.Height);

            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position
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

                if (flagsStaged.Any()) lstStaged.Items.Add(new ItemView(item.FilePath, flagsStaged), true);
                if (flagsUnstaged.Any()) lstDif.Items.Add(new ItemView(item.FilePath, flagsUnstaged), true);
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

        private void GroupSelection(CheckedListBox lst, bool? op)
        {
            for (int i = 0; i < lst.Items.Count; i++)
            {
                bool v = (op == null) ? !lst.GetItemChecked(i) : op.Value;
                lst.SetItemChecked(i, v);
            }
        }

    }
}
