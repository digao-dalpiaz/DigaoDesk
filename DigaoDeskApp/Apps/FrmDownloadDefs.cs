using System;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmDownloadDefs : Form
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\DownloadDefs";

        public FrmDownloadDefs()
        {
            InitializeComponent();

            LoadLang();

            edURL_TextChanged(null, null);
        }

        private void LoadLang()
        {
            this.Text = Vars.Lang.DownloadDefs_Title;
            lbURL.Text = Vars.Lang.DownloadDefs_URL;

            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        private void FrmDownloadDefs_Load(object sender, EventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            edURL.Text = (string)r.GetValue("URL");
        }

        private void FrmDownloadDefs_FormClosed(object sender, FormClosedEventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            r.SetValue("URL", getURL());
        }

        public string getURL()
        {
            return edURL.Text.Trim();
        }

        private void edURL_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = getURL() != string.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        
    }
}
