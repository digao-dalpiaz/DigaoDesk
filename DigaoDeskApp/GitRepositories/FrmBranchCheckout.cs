using System;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchCheckout : Form
    {
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
    }
}
