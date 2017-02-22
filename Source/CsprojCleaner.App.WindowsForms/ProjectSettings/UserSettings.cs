using CsprojCleaner.App.WindowsForms.Properties;
using CsprojCleaner.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsprojCleaner.App.WindowsForms.ProjectSettings
{
    static class UserSettings
    {
        static readonly string[] supportedCultures = new string[] { "en-US", "pt-BR", };
        static readonly string defaultCulture = "en-US";

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
            return Settings.Default.FileFolderPaths ?? new StringCollection();
        }

        internal static StringCollection RecoverLogPaths()
        {
            return Settings.Default.LogFolderPaths ?? new StringCollection();
        }

        internal static void RememberAllowedExtensions(List<string> extensions)
        {
            Settings.Default.AllowedExtensions = new StringCollection();

            if (extensions != null || extensions.Any())
                Settings.Default.AllowedExtensions.AddRange(extensions.ToArray());

            Settings.Default.Save();
        }

        internal static IEnumerable<string> RecoverAllowedExtensions()
        {
            if (Settings.Default.AllowedExtensions == null || Settings.Default.AllowedExtensions.Count == 0)
                return Domain.Constants.Extensions.SupportedExtensions;

            return Settings.Default.AllowedExtensions.Cast<string>().ToList();
        }

        internal static void RememberLanguage(string language)
        {
            if (String.IsNullOrEmpty(language) || CultureInfo.GetCultureInfo(language) == null || !supportedCultures.Contains(language))
                Settings.Default.Language = defaultCulture;
            else
                Settings.Default.Language = CultureInfo.GetCultureInfo(language).Name;

            Settings.Default.Save();
        }

        internal static string RecoverLanguage()
        {
            return String.IsNullOrEmpty(Settings.Default.Language)
                ? defaultCulture
                : Settings.Default.Language;
        }






        internal static void RememberNonExistentFilesAction(NonExistentFilesAction action)
        {
            Settings.Default.NonExistentFilesAction = action;
            Settings.Default.Save();
        }

        internal static NonExistentFilesAction RecoverNonExistentFilesAction()
        {
            return Settings.Default.NonExistentFilesAction;
        }
    }
}
