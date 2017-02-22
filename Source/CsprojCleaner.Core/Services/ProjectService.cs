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
                BeforeClean();

                _logService.WriteStatus("File: " + file);

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
                        !File.Exists(file + "\\" + projectItem.Xml.Include))
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

                if (!ResolveIfNoDuplicatedItens(duplicatedCount)) return;

                UpdateCsprojFile(file, csproj);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                _logService.WriteError(uaEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                _logService.WriteError(pathEx.Message);
            }
            catch(Exception e)
            {
                _logService.WriteError(e.Message);
            }
            finally
            {
                AfterClean();
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
                _logService.WriteError("Error when tried to update file " + fullPath);
            }
        }

        private bool ResolveIfNoDuplicatedItens(int countDuplicated)
        {
            if (countDuplicated == 0)
            {
                _logService.WriteStatus("No duplicated items was found.");
                _logService.WriteStatus(String.Empty);
                return false;
            }

            _logService.WriteStatus(String.Format("Was found {0} duplicated items.", countDuplicated));
            _logService.WriteStatus(String.Empty);
            return true;
        }

        private void BeforeClean()
        {
            _logService.WriteStatus(String.Empty);
            _logService.WriteStatus("Preparing to execute the cleaner...");
            _logService.WriteStatus(String.Empty);
        }

        private void AfterClean()
        {
            _logService.WriteStatus("Cleaner runned succefull.");
        }
    }
}
