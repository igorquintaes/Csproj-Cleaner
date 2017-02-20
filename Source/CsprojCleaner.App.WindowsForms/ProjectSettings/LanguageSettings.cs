using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsprojCleaner.App.WindowsForms.ProjectSettings
{
    public static class LanguageSettings
    {
        private static CultureInfo _currentCulture;
        public static CultureInfo CurrentCulture { get { return _currentCulture; } }

        public static ResourceManager Resources;

        public static object[] Languages
        {
            get
            {
                return new[] {
                    new { Text = "English", Value = "en-US" },
                    new { Text = "Português", Value = "pt-BR" }
                };
            }
        }

        static LanguageSettings()
        {
            _currentCulture = CultureInfo.CreateSpecificCulture(UserSettings.RecoverLanguage());

            Resources = new ResourceManager("Language", typeof(Program).Assembly);
        }

        public static void ChangeLanguage(string culture)
        {
            _currentCulture = CultureInfo.CreateSpecificCulture(UserSettings.RecoverLanguage());

            Thread.CurrentThread.CurrentCulture = _currentCulture;
            Thread.CurrentThread.CurrentUICulture = _currentCulture;
        }
    }
}
