using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.coolrepeater.Code.Config
{
    public class ConfigModel
    {
        public int RepeatThreshold { get; set; } = 3;

        public bool IgnoreAnonymous { get; set; } = true;

        public bool IgnorePicture { get; set; } = false;

        public bool RandomRepeatProbability { get; set; } = true;

        public decimal RepeatProbability { get; set; } = 0.6M;

        public string[] BlockWords { get; set; } = new string[] { };

        public long[] EnabledGroups { get; set; } = new long[] { };

        public long[] DisabledGroups { get; set; } = new long[] { };
    }
}
