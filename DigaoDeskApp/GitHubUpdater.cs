using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    class GitHubUpdater
    {

        private const string URL = "https://api.github.com/repos/digao-dalpiaz/DigaoDesk/releases/latest";

        public static void RunTask()
        {
            Task.Run(Check);      
        }

        private static void Check()
        {
            WebClient w = new();
            w.Headers.Add("User-Agent", "request");

            string data;
            try
            {
                data = w.DownloadString(URL);
            } 
            catch (WebException)
            {
                return;
            }

            var info = JsonConvert.DeserializeObject<ReleaseInfo>(data);

            if (info.tag_name.StartsWith("v")) info.tag_name = info.tag_name.Substring(1);

            if (info.tag_name != Vars.APP_VERSION)
            {
                Vars.FrmMainObj.Invoke(new MethodInvoker(() => { 
                    if (Messages.Question("There is a new version of Digao Desk available!" + Environment.NewLine + 
                        Environment.NewLine +
                        "New version: " + info.tag_name + Environment.NewLine +
                        "Published at: " + info.published_at.ToString("dd/MM/yyyy HH:mm") + Environment.NewLine +
                        Environment.NewLine +
                        "Do you want to check this version in GitHub now?"))
                    {
                        Process.Start("explorer", info.html_url);
                    }
                }));
            }
        }

#pragma warning disable 0649
        private class ReleaseInfo
        {
            public string html_url;
            public string tag_name;
            public string name;
            public DateTime published_at;
            public List<ReleaseAssetInfo> assets;
            public string body;
        }

        private class ReleaseAssetInfo
        {
            public string name;
            public long size;
            public string browser_download_url;
        }
#pragma warning restore 0649

    }
}
