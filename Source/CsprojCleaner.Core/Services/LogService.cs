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
                CreateLog(LogStatus);

                LogError = string.Format("{0}\\{1}{2}.txt", path, date, "-ERROR");
                CreateLog(LogError);

                LogNonExistentFiles = string.Format("{0}\\{1}{2}.txt", path, date, "-NONEXISTENT");
                CreateLog(LogNonExistentFiles);
            }
            catch (Exception e)
            {
                ConsoleLog = e.Message;
                throw new InitializeLogException();
            }
        }

        public void WriteStatus(string titleLog, List<string> logItems)
        {
            WriteLog(LogStatus, titleLog, logItems);
        }

        public void WriteError(string titleLog, string error)
        {
            WriteLog(LogError, titleLog, new List<string>()
            {
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + error
            });
        }

        public void WriteNonExistentFiles(string titleLog, List<string> logItems)
        {
            WriteLog(LogNonExistentFiles, titleLog, logItems);
        }

        private void WriteLog(string log, string titleLog, List<string> logItems)
        {
            if (!SaveLog)
                return;

            if (string.IsNullOrEmpty(log))
                throw new Exception("Invalid log path.");

            var file = new StreamWriter(log, true);

            if(!String.IsNullOrEmpty(titleLog))
                file.WriteLine(titleLog);

            if (logItems == null || !logItems.Any())
                file.WriteLine("No results.");
            else
            {
                file.WriteLine(logItems.Count() + " results");
                logItems.ForEach(x => file.WriteLine("Item:         " + x));
            }

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

        private void CreateLog(string log)
        {
            if (!File.Exists(log))
            {
                var file = File.Create(log);
                file.Close();

                var stream = new StreamWriter(log, true);
                stream.WriteLine("Initialized at: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                stream.Close();
            }
        }
    }
}
