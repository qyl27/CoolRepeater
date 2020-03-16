namespace cx.rain.cq.coolrepeater.UI.Window
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.labelRepeatThresholdLeft = new System.Windows.Forms.Label();
            this.labelRepeatThresholdRight = new System.Windows.Forms.Label();
            this.checkBoxIgnoreAnonymous = new System.Windows.Forms.CheckBox();
            this.listBoxBlackWords = new System.Windows.Forms.ListBox();
            this.labelBlackWords = new System.Windows.Forms.Label();
            this.buttonBlockWordsRemoveSelect = new System.Windows.Forms.Button();
            this.textBoxBlockWordsAdd = new System.Windows.Forms.TextBox();
            this.buttonBlockWordsAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownRepeatThreshold = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRepeatThresholdLeft
            // 
            this.labelRepeatThresholdLeft.AutoSize = true;
            this.labelRepeatThresholdLeft.Location = new System.Drawing.Point(12, 9);
            this.labelRepeatThresholdLeft.Name = "labelRepeatThresholdLeft";
            this.labelRepeatThresholdLeft.Size = new System.Drawing.Size(113, 12);
            this.labelRepeatThresholdLeft.TabIndex = 0;
            this.labelRepeatThresholdLeft.Text = "当其它群员复读超过";
            // 
            // labelRepeatThresholdRight
            // 
            this.labelRepeatThresholdRight.AutoSize = true;
            this.labelRepeatThresholdRight.Location = new System.Drawing.Point(182, 9);
            this.labelRepeatThresholdRight.Name = "labelRepeatThresholdRight";
            this.labelRepeatThresholdRight.Size = new System.Drawing.Size(77, 12);
            this.labelRepeatThresholdRight.TabIndex = 1;
            this.labelRepeatThresholdRight.Text = "条时触发复读";
            // 
            // checkBoxIgnoreAnonymous
            // 
            this.checkBoxIgnoreAnonymous.AutoSize = true;
            this.checkBoxIgnoreAnonymous.Location = new System.Drawing.Point(138, 162);
            this.checkBoxIgnoreAnonymous.Name = "checkBoxIgnoreAnonymous";
            this.checkBoxIgnoreAnonymous.Size = new System.Drawing.Size(132, 16);
            this.checkBoxIgnoreAnonymous.TabIndex = 5;
            this.checkBoxIgnoreAnonymous.Text = "忽略匿名成员的复读";
            this.checkBoxIgnoreAnonymous.UseVisualStyleBackColor = true;
            // 
            // listBoxBlackWords
            // 
            this.listBoxBlackWords.FormattingEnabled = true;
            this.listBoxBlackWords.ItemHeight = 12;
            this.listBoxBlackWords.Location = new System.Drawing.Point(12, 56);
            this.listBoxBlackWords.Name = "listBoxBlackWords";
            this.listBoxBlackWords.Size = new System.Drawing.Size(120, 184);
            this.listBoxBlackWords.TabIndex = 1;
            // 
            // labelBlackWords
            // 
            this.labelBlackWords.AutoSize = true;
            this.labelBlackWords.Location = new System.Drawing.Point(10, 41);
            this.labelBlackWords.Name = "labelBlackWords";
            this.labelBlackWords.Size = new System.Drawing.Size(221, 12);
            this.labelBlackWords.TabIndex = 5;
            this.labelBlackWords.Text = "如果复读内容中包含以下词汇则不复读：";
            // 
            // buttonBlockWordsRemoveSelect
            // 
            this.buttonBlockWordsRemoveSelect.Location = new System.Drawing.Point(138, 56);
            this.buttonBlockWordsRemoveSelect.Name = "buttonBlockWordsRemoveSelect";
            this.buttonBlockWordsRemoveSelect.Size = new System.Drawing.Size(121, 23);
            this.buttonBlockWordsRemoveSelect.TabIndex = 2;
            this.buttonBlockWordsRemoveSelect.Text = "移除左侧选中";
            this.buttonBlockWordsRemoveSelect.UseVisualStyleBackColor = true;
            this.buttonBlockWordsRemoveSelect.Click += new System.EventHandler(this.buttonBlockWordsRemoveSelect_Click);
            // 
            // textBoxBlockWordsAdd
            // 
            this.textBoxBlockWordsAdd.Location = new System.Drawing.Point(138, 94);
            this.textBoxBlockWordsAdd.Name = "textBoxBlockWordsAdd";
            this.textBoxBlockWordsAdd.Size = new System.Drawing.Size(121, 21);
            this.textBoxBlockWordsAdd.TabIndex = 3;
            // 
            // buttonBlockWordsAdd
            // 
            this.buttonBlockWordsAdd.Location = new System.Drawing.Point(138, 121);
            this.buttonBlockWordsAdd.Name = "buttonBlockWordsAdd";
            this.buttonBlockWordsAdd.Size = new System.Drawing.Size(121, 23);
            this.buttonBlockWordsAdd.TabIndex = 4;
            this.buttonBlockWordsAdd.Text = "向左侧增加";
            this.buttonBlockWordsAdd.UseVisualStyleBackColor = true;
            this.buttonBlockWordsAdd.Click += new System.EventHandler(this.buttonBlockWordsAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(138, 184);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 53);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownRepeatThreshold
            // 
            this.numericUpDownRepeatThreshold.Location = new System.Drawing.Point(131, 7);
            this.numericUpDownRepeatThreshold.Maximum = new decimal(new int[] {
            233,
            0,
            0,
            0});
            this.numericUpDownRepeatThreshold.Name = "numericUpDownRepeatThreshold";
            this.numericUpDownRepeatThreshold.Size = new System.Drawing.Size(45, 21);
            this.numericUpDownRepeatThreshold.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 249);
            this.Controls.Add(this.numericUpDownRepeatThreshold);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBlockWordsAdd);
            this.Controls.Add(this.textBoxBlockWordsAdd);
            this.Controls.Add(this.buttonBlockWordsRemoveSelect);
            this.Controls.Add(this.labelBlackWords);
            this.Controls.Add(this.listBoxBlackWords);
            this.Controls.Add(this.checkBoxIgnoreAnonymous);
            this.Controls.Add(this.labelRepeatThresholdRight);
            this.Controls.Add(this.labelRepeatThresholdLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Cool复读机选项";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRepeatThresholdLeft;
        private System.Windows.Forms.Label labelRepeatThresholdRight;
        private System.Windows.Forms.CheckBox checkBoxIgnoreAnonymous;
        private System.Windows.Forms.ListBox listBoxBlackWords;
        private System.Windows.Forms.Label labelBlackWords;
        private System.Windows.Forms.Button buttonBlockWordsRemoveSelect;
        private System.Windows.Forms.TextBox textBoxBlockWordsAdd;
        private System.Windows.Forms.Button buttonBlockWordsAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeatThreshold;
    }
}