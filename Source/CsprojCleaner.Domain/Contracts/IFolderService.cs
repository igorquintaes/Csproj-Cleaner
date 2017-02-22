using System.Collections.Generic;

namespace CsprojCleaner.Domain.Contracts
{
    public interface IFolderService
    {
        IEnumerable<string> GetAllProjectPathFromAFolder(string folder);
        IEnumerable<string> GetAllProjectPathFromAFolder(string folder, List<string> extensions);
    }
}
