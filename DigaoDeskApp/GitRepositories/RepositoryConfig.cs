namespace DigaoDeskApp
{
    public class RepositoryConfigItem
    {
        public string Name;
        public RepositoryConfigContents Config;
    }

    public class RepositoryConfigContents
    {
        public string MasterBranch = "origin/master";
    }
}
