using System.Collections.Generic;

namespace CsprojCleaner.Domain.Constants
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
                "*.lsproj",
                "*.vcxproj",
                "*.ls3proj",
                "*.jsproj"
            };
        }
    }
}
