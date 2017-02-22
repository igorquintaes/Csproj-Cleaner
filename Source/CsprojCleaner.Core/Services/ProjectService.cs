using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsprojCleaner.Domain.Contracts;
using Microsoft.Build.Evaluation;
using CsprojCleaner.Domain.Enums;

namespace CsprojCleaner.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ILogService _logService;

        public ProjectService(ILogService logService)
        {
            _logService = logService;
        }

        public void Clean(string file)
        {
            Clean(file, NonExistentFilesAction.Nothing);
        }

        public void Clean(string file, NonExistentFilesAction action)
        {
            try
            {
                var engine = new ProjectCollection { DefaultToolsVersion = "4.0" };
                var csproj = engine.LoadProject(file);
                var duplicatedCount = 0;

                if (csproj.Items.Count == 0)
                    return;

                var currentReferences = new HashSet<string>();
                var itensToRemove = new List<ProjectItem>();
                
                var nonExistentItems = new List<string>();

                foreach (var projectItem in csproj.Items.Where(projectItem => projectItem.ItemType == "Content" || projectItem.ItemType == "Compile"))
                {
                    // Duplicated files
                    if (currentReferences.Contains(projectItem.Xml.Include))
                    {
                        itensToRemove.Add(projectItem);
                        duplicatedCount++;
                        continue;
                    }

                    // Non existent files
                    if (action != NonExistentFilesAction.Nothing &&
                        !File.Exists(Path.GetDirectoryName(file) + "\\" + projectItem.Xml.Include))
                    {
                        nonExistentItems.Add(projectItem.Xml.Include);

                        if (action == NonExistentFilesAction.LogAndDelete)
                        {
                            itensToRemove.Add(projectItem);
                            continue;
                        }
                    }

                    currentReferences.Add(projectItem.Xml.Include);
                }

                itensToRemove.ForEach(x => csproj.RemoveItem(x));
                _logService.WriteStatus(file, itensToRemove.Select(x => x.Xml.Include).ToList());
                _logService.WriteNonExistentFiles(file, nonExistentItems);

                if (!itensToRemove.Any()) return;

                UpdateCsprojFile(file, csproj);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                _logService.WriteError(file, "Unauthorized Access. Details: " + uaEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                _logService.WriteError(file, "Path Too Long. Details: " + pathEx.Message);
            }
            catch(Exception e)
            {
                _logService.WriteError(file, e.Message);
            }
        }

        private void UpdateCsprojFile(string fullPath, Project csproj)
        {
            try
            {
                var fileName = Path.GetFileName(fullPath);

                File.Delete(fullPath);
                csproj.Save(fileName);

                File.Move(csproj.FullPath, fullPath);
            }
            catch (IOException)
            {
                _logService.WriteError(fullPath, "Error when tried to update file " + fullPath);
            }
        }
    }
}
