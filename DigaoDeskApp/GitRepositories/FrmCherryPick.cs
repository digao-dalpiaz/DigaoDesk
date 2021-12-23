﻿using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmCherryPick : Form
    {

        private class CommitView
        {
            private Commit _commit;

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

        private Repository _repository;
        private List<CommitView> _lstCommits;
        private BindingSource _gridBind;

        public List<Commit> ResultCommits;

        public FrmCherryPick(Repository repository)
        {
            InitializeComponent();

            edBranch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            _lstCommits = new();

            _gridBind = new();
            _gridBind.DataSource = _lstCommits;

            g.DataSource = _gridBind;

            FillBranches();
            FillList();
        }

        private void FillBranches()
        {
            foreach (var item in _repository.Branches.Where(x => x.IsRemote && !GitUtils.IsBranchOriginHead(x)))
            {
                edBranch.Items.Add(item.FriendlyName);
            }
        }

        private void FillList()
        {
            _lstCommits.Clear();
            try
            {
                if (edBranch.SelectedItem == null) return;
                var branch = _repository.Branches[edBranch.SelectedItem.ToString()];
                if (branch == null) return;

                foreach (var item in branch.Commits.Where(x =>
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
                lbCount.Text = "Count: " + _lstCommits.Count;
            }
        }

        private void edBranch_TextChanged(object sender, EventArgs e)
        {
            FillList();
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
                Messages.Error("Please, select at least one commit.");
                return;
            }

            //

            List<CommitView> selectedsCommitView = new();
            foreach (DataGridViewRow row in g.SelectedRows) //SelectedRows contain order accorind to the user selection order
            {
                selectedsCommitView.Add(row.DataBoundItem as CommitView);
            }

            ResultCommits = _lstCommits.Where(x => selectedsCommitView.Contains(x)).Select(x => x.GetCommit()).ToList();

            DialogResult = DialogResult.OK;
        }
        
    }
}
