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

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            autoCompleteProjectPaths.AddRange(UserSettings.RecoverProjectPaths().ToArray());
            autoCompleteLogPaths.AddRange(UserSettings.RecoverLogPaths().ToArray());

            ProjDir.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ProjDir.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ProjDir.AutoCompleteCustomSource = autoCompleteProjectPaths;

            LogDir.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            LogDir.AutoCompleteSource = AutoCompleteSource.CustomSource;
            LogDir.AutoCompleteCustomSource = autoCompleteLogPaths;
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
                CleanButton.Text = Resources.Loading___;
                CleanButton.Enabled = false;

                var t = new Thread(ThreadClean) { IsBackground = true };
                t.Start();
            }
            catch (InitializeLogException)
            {
                CleanButton.Text = Resources.ErrorLogExceptionInitialize;
            }
            catch (ReadFolderException)
            {
                CleanButton.Text = Resources.ErrorFolderExceptionVerifyLog;
                _logService.WriteError(_logService.ConsoleLog);
            }
            catch (Exception ex)
            {
                CleanButton.Text = Resources.ErrorExceptionVerifyLog;
                _logService.WriteError(ex.Message);
            }

            CleanButton.Enabled = true;
        }

        private bool ValidateInputs()
        {
            if (String.IsNullOrEmpty(ProjDir.Text))
            {
                MessageBox.Show(Resources.VerifyAllDirWasFilled, Resources.Warning_);
                return false;
            }

            if (!Directory.Exists(ProjDir.Text))
            {
                MessageBox.Show("O diret�rio de projetos n�o existe. Por favor, selecione um diret�rio v�lido.");
                return false;
            }

            if (_logService.SaveLog && !Directory.Exists(LogDir.Text))
            {
                MessageBox.Show("O diret�rio de log n�o existe. Por favor, selecione um diret�rio v�lido.");
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
                files = _folderService.GetAllProjectPathFromAFolder(ProjDir.Text).ToList();
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
            CleanButton.Text = Resources.FinishedClickToRunAgain;
            LoadingBar.Value = 100;
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

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
