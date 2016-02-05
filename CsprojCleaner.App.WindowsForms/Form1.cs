using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CsprojCleaner.App.WindowsForms.Properties;
using CsprojCleaner.Core.Exceptions;
using CsprojCleaner.Core.Services;

namespace CsprojCleaner.App.WindowsForms
{
    public partial class Form1 : Form
    {
        private int _countItems;
        private int _countLoop;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Label1Click(object sender, EventArgs e)
        {

        }

        private void Label2Click(object sender, EventArgs e)
        {

        }

        private void Button1Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(projDir.Text) || String.IsNullOrEmpty(logDir.Text))
            {
                MessageBox.Show(Resources.VerifyAllDirWasFilled , Resources.Warning_);
                return;
            }

            try
            {
                CleanButton.Text = Resources.Loading___;

                var t = new Thread(ThreadClean) { IsBackground = true };
                t.Start();
            }
            catch (LogException)
            {
                CleanButton.Text = Resources.ErrorLogExceptionInitialize;
            }
            catch (FolderException)
            {
                CleanButton.Text = Resources.ErrorFolderExceptionVerifyLog;
                LogService.WriteError(LogService.ConsoleLog);
            }
            catch (Exception ex)
            {
                CleanButton.Text = Resources.ErrorExceptionVerifyLog;
                LogService.WriteError(ex.Message);
            }

            CleanButton.Enabled = true;
        }

        private void Form1Load(object sender, EventArgs e)
        {

        }

        private void ProjDirTextChanged(object sender, EventArgs e)
        {

        }

        private void LoadCsprojFolderButtonClick(object sender, EventArgs e)
        {
            if (FolderCsproj.ShowDialog() == DialogResult.OK)
            {
                projDir.Text = FolderCsproj.SelectedPath;
            }
        }

        private void LoadLogFolderButtonClick(object sender, EventArgs e)
        {
            if (FolderLog.ShowDialog() == DialogResult.OK)
            {
                logDir.Text = FolderLog.SelectedPath;
            }
        }

        private void FolderBrowserDialog1HelpRequest(object sender, EventArgs e)
        { 

        }

        void ThreadClean()
        {
            var updateCounterDelegate = new MethodInvoker(UpdateCount);

            lock (stateLock)
            {
                _countItems = 0;
                _countLoop = 0;
                currentCount = 0;
                CleanButton.Enabled = false;
            }
            Invoke(updateCounterDelegate);

            lock (stateLock)
            {
                LogService.InitializeLog(logDir.Text);
                currentCount = 5;
            }
            Invoke(updateCounterDelegate);
            Thread.Sleep(500);

            List<string> files;
            lock (stateLock)
            {
                files = FolderService.GetAllCsprojPathFromAFolder(projDir.Text).ToList();
                _countItems = files.Count;
                currentCount = 10;
            }

            foreach (var t in files)
            {
                lock (stateLock)
                {
                    CsprojService.Clean(t);
                    _countLoop++;
                }

                Invoke(updateCounterDelegate);
            }

            Invoke(new MethodInvoker(Finish));
        }

        void UpdateCount()
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

                progressBar1.Value = tmpCount;
            }
        }

        void Finish()
        {
            CleanButton.Enabled = true;
            CleanButton.Text = Resources.FinishedClickToRunAgain;
            progressBar1.Value = 100;
        }

        private void ProgressBar1Click(object sender, EventArgs e)
        {

        }
    }
}
