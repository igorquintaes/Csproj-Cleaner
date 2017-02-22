using System;
using System.IO;

namespace CsprojCleaner.Core.Services
{
    using Domain.Contracts;
    using Domain.Exceptions;
    using System.Collections.Generic;
    using System.Linq;

    public class LogService : ILogService
    {
        public bool SaveLog { get; private set; }
        public string LogStatus { get; private set; }
        public string LogError { get; private set; }
        public string LogNonExistentFiles { get; private set; }
        public string ConsoleLog { get; private set; }

        public void InitializeLog(string path)
        {
            if (!SaveLog) return;

            try
            {
                var date = DateTime.Now.ToString("yyyyMMddHHmmss");
                path = Path.GetFullPath(path);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                LogStatus = string.Format("{0}\\{1}{2}.txt", path, date, "-DUPLICATES");
                if (!File.Exists(LogStatus))
                {
                    var fileStatus = File.Create(LogStatus);
                    fileStatus.Close();

                    var file = new StreamWriter(LogStatus, true);
                    file.WriteLine("Initialized at: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    file.Close();
                }

                LogError = string.Format("{0}\\{1}{2}.txt", path, date, "-ERROR");
                if (!File.Exists(LogError))
                {
                    var fileError = File.Create(LogError);
                    fileError.Close();

                    var file = new StreamWriter(LogError, true);
                    file.WriteLine("Initialized at: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    file.Close();
                }

                LogNonExistentFiles = string.Format("{0}\\{1}{2}.txt", path, date, "-NONEXISTENT");
                if (!File.Exists(LogNonExistentFiles))
                {
                    var fileError = File.Create(LogNonExistentFiles);
                    fileError.Close();

                    var file = new StreamWriter(LogNonExistentFiles, true);
                    file.WriteLine("Initialized at: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    file.Close();
                }
            }
            catch (Exception e)
            {
                ConsoleLog = e.Message;
                throw new InitializeLogException();
            }
        }

        public void WriteStatus(string lines)
        {
            if (!SaveLog) return;

            if (string.IsNullOrEmpty(LogStatus)) throw new Exception("Invalid log path.");

            var file = new StreamWriter(LogStatus, true);
            file.WriteLine(String.IsNullOrEmpty(lines) ? String.Empty : DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + lines);
            file.Close();
        }

        public void WriteError(string lines)
        {
            if (!SaveLog) return;
            if (string.IsNullOrEmpty(LogError)) throw new Exception("Invalid log path.");

            var file = new StreamWriter(LogError, true);
            file.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + lines);
            file.WriteLine(String.Empty);
            file.Close();
        }

        public void WriteNonExistentFiles(string project, List<string> files)
        {
            if (!SaveLog) return;

            if (string.IsNullOrEmpty(LogNonExistentFiles)) throw new Exception("Invalid log path.");

            var file = new StreamWriter(LogNonExistentFiles, true);
            file.WriteLine("Project Name: " + project);

            if (files == null || !files.Any())
                file.WriteLine("No non-existent files was found.");
            else
                files.ForEach(x => file.WriteLine("Duplicated:   " + x));

            file.WriteLine(String.Empty);
            file.Close();
        }

        public void SetConsoleLog(string message)
        {
            ConsoleLog = message;
        }

        public void SetSaveLog(bool save)
        {
            SaveLog = save;
        }
    }
}
