using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Evaluation;

namespace CsprojCleaner.Core.Services
{
    public class CsprojService
    {
        public static void Clean(string file)
        {
            try
            {
                BeforeClean();

                LogService.WriteStatus("Arquivo: " + file);

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
                LogService.WriteError(uaEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                LogService.WriteError(pathEx.Message);
            }
            catch(Exception e)
            {
                LogService.WriteError(e.Message);
            }
            finally
            {
                AfterClean();
            }
        }

        private static void UpdateCsprojFile(string fullPath, Project csproj)
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
                LogService.WriteError("Erro ao atualizar o arquivo " + fullPath);
            }
        }

        private static bool ResolveIfNoDuplicatedItens(int countDuplicated)
        {
            if (countDuplicated == 0)
            {
                LogService.WriteStatus("Não foram encontrados itens duplicados");
                LogService.WriteStatus(String.Empty);
                return false;
            }

            LogService.WriteStatus(String.Format("Foram encontrados {0} itens duplicados.", countDuplicated));
            LogService.WriteStatus(String.Empty);
            return true;
        }



        private static void BeforeClean()
        {
            LogService.WriteStatus(String.Empty);
            LogService.WriteStatus("Preparando-se para executar a limpeza...");
            LogService.WriteStatus(String.Empty);
        }

        private static void AfterClean()
        {
            LogService.WriteStatus("Limpeza executada com sucesso.");
        }
    }
}
