using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.coolrepeater.Code.Config
{
    public class ConfigWorker
    {
        public static string Path = "";

        public static void Load(string path)
        {
            Path = path;

            if (File.Exists(path))
            {
                var config = JsonConvert.DeserializeObject<ConfigModel>(File.ReadAllText(path));
                CoolRepeater.RepeatThreshold = config.RepeatThreshold;
                CoolRepeater.IgnoreAnonymous = config.IgnoreAnonymous;
                CoolRepeater.BlockWords = config.BlockWords.ToList();
            }
            else
            {
                var config = new ConfigModel()
                {
                    RepeatThreshold = CoolRepeater.RepeatThreshold,
                    IgnoreAnonymous = CoolRepeater.IgnoreAnonymous,
                    BlockWords = CoolRepeater.BlockWords.ToArray()
                };
                var configJson = JsonConvert.SerializeObject(config);
                File.WriteAllText(path, configJson);
            }
        }

        public static void Save(string path)
        {
            var config = new ConfigModel()
            {
                RepeatThreshold = CoolRepeater.RepeatThreshold,
                IgnoreAnonymous = CoolRepeater.IgnoreAnonymous,
                BlockWords = CoolRepeater.BlockWords.ToArray()
            };
            var configJson = JsonConvert.SerializeObject(config);
            File.WriteAllText(path, configJson);
        }
    }
}
