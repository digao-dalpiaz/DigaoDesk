using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;

namespace DigaoDeskApp
{
    class Config
    {

        public ConfigLog Log;
        public bool NotifyAppStops = true;
        
        public string ReposDir;
        public ConfigGit Git;

        public class ConfigLog
        {
            public string FontName = "Consolas";
            public float FontSize = 10;
            public Color TextColor = Color.Lime;
            public Color BgColor = Color.FromArgb(30, 30, 30);
            public bool ShowTimestamp = false;
            public bool WordWrap = false;
        }

        public class ConfigGit
        {
            public string Name;
            public string Email;
        }

        private static string GetConfigFile()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        }

        public static void Load()
        {
            var path = GetConfigFile();
            if (File.Exists(path)) {
                var data = File.ReadAllText(path);
                Vars.Config = JsonConvert.DeserializeObject<Config>(data);
            } 
            else
            {
                Vars.Config = new();
            }

            if (Vars.Config.Log == null) Vars.Config.Log = new();
            if (Vars.Config.Git == null) Vars.Config.Git = new();
        }

        public void Save()
        {
            var path = GetConfigFile();
            var data = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, data);
        }

    }
}
