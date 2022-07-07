﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DigaoDeskApp;

internal class LangEngine
{
    public const string DEFAULT_LANG = "english";

    public static List<Definition> Definitions = new() {
        new Definition { Name = "English", Value = "english" },
        new Definition { Name = "Chinese", Value = "chinese" }
    };

    public class Definition
    {
        public string Name;
        public string Value;

        public override string ToString()
        {
            return Name;
        }
    }

    public static void Init()
    {
        string langValue = Vars.Config.Language;
        if (GetDefinitionByValue(langValue) == null)
        {
            //wrong language in config file, then load default language
            langValue = DEFAULT_LANG;
        }

        string resName = string.Format("Languages.lang_{0}.json", langValue);

        var langData = Utils.GetResource(resName);
        Vars.Lang = JsonConvert.DeserializeObject<Language>(langData);

        CheckNullValues();
    }

    private static void CheckNullValues()
    {
        foreach (var p in typeof(Language).GetFields())
        {
            if (p.GetValue(Vars.Lang) == null)
            {
                throw new Exception(string.Format("Language string '{0}' is null", p.Name));
            }
        }
    }

    public static Definition GetDefinitionByValue(string value)
    {
        return Definitions.Find(x => x.Value == value);
    }

}
