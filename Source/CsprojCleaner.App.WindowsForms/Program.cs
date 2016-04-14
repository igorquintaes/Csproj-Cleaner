using System;
using System.Windows.Forms;
using CsprojCleaner.Core.Services;
using CsprojCleaner.Domain.Contracts;
using SimpleInjector;

namespace CsprojCleaner.App.WindowsForms
{
    static class Program
    {
        private static Container _container;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SimpleInjector();

            Application.Run(_container.GetInstance<Main>());
        }

        private static void SimpleInjector()
        {
            _container = new Container();

            _container.RegisterSingleton<Main>();
            _container.RegisterSingleton<IProjectService, ProjectService>();
            _container.RegisterSingleton<ILogService, LogService>();
            _container.RegisterSingleton<IFolderService, FolderService>();

            _container.Verify();
        }
    }
}
