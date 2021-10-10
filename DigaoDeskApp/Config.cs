using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;

namespace DigaoDeskApp
{
    class Config
    {

        public ConfigLog Log;

        public class ConfigLog
        {
            public string FontName = "Consolas";
            public float FontSize = 10;
            public Color TextColor = Color.Lime;
            public Color BgColor = Color.FromArgb(30, 30, 30);
            public bool ShowTimestamp = false;
            public bool WordWrap = false;
            public bool AutoScroll = true;
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
                Vars.Config.Log = new();
            }            
        }

        public void Save()
        {
            var path = GetConfigFile();
            var data = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, data);
        }

    }
}
