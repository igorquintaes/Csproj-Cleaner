using CsprojCleaner.Domain.Enums;

namespace CsprojCleaner.Domain.Contracts
{
    public interface IProjectService
    {
        void Clean(string file);
        void Clean(string file, NonExistentFilesAction action);
    }
}
