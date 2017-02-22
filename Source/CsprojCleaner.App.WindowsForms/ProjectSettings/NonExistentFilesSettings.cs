using CsprojCleaner.App.WindowsForms.Resources;
using CsprojCleaner.Domain.Enums;

namespace CsprojCleaner.App.WindowsForms.ProjectSettings
{
    public static class NonExistentFilesSettings
    {
        public static NonExistentFilesAction Action { get; private set; }

        public static object[] Actions
        {
            get
            {
                return new[] {
                    new { Text = Language.NonExistentFilesActionNothing, Value = NonExistentFilesAction.Nothing },
                    new { Text = Language.NonExistentFilesActionLog, Value = NonExistentFilesAction.Log },
                    new { Text = Language.NonExistentFilesActionLogDelete, Value = NonExistentFilesAction.LogAndDelete }
                };
            }
        }
        
        public static void ChangeAction(NonExistentFilesAction action)
        {
            Action = action;
        }

        public static void Initialize()
        {
            ChangeAction(UserSettings.RecoverNonExistentFilesAction());
        }
    }
}
