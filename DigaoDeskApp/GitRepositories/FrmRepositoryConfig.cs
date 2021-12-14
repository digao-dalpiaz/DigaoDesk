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
            edMasterBranch.Text = _config.MasterBranch;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            edMasterBranch.Text = edMasterBranch.Text.Trim();

            //

            _config.MasterBranch = edMasterBranch.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
