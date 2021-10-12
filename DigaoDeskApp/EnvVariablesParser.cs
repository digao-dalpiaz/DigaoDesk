﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigaoDeskApp
{
    class EnvVariablesParser
    {

        public static Dictionary<string, string> StringToDictionary(string text)
        {
            Dictionary<string, string> dic = new(StringComparer.InvariantCultureIgnoreCase);

            var lines = text.Split(Environment.NewLine);
            foreach (var preLine in lines)
            {
                var line = preLine.Trim();
                try
                {
                    if (line == string.Empty) continue;
                    
                    var parts = line.Split("=");

                    if (parts.Count() < 2) Messages.ThrowMsg("Missing equals sign");

                    var key = parts[0].Trim();
                    var value = parts[1].Trim();

                    if (key == string.Empty) Messages.ThrowMsg("Missing key name");
                    if (dic.ContainsKey(key)) Messages.ThrowMsg("Repeated key name");

                    dic.Add(key, value);
                }
                catch (Messages.MessageException msgEx)
                {
                    Messages.ThrowMsg(msgEx.Message + Environment.NewLine + "Line: " + line);
                }
            }

            return dic;
        }

        public static string DictionaryToString(Dictionary<string, string> lst)
        {
            StringBuilder sb = new();

            foreach (var item in lst)
            {
                sb.AppendLine(item.Key + "=" + item.Value);
            }

            return sb.ToString();
        }

    }
}
