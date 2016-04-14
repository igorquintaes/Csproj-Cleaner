using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsprojCleaner.Core.Constants
{
    public static class Extensions
    {
        public static List<string> SupportedExtensions { get; private set; }
 
        static Extensions()
        {
            SupportedExtensions = new List<string>
            {
                "*.csproj",
                "*.fsproj",
                "*.vbproj",
                "*.modelproj",
                "*.lsproj",
                "*.vcxproj",
                "*.ls3proj",
                "*.jsproj",
                "*.dbproj",
                "*.oradbproj",
                "*.msbuildproj",
                "*.sqlproj"
            };
        }
    }
}
