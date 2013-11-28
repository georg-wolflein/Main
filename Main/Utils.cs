using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    /// <summary>
    /// Contains some convenient tool methods. 
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Adds "\" to the end of a directory if it is not the last character. 
        /// </summary>
        /// <param name="directoryName">The directory path. </param>
        /// <returns></returns>
        public static string QualifyDirectory(string directoryName)
        {
            if (!directoryName.EndsWith("\\")) directoryName += "\\";
            return directoryName;
        }

        /// <summary>
        /// Get the directory path of a given filename. 
        /// </summary>
        /// <param name="fileName">The filename. </param>
        /// <returns></returns>
        public static string DirectoryFromFile(string fileName)
        {
            return QualifyDirectory(fileName.Substring(0, fileName.LastIndexOf("\\")));
        }
    }
}
