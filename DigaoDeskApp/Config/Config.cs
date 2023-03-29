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
        public ConfigApps Apps;
        
        public string ReposDir;
        public string ShellProgram = "cmd.exe";
        public string DiffProgram;
        public string DiffProgramArguments;
        public string GitNewBranchPrefixList;
        public string GitCustomCommands;
        public bool GitAutoCRLF = true;
        public bool GitAutoFetch = true;
        public string GitCommitMessage;
        public ConfigGit Git;

        public class ConfigTheme
        {
            public bool DarkTitle = true;

            public Color ToolbarBack = Color.FromArgb(30, 30, 30);
            public Color ToolbarFore = Color.White;
            public Color GridHeadBack = Color.FromArgb(0, 26, 50);
            public Color GridHeadFore = Color.White;
            public Color GridBack = Color.FromArgb(30, 30, 30);
            public Color GridLines = Color.FromArgb(65, 65, 65);
            public Color GridDataBack = Color.FromArgb(30, 30, 30);
            public Color GridDataFore = Color.FromArgb(255, 255, 128);
            public Color GridSelBack = Color.FromArgb(1, 38, 118);
            public Color GridSelFore = Color.White;
            public Color SplitterBack = Color.FromArgb(50, 50, 50);
            public Color ConsoleBack = Color.FromArgb(15, 15, 15);
            public Color StatusBack = Color.FromArgb(30, 30, 30);
            public Color StatusFore = Color.Silver;

            public Color AppLogNormal = Color.FromArgb(128, 255, 128);
            public Color AppLogError = Color.Salmon;
            public Color AppLogDynWarn = Color.Orange;
            public Color AppLogDynError = Color.Crimson;
            public Color AppLogStop = Color.MediumPurple;

            public Color RepoLogNormal = Color.White;
            public Color RepoLogAlert = Color.Fuchsia;
            public Color RepoLogError = Color.Red;
            public Color RepoLogDone = Color.Lime;
            public Color RepoLogTitle = Color.Yellow;
            public Color RepoLogAggProcessing = Color.MediumAquamarine;
            public Color RepoLogProcessing = Color.Cyan;
            public Color RepoLogRefreshing = Color.BlueViolet;
            public Color RepoLogRefreshDone = Color.MediumPurple;

            public Color RepoLogStatusOK = Color.Gold;
            public Color RepoLogStatusWarn = Color.Crimson;
            public Color RepoLogStatusNone = Color.SeaGreen;

            public Color RepoLogLabelCaption = Color.Wheat;
            public Color RepoLogLabelValue = Color.DodgerBlue;

            public Color TimestampFore = Color.Gray;

            public string FontName = "Consolas";
            public float FontSize = 10;
            public bool ShowTimestamp = false;
            public bool WordWrap = false;
        }

        public class ConfigApps
        {
            public bool CalcResources = true;
            public bool NotifyAppStops = true;
            public bool DontNotifyWhenAppsActive = false;
            public int MaxLogSize = 25000;
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

                EventAudit.Do("Settings loaded from file");
            } 
            else
            {
                Vars.Config = new();

                EventAudit.Do("Settings initialized from defaults");
            }

            if (Vars.Config.Theme == null) Vars.Config.Theme = new();
            if (Vars.Config.Apps == null) Vars.Config.Apps = new();
            if (Vars.Config.Git == null) Vars.Config.Git = new();
        }

        public void Save()
        {
            var path = GetConfigFile();
            var data = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, data);

            EventAudit.Do("Settings saved");
        }

    }
}
