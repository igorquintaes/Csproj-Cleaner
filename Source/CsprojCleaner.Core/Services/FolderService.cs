using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsprojCleaner.Domain.Constants;
using CsprojCleaner.Domain.Contracts;
using CsprojCleaner.Domain.Exceptions;

namespace CsprojCleaner.Core.Services
{
    public class FolderService : IFolderService
    {
        
        private readonly ILogService _logService;

        public FolderService(ILogService logService)
        {
            _logService = logService;
        }

        public IEnumerable<string> ProjectExtensions { get; private set; }

        public void SetProjectExtensions(List<string> extensions)
        {
            if (!extensions.All(x => Extensions.SupportedExtensions.Contains(x)))
                throw new InvalidDataException("Extensão não suportada!");

            ProjectExtensions = extensions;
        }

        public IEnumerable<string> GetAllProjectPathFromAFolder(string folder)
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
                    _logService.WriteStatus("Não foram encontrados arquivos de projeto no caminho especificado.");
                    return new List<string>();
                }

                files.ForEach(x => _logService.WriteStatus(String.Format("Arquivo encontrado: {0}", x)));
                return files;
            }
            catch (Exception e)
            {
                _logService.SetConsoleLog(e.Message);
                throw new FolderException();
            }
        }
    }
}
