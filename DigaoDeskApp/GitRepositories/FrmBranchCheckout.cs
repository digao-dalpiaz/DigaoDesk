using LibGit2Sharp;
using System;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchCheckout : Form
    {

        public class BranchView
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

        public Branch GetSelected()
        {
            return (l.SelectedItem as BranchView).BranchData;
        }

    }
}
