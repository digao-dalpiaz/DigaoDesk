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

            _config = config;
        }

        private void FrmRepositoryConfig_Load(object sender, EventArgs e)
        {
            edOrder.Text = _config.Order;
            edMasterBranch.Text = _config.MasterBranch;
            ckFetch.Checked = _config.Fetch;
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
