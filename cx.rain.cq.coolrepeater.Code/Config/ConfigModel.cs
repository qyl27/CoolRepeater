using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.coolrepeater.Code.Config
{
    public class ConfigModel
    {
        public int RepeatThreshold { get; set; }

        public bool IgnoreAnonymous { get; set; }

        public string[] BlockWords { get; set; }
    }
}
