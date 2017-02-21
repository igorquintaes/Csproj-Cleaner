using CsprojCleaner.App.WindowsForms.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsprojCleaner.App.WindowsForms.Forms.Help
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            LoadTexts();
        }

        private void LoadTexts()
        {
            this.sourceCodeIn.Text = Language.AboutSourceCodeIn;
            this.closeBtn.Text = Language.Close;
            this.Name = Language.About;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void developedBy_Click(object sender, EventArgs e)
        {

        }

        private void authorName_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
