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
        private GitHubUpdater.ReleaseAssetInfo _assetInfo;

        public FrmDownload(GitHubUpdater.ReleaseInfo releaseInfo, string news)
        {
            InitializeComponent();

            LoadLang();

            _releaseInfo = releaseInfo;
            _assetInfo = GetAsset();

            lbCurrentVersion.Text = Vars.APP_VERSION;
            lbNewVersion.Text = releaseInfo.tag_name;
            lbTimestamp.Text = releaseInfo.published_at.ToString("yyyy-MM-dd HH:mm");
            
            lbSize.Text = _assetInfo != null ? 
                (Convert.ToDecimal(_assetInfo.size) / 1024 / 1024).ToString("0.00") + " MB" : null;

            edNews.Text = news;
        }

        private void LoadLang()
        {
            this.Text = Vars.Lang.Updater_Title;
            lbNewVersionAvailable.Text = Vars.Lang.Updater_LabelNewVersionAvailable;
            lblbCurrentVersion.Text = Vars.Lang.Updater_LabelCurrentVersion;
            lblbNewVersion.Text = Vars.Lang.Updater_LabelNewVersion;
            lblbTimestamp.Text = Vars.Lang.Updater_LabelTimestamp;
            lblbSize.Text = Vars.Lang.Updater_LabelSize;
            lbDownloading.Text = Vars.Lang.Updater_LabelDownloading;
            btnDownload.Text = Vars.Lang.Updater_BtnDownload;
            btnCancel.Text = Vars.Lang.Updater_BtnCancel;
        }

        private GitHubUpdater.ReleaseAssetInfo GetAsset()
        {
            if (_releaseInfo.assets != null && _releaseInfo.assets.Any())
            {
                GitHubUpdater.ReleaseAssetInfo asset = _releaseInfo.assets[0];
                if (asset.browser_download_url.EndsWith(".exe"))
                {
                    return asset;
                }
            }

            return null;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (_assetInfo == null)
            {
                Messages.Error("Invalid asset");
                return;
            }

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
                Messages.Info(Vars.Lang.Updater_CloseToUpdate);
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
            string urlExe = _assetInfo.browser_download_url;

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
