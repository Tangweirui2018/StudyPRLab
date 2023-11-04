using ConsoleAppTEST;
using GitHubInfoUpdate.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitHubInfoUpdate
{
    class Functions
    {
        public Functions() 
        {
            client = new();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + "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");
            client.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
            client.DefaultRequestHeaders.Add("User-Agent", "TWR-APP");
        }
        private static JsonSerializerOptions jsonOptions = new(){ IncludeFields = true };
        private HttpClient client;
        public async Task<List<Release>?> GetRelease(string url)
        {
            try
            {
                var response = await client.GetAsync(url);
                var json = JsonSerializer.Deserialize<List<Release>>(response.Content.ReadAsStream());
                return json;
            }
            catch
            {
                return null;
            }
        }

        public static Config ReadConfig(string config)
        {
            if(File.Exists(config))
            {
                try
                {
                    using var file = File.OpenRead(config);
                    var json = JsonSerializer.Deserialize<Config>(file, jsonOptions);
                    if(json != null)
                    {
                        json.ReleaseInfo ??= new();
                        return json;
                    }
                }catch { }
            }
            return new Config() { ReleaseInfo = new()};
        }
        public static bool SaveConfig(Config config, string file)
        {
            try
            {
                var json = JsonSerializer.Serialize(config, jsonOptions);
                if (json != null)
                {
                    File.WriteAllText(file, json);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public static bool MatchSame(Config config, string newRepo, string newOwner)
        {
            if(config.ReleaseInfo == null)
            {
                throw new Exception("Wrong Config");
            }
            foreach(var item in config.ReleaseInfo)
            {
                (var repo, var owner, _, _, _) = item.ToTuple();
                if(newRepo.Equals(repo) && newOwner.Equals(owner))
                    return false;
                
            }
            return true;
        }

    }
}
