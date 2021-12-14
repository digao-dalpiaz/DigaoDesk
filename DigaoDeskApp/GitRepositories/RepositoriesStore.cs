using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DigaoDeskApp
{
    public class RepositoriesStore
    {

        private static string GetRepositoriesFile()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "repositories.json");
        }

        public static List<RepositoryConfigItem> Load()
        {
            var path = GetRepositoriesFile();
            if (File.Exists(path))
            {
                var data = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<List<RepositoryConfigItem>>(data);
            }
            else
            {
                return new();
            }
        }

        public static void Save(List<DigaoRepository> lstRepositories)
        {
            var path = GetRepositoriesFile();

            List<RepositoryConfigItem> lst = new();

            foreach (var repo in lstRepositories)
            {
                RepositoryConfigItem item = new();
                item.Name = repo.Name;
                item.Config = repo.Config;
                lst.Add(item);
            }

            var data = JsonConvert.SerializeObject(lst, Formatting.Indented);
            File.WriteAllText(path, data);
        }

    }
}
