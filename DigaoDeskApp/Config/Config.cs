﻿using Newtonsoft.Json;
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
            public Color ConsoleFore = Color.FromArgb(128, 255, 128);
            public Color StatusBack = Color.FromArgb(30, 30, 30);
            public Color StatusFore = Color.Silver;

            public string FontName = "Consolas";
            public float FontSize = 10;
            public bool ShowTimestamp = false;
            public bool WordWrap = false;
        }

        public class ConfigApps
        {
            public bool NotifyAppStops = true;
            public bool DontNotifyWhenAppsActive = false;
            public int MaxLogLines = 10000;
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
            if (Vars.Config.Apps == null) Vars.Config.Apps = new();
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
