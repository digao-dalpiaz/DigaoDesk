using Equin.ApplicationFramework;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchSelector : Form
    {

        public Branch ResultBranch;

        private class BranchInfo
        {
            private Branch _branch;

            public BranchInfo(Branch branch)
            {
                _branch = branch;
            }

            public Branch GetBranch()
            {
                return _branch;
            }

            public string Name
            {
                get
                {
                    return GitUtils.GetBranchDisplayName(_branch);
                }
            }

            public string Location
            {
                get
                {
                    return _branch.IsRemote ? "Remote" : "Local";
                }
            }

            public string Author
            {
                get
                {
                    return _branch.Tip.Author.Name;
                }
            }

            public string Timestamp
            {
                get
                {
                    return _branch.Tip.Author.When.ToLocalTime().ToString(Vars.DATETIME_FMT);
                }
            }           
        }

        private List<BranchInfo> _internalBranchList = new();
        private BindingListView<BranchInfo> _gridBind;
        private bool _useLocation;

        public FrmBranchSelector(string title, bool useLocation)
        {
            InitializeComponent();

            edSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            boxButtons.Anchor = AnchorStyles.Bottom;
            lbCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            this.Text = title;
            this._useLocation = useLocation;
        }

        public void AddBranches(IEnumerable<Branch> lst)
        {
            foreach (var item in lst)
            {
                _internalBranchList.Add(new BranchInfo(item));
            }
        }

        private void FrmBranchCheckout_Load(object sender, EventArgs e)
        {
            boxLocation.Visible = _useLocation;

            LoadGrid();
        }

        private void LoadGrid()
        {
            _gridBind = new(_internalBranchList);
            _gridBind.ApplySort("Timestamp DESC");
            DoFilter();
            
            g.DataSource = _gridBind;
        }

        private void DoFilter()
        {
            _gridBind.ApplyFilter(x => {
                var branch = x.GetBranch();
                    
                return 
                    (edSearch.Text == string.Empty || branch.FriendlyName.Contains(edSearch.Text, StringComparison.InvariantCultureIgnoreCase)) &&
                    (!_useLocation || branch.IsRemote == ckRemote.Checked);
            });
            lbCount.Text = "Count: " + _gridBind.Count;
        }

        private void edSearch_TextChanged(object sender, EventArgs e)
        {
            DoFilter();
        }

        private Branch GetBranchByRow(DataGridViewRow row)
        {
            return (row.DataBoundItem as ObjectView<BranchInfo>).Object.GetBranch();
        }

        private void g_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (g.Columns[e.ColumnIndex].Name.Equals(colName.Name))
            {
                var branch = GetBranchByRow(g.Rows[e.RowIndex]);
                if (GitUtils.IsBranchMaster(branch))
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                }
            }
        }

        private void g_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK.PerformClick();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (g.CurrentRow == null)
            {
                Messages.Error("Please, select a branch!");
                return;
            }

            //

            ResultBranch = GetBranchByRow(g.CurrentRow);

            DialogResult = DialogResult.OK;
        }

    }
}
