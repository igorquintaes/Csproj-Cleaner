﻿using CsprojCleaner.App.WindowsForms.ProjectSettings;
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
            ManageEvents();
        }

        private void ManageEvents()
        {
            LanguageSettings.LanguageChanged += new LanguageChangedEventHandler(LoadTexts);
        }

        private void LoadTexts()
        {
            this.sourceCodeIn.Text = Language.AboutSourceCodeIn;
            this.closeBtn.Text = Language.Close;
            this.Text = Language.About;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var target = e.Link.LinkData as string;
            System.Diagnostics.Process.Start(target);

        }
    }
}