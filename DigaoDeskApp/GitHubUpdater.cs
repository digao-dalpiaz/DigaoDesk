using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public class GitHubUpdater
    {

        private const string URL = "https://api.github.com/repos/digao-dalpiaz/DigaoDesk/releases/latest";

        private const string UPDATE_ARG_PARAM = "/update";

        public static void RunTask()
        {
            Task.Run(Check);      
        }

        private static void Check()
        {
            HttpClient http = new();
            http.DefaultRequestHeaders.Add("User-Agent", "request");

            string data;
            try
            {
                data = http.GetAsync(URL).GetAwaiter().GetResult()
                    .Content.ReadAsStringAsync().GetAwaiter().GetResult();
            } 
            catch (Exception ex)
            {
                Debug.WriteLine("Error checking updates: " + ex.Message);
                return;
            }

            ReleaseInfo info;
            try
            {
                info = JsonConvert.DeserializeObject<ReleaseInfo>(data);
            }
            catch (Exception ex)
            {
                Vars.FrmMainObj.Invoke(new MethodInvoker(() =>
                {
                    Messages.Error("Failed to read version information from GitHub: " + ex.Message);
                }));
                return;
            }

            if (info.tag_name.StartsWith("v")) info.tag_name = info.tag_name.Substring(1);

            if (info.tag_name != Vars.APP_VERSION)
            {
                Vars.FrmMainObj.Invoke(new MethodInvoker(() =>
                {
                    FrmDownload f = new(info);
                    f.Show();
                }));
            }
        }

        public static void CheckForRunTmpUpdateExeOnClosing()
        {
            if (Vars.UpdateTmpExe == null) return;

            if (!File.Exists(Vars.UpdateTmpExe))
            {
                Messages.Error("Unable to run the temp update program because is was removed!");
                return;
            }

            List<string> args = new();
            args.Add(Application.ExecutablePath);
            args.Add(UPDATE_ARG_PARAM);

            Process.Start(Vars.UpdateTmpExe, args);
        }

        public static bool CheckForUpdateExe()
        {
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
