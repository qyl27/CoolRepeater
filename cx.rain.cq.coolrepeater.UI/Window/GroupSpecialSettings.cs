using cx.rain.cq.coolrepeater.Code;
using cx.rain.cq.coolrepeater.Code.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cx.rain.cq.coolrepeater.UI.Window
{
    public partial class GroupSpecialSettings : Form
    {
        public GroupSpecialSettings()
        {
            InitializeComponent();

            foreach (var item in CoolRepeater.EnabledGroups)
            {
                listBoxEnableGroup.Items.Add(item);
            }

            foreach (var item in CoolRepeater.DisabledGroups)
            {
                listBoxDisableGroup.Items.Add(item);
            }

            foreach (var item in CoolRepeater.Api.GetGroupList())
            {
                if (!CoolRepeater.EnabledGroups.Contains(item.Group.Id)
                    && !CoolRepeater.DisabledGroups.Contains(item.Group.Id))
                {
                    listBoxDisableGroup.Items.Add(item.Group.Id);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CoolRepeater.EnabledGroups.Clear();
            foreach (var item in listBoxEnableGroup.Items)
            {
                CoolRepeater.EnabledGroups.Add(long.Parse(item.ToString()));
            }

            CoolRepeater.DisabledGroups.Clear();
            foreach (var item in listBoxDisableGroup.Items)
            {
                CoolRepeater.DisabledGroups.Add(long.Parse(item.ToString()));
            }

            ConfigWorker.Save(ConfigWorker.Path);
            Close();
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            if (listBoxDisableGroup.SelectedIndex != -1)
            {
                listBoxEnableGroup.Items.Add(listBoxDisableGroup.SelectedItem);
                listBoxDisableGroup.Items.Remove(listBoxDisableGroup.SelectedItem);
            }
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            if (listBoxEnableGroup.SelectedIndex != -1)
            {
                listBoxDisableGroup.Items.Add(listBoxEnableGroup.SelectedItem);
                listBoxEnableGroup.Items.Remove(listBoxEnableGroup.SelectedItem);
            }
        }
    }
}
