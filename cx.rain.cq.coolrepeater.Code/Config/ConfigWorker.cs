using Newtonsoft.Json;
using System.IO;
using System.Linq;

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
                CoolRepeater.IgnorePicture = config.IgnorePicture;
                CoolRepeater.GreaterChancesMoreRepeat = config.GreaterChancesMoreRepeat;
                CoolRepeater.RepeatProbability = config.RepeatProbability;
                CoolRepeater.BlockWords = config.BlockWords.ToList();
                CoolRepeater.EnabledGroups = config.EnabledGroups.ToList();
                CoolRepeater.DisabledGroups = config.DisabledGroups.ToList();
            }
            else
            {
                Save(path);
            }
        }

        public static void Save(string path)
        {
            var config = new ConfigModel()
            {
                IgnoreAnonymous = CoolRepeater.IgnoreAnonymous,
                IgnorePicture = CoolRepeater.IgnorePicture,
                RepeatThreshold = CoolRepeater.RepeatThreshold,
                GreaterChancesMoreRepeat = CoolRepeater.GreaterChancesMoreRepeat,
                RepeatProbability = CoolRepeater.RepeatProbability,
                BlockWords = CoolRepeater.BlockWords.ToArray(), 
                DisabledGroups = CoolRepeater.DisabledGroups.ToArray(), 
                EnabledGroups = CoolRepeater.EnabledGroups.ToArray()
            };
            var configJson = JsonConvert.SerializeObject(config);
            File.WriteAllText(path, configJson);
        }
    }
}
