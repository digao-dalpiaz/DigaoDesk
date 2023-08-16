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
    }
}
