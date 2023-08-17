using System.IO;
using System.Linq;
using System;

namespace DigaoDeskApp
{
    public class OldConfig
    {
        public string ReposDir;
        public string ShellProgram;
        public string DiffProgram;
        public string DiffProgramArguments;
        public string GitNewBranchPrefixList;
        public string GitCustomCommands;
        public bool GitAutoCRLF;
        public bool GitAutoFetch;
        public string GitCommitMessage;
        public ConfigGit Git;

        public class ConfigGit
        {
            public string Name;
            public string Email;

            public string CredUsername;
            public string CredPassword;
        }

        public void ConvertToNew(Config config)
        {
            config.Repos = new();
            config.Repos.GitGroups = new();

            config.Repos.ShellProgram = ShellProgram;
            config.Repos.DiffProgram = DiffProgram;
            config.Repos.DiffProgramArguments = DiffProgramArguments;
            config.Repos.GitNewBranchPrefixList = GitNewBranchPrefixList;
            config.Repos.GitCustomCommands = GitCustomCommands;
            config.Repos.GitAutoCRLF = GitAutoCRLF;
            config.Repos.GitAutoFetch = GitAutoFetch;
            config.Repos.GitCommitMessage = GitCommitMessage;

            if (!string.IsNullOrEmpty(ReposDir))
            {
                Config.CfgGitGroup g = new();
                g.InitUUID();
                g.Ident = "My Repositories";
                g.Path = ReposDir;
                g.AuthorName = Git.Name;
                g.AuthorEmail = Git.Email;
                g.CredUsername = Git.CredUsername;
                g.CredPassword = Git.CredPassword;

                config.Repos.GitGroups.Add(g);
            }

            config.Version = 2;
            config.Save();
        }

        public static void ConvertOldFiles(Config config)
        {
            if (config.Repos.GitGroups.Any())
            {
                string dir = AppDomain.CurrentDomain.BaseDirectory;

                Guid uuid = config.Repos.GitGroups.First().ReadSafeUUID();

                string oldLogFile = Path.Combine(dir, "gitrepos.log");
                if (File.Exists(oldLogFile))
                {
                    string newLogFile = Path.Combine(dir, string.Format("gitrepos_{0}.log", uuid));
                    File.Move(oldLogFile, newLogFile);

                    EventAudit.Do("Old repositories log file converted");
                }

                string oldReposCfg = Path.Combine(dir, "repositories.json");
                if (File.Exists(oldReposCfg))
                {
                    string newReposCfg = Path.Combine(dir, string.Format("repositories_{0}.json", uuid));
                    File.Move(oldReposCfg, newReposCfg);

                    EventAudit.Do("Old repositories config file converted");
                }
            }
        }

    }
}
