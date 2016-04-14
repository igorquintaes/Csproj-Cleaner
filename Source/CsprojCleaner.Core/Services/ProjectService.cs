using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsprojCleaner.Domain.Contracts;
using Microsoft.Build.Evaluation;

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
            try
            {
                BeforeClean();

                _logService.WriteStatus("Arquivo: " + file);

                var engine = new ProjectCollection { DefaultToolsVersion = "4.0" };
                var csproj = engine.LoadProject(file);
                var quantidadeDuplicatas = 0;

                if (csproj.Items.Count == 0)
                    return;

                var currentReferences = new HashSet<string>();
                var itensToRemove = new List<ProjectItem>();

                foreach (var projectItem in csproj.Items.Where(projectItem => projectItem.ItemType == "Content" || projectItem.ItemType == "Compile"))
                {
                    if (!currentReferences.Contains(projectItem.Xml.Include))
                    {
                        currentReferences.Add(projectItem.Xml.Include);
                        continue;
                    }

                    itensToRemove.Add(projectItem);
                    quantidadeDuplicatas ++;
                }

                itensToRemove.ForEach(x => csproj.RemoveItem(x));

                if (!ResolveIfNoDuplicatedItens(quantidadeDuplicatas)) return;

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
                _logService.WriteError("Erro ao atualizar o arquivo " + fullPath);
            }
        }

        private bool ResolveIfNoDuplicatedItens(int countDuplicated)
        {
            if (countDuplicated == 0)
            {
                _logService.WriteStatus("Não foram encontrados itens duplicados");
                _logService.WriteStatus(String.Empty);
                return false;
            }

            _logService.WriteStatus(String.Format("Foram encontrados {0} itens duplicados.", countDuplicated));
            _logService.WriteStatus(String.Empty);
            return true;
        }

        private void BeforeClean()
        {
            _logService.WriteStatus(String.Empty);
            _logService.WriteStatus("Preparando-se para executar a limpeza...");
            _logService.WriteStatus(String.Empty);
        }

        private void AfterClean()
        {
            _logService.WriteStatus("Limpeza executada com sucesso.");
        }
    }
}
