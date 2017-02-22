using CsprojCleaner.App.WindowsForms.Resources;
using System.Collections.Generic;

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
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.language = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.extensions = new System.Windows.Forms.Label();
            this.saveConfiguration = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.NonExistentFilesLabel = new System.Windows.Forms.Label();
            this.nonExistentFilesBox = new System.Windows.Forms.ComboBox();
            this.nonExistentFilesWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // languageBox
            // 
            this.languageBox.DisplayMember = "Text";
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Location = new System.Drawing.Point(12, 29);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(121, 21);
            this.languageBox.TabIndex = 0;
            this.languageBox.ValueMember = "Value";
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
            this.checkedListBox1.Location = new System.Drawing.Point(152, 29);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 2;
            // 
            // extensions
            // 
            this.extensions.AutoSize = true;
            this.extensions.Location = new System.Drawing.Point(149, 13);
            this.extensions.Name = "extensions";
            this.extensions.Size = new System.Drawing.Size(99, 13);
            this.extensions.TabIndex = 3;
            this.extensions.Text = "Extensions to clear:";
            // 
            // saveConfiguration
            // 
            this.saveConfiguration.Location = new System.Drawing.Point(197, 150);
            this.saveConfiguration.Name = "saveConfiguration";
            this.saveConfiguration.Size = new System.Drawing.Size(75, 23);
            this.saveConfiguration.TabIndex = 4;
            this.saveConfiguration.Text = global::CsprojCleaner.App.WindowsForms.Resources.Language.Save;
            this.saveConfiguration.UseVisualStyleBackColor = true;
            this.saveConfiguration.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(114, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = global::CsprojCleaner.App.WindowsForms.Resources.Language.Cancel;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // NonExistentFilesLabel
            // 
            this.NonExistentFilesLabel.AutoSize = true;
            this.NonExistentFilesLabel.Location = new System.Drawing.Point(9, 70);
            this.NonExistentFilesLabel.Name = "NonExistentFilesLabel";
            this.NonExistentFilesLabel.Size = new System.Drawing.Size(122, 13);
            this.NonExistentFilesLabel.TabIndex = 6;
            this.NonExistentFilesLabel.Text = "Non existent files action:";
            // 
            // nonExistentFilesBox
            // 
            this.nonExistentFilesBox.DisplayMember = "Text";
            this.nonExistentFilesBox.FormattingEnabled = true;
            this.nonExistentFilesBox.Location = new System.Drawing.Point(12, 86);
            this.nonExistentFilesBox.Name = "nonExistentFilesBox";
            this.nonExistentFilesBox.Size = new System.Drawing.Size(121, 21);
            this.nonExistentFilesBox.TabIndex = 0;
            this.nonExistentFilesBox.ValueMember = "Value";
            this.nonExistentFilesBox.SelectedIndexChanged += new System.EventHandler(this.nonExistentFilesBox_Changed);
            // 
            // nonExistentFilesWarning
            // 
            this.nonExistentFilesWarning.AutoSize = true;
            this.nonExistentFilesWarning.ForeColor = System.Drawing.Color.Red;
            this.nonExistentFilesWarning.Location = new System.Drawing.Point(9, 110);
            this.nonExistentFilesWarning.MaximumSize = new System.Drawing.Size(150, 0);
            this.nonExistentFilesWarning.Name = "nonExistentFilesWarning";
            this.nonExistentFilesWarning.Size = new System.Drawing.Size(130, 26);
            this.nonExistentFilesWarning.TabIndex = 7;
            this.nonExistentFilesWarning.Text = "Warning! This options will make program runs slow!";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.nonExistentFilesWarning);
            this.Controls.Add(this.NonExistentFilesLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveConfiguration);
            this.Controls.Add(this.extensions);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.language);
            this.Controls.Add(this.nonExistentFilesBox);
            this.Controls.Add(this.languageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Configuration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label extensions;
        private System.Windows.Forms.Button saveConfiguration;
        private System.Windows.Forms.Button cancelButton;

        private List<string> extensionList;
        private System.Windows.Forms.Label NonExistentFilesLabel;
        private System.Windows.Forms.ComboBox nonExistentFilesBox;
        private System.Windows.Forms.Label nonExistentFilesWarning;
    }
}