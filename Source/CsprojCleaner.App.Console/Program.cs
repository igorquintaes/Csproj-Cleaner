using System;
using System.Configuration;
using System.Linq;
using CsprojCleaner.Core.Exceptions;
using CsprojCleaner.Core.Services;

namespace CsprojCleaner.App.Console
{
    class Program
    {
        static void Main()
        {
            try
            {
                System.Console.WriteLine("Iniciando Limpeza...");
                LogService.InitializeLog(ConfigurationManager.AppSettings["LogPath"]);

                var files = FolderService.GetAllProjectPathFromAFolder(ConfigurationManager.AppSettings["FolderPath"]).ToList();
                files.ForEach(ProjectService.Clean);
            }
            catch (LogException)
            {
                System.Console.WriteLine("Erro ao instanciar log de erros: " + LogService.ConsoleLog);
            }
            catch (FolderException)
            {
                System.Console.WriteLine("Erro no directório de .csproj: " + LogService.ConsoleLog);
                LogService.WriteError(LogService.ConsoleLog);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro: " + e.Message);
                LogService.WriteError(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Verifique o diretório de Logs para maiores informações.");
                System.Console.WriteLine("Limpeza Concluída.");
                System.Console.ReadKey();
            }
        }
    }
}
