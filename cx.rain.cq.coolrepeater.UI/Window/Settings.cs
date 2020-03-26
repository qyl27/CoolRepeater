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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            numericUpDownRepeatThreshold.Value = CoolRepeater.RepeatThreshold;
            checkBoxIgnoreAnonymous.Checked = CoolRepeater.IgnoreAnonymous;
            checkBoxIgnorePicture.Checked = CoolRepeater.IgnorePicture;
            numericUpDownRepeatProbability.Value = CoolRepeater.RepeatProbability;
            checkBoxGreaterChancesMoreRepeat.Checked = CoolRepeater.GreaterChancesMoreRepeat;

            foreach (var item in CoolRepeater.BlockWords)
            {
                listBoxBlackWords.Items.Add(item);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CoolRepeater.RepeatThreshold = (int) numericUpDownRepeatThreshold.Value;
            CoolRepeater.IgnoreAnonymous = checkBoxIgnoreAnonymous.Checked;
            CoolRepeater.IgnorePicture = checkBoxIgnorePicture.Checked;
            CoolRepeater.RepeatProbability = numericUpDownRepeatProbability.Value;
            CoolRepeater.GreaterChancesMoreRepeat = checkBoxGreaterChancesMoreRepeat.Checked;

            CoolRepeater.BlockWords.Clear();
            foreach (var item in listBoxBlackWords.Items)
            {
                CoolRepeater.BlockWords.Add(item.ToString());
            }
            ConfigWorker.Save(ConfigWorker.Path);
            Close();
        }

        private void buttonBlockWordsRemoveSelect_Click(object sender, EventArgs e)
        {
            if (listBoxBlackWords.SelectedIndex >= 0)
            {
                listBoxBlackWords.Items.RemoveAt(listBoxBlackWords.SelectedIndex);
            }
        }

        private void buttonBlockWordsAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBlockWordsAdd.Text))
            {
                listBoxBlackWords.Items.Add(textBoxBlockWordsAdd.Text);
            }
            else
            {
                MessageBox.Show("请在上面的文本框中填入所要拒绝复读的词汇。", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGroupSpecialSetting_Click(object sender, EventArgs e)
        {
            new GroupSpecialSettings().Show();
        }
    }
}
