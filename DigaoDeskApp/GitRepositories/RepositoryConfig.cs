namespace DigaoDeskApp
{
    public class RepositoryConfigItem
    {
        public string Name;
        public RepositoryConfigContents Config;
    }

    public class RepositoryConfigContents
    {
        public string Order;
        public string MasterBranch = "origin/main";
    }
}
