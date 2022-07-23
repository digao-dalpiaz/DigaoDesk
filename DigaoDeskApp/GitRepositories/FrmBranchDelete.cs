using Equin.ApplicationFramework;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchDelete : Form
    {

        public class BranchForDeletion
        {
            public Branch Branch { get; }
            public bool DelLocal { get; }
            public bool DelRemote { get; }

            public BranchForDeletion(Branch branch, bool local, bool remote)
            {
                this.Branch = branch;
                this.DelLocal = local;
                this.DelRemote = remote;
            }

            public override string ToString()
            {
                List<string> lst = new();
                if (DelLocal) lst.Add(Vars.Lang.BranchDelete_DeleteLocal);
                if (DelRemote) lst.Add(Vars.Lang.BranchDelete_DeleteRemote);

                return string.Format("[{0}] {1}", string.Join(", ", lst), GitUtils.GetBranchDisplayName(Branch));
            }
        }

        private List<BranchSelectorItem> _internalBranchList = new();
        private BindingListView<BranchSelectorItem> _gridBind;

        public FrmBranchDelete()
        {
            InitializeComponent();

            LoadLang();
        }

        public void LoadLang()
        {
            this.Text = Vars.Lang.BranchDelete_Title;
            lbFilterBranches.Text = Vars.Lang.BranchDelete_FilterBranches;
            ckDeleteLocal.Text = Vars.Lang.BranchDelete_DeleteLocal;
            ckDeleteRemote.Text = Vars.Lang.BranchDelete_DeleteRemote;
            btnAdd.Text = Vars.Lang.BranchDelete_BtnAdd;
            btnDel.Text = Vars.Lang.BranchDelete_BtnDelete;
            lbConfirmation.Text = Vars.Lang.BranchDelete_ConfirmationLabel;
            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;

            //Using Branch Selector strings:
            colName.HeaderText = Vars.Lang.BranchSelector_ColName;
            colLocation.HeaderText = Vars.Lang.BranchSelector_ColLocation;
            colAuthor.HeaderText = Vars.Lang.BranchSelector_ColAuthor;
            colDateTime.HeaderText = Vars.Lang.BranchSelector_ColDateTime;
            ckFilterLocal.Text = Vars.Lang.BranchSelector_Local;
            ckFilterRemote.Text = Vars.Lang.BranchSelector_Remote;
        }

        public void AddBranches(IEnumerable<Branch> lst)
        {
            foreach (var item in lst)
            {
                _internalBranchList.Add(new BranchSelectorItem(item));
            }
        }

        private void LoadGrid()
        {
            _gridBind = new(_internalBranchList);
            //_gridBind.ApplySort("Timestamp DESC");
            FilterBranches();

            g.DataSource = _gridBind;
        }

        private void FrmBranchDelete_Load(object sender, EventArgs e)
        {
            LoadGrid();
            g_SelectionChanged(null, null);
            lst_SelectedIndexChanged(null, null);
            edConfirm_TextChanged(null, null);
        }

        public IEnumerable<BranchForDeletion> GetListBranchesForDeletion()
        {
            return lst.Items.Cast<BranchForDeletion>();
        }

        private void FilterBranches()
        {
            var lstForDeletion = GetListBranchesForDeletion();

            _gridBind.ApplyFilter(x => {
                var branch = x.GetBranch();

                if (lstForDeletion.Any(bfd => bfd.Branch == branch 
                    || bfd.Branch.TrackedBranch == branch 
                    || branch.TrackedBranch == bfd.Branch)) return false; //already mark for deletion

                return
                    (edSearch.Text == string.Empty || branch.FriendlyName.Contains(edSearch.Text, StringComparison.InvariantCultureIgnoreCase)) &&
                    (branch.IsRemote == ckFilterRemote.Checked);
            });
        }

        private Branch GetBranchByRow(DataGridViewRow row)
        {
            return (row.DataBoundItem as ObjectView<BranchSelectorItem>).Object.GetBranch();
        }

        private void edSearch_TextChanged(object sender, EventArgs e)
        {
            FilterBranches();
        }

        private void g_SelectionChanged(object sender, EventArgs e)
        {
            Branch branch = null;
            if (g.CurrentRow != null)
            {
                branch = GetBranchByRow(g.CurrentRow);
            }

            bool sel = branch != null;

            btnAdd.Enabled = sel;
            ckDeleteLocal.Visible = sel && !branch.IsRemote;
            ckDeleteRemote.Visible = sel && (branch.IsRemote || branch.IsTracking);
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDel.Enabled = lst.SelectedItem != null;
        }

        private void edConfirm_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (edConfirm.Text == Vars.Lang.BranchDelete_ConfirmationText);
        }

        private bool GetDeleteLocal()
        {
            return ckDeleteLocal.Visible && ckDeleteLocal.Checked;
        }

        private bool GetDeleteRemote()
        {
            return ckDeleteRemote.Visible && ckDeleteRemote.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lst.Items.Count == 0)
            {
                Messages.Error(Vars.Lang.BranchDelete_BranchRequired);
                return;
            }

            //

            DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!GetDeleteLocal() && !GetDeleteRemote())
            {
                Messages.Error(Vars.Lang.BranchDelete_OptionRequired);
                return;
            }

            lst.Items.Add(new BranchForDeletion(GetBranchByRow(g.CurrentRow), GetDeleteLocal(), GetDeleteRemote()));
            FilterBranches();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lst.Items.RemoveAt(lst.SelectedIndex);
            FilterBranches();
        }

    }
}
