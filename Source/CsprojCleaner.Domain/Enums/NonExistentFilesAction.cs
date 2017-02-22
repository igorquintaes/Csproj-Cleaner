using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsprojCleaner.Domain.Enums
{
    public enum NonExistentFilesAction
    {
        Nothing = 0,
        Log = 1,
        LogAndDelete = 2
    }
}
