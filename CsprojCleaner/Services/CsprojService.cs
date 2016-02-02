using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.BuildEngine;

namespace CsprojCleaner.Services
{
    public class CsprojService
    {
        public static void Clean(string file)
        {
            try
            {
                BeforeClean();
                
                Console.WriteLine("Arquivo: " + file);

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
                Console.WriteLine(uaEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                Console.WriteLine(pathEx.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
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
                Console.WriteLine("Erro ao atualizar o arquivo " + fullPath);
                Console.WriteLine(String.Empty);
            }
        }

        private static bool ResolveIfNoDuplicatedItens(int countDuplicated)
        {
            if (countDuplicated == 0)
            {
                Console.WriteLine("Não foram encontrados itens duplicados");
                Console.WriteLine(String.Empty);
                return false;
            }

            Console.WriteLine("Foram encontrados {0} itens duplicados.", countDuplicated);
            Console.WriteLine(String.Empty);
            return true;
        }

        

        private static void BeforeClean()
        {
            Console.WriteLine(String.Empty);
            Console.WriteLine("Preparando-se para executar a limpeza...");
            Console.WriteLine(String.Empty);
        }
    }
}
