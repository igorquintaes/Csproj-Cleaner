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

        public IEnumerable<string> GetAllProjectPathFromAFolder(string folder)
        {
            return GetAllProjectPathFromAFolder(folder, Extensions.SupportedExtensions);
        }

        public IEnumerable<string> GetAllProjectPathFromAFolder(string folder, List<string> extensions)
        {
            try
            {
                if (extensions == null || !extensions.Any())
                    extensions = Extensions.SupportedExtensions;

                var files = extensions
                    .SelectMany(x => Directory.EnumerateFiles(folder, x, SearchOption.AllDirectories))
                    .ToList();

                if (!files.Any())
                {
                    _logService.WriteStatus(String.Empty, new List<string>() { "Projects files was not found inside the specified folder." });
                    return new List<string>();
                }

                _logService.WriteStatus("Project files found:", files);
                return files;
            }
            catch (Exception e)
            {
                _logService.SetConsoleLog(e.Message);
                throw new ReadFolderException();
            }
        }
    }
}
