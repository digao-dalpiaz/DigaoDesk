using System;
using System.Collections.Generic;
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

                    var i = line.IndexOf("=");
                    if (i == -1) Messages.ThrowMsg(Vars.Lang.EnvVarParser_MissingEqual);

                    var key = line.Substring(0, i).Trim();
                    var value = line.Substring(i+1).Trim();

                    if (key == string.Empty) Messages.ThrowMsg(Vars.Lang.EnvVarParser_MissingKey);
                    if (dic.ContainsKey(key)) Messages.ThrowMsg(Vars.Lang.EnvVarParser_DuplicatedKey);

                    dic.Add(key, value);
                }
                catch (Messages.MessageException msgEx)
                {
                    Messages.ThrowMsg(msgEx.Message + Environment.NewLine + string.Format(Vars.Lang.EnvVarParser_ErrorLine, line));
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
