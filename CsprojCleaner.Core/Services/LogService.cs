using System;
using System.IO;
using CsprojCleaner.Core.Exceptions;

namespace CsprojCleaner.Core.Services
{
    public static class LogService
    {

        public static string LogStatus { get; set; }
        public static string LogError { get; set; }
        public static string ConsoleLog { get; set; }

        public static void InitializeLog(string path)
        {
            try
            {
                var date = DateTime.Now.ToString("yyyyMMddHHmmss");
                path = Path.GetFullPath(path);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                LogStatus = string.Format("{0}\\{1}{2}.txt", path, date, "-LOGSTATUS");
                if (!File.Exists(LogStatus))
                {
                    var fileStatus = File.Create(LogStatus);
                    fileStatus.Close();
                }

                LogError = string.Format("{0}\\{1}{2}.txt", path, date, "-LOGERROR");
                if (!File.Exists(LogStatus))
                {
                    var fileError = File.Create(LogError);
                    fileError.Close();
                }
            }
            catch (Exception e)
            {
                ConsoleLog = e.Message;
                throw new LogException();
            }
        }

        public static void WriteStatus(string lines)
        {
            if (string.IsNullOrEmpty(LogStatus)) throw new Exception("Path de log inválido.");

            var file = new StreamWriter(LogStatus, true);
            file.WriteLine(String.IsNullOrEmpty(lines) ? String.Empty : DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + lines);
            file.Close();
        }

        public static void WriteError(string lines)
        {
            if (string.IsNullOrEmpty(LogError)) throw new Exception("Path de log inválido.");

            var file = new StreamWriter(LogError, true);
            file.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + lines);
            file.WriteLine(String.Empty);
            file.Close();
        }
    }
}
