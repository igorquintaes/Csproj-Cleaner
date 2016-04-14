using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsprojCleaner.Core.Constants;
using CsprojCleaner.Core.Exceptions;

namespace CsprojCleaner.Core.Services
{
    public class FolderService
    {
        public static IEnumerable<string> ProjectExtensions { get; private set; }

        public void SetProjectExtensions(List<string> extensions)
        {
            if (!extensions.All(x => Extensions.SupportedExtensions.Contains(x)))
                throw new InvalidDataException("Extensão não suportada!");

            ProjectExtensions = extensions;
        }

        public static IEnumerable<string> GetAllProjectPathFromAFolder(string folder)
        {
            try
            {
                if (ProjectExtensions == null || !ProjectExtensions.Any())
                    ProjectExtensions = Extensions.SupportedExtensions;

                var files = ProjectExtensions
                    .SelectMany(x => Directory.EnumerateFiles(folder, x, SearchOption.AllDirectories))
                    .ToList();

                if (!files.Any())
                {
                    LogService.WriteStatus("Não foram encontrados arquivos de projeto no caminho especificado.");
                    return new List<string>();
                }

                files.ForEach(x => LogService.WriteStatus(String.Format("Arquivo encontrado: {0}", x)));
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
