﻿using cx.rain.cq.coolrepeater.Code.Config;
using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.coolrepeater.Code.Event
{
    public class Event_AppEnable : IAppEnable
    {
        public void AppEnable(object sender, CQAppEnableEventArgs e)
        {
            e.CQLog.Info("Cool复读机", "欢迎使用！");

            var dataDir = e.CQApi.AppDirectory;
            var configPath = dataDir + "/config.json";
            ConfigWorker.Load(configPath);
            e.CQLog.Info("Cool复读机", "配置文件加载完成。");
        }
    }
}
