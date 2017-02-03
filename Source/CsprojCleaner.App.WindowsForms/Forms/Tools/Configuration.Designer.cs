namespace CsprojCleaner.App.WindowsForms.Forms.Tools
{
    partial class Configuration
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.language = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.extencions = new System.Windows.Forms.Label();
            this.saveConfiguration = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Location = new System.Drawing.Point(9, 13);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(58, 13);
            this.language.TabIndex = 1;
            this.language.Text = "Language:";
            this.language.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 81);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 2;
            // 
            // extencions
            // 
            this.extencions.AutoSize = true;
            this.extencions.Location = new System.Drawing.Point(9, 65);
            this.extencions.Name = "extencions";
            this.extencions.Size = new System.Drawing.Size(102, 13);
            this.extencions.TabIndex = 3;
            this.extencions.Text = "Extensions to clean:";
            // 
            // saveConfiguration
            // 
            this.saveConfiguration.Location = new System.Drawing.Point(197, 226);
            this.saveConfiguration.Name = "saveConfiguration";
            this.saveConfiguration.Size = new System.Drawing.Size(75, 23);
            this.saveConfiguration.TabIndex = 4;
            this.saveConfiguration.Text = "Save";
            this.saveConfiguration.UseVisualStyleBackColor = true;
            this.saveConfiguration.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(116, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveConfiguration);
            this.Controls.Add(this.extencions);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.language);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label extencions;
        private System.Windows.Forms.Button saveConfiguration;
        private System.Windows.Forms.Button cancelButton;
    }
}