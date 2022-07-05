using Newtonsoft.Json;
using System;
using System.Linq;

namespace DigaoDeskApp;

internal class LangEngine
{
    public const string DEFAULT_LANG = "english";

    public static string[] Definitions = {
        "english",
        "chinese"
    };

    public static void Init()
    {
        string langName = Vars.Config.Language;
        if (!Definitions.Contains(langName))
        {
            //wrong language in config file, then load default language
            langName = DEFAULT_LANG;
        }

        string resName = string.Format("Languages.lang_{0}.json", langName);

        var langData = Utils.GetResource(resName);
        Vars.Lang = JsonConvert.DeserializeObject<Language>(langData);
    }

}
