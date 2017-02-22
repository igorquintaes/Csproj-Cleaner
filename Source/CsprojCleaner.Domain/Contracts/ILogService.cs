using System.Collections.Generic;

namespace CsprojCleaner.Domain.Contracts
{
    public interface ILogService
    {
        bool SaveLog { get; }
        string LogStatus { get; }
        string LogError { get; }
        string ConsoleLog { get; }

        void InitializeLog(string path);
        void WriteStatus(string project, List<string> files);
        void WriteNonExistentFiles(string project, List<string> files);
        void WriteError(string project, string error);
        void SetConsoleLog(string message);
        void SetSaveLog(bool save);
    }
}
