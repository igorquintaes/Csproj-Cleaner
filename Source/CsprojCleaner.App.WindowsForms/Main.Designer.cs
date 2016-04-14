using System;
using System.Drawing;

namespace CsprojCleaner.App.WindowsForms
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjDir
            // 
            this.ProjDir.Location = new System.Drawing.Point(45, 88);
            this.ProjDir.Name = "ProjDir";
            this.ProjDir.Size = new System.Drawing.Size(340, 20);
            this.ProjDir.TabIndex = 1;
            // 
            // LabelLogFolder
            // 
            this.LabelLogFolder.AutoSize = true;
            this.LabelLogFolder.Location = new System.Drawing.Point(9, 122);
            this.LabelLogFolder.Name = "LabelLogFolder";
            this.LabelLogFolder.Size = new System.Drawing.Size(223, 13);
            this.LabelLogFolder.TabIndex = 1;
            this.LabelLogFolder.Text = "Diretório da pasta de armazenamento de logs:";
            // 
            // StepsLabelTitle
            // 
            this.StepsLabelTitle.AutoSize = true;
            this.StepsLabelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.StepsLabelTitle.Location = new System.Drawing.Point(9, 9);
            this.StepsLabelTitle.Name = "StepsLabelTitle";
            this.StepsLabelTitle.Size = new System.Drawing.Size(80, 13);
            this.StepsLabelTitle.TabIndex = 2;
            this.StepsLabelTitle.Text = "Procedimentos:";
            // 
            // StepsLabelDescription
            // 
            this.StepsLabelDescription.AutoSize = true;
            this.StepsLabelDescription.Location = new System.Drawing.Point(9, 31);
            this.StepsLabelDescription.MaximumSize = new System.Drawing.Size(510, 0);
            this.StepsLabelDescription.Name = "StepsLabelDescription";
            this.StepsLabelDescription.Size = new System.Drawing.Size(509, 26);
            this.StepsLabelDescription.TabIndex = 2;
            this.StepsLabelDescription.Text = "Insira um diretório válido para que todos os arquivos csproj dentro dele ou de su" +
    "as subpastas sejam limpos. A limpeza iniciará assim que o botão \"Executar Limpez" +
    "a\" for clicado.";
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(12, 178);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(373, 23);
            this.CleanButton.TabIndex = 4;
            this.CleanButton.Text = "Executar Limpeza";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.Button1Click);
            // 
            // LogDir
            // 
            this.LogDir.Location = new System.Drawing.Point(45, 138);
            this.LogDir.Name = "LogDir";
            this.LogDir.Size = new System.Drawing.Size(340, 20);
            this.LogDir.TabIndex = 3;
            // 
            // LabelProjectFolder
            // 
            this.LabelProjectFolder.AutoSize = true;
            this.LabelProjectFolder.Location = new System.Drawing.Point(9, 72);
            this.LabelProjectFolder.Name = "LabelProjectFolder";
            this.LabelProjectFolder.Size = new System.Drawing.Size(142, 13);
            this.LabelProjectFolder.TabIndex = 1;
            this.LabelProjectFolder.Text = "Diretório da pasta de .csproj:";
            // 
            // LogoImage
            // 
            this.LogoImage.Image = global::CsprojCleaner.App.WindowsForms.Properties.Resources.eguru_logo;
            this.LogoImage.Location = new System.Drawing.Point(400, 47);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(120, 111);
            this.LogoImage.TabIndex = 4;
            this.LogoImage.TabStop = false;
            // 
            // LoadCsprojButton
            // 
            this.LoadCsprojButton.Location = new System.Drawing.Point(12, 87);
            this.LoadCsprojButton.Name = "LoadCsprojButton";
            this.LoadCsprojButton.Size = new System.Drawing.Size(27, 21);
            this.LoadCsprojButton.TabIndex = 0;
            this.LoadCsprojButton.Text = "...";
            this.LoadCsprojButton.UseVisualStyleBackColor = true;
            this.LoadCsprojButton.Click += new System.EventHandler(this.LoadCsprojFolderButtonClick);
            // 
            // LoadLogButton
            // 
            this.LoadLogButton.Location = new System.Drawing.Point(12, 137);
            this.LoadLogButton.Name = "LoadLogButton";
            this.LoadLogButton.Size = new System.Drawing.Size(27, 21);
            this.LoadLogButton.TabIndex = 2;
            this.LoadLogButton.Text = "...";
            this.LoadLogButton.UseVisualStyleBackColor = true;
            this.LoadLogButton.Click += new System.EventHandler(this.LoadLogFolderButtonClick);
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(400, 179);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(120, 21);
            this.LoadingBar.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 213);
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
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csproj Cleaner";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
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
    }
}

