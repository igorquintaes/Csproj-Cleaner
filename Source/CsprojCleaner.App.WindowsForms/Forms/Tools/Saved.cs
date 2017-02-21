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

namespace CsprojCleaner.App.WindowsForms.Forms.Tools
{
    public partial class Saved : Form
    {
        public Saved()
        {
            InitializeComponent();
            LoadTexts();
        }

        private void LoadTexts()
        {
            this.closeBtn.Text = Language.Close;
            this.Text = Language.Saved;
            this.savedSuccefull.Text = Language.SuccefullSavedConfig;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
