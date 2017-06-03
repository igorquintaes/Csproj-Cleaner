using CsprojCleaner.App.WindowsForms.Contracts;
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
        private readonly IFormOpener _formOpener;

        public Configuration(IFormOpener formOpener)
        {
            _formOpener = formOpener;

            InitializeComponent();
            LoadTexts();
            ManageCheckboxList();
            ManageLanguageList();
            ManageNonExistentFilesList();
            ManageEvents();
        }

        private void LoadTexts()
        {
            this.language.Text = Language.LanguageStr;
            this.extensions.Text = Language.ExtensionsToClear;
            this.saveConfiguration.Text = Language.Save;
            this.cancelButton.Text = Language.Cancel;
            this.Text = Language.Settings;
            this.nonExistentFilesWarning.Text = Language.WarningNonExistentFiles;
            this.NonExistentFilesLabel.Text = Language.NonExistentFiles;
        }

        private void ManageEvents()
        {
            LanguageSettings.LanguageChanged += new LanguageChangedEventHandler(LoadTexts);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            UserSettings.RememberAllowedExtensions(checkedListBox1.CheckedItems.Cast<string>().ToList());

            var action = (nonExistentFilesBox.SelectedItem as dynamic).Value;
            UserSettings.RememberNonExistentFilesAction(action);
            NonExistentFilesSettings.ChangeAction(action);

            var language = (languageBox.SelectedItem as dynamic).Value.ToString();
            UserSettings.RememberLanguage(language);
            LanguageSettings.ChangeLanguage(language);


            _formOpener.ShowModelessForm<Saved>();
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

            this.languageBox.DataSource = LanguageSettings.Languages;
            this.languageBox.SelectedIndex = 0;
            
            for (var i = 0; i < LanguageSettings.Languages.Count(); i++)
            {
                if (LanguageSettings.CurrentCulture.Name == (LanguageSettings.Languages[i] as dynamic).Value.ToString())
                {
                    this.languageBox.SelectedIndex = i;
                    break;
                }
            }
        }
        private void ManageNonExistentFilesList()
        {
            this.nonExistentFilesBox.DataSource = NonExistentFilesSettings.Actions;
            this.nonExistentFilesBox.SelectedIndex = 0;

            for (var i = 0; i < NonExistentFilesSettings.Actions.Count(); i++)
            {
                if (NonExistentFilesSettings.Action == (NonExistentFilesSettings.Actions[i] as dynamic).Value)
                {
                    this.nonExistentFilesBox.SelectedIndex = i;
                    break;
                }
            }

            if (NonExistentFilesSettings.Action == Domain.Enums.NonExistentFilesAction.Nothing)
                this.nonExistentFilesWarning.Visible = false;
        }

        private void nonExistentFilesBox_Changed(object sender, EventArgs e)
        {
            if ((nonExistentFilesBox.SelectedItem as dynamic).Value == Domain.Enums.NonExistentFilesAction.Nothing)
                this.nonExistentFilesWarning.Visible = false;
            else
                this.nonExistentFilesWarning.Visible = true;
        }
    }
}
