using CsprojCleaner.App.WindowsForms.ProjectSettings;
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
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            LoadTexts();
            ManageCheckboxList();
            ManageLanguageList();
        }

        private void LoadTexts()
        {
            this.language.Text = Language.LanguageStr;
            this.extensions.Text = Language.ExtensionsToClear;
            this.saveConfiguration.Text = Language.Save;
            this.cancelButton.Text = Language.Cancel;
            this.Text = Language.Settings;
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

            var language = (comboBox1.SelectedItem as dynamic).Value.ToString();
            UserSettings.RememberLanguage(language);
            LanguageSettings.ChangeLanguage(language);

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

            this.comboBox1.DataSource = LanguageSettings.Languages;
            this.comboBox1.SelectedIndex = 0;
            
            for (var i = 0; i < LanguageSettings.Languages.Count(); i++)
            {
                if (LanguageSettings.CurrentCulture.Name == (LanguageSettings.Languages[i] as dynamic).Value.ToString())
                {
                    this.comboBox1.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
