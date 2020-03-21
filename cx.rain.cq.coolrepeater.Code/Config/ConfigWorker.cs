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
                CoolRepeater.RandomRepeatProbability = config.RandomRepeatProbability;
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
            var config = new ConfigModel();
            var configJson = JsonConvert.SerializeObject(config);
            File.WriteAllText(path, configJson);
        }
    }
}
