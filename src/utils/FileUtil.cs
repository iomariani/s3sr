using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace mktm.ts3tools.s3sr
{
    /// <summary>
    /// Class that Contains Utilities for File Handling
    /// </summary>
    class FileUtil
    {
        /// <summary>
        /// Creates a backup for file specified in <paramref name="FileName"/>
        /// </summary>
        /// <param name="FileName">File Path</param>
        /// <returns>Returns the Backup file path</returns>
        public static string Backup(string FileName)
        {
            if(!File.Exists(FileName))
                return null;

            string FileNameBackup = FileName + ".bak";
            File.Copy(FileName, FileNameBackup);

            return FileNameBackup;
        }
    }
}