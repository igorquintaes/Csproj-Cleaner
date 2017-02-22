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
        void WriteStatus(string lines);
        void WriteError(string lines);
        void SetConsoleLog(string message);
        void SetSaveLog(bool save);
        void WriteNonExistentFiles(string project, List<string> files);
    }
}
