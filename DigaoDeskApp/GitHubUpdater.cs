using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public class GitHubUpdater
    {

        private const string URL_RELEASES = "https://api.github.com/repos/digao-dalpiaz/DigaoDesk/releases";
        private const string URL_LATEST = URL_RELEASES + "/latest";

        private const string UPDATE_ARG_PARAM = "/update";

        public static void RunTask()
        {
            Task.Run(Check);      
        }

        private static string GetGitHubAPI(string url)
        {
            HttpClient http = new();
            http.DefaultRequestHeaders.Add("User-Agent", "request");

            return http.GetAsync(url).GetAwaiter().GetResult()
                .Content.ReadAsStringAsync().GetAwaiter().GetResult();
        }

        private static void Check()
        {
            string data;
            try
            {
                data = GetGitHubAPI(URL_LATEST);
            } 
            catch (Exception ex)
            {
                Debug.WriteLine("Error checking updates: " + ex.Message);
                return;
            }

            try
            {
                var info = JsonConvert.DeserializeObject<ReleaseInfo>(data);
                if (info.message != null) return; //some error message returned
                NormalizeVersion(info);

                if (info.tag_name != Vars.APP_VERSION)
                {
                    string news = RetrieveNews();

                    Vars.FrmMainObj.Invoke(new MethodInvoker(() =>
                    {
                        FrmDownload f = new(info, news);
                        f.Show();
                    }));
                }
            }
            catch (Exception ex)
            {
                Vars.FrmMainObj.Invoke(new MethodInvoker(() =>
                {
                    Messages.Error(string.Format(Vars.Lang.Updater_FailedToReadVersionInfo, ex.Message));
                }));
            }
        }

        private static void NormalizeVersion(ReleaseInfo info)
        {
            if (info.tag_name.StartsWith("v")) info.tag_name = info.tag_name.Substring(1);
        }

        private static string RetrieveNews()
        {
            List<ReleaseInfo> lstVersionsNews = new();
            FindVersions(lstVersionsNews);

            StringBuilder sb = new();
            foreach (var version in lstVersionsNews)
            {
                sb.AppendLine(string.Format("[Version {0}]", version.tag_name));
                sb.AppendLine(version.body.Replace("\\r\\n", Environment.NewLine));
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private static void FindVersions(List<ReleaseInfo> lstVersionsNews)
        {
            int page = 0;
            while (true)
            {
                page++;
                string data = GetGitHubAPI(URL_RELEASES + "?per_page=5&page=" + page);
                var lstInfo = JsonConvert.DeserializeObject<List<ReleaseInfo>>(data);
                if (!lstInfo.Any()) return; //anything wrong!
                foreach (var version in lstInfo)
                {
                    NormalizeVersion(version);
                    if (version.tag_name == Vars.APP_VERSION) return;

                    lstVersionsNews.Add(version);
                }
            }
        }

        public static void CheckForRunTmpUpdateExeOnClosing()
        {
            if (Vars.UpdateTmpExe == null) return;

            if (!File.Exists(Vars.UpdateTmpExe))
            {
                Messages.Warning(Vars.Lang.Updater_TmpExeRemoved);
                return;
            }

            List<string> args = new();
            args.Add(Application.ExecutablePath);
            args.Add(UPDATE_ARG_PARAM);

            Process.Start(Vars.UpdateTmpExe, args);
        }

        public static bool CheckForUpdateExe()
        {
            //Translation and config not available at this point!
            if (!Environment.GetCommandLineArgs().Any(x => x == UPDATE_ARG_PARAM)) return false;

            try
            {
                FrmWait.Start("Updating...");
                try
                {
                    string target = Environment.GetCommandLineArgs()[1];
                    if (!target.EndsWith(".exe", StringComparison.OrdinalIgnoreCase)) throw new Exception("Invalid target");

                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            File.Copy(Application.ExecutablePath, target, true);
                            break;
                        }
                        catch (Exception)
                        {
                            Thread.Sleep(1000);
                        }
                    }

                    Process.Start(target);
                }
                finally
                {
                    FrmWait.Stop();
                }
            }
            catch (Exception ex)
            {
                Messages.Error("Error on updating process: " + ex.Message);
            }
            return true;
        }

        public class ReleaseInfo
        {
            public string message;

            public string html_url;
            public string tag_name;
            public string name;
            public DateTime published_at;
            public List<ReleaseAssetInfo> assets;
            public string body;
        }

        public class ReleaseAssetInfo
        {
            public string name;
            public long size;
            public string browser_download_url;
        }

    }
}
