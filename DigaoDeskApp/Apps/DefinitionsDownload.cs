using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    internal class DefinitionsDownload
    {

        public bool DoDownloadDialog()
        {
            FrmDownloadDefs f = new();
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DoDownload(f.getURL());
                    return true;
                }
                catch (Exception ex)
                {
                    Messages.Error(ex.Message);
                }
            }

            return false;
        }

        private void DoDownload(string url)
        {
            var AppDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "DigaoDesk");
            if (!Directory.Exists(AppDataDir))
            {
                Directory.CreateDirectory(AppDataDir);
            }

            FrmWait.Start(Vars.Lang.DownloadDefs_Downloading);
            try
            {
                using var http = new HttpClient();
                using var stm = http.GetStreamAsync(url).Result;
                using var zip = new ZipArchive(stm);
                zip.ExtractToDirectory(AppDataDir, true);
            }
            finally
            {
                FrmWait.Stop();
            }

            var arqApps = Path.Combine(AppDataDir, "applications.json");
            if (!File.Exists(arqApps))
            {
                throw new Exception(Vars.Lang.DownloadDefs_FileAppsJsonNotFound);
            }
            var content = File.ReadAllText(arqApps);
            File.Delete(arqApps);

            var appsList = JsonConvert.DeserializeObject<List<DigaoApplication>>(content);

            int iAdd = 0;
            int iUpd = 0;

            foreach (var app in appsList)
            {
                var actualApp = Vars.AppList.Find(x => x.Name == app.Name);
                if (actualApp != null)
                {
                    CopyApp(app, actualApp);
                    iUpd++;
                } 
                else
                {
                    Vars.AppList.Add(app);
                    iAdd++;
                }
            }

            ApplicationsStore.SaveApplications();

            Messages.Info(string.Format(Vars.Lang.DownloadDefs_Report, iAdd, iUpd));
        }

        private static void CopyApp(DigaoApplication source, DigaoApplication target)
        {
            target.Cmd = source.Cmd;
            target.Args = source.Args;
            target.WorkDir = source.WorkDir;
            target.EnvVars = source.EnvVars;
            target.TcpPort = source.TcpPort;
        }

    }
}
