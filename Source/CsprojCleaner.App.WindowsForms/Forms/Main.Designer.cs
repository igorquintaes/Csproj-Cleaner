using CsprojCleaner.App.WindowsForms.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CsprojCleaner.App.WindowsForms.Forms
{
    partial class Main
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.ProjDir = new System.Windows.Forms.TextBox();
            this.LabelLogFolder = new System.Windows.Forms.Label();
            this.StepsLabelTitle = new System.Windows.Forms.Label();
            this.StepsLabelDescription = new System.Windows.Forms.Label();
            this.CleanButton = new System.Windows.Forms.Button();
            this.LogDir = new System.Windows.Forms.TextBox();
            this.LabelProjectFolder = new System.Windows.Forms.Label();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.LoadCsprojButton = new System.Windows.Forms.Button();
            this.LoadLogButton = new System.Windows.Forms.Button();
            this.FolderCsproj = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderLog = new System.Windows.Forms.FolderBrowserDialog();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.menuStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjDir
            // 
            this.ProjDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProjDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProjDir.Location = new System.Drawing.Point(45, 116);
            this.ProjDir.Name = "ProjDir";
            this.ProjDir.Size = new System.Drawing.Size(340, 20);
            this.ProjDir.TabIndex = 1;
            // 
            // LabelLogFolder
            // 
            this.LabelLogFolder.AutoSize = true;
            this.LabelLogFolder.Location = new System.Drawing.Point(9, 150);
            this.LabelLogFolder.Name = "LabelLogFolder";
            this.LabelLogFolder.Size = new System.Drawing.Size(0, 13);
            this.LabelLogFolder.TabIndex = 1;
            // 
            // StepsLabelTitle
            // 
            this.StepsLabelTitle.AutoSize = true;
            this.StepsLabelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.StepsLabelTitle.Location = new System.Drawing.Point(9, 37);
            this.StepsLabelTitle.Name = "StepsLabelTitle";
            this.StepsLabelTitle.Size = new System.Drawing.Size(0, 13);
            this.StepsLabelTitle.TabIndex = 2;
            // 
            // StepsLabelDescription
            // 
            this.StepsLabelDescription.AutoSize = true;
            this.StepsLabelDescription.Location = new System.Drawing.Point(9, 59);
            this.StepsLabelDescription.MaximumSize = new System.Drawing.Size(510, 0);
            this.StepsLabelDescription.Name = "StepsLabelDescription";
            this.StepsLabelDescription.Size = new System.Drawing.Size(0, 13);
            this.StepsLabelDescription.TabIndex = 2;
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(12, 206);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(373, 23);
            this.CleanButton.TabIndex = 4;
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.RunProjectCleaner);
            // 
            // LogDir
            // 
            this.LogDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LogDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LogDir.Location = new System.Drawing.Point(45, 166);
            this.LogDir.Name = "LogDir";
            this.LogDir.Size = new System.Drawing.Size(340, 20);
            this.LogDir.TabIndex = 3;
            // 
            // LabelProjectFolder
            // 
            this.LabelProjectFolder.AutoSize = true;
            this.LabelProjectFolder.Location = new System.Drawing.Point(9, 100);
            this.LabelProjectFolder.Name = "LabelProjectFolder";
            this.LabelProjectFolder.Size = new System.Drawing.Size(142, 13);
            this.LabelProjectFolder.TabIndex = 1;
            // 
            // LogoImage
            // 
            this.LogoImage.Image = global::CsprojCleaner.App.WindowsForms.Properties.Resources.Logo;
            this.LogoImage.Location = new System.Drawing.Point(400, 75);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(120, 111);
            this.LogoImage.TabIndex = 4;
            this.LogoImage.TabStop = false;
            // 
            // LoadCsprojButton
            // 
            this.LoadCsprojButton.Location = new System.Drawing.Point(12, 115);
            this.LoadCsprojButton.Name = "LoadCsprojButton";
            this.LoadCsprojButton.Size = new System.Drawing.Size(27, 21);
            this.LoadCsprojButton.TabIndex = 0;
            this.LoadCsprojButton.Text = "...";
            this.LoadCsprojButton.UseVisualStyleBackColor = true;
            this.LoadCsprojButton.Click += new System.EventHandler(this.LoadCsprojFolder);
            // 
            // LoadLogButton
            // 
            this.LoadLogButton.Location = new System.Drawing.Point(12, 165);
            this.LoadLogButton.Name = "LoadLogButton";
            this.LoadLogButton.Size = new System.Drawing.Size(27, 21);
            this.LoadLogButton.TabIndex = 2;
            this.LoadLogButton.Text = "...";
            this.LoadLogButton.UseVisualStyleBackColor = true;
            this.LoadLogButton.Click += new System.EventHandler(this.LoadLogFolder);
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(400, 207);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(120, 21);
            this.LoadingBar.TabIndex = 6;
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripOptions.Location = new System.Drawing.Point(0, 0);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Size = new System.Drawing.Size(534, 24);
            this.menuStripOptions.TabIndex = 7;
            this.menuStripOptions.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.CleanButton.Text = Language.CleanProjects;
            this.LabelLogFolder.Text = Language.SaveLogDir;
            this.StepsLabelTitle.Text = Language.Steps;
            this.StepsLabelDescription.Text = Language.StepsDescription;
            this.LabelProjectFolder.Text = Language.TargetFolder;
            this.toolsToolStripMenuItem.Text = Language.Tools;
            this.helpToolStripMenuItem.Text = Language.Help;
            this.aboutToolStripMenuItem.Text = Language.About;
            this.settingsToolStripMenuItem.Text = Language.Settings;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 236);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.LoadLogButton);
            this.Controls.Add(this.LoadCsprojButton);
            this.Controls.Add(this.LogoImage);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.StepsLabelDescription);
            this.Controls.Add(this.StepsLabelTitle);
            this.Controls.Add(this.LabelProjectFolder);
            this.Controls.Add(this.LabelLogFolder);
            this.Controls.Add(this.LogDir);
            this.Controls.Add(this.ProjDir);
            this.Controls.Add(this.menuStripOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Cleaner";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjDir;
        private System.Windows.Forms.Label LabelLogFolder;
        private System.Windows.Forms.Label StepsLabelTitle;
        private System.Windows.Forms.Label StepsLabelDescription;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.TextBox LogDir;
        private System.Windows.Forms.Label LabelProjectFolder;
        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.Button LoadCsprojButton;
        private System.Windows.Forms.Button LoadLogButton;
        private System.Windows.Forms.FolderBrowserDialog FolderCsproj;
        private System.Windows.Forms.FolderBrowserDialog FolderLog;

        readonly object stateLock = new object();
        int currentCount;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        AutoCompleteStringCollection autoCompleteProjectPaths = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoCompleteLogPaths = new AutoCompleteStringCollection();
    }
}

