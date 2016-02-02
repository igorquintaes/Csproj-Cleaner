using System;
using System.Linq;
using System.Windows.Forms;
using CsprojCleaner.App.WindowsForms.Properties;
using CsprojCleaner.Core.Exceptions;
using CsprojCleaner.Core.Services;

namespace CsprojCleaner.App.WindowsForms
{
    public partial class Form1 : Form
    {
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
            try
            {
                CleanButton.Text = Resources.Loading___;

                LogService.InitializeLog(logDir.Text);

                var files = FolderService.GetAllCsprojPathFromAFolder(projDir.Text).ToList();
                files.ForEach(CsprojService.Clean);

                CleanButton.Text = Resources.FinishedClickToRunAgain;
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
        }

        private void Form1Load(object sender, EventArgs e)
        {

        }

        private void ProjDirTextChanged(object sender, EventArgs e)
        {

        }
    }
}
