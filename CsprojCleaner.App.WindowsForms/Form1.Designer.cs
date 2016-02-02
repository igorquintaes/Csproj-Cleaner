namespace CsprojCleaner.App.WindowsForms
{
    partial class Form1
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
            this.projDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CleanButton = new System.Windows.Forms.Button();
            this.logDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadCsprojButton = new System.Windows.Forms.Button();
            this.LoadLogButton = new System.Windows.Forms.Button();
            this.FolderCsproj = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderLog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // projDir
            // 
            this.projDir.Location = new System.Drawing.Point(45, 88);
            this.projDir.Name = "projDir";
            this.projDir.Size = new System.Drawing.Size(340, 20);
            this.projDir.TabIndex = 0;
            this.projDir.TextChanged += new System.EventHandler(this.ProjDirTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diretório da pasta de armazenamento de logs:";
            this.label1.Click += new System.EventHandler(this.Label1Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Procedimentos:";
            this.label2.Click += new System.EventHandler(this.Label2Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insira um diretório válido para que todos os arquivos csproj dentro dele ou de su" +
    "as subpastas sejam limpos.";
            this.label3.Click += new System.EventHandler(this.Label2Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "A limpeza iniciará assim que o botão \"Executar Limpeza\" for clicado.";
            this.label4.Click += new System.EventHandler(this.Label2Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(12, 178);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(373, 23);
            this.CleanButton.TabIndex = 3;
            this.CleanButton.Text = "Executar Limpeza";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.Button1Click);
            // 
            // logDir
            // 
            this.logDir.Location = new System.Drawing.Point(45, 138);
            this.logDir.Name = "logDir";
            this.logDir.Size = new System.Drawing.Size(340, 20);
            this.logDir.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Diretório da pasta de .csproj:";
            this.label5.Click += new System.EventHandler(this.Label1Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CsprojCleaner.App.WindowsForms.Properties.Resources.eguru_logo;
            this.pictureBox1.Location = new System.Drawing.Point(398, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 111);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoadCsprojButton
            // 
            this.LoadCsprojButton.Location = new System.Drawing.Point(12, 87);
            this.LoadCsprojButton.Name = "LoadCsprojButton";
            this.LoadCsprojButton.Size = new System.Drawing.Size(27, 21);
            this.LoadCsprojButton.TabIndex = 5;
            this.LoadCsprojButton.Text = "...";
            this.LoadCsprojButton.UseVisualStyleBackColor = true;
            this.LoadCsprojButton.Click += new System.EventHandler(this.LoadCsprojFolderButtonClick);
            // 
            // LoadLogButton
            // 
            this.LoadLogButton.Location = new System.Drawing.Point(12, 137);
            this.LoadLogButton.Name = "LoadLogButton";
            this.LoadLogButton.Size = new System.Drawing.Size(27, 21);
            this.LoadLogButton.TabIndex = 5;
            this.LoadLogButton.Text = "...";
            this.LoadLogButton.UseVisualStyleBackColor = true;
            this.LoadLogButton.Click += new System.EventHandler(this.LoadLogFolderButtonClick);
            // 
            // FolderCsproj
            // 
            this.FolderCsproj.HelpRequest += new System.EventHandler(this.FolderBrowserDialog1HelpRequest);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(398, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 213);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LoadLogButton);
            this.Controls.Add(this.LoadCsprojButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logDir);
            this.Controls.Add(this.projDir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csproj Cleaner";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.TextBox logDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadCsprojButton;
        private System.Windows.Forms.Button LoadLogButton;
        private System.Windows.Forms.FolderBrowserDialog FolderCsproj;
        private System.Windows.Forms.FolderBrowserDialog FolderLog;

        readonly object stateLock = new object();
        int currentCount;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

