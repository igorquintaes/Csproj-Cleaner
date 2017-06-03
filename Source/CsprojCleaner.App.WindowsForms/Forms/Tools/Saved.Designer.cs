using CsprojCleaner.App.WindowsForms.Resources;

namespace CsprojCleaner.App.WindowsForms.Forms.Tools
{
    partial class Saved
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.savedSuccefull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(57, 91);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // savedSuccefull
            // 
            this.savedSuccefull.AutoSize = true;
            this.savedSuccefull.Location = new System.Drawing.Point(12, 9);
            this.savedSuccefull.MaximumSize = new System.Drawing.Size(175, 0);
            this.savedSuccefull.Name = "savedSuccefull";
            this.savedSuccefull.Size = new System.Drawing.Size(0, 13);
            this.savedSuccefull.TabIndex = 1;
            // 
            // Saved
            // 
            this.closeBtn.Text = Language.Close;
            this.Text = Language.Saved;
            this.savedSuccefull.Text = Language.SuccefullSavedConfig;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 126);
            this.Controls.Add(this.savedSuccefull);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saved";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label savedSuccefull;
    }
}