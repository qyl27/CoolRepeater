using cx.rain.cq.coolrepeater.Code.Config;
using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.coolrepeater.Code.Event
{
    public class Event_AppDisable : IAppDisable
    {
        public void AppDisable(object sender, CQAppDisableEventArgs e)
        {
            ConfigWorker.Save(ConfigWorker.Path);
            e.CQLog.Info("Cool复读机", "感谢使用！");
        }
    }
}
