using cx.rain.cq.coolrepeater.UI.Window;
using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cx.rain.cq.coolrepeater.UI.Menu
{
    public class Menu_Settings : IMenuCall
    {
        private Form WindowSetting = null;

        public void MenuCall(object sender, CQMenuCallEventArgs e)
        {
            if (WindowSetting == null)
            {
                WindowSetting = new Settings();
                WindowSetting.FormClosing += WindowSetting_FormClosing;
                WindowSetting.Show();
            }
            else
            {
                WindowSetting.Activate();
            }
        }

        private void WindowSetting_FormClosing(object sender, CancelEventArgs e)
        {
            WindowSetting = null;
        }
    }
}
