namespace cx.rain.cq.coolrepeater.UI.Window
{
    partial class GroupSpecialSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupSpecialSettings));
            this.listBoxEnableGroup = new System.Windows.Forms.ListBox();
            this.labelEnableRepeat = new System.Windows.Forms.Label();
            this.labelDisableGroup = new System.Windows.Forms.Label();
            this.listBoxDisableGroup = new System.Windows.Forms.ListBox();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEnableGroup
            // 
            this.listBoxEnableGroup.FormattingEnabled = true;
            this.listBoxEnableGroup.ItemHeight = 12;
            this.listBoxEnableGroup.Location = new System.Drawing.Point(12, 24);
            this.listBoxEnableGroup.Name = "listBoxEnableGroup";
            this.listBoxEnableGroup.Size = new System.Drawing.Size(120, 196);
            this.listBoxEnableGroup.TabIndex = 0;
            // 
            // labelEnableRepeat
            // 
            this.labelEnableRepeat.AutoSize = true;
            this.labelEnableRepeat.Location = new System.Drawing.Point(10, 8);
            this.labelEnableRepeat.Name = "labelEnableRepeat";
            this.labelEnableRepeat.Size = new System.Drawing.Size(89, 12);
            this.labelEnableRepeat.TabIndex = 1;
            this.labelEnableRepeat.Text = "启用复读的群：";
            // 
            // labelDisableGroup
            // 
            this.labelDisableGroup.AutoSize = true;
            this.labelDisableGroup.Location = new System.Drawing.Point(217, 8);
            this.labelDisableGroup.Name = "labelDisableGroup";
            this.labelDisableGroup.Size = new System.Drawing.Size(89, 12);
            this.labelDisableGroup.TabIndex = 3;
            this.labelDisableGroup.Text = "禁用复读的群：";
            // 
            // listBoxDisableGroup
            // 
            this.listBoxDisableGroup.FormattingEnabled = true;
            this.listBoxDisableGroup.ItemHeight = 12;
            this.listBoxDisableGroup.Location = new System.Drawing.Point(219, 24);
            this.listBoxDisableGroup.Name = "listBoxDisableGroup";
            this.listBoxDisableGroup.Size = new System.Drawing.Size(120, 196);
            this.listBoxDisableGroup.TabIndex = 2;
            // 
            // buttonEnable
            // 
            this.buttonEnable.Location = new System.Drawing.Point(138, 57);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(75, 23);
            this.buttonEnable.TabIndex = 4;
            this.buttonEnable.Text = "启用 <-";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Location = new System.Drawing.Point(138, 86);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(75, 23);
            this.buttonDisable.TabIndex = 5;
            this.buttonDisable.Text = "禁用 ->";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(138, 196);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // GroupSpecialSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 231);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.labelDisableGroup);
            this.Controls.Add(this.listBoxDisableGroup);
            this.Controls.Add(this.labelEnableRepeat);
            this.Controls.Add(this.listBoxEnableGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupSpecialSettings";
            this.Text = "分群复读设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEnableGroup;
        private System.Windows.Forms.Label labelEnableRepeat;
        private System.Windows.Forms.Label labelDisableGroup;
        private System.Windows.Forms.ListBox listBoxDisableGroup;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.Button buttonSave;
    }
}