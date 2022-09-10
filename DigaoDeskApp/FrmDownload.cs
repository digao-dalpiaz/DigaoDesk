using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmDownload : Form
    {

        private const bool TESTING_MODE = false;

        private GitHubUpdater.ReleaseInfo _releaseInfo;

        public FrmDownload(GitHubUpdater.ReleaseInfo releaseInfo)
        {
            InitializeComponent();

            _releaseInfo = releaseInfo;

            lbVersion.Text = releaseInfo.tag_name;
            lbTimestamp.Text = releaseInfo.published_at.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            lbDownloading.Visible = true;
            btnDownload.Enabled = false;
            btnCancel.Enabled = false;
            this.Refresh();

            try
            {
                try
                {
                    DownloadFile();
                }
                finally
                {
                    lbDownloading.Visible = false;
                }

                this.Close();
                Messages.Info("Please, close the program to finish the update process.");
            }
            catch (Exception ex)
            {
                Messages.Error(ex.Message);

                btnDownload.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DownloadFile()
        {
            if (!_releaseInfo.assets.Any()) throw new Exception("No assets found");

            string urlExe = _releaseInfo.assets[0].browser_download_url;
            if (!urlExe.EndsWith(".exe")) throw new Exception("Invalid asset file");

            HttpClient http = new();
            Stream stm = http.GetAsync(urlExe).GetAwaiter().GetResult()
                .Content.ReadAsStreamAsync().GetAwaiter().GetResult();

            string tmpExe = Path.GetTempFileName() + ".exe";
            using (var fileStream = File.Create(tmpExe))
            {
                stm.Seek(0, SeekOrigin.Begin);
                stm.CopyTo(fileStream);
            }

            if (TESTING_MODE) File.Copy(Application.ExecutablePath, tmpExe, true);

            Vars.UpdateTmpExe = tmpExe;
        }

    }
}
