﻿using Equin.ApplicationFramework;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchCheckout : Form
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
                    return _branch.FriendlyName;
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

        public FrmBranchCheckout()
        {
            InitializeComponent();
        }

        public void AddBranches(IEnumerable<Branch> lst)
        {
            foreach (var item in lst.OrderByDescending(x => x.Tip.Author.When.ToLocalTime()))
            {
                _internalBranchList.Add(new BranchInfo(item));
            }
        }

        private void FrmBranchCheckout_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            _gridBind = new(_internalBranchList);
            g.DataSource = _gridBind;
        }

        private void DoFilter()
        {
            if (edSearch.Text != string.Empty)
            {
                _gridBind.ApplyFilter(x => x.Name.Contains(edSearch.Text, StringComparison.InvariantCultureIgnoreCase));
            } 
            else
            {
                _gridBind.RemoveFilter();
            }
        }

        private void edSearch_TextChanged(object sender, EventArgs e)
        {
            DoFilter();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (g.CurrentRow == null)
            {
                Messages.Error("Please, select a branch!");
                return;
            }

            //

            ResultBranch = (g.CurrentRow.DataBoundItem as ObjectView<BranchInfo>).Object.GetBranch();

            DialogResult = DialogResult.OK;
        }        

        private void g_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK.PerformClick();
        }

    }
}
