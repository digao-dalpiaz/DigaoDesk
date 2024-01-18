using LibGit2Sharp;

namespace DigaoDeskApp
{
    public partial class FrmCherryPick : Form
    {

        private class CommitView
        {
            private readonly Commit _commit;

            public CommitView(Commit commit)
            {
                this._commit = commit;
            }

            public Commit GetCommit()
            {
                return _commit;
            }

            public string Id { get { return _commit.Id.Sha; } }
            public string Message { get { return _commit.MessageShort; } }
            public string Author { get { return _commit.Author.Name; } }
            public string DateTime { get { return _commit.Author.When.ToLocalTime().ToString(Vars.DATETIME_FMT); } }
        }

        private readonly Repository _repository;
        private Branch _branch;
        private List<CommitView> _lstCommits;
        private BindingSource _gridBind;

        public List<Commit> ResultCommits;

        public FrmCherryPick(Repository repository)
        {
            InitializeComponent();

            LoadLang();

            btnSelBranch.Height = edBranch.Height;

            edBranch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSelBranch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            boxButtons.Anchor = AnchorStyles.Bottom;

            _repository = repository;
        }

        private void FrmCherryPick_Load(object sender, EventArgs e)
        {
            _lstCommits = [];

            _gridBind = [];
            _gridBind.DataSource = _lstCommits;

            g.DataSource = _gridBind;

            lbCount.Text = String.Empty;
        }

        private void LoadLang()
        {
            this.Text = Vars.Lang.CherryPick_Title;
            lbBranch.Text = Vars.Lang.CherryPick_Branch;
            lbSearch.Text = Vars.Lang.CherryPick_Search;
            lbStartDate.Text = Vars.Lang.CherryPick_StartDate;
            lbEndDate.Text = Vars.Lang.CherryPick_EndDate;
            btnSelBranch.Text = Vars.Lang.CherryPick_SelectBranch;
            colId.HeaderText = Vars.Lang.CherryPick_ColID;
            colMessage.HeaderText = Vars.Lang.CherryPick_ColMessage;
            colAuthor.HeaderText = Vars.Lang.CherryPick_ColAuthor;
            colDateTime.HeaderText = Vars.Lang.CherryPick_ColDateTime;
            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        private void FillList()
        {
            _lstCommits.Clear();
            try
            {
                if (_branch == null) return;

                foreach (var item in _branch.Commits.Where(x =>
                {
                    if (edStartDate.Checked) if (!(x.Author.When.ToLocalTime().Date >= edStartDate.Value.Date)) return false;
                    if (edEndDate.Checked) if (!(x.Author.When.ToLocalTime().Date <= edEndDate.Value.Date)) return false;
                    if (edSearch.Text != string.Empty) if (!(x.Id.Sha.StartsWith(edSearch.Text, StringComparison.InvariantCultureIgnoreCase) || x.MessageShort.Contains(edSearch.Text, StringComparison.InvariantCultureIgnoreCase))) return false;
                    return true;
                }))
                {
                    _lstCommits.Add(new CommitView(item));
                }
            }
            finally
            {
                _gridBind.ResetBindings(false);
                lbCount.Text = string.Format(Vars.Lang.CountLabel, _lstCommits.Count);
            }
        }

        private void btnSelBranch_Click(object sender, EventArgs e)
        {
            var lstBranches = _repository.Branches.Where(x => !x.IsCurrentRepositoryHead && !GitUtils.IsBranchOriginHead(x) && !GitUtils.IsBranchLocalAndRemoteLinked(_repository.Head, x));
            if (!lstBranches.Any())
            {
                Messages.Error(Vars.Lang.CherryPick_NoOthersBranches);
                return;
            }

            FrmBranchSelector f = new(Vars.Lang.CherryPick_SelectBranchTitle, true);            
            f.AddBranches(lstBranches);
            if (f.ShowDialog() == DialogResult.OK)
            {
                _branch = f.ResultBranch;
                edBranch.Text = _branch.FriendlyName;

                FillList();
            }
        }

        private void edSearch_TextChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void edDates_ValueChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (g.SelectedRows.Count == 0)
            {
                Messages.Error(Vars.Lang.CherryPick_OneCommitRequired);
                return;
            }

            //

            List<CommitView> selectedsCommitView = [];
            foreach (DataGridViewRow row in g.SelectedRows) //SelectedRows contain order accorind to the user selection order
            {
                selectedsCommitView.Add(row.DataBoundItem as CommitView);
            }

            ResultCommits = _lstCommits.Where(x => selectedsCommitView.Contains(x)).Select(x => x.GetCommit()).ToList();

            DialogResult = DialogResult.OK;
        }

    }
}
