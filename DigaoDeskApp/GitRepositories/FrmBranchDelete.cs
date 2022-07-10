using LibGit2Sharp;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchDelete : Form
    {

        public DeleteBranchParams FormParams;
        public class DeleteBranchParams
        {
            public Branch Branch;
            public bool Local;
            public bool Remote;
        }

        public FrmBranchDelete()
        {
            InitializeComponent();

            LoadLang();
        }

        public void LoadLang()
        {
            this.Text = Vars.Lang.BranchDelete_Title;
            lbBranch.Text = Vars.Lang.BranchDelete_Branch;
            lbConfirmation.Text = Vars.Lang.BranchDelete_ConfirmationLabel;
            ckLocal.Text = Vars.Lang.BranchDelete_OptLocal;
            ckRemote.Text = Vars.Lang.BranchDelete_OptRemote;
            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        public void AddBranches(IEnumerable<Branch> lst)
        {
            foreach (var item in lst)
            {
                lstBranches.Items.Add(new BranchView(item));
            }
        }

        private void FrmBranchDelete_Load(object sender, System.EventArgs e)
        {
            lstBranches_TextChanged(null, null);
            edConfirm_TextChanged(null, null);
        }

        private void lstBranches_TextChanged(object sender, System.EventArgs e)
        {
            var sel = lstBranches.SelectedItem as BranchView;

            ckLocal.Visible = (sel != null);
            ckRemote.Visible = (sel != null && sel.BranchData.IsTracking);
        }

        private bool GetOptLocal()
        {
            return ckLocal.Visible && ckLocal.Checked;
        }

        private bool GetOptRemote()
        {
            return ckRemote.Visible && ckRemote.Checked;
        }

        private void edConfirm_TextChanged(object sender, System.EventArgs e)
        {
            btnOK.Enabled = (edConfirm.Text == Vars.Lang.BranchDelete_ConfirmationText);
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (lstBranches.SelectedItem == null)
            {
                Messages.Error(Vars.Lang.BranchDelete_BranchRequired);
                lstBranches.Select();
                return;
            }

            if (!GetOptLocal() && !GetOptRemote())
            {                
                Messages.Error(Vars.Lang.BranchDelete_OptionRequired);
                return;
            }

            //

            FormParams = new DeleteBranchParams
            {
                Branch = (lstBranches.SelectedItem as BranchView).BranchData,
                Local = GetOptLocal(),
                Remote = GetOptRemote()
            };

            DialogResult = DialogResult.OK;
        }
                
    }
}
