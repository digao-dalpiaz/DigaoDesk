using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DigaoDeskApp
{
    class ApplicationsStore
    {

        private static string GetApplicationsFile()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "applications.json");
        }

        public static void LoadApplications()
        {
            var path = GetApplicationsFile();
            if (File.Exists(path))
            {
                var data = File.ReadAllText(path);
                Vars.AppList = JsonConvert.DeserializeObject<List<DigaoApplication>>(data);
            }
            else
            {
                Vars.AppList = new();
            }
        }

        public static void SaveApplications()
        {
            var path = GetApplicationsFile();
            var data = JsonConvert.SerializeObject(Vars.AppList, Formatting.Indented);
            File.WriteAllText(path, data);
        }

    }
}
