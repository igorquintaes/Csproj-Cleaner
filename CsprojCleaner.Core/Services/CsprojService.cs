using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.BuildEngine;

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

                var engine = new Engine(Environment.CurrentDirectory);
                var csproj = new Project(engine);
                var quantidadeDuplicatas = 0;

                csproj.Load(file);

                if (csproj.ItemGroups == null || csproj.ItemGroups.Count == 0)
                    return;

                var currentReferences = new HashSet<string>();

                foreach (BuildItemGroup ig in csproj.ItemGroups)
                {
                    var itemsToRemove = new List<BuildItem>();

                    foreach (var item in ig.Cast<BuildItem>().Where(item => item.Name == "Content"))
                    {
                        if (currentReferences.Contains(item.Include))
                            itemsToRemove.Add(item);
                        else
                            currentReferences.Add(item.Include);
                    }

                    quantidadeDuplicatas += itemsToRemove.Count;

                    // Remove duplicate items
                    foreach (var itemToRemove in itemsToRemove)
                    {
                        ig.RemoveItem(itemToRemove);
                    }
                }

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

                File.Move(csproj.FullFileName, fullPath);
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
