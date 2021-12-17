using LibGit2Sharp;
using System;
using System.Collections.Generic;
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
            private StatusEntry _entry;
            public StatusEntry Entry { get { return _entry; } }

            public ItemView(StatusEntry entry)
            {
                this._entry = entry;
            }

            public override string ToString()
            {
                return "[" + GitUtils.GetFileStatusAsString(_entry.State) + "] " + _entry.FilePath;
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
                var itemView = new ItemView(item);

                if (ENUM_STAGED.HasFlag(item.State)) {
                    lstStaged.Items.Add(itemView, true);
                } 
                else
                if (ENUM_UNSTAGED.HasFlag(item.State))
                {
                    lstDif.Items.Add(itemView, true);
                }
            }

            lbCountStaged.Text = lstStaged.Items.Count.ToString();
            lbCountDif.Text = lstDif.Items.Count.ToString();
        }

        private void btnStage_Click(object sender, EventArgs e)
        {
            if (lstDif.CheckedItems.Count == 0) return;

            foreach (ItemView item in lstDif.CheckedItems)
            {
                Commands.Stage(_repository, item.Entry.FilePath);
            }

            LoadLists();
        }

        private void btnUnstage_Click(object sender, EventArgs e)
        {
            if (lstStaged.CheckedItems.Count == 0) return;

            foreach (ItemView item in lstStaged.CheckedItems)
            {
                Commands.Unstage(_repository, item.Entry.FilePath);
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
