using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;

namespace DigaoDeskApp
{
    class Config
    {

        public string Language = LangEngine.DEFAULT_LANG;

        public ConfigTheme Theme;
        public ConfigLog Log;
        public bool NotifyAppStops = true;
        public bool DontNotifyWhenAppsActive = false;
        
        public string ReposDir;
        public string ShellProgram = "cmd.exe";
        public string DiffProgram;
        public string DiffProgramArguments;
        public string GitNewBranchPrefixList;
        public bool GitAutoFetch = true;
        public string GitCommitMessage;
        public ConfigGit Git;

        public class ConfigTheme
        {
            public bool DarkTitle;
            public Color ToolbarBack;
            public Color ToolbarFore;
            public Color GridHeadBack;
            public Color GridHeadFore;
            public Color GridBack;
            public Color GridLines;
            public Color GridDataBack;
            public Color GridDataFore;
            public Color GridSelBack;
            public Color GridSelFore;
            public Color SplitterBack;
            public Color ConsoleBack;
            public Color ConsoleFore;
            public Color StatusBack;
            public Color StatusFore;
        }

        public class ConfigLog
        {
            public string FontName = "Consolas";
            public float FontSize = 10;
            public bool ShowTimestamp = false;
            public bool WordWrap = false;
        }

        public class ConfigGit
        {
            public string Name;
            public string Email;

            public string CredUsername;
            public string CredPassword;
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

            if (Vars.Config.Theme == null) Vars.Config.Theme = new();
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
