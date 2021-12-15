namespace DigaoDeskApp
{
    public class RepositoryConfigItem
    {
        public string Name;
        public RepositoryConfigContents Config;
    }

    public class RepositoryConfigContents
    {
        public string Order = ""; //if default null, when using repository config dialog and leave it blank, the order changes
        public string MasterBranch = "origin/main";
    }
}
