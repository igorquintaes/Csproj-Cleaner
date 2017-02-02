namespace CsprojCleaner.App.WindowsForms.Forms.Help
{
    partial class About
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
            System.Windows.Forms.Label authorName;
            this.contribuitors = new System.Windows.Forms.Label();
            this.sourceCodeIn = new System.Windows.Forms.Label();
            this.linkSource = new System.Windows.Forms.LinkLabel();
            this.closeBtn = new System.Windows.Forms.Button();
            authorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contribuitors
            // 
            this.contribuitors.AutoSize = true;
            this.contribuitors.Location = new System.Drawing.Point(12, 75);
            this.contribuitors.Name = "contribuitors";
            this.contribuitors.Size = new System.Drawing.Size(68, 13);
            this.contribuitors.TabIndex = 0;
            this.contribuitors.Text = "Contribuitors:";
            this.contribuitors.Click += new System.EventHandler(this.developedBy_Click);
            // 
            // authorName
            // 
            authorName.AutoSize = true;
            authorName.Location = new System.Drawing.Point(12, 88);
            authorName.Name = "authorName";
            authorName.Size = new System.Drawing.Size(179, 13);
            authorName.TabIndex = 1;
            authorName.Text = "igorquintaes, VitorLuizC, dhustkoder.";
            authorName.Click += new System.EventHandler(this.authorName_Click);
            // 
            // sourceCodeIn
            // 
            this.sourceCodeIn.AutoSize = true;
            this.sourceCodeIn.Location = new System.Drawing.Point(12, 9);
            this.sourceCodeIn.MaximumSize = new System.Drawing.Size(250, 0);
            this.sourceCodeIn.Name = "sourceCodeIn";
            this.sourceCodeIn.Size = new System.Drawing.Size(249, 26);
            this.sourceCodeIn.TabIndex = 2;
            this.sourceCodeIn.Text = "It is an Open Source project. All the application and code can be find in:";
            this.sourceCodeIn.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkSource
            // 
            this.linkSource.AutoSize = true;
            this.linkSource.Location = new System.Drawing.Point(12, 35);
            this.linkSource.Name = "linkSource";
            this.linkSource.Size = new System.Drawing.Size(230, 13);
            this.linkSource.TabIndex = 3;
            this.linkSource.TabStop = true;
            this.linkSource.Text = "https://github.com/igorquintaes/Csproj-Cleaner";
            this.linkSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSource_LinkClicked);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(197, 118);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.linkSource);
            this.Controls.Add(this.sourceCodeIn);
            this.Controls.Add(authorName);
            this.Controls.Add(this.contribuitors);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contribuitors;
        private System.Windows.Forms.Label sourceCodeIn;
        private System.Windows.Forms.LinkLabel linkSource;
        private System.Windows.Forms.Button closeBtn;
    }
}