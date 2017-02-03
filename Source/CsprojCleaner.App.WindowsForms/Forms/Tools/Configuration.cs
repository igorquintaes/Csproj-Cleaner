using CsprojCleaner.App.WindowsForms.ProjectSettings;
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
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            ManageCheckboxList();
            ManageLanguageList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            UserSettings.RememberAllowedExtensions(checkedListBox1.CheckedItems.Cast<string>().ToList());

            var savedForm = new Saved();
            savedForm.Show();

            this.Close();
        }

        private void ManageCheckboxList()
        {
            extensionList = UserSettings.RecoverAllowedExtensions().ToList();
            this.checkedListBox1.Items.AddRange(Domain.Constants.Extensions.SupportedExtensions.ToArray());

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (extensionList.Contains(checkedListBox1.Items[i].ToString()))
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void ManageLanguageList()
        {
           // todo
        }
    }
}
