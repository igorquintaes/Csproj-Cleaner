﻿using CsprojCleaner.App.WindowsForms.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsprojCleaner.App.WindowsForms.ProjectSettings
{
    static class UserSettings
    {
        internal static void RememberPaths(string projDir, string logDir)
        { 
            if (!String.IsNullOrEmpty(projDir))
            {
                if (Settings.Default.FileFolderPaths == null)
                    Settings.Default.FileFolderPaths = new StringCollection();

                Settings.Default.FileFolderPaths.Add(projDir);
            }

            if (!String.IsNullOrEmpty(logDir))
            {

                if (Settings.Default.LogFolderPaths == null)
                    Settings.Default.LogFolderPaths = new StringCollection();

                Settings.Default.LogFolderPaths.Add(logDir);
            }

            Settings.Default.Save();
        }

        internal static StringCollection RecoverProjectPaths()
        {
            return (Settings.Default.FileFolderPaths ?? new StringCollection());
        }

        internal static StringCollection RecoverLogPaths()
        {
            return (Settings.Default.LogFolderPaths ?? new StringCollection());
        }
    }
}
