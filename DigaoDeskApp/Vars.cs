using System.Collections.Generic;

namespace DigaoDeskApp
{
    class Vars
    {

        public const string APP_VERSION = "1.10.4";
        public const string APP_REGKEY = @"SOFTWARE\DigaoDesk";

        public const string GITHUB_LINK = "https://github.com/digao-dalpiaz/DigaoDesk";

        private const string DIGAODALPIAZ_WP_LINK = "https://digaodalpiaz.com/wp/";
        public const string DIGAODALPIAZ_DONATE_LINK = DIGAODALPIAZ_WP_LINK + "donate";
        public const string DIGAODALPIAZ_SURVEY_LINK = DIGAODALPIAZ_WP_LINK + "digao-desk-usage";

        public const string DATETIME_FMT = "yyyy-MM-dd HH:mm:ss";

        public static FrmMain FrmMainObj;
        public static FrmConfig FrmConfigObj;
        public static FrmApps FrmAppsObj;
        public static FrmRepos FrmReposObj;

        public static FrmFind FrmFindObj;
        public static FindMemory FindMemoryObj;

        public static List<DigaoApplication> AppList;

        public static Config Config;

        public static Language Lang;

        public static string UpdateTmpExe;

        public static bool IsSuspended;

    }
}
