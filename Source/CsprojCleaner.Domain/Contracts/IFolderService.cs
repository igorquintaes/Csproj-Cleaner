using System.Collections.Generic;

namespace CsprojCleaner.Domain.Contracts
{
    public interface IFolderService
    {
        IEnumerable<string> ProjectExtensions { get; }

        void SetProjectExtensions(List<string> extensions);
        IEnumerable<string> GetAllProjectPathFromAFolder(string folder);
    }
}
