using System;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmRepositoryConfig : Form
    {

        private RepositoryConfigContents _config;

        public FrmRepositoryConfig(RepositoryConfigContents config)
        {
            InitializeComponent();

            LoadLang();

            _config = config;
        }

        private void FrmRepositoryConfig_Load(object sender, EventArgs e)
        {
            edOrder.Text = _config.Order;
            edMasterBranch.Text = _config.MasterBranch;
            ckFetch.Checked = _config.Fetch;
        }

        private void LoadLang()
        {
            this.Text = Vars.Lang.RepoConfig_Title;
            lbOrder.Text = Vars.Lang.RepoConfig_Order;
            lbMasterBranch.Text = Vars.Lang.RepoConfig_MasterBranch;
            ckFetch.Text = Vars.Lang.RepoConfig_Fetch;
            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            edOrder.Text = edOrder.Text.Trim();
            edMasterBranch.Text = edMasterBranch.Text.Trim();

            //

            _config.Order = edOrder.Text;
            _config.MasterBranch = edMasterBranch.Text;
            _config.Fetch = ckFetch.Checked;

            DialogResult = DialogResult.OK;
        }
    }
}
