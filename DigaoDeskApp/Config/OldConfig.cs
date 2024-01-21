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
            config.Repos.GitGroups = [];

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
            if (config.Repos.GitGroups.Count > 0)
            {
                string dir = AppDomain.CurrentDomain.BaseDirectory;

                Guid uuid = config.Repos.GitGroups.First().ReadSafeUUID();

                MoveFile(uuid, dir, "gitrepos", ".log");
                MoveFile(uuid, dir, "repositories", ".json");
            }
        }

        private static void MoveFile(Guid uuid, string dir, string name, string extension)
        {
            string oldFile = Path.Combine(dir, name + extension);
            if (File.Exists(oldFile))
            {
                string newFile = Path.Combine(dir, name + "_" + uuid + extension);

                EventAudit.Do(string.Format("Rename old file {0} to {1}", oldFile, newFile));
                try
                {
                    File.Move(oldFile, newFile);
                }
                catch (Exception e)
                {
                    EventAudit.Do("Error renaming file: " + e.Message);
                }
            }
        }

    }
}
