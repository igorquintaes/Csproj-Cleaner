﻿using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CleanButton.Text = "Aguarde...";

                LogService.InitializeLog(logDir.Text);

                var files = FolderService.GetAllCsprojPathFromAFolder(projDir.Text).ToList();
                files.ForEach(CsprojService.Clean);

                CleanButton.Text = "Concluído! Clique para executar de novo";
            }
            catch (LogException)
            {
                CleanButton.Text = "Erro ao instanciar log de erros: ";
            }
            catch (FolderException)
            {
                CleanButton.Text = "Erro (FolderException). Verifique o log. ";
                LogService.WriteError(LogService.ConsoleLog);
            }
            catch (Exception ex)
            {
                CleanButton.Text = "Erro (Exception). Verifique o log.";
                LogService.WriteError(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void projDir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
