using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchCheckout : Form
    {

        private class BranchView
        {
            private Branch _branch;
            public Branch BranchData
            {
                get
                {
                    return _branch;
                }
            }

            public BranchView(Branch branch)
            {
                this._branch = branch;
            }

            public override string ToString()
            {
                return _branch.FriendlyName;
            }
        }

        public FrmBranchCheckout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (l.SelectedItem == null)
            {
                Messages.Error("Please, select a branch!");
                l.Select();
                return;
            }

            DialogResult = DialogResult.OK;
        }

        public void AddBranches(IEnumerable<Branch> lst)
        {
            foreach (var item in lst)
            {
                l.Items.Add(new BranchView(item));
            }
        }

        public Branch GetSelected()
        {
            return (l.SelectedItem as BranchView).BranchData;
        }

    }
}
