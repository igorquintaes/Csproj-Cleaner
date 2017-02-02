using System;
using System.Drawing;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjDir
            // 
            this.ProjDir.Location = new System.Drawing.Point(45, 116);
            this.ProjDir.Name = "ProjDir";
            this.ProjDir.Size = new System.Drawing.Size(340, 20);
            this.ProjDir.TabIndex = 1;
            this.ProjDir.TextChanged += new System.EventHandler(this.ProjDir_TextChanged);
            // 
            // LabelLogFolder
            // 
            this.LabelLogFolder.AutoSize = true;
            this.LabelLogFolder.Location = new System.Drawing.Point(9, 150);
            this.LabelLogFolder.Name = "LabelLogFolder";
            this.LabelLogFolder.Size = new System.Drawing.Size(223, 13);
            this.LabelLogFolder.TabIndex = 1;
            this.LabelLogFolder.Text = "Diretório da pasta de armazenamento de logs:";
            this.LabelLogFolder.Click += new System.EventHandler(this.LabelLogFolder_Click);
            // 
            // StepsLabelTitle
            // 
            this.StepsLabelTitle.AutoSize = true;
            this.StepsLabelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.StepsLabelTitle.Location = new System.Drawing.Point(9, 37);
            this.StepsLabelTitle.Name = "StepsLabelTitle";
            this.StepsLabelTitle.Size = new System.Drawing.Size(80, 13);
            this.StepsLabelTitle.TabIndex = 2;
            this.StepsLabelTitle.Text = "Procedimentos:";
            this.StepsLabelTitle.Click += new System.EventHandler(this.StepsLabelTitle_Click);
            // 
            // StepsLabelDescription
            // 
            this.StepsLabelDescription.AutoSize = true;
            this.StepsLabelDescription.Location = new System.Drawing.Point(9, 59);
            this.StepsLabelDescription.MaximumSize = new System.Drawing.Size(510, 0);
            this.StepsLabelDescription.Name = "StepsLabelDescription";
            this.StepsLabelDescription.Size = new System.Drawing.Size(509, 26);
            this.StepsLabelDescription.TabIndex = 2;
            this.StepsLabelDescription.Text = "Insira um diretório válido para que todos os arquivos csproj dentro dele ou de su" +
    "as subpastas sejam limpos. A limpeza iniciará assim que o botão \"Executar Limpez" +
    "a\" for clicado.";
            this.StepsLabelDescription.Click += new System.EventHandler(this.StepsLabelDescription_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(12, 206);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(373, 23);
            this.CleanButton.TabIndex = 4;
            this.CleanButton.Text = "Executar Limpeza";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.RunProjectCleaner);
            // 
            // LogDir
            // 
            this.LogDir.Location = new System.Drawing.Point(45, 166);
            this.LogDir.Name = "LogDir";
            this.LogDir.Size = new System.Drawing.Size(340, 20);
            this.LogDir.TabIndex = 3;
            this.LogDir.TextChanged += new System.EventHandler(this.LogDir_TextChanged);
            // 
            // LabelProjectFolder
            // 
            this.LabelProjectFolder.AutoSize = true;
            this.LabelProjectFolder.Location = new System.Drawing.Point(9, 100);
            this.LabelProjectFolder.Name = "LabelProjectFolder";
            this.LabelProjectFolder.Size = new System.Drawing.Size(142, 13);
            this.LabelProjectFolder.TabIndex = 1;
            this.LabelProjectFolder.Text = "Diretório da pasta de .csproj:";
            this.LabelProjectFolder.Click += new System.EventHandler(this.LabelProjectFolder_Click);
            // 
            // LogoImage
            // 
            this.LogoImage.Image = global::CsprojCleaner.App.WindowsForms.Properties.Resources.eguru_logo;
            this.LogoImage.Location = new System.Drawing.Point(400, 75);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(120, 111);
            this.LogoImage.TabIndex = 4;
            this.LogoImage.TabStop = false;
            this.LogoImage.Click += new System.EventHandler(this.LogoImage_Click);
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
            this.LoadingBar.Click += new System.EventHandler(this.LoadingBar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcoesToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opcoesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opcoesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opcoesToolStripMenuItem.Text = "Opções";
            // 
            // Main
            // 
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
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Csproj Cleaner";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

