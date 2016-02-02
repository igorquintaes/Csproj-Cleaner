using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using Microsoft.Build.BuildEngine;

namespace CsprojCleaner
{
    class Program
    {
        static void Main()
        {
            try
            {
                var files = GetAllCsprojPathFromAFolder(ConfigurationManager.AppSettings["FolderPath"]);
                BeforeClean();

                foreach (var file in files)
                {
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

                    if (!ResolveIfNoDuplicatedItens(quantidadeDuplicatas)) continue;

                    UpdateCsprojFile(file, csproj);
                }
            }
            catch (UnauthorizedAccessException uaEx)
            {
                Console.WriteLine(uaEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                Console.WriteLine(pathEx.Message);
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

        private static IEnumerable<string> GetAllCsprojPathFromAFolder(string folder)
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
                return null;
            }

            files.ForEach(x => Console.WriteLine("Arquivo encontrado: {0}", x));
            return files;
        }

        private static void BeforeClean()
        {
            Console.WriteLine(String.Empty);
            Console.WriteLine("Preparando-se para executar a limpeza...");
            Console.WriteLine(String.Empty);
        }
    }
}
