using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CsprojCleaner.App.WindowsForms.Properties;
using CsprojCleaner.Domain.Contracts;
using CsprojCleaner.Domain.Exceptions;
using CsprojCleaner.App.WindowsForms.ProjectSettings;
using CsprojCleaner.App.WindowsForms.Extensions;
using CsprojCleaner.App.WindowsForms.Forms.Help;
using CsprojCleaner.App.WindowsForms.Forms.Tools;
using CsprojCleaner.App.WindowsForms.Resources;

namespace CsprojCleaner.App.WindowsForms.Forms
{
    public partial class Main : Form
    {
        private int _countItems;
        private int _countLoop;

        private readonly ILogService _logService;
        private readonly IProjectService _projectService;
        private readonly IFolderService _folderService;

        public Main(ILogService logService,
            IProjectService projectService,
            IFolderService folderService)
        {
            _logService = logService;
            _projectService = projectService;
            _folderService = folderService;

            LanguageSettings.Initialize();
            InitializeComponent();
            LoadTexts();

            autoCompleteProjectPaths.AddRange(UserSettings.RecoverProjectPaths().ToArray());
            autoCompleteLogPaths.AddRange(UserSettings.RecoverLogPaths().ToArray());

            this.ProjDir.AutoCompleteCustomSource = autoCompleteProjectPaths;
            this.LogDir.AutoCompleteCustomSource = autoCompleteLogPaths;
        }
        
        private void LoadCsprojFolder(object sender, EventArgs e)
        {
            if (FolderCsproj.ShowDialog() == DialogResult.OK)
            {
                ProjDir.Text = FolderCsproj.SelectedPath;
            }
        }

        private void LoadLogFolder(object sender, EventArgs e)
        {
            if (FolderLog.ShowDialog() == DialogResult.OK)
            {
                LogDir.Text = FolderLog.SelectedPath;
            }
        }

        private void RunProjectCleaner(object sender, EventArgs e)
        {
            _logService.SetSaveLog(!String.IsNullOrEmpty(LogDir.Text));

            if (!ValidateInputs()) return;

            UserSettings.RememberPaths(ProjDir.Text, LogDir.Text);

            if (!autoCompleteProjectPaths.Contains(ProjDir.Text))
                autoCompleteProjectPaths.Add(ProjDir.Text);

            if (!autoCompleteLogPaths.Contains(LogDir.Text))
                autoCompleteLogPaths.Add(LogDir.Text);

            try
            {
                CleanButton.Text = Language.Loading;
                CleanButton.Enabled = false;

                var t = new Thread(ThreadClean) { IsBackground = true };
                t.Start();
            }
            catch (InitializeLogException)
            {
                CleanButton.Text = Language.ErrorLogExceptionInitialize;
            }
            catch (ReadFolderException)
            {
                CleanButton.Text = Language.ErrorFolderExceptionVerifyLog;
                _logService.WriteError(_logService.ConsoleLog);
            }
            catch (Exception ex)
            {
                CleanButton.Text = Language.ErrorExceptionVerifyLog;
                _logService.WriteError(ex.Message);
            }

            CleanButton.Enabled = true;
        }

        private bool ValidateInputs()
        {
            if (String.IsNullOrEmpty(ProjDir.Text))
            {
                MessageBox.Show(Language.VerifyIfAllDirsAreFilled, Language.Warning);
                return false;
            }

            if (!Directory.Exists(ProjDir.Text))
            {
                MessageBox.Show(Language.InvalidProjectFolder);
                return false;
            }

            if (_logService.SaveLog && !Directory.Exists(LogDir.Text))
            {
                MessageBox.Show(Language.InvalidLogFolder);
                return false;
            }

            return true;
        }

        private void ThreadClean()
        {
            var updateCounterDelegate = new MethodInvoker(UpdateCount);

            lock (stateLock)
            {
                _countItems = 0;
                _countLoop = 0;
                currentCount = 0;
            }
            Invoke(updateCounterDelegate);

            lock (stateLock)
            {
                _logService.InitializeLog(LogDir.Text);
                currentCount = 5;
            }
            Invoke(updateCounterDelegate);
            Thread.Sleep(500);

            List<string> files;
            lock (stateLock)
            {
                var extensions = UserSettings.RecoverAllowedExtensions().ToList();
                files = _folderService.GetAllProjectPathFromAFolder(ProjDir.Text, extensions).ToList();
                _countItems = files.Count;
                currentCount = 10;
            }

            foreach (var t in files)
            {
                lock (stateLock)
                {
                    _projectService.Clean(t);
                    _countLoop++;
                }

                Invoke(updateCounterDelegate);
            }

            Invoke(new MethodInvoker(Finish));
        }

        private void UpdateCount()
        {
            lock (stateLock)
            {
                int tmpCount;
                if (_countItems <= 0 || _countLoop <= 0)
                {
                    tmpCount = currentCount;
                }
                else
                {
                    var value = (double)currentCount + (double)_countLoop / (double)_countItems * (double)(100 - currentCount);
                    tmpCount = Convert.ToInt32(value);
                }

                LoadingBar.Value = tmpCount;
            }
        }

        private void Finish()
        {
            CleanButton.Enabled = true;
            CleanButton.Text = Language.FinishedClickToRunAgain;
            LoadingBar.Value = 100;
        }

        private void LoadTexts()
        {
            this.CleanButton.Text = Language.CleanProjects;
            this.LabelLogFolder.Text = Language.SaveLogDir;
            this.StepsLabelTitle.Text = Language.Steps;
            this.StepsLabelDescription.Text = Language.StepsDescription;
            this.LabelProjectFolder.Text = Language.TargetFolder;
            this.toolsToolStripMenuItem.Text = Language.Tools;
            this.helpToolStripMenuItem.Text = Language.Help;
            this.aboutToolStripMenuItem.Text = Language.About;
            this.settingsToolStripMenuItem.Text = Language.Settings;

        }

        private void LoadingBar_Click(object sender, EventArgs e)
        {

        }

        private void LogDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoImage_Click(object sender, EventArgs e)
        {

        }

        private void LabelLogFolder_Click(object sender, EventArgs e)
        {

        }

        private void ProjDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelProjectFolder_Click(object sender, EventArgs e)
        {

        }

        private void StepsLabelDescription_Click(object sender, EventArgs e)
        {

        }

        private void StepsLabelTitle_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration configurationForm = new Configuration();
            configurationForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}
