using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsprojCleaner.App.WindowsForms.Extensions
{
    public static class StringCollectionExtension
    {
        public static string[] ToArray(this StringCollection collection)
        {
            string[] strArray = new string[collection.Count];
            collection.CopyTo(strArray, 0);

            return strArray;
        }
    }
}
