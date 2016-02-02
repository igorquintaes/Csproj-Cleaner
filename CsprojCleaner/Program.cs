using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using CsprojCleaner.Services;
using Microsoft.Build.BuildEngine;

namespace CsprojCleaner
{
    class Program
    {
        static void Main()
        {
            var files = FolderService.GetAllCsprojPathFromAFolder(ConfigurationManager.AppSettings["FolderPath"]).ToList();
            files.ForEach(CsprojService.Clean);
        }
    }
}
