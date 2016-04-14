﻿namespace CsprojCleaner.Domain.Contracts
{
    public interface ILogService
    {

        string LogStatus { get; }
        string LogError { get; }
        string ConsoleLog { get; }

        void InitializeLog(string path);
        void WriteStatus(string lines);
        void WriteError(string lines);
        void SetConsoleLog(string message);
    }
}
