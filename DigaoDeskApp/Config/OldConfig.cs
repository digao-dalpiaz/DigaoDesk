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
        }
    }
}
