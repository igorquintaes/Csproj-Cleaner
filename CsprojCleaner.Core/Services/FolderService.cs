using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsprojCleaner.Core.Exceptions;

namespace CsprojCleaner.Core.Services
{
    public class FolderService
    {
        public static IEnumerable<string> GetAllCsprojPathFromAFolder(string folder)
        {
            try
            {
                var files =
                    Directory.EnumerateFiles(
                    folder,
                    "*.csproj",
                    SearchOption.AllDirectories)
                .ToList();

                if (!files.Any())
                {
                    Console.WriteLine("Não foram encontrados arquivos .csproj no caminho especificado.");
                    Console.ReadKey();
                    return new List<string>();
                }

                files.ForEach(x => Console.WriteLine("Arquivo encontrado: {0}", x));
                return files;
            }
            catch (Exception e)
            {
                LogService.ConsoleLog = e.Message;
                throw new FolderException();
            }
        }
    }
}
