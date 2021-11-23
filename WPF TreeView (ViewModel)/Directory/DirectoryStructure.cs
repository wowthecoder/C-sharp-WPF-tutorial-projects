using System.Collections.Generic;
using System.IO;

namespace WPF_TreeView
{
    /// <summary>
    /// A helper class to query information about directories
    /// </summary>
    public static class DirectoryStructure
    {
        public static List<DirectoryItem> GetLogicalDrives()
        {
            List<DirectoryItem> drives = new List<DirectoryItem>();
            foreach (string drive in Directory.GetLogicalDrives())
            {
                var item = new DirectoryItem { FullPath = drive, Type = DirectoryItemType.Drive };
                drives.Add(item);
            }
            return drives;
        }

        /// <summary>
        /// Get the top-level contents of the directory(returns all folders and files in a directory)
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static List<DirectoryItem> GetDirectoryContents(string fullPath)
        {
            var items = new List<DirectoryItem>();

            #region Get Folder

            //Try and get the directories in the folder
            //Ignore any errors while doing so
            try
            {
                string[] dirs = Directory.GetDirectories(fullPath);

                if (dirs.Length > 0)
                {
                    foreach (string dir in dirs)
                    {
                        DirectoryItem dirItem = new DirectoryItem { FullPath = dir, Type = DirectoryItemType.Folder };
                        items.Add(dirItem);
                    }
                }
            }
            catch { }

            #endregion

            #region Get Files

            List<string> files = new List<string>();

            try
            {
                string[] fs = Directory.GetFiles(fullPath);

                if (fs.Length > 0)
                {
                    foreach (string file in fs) 
                    {
                        DirectoryItem dirItem = new DirectoryItem { FullPath = file, Type = DirectoryItemType.File};
                        items.Add(dirItem);
                    }
                }
            }
            catch { }

            #endregion

            return items;
        }

        #region Helpers

        /// <summary>
        /// Find the file or folder name from a full path
        /// </summary>
        /// <param name="path">The full path</param>
        /// <returns></returns>
        public static string GetFileFolderName(string path)
        {
            // If we have no path, return empty
            if (string.IsNullOrEmpty(path))
                return string.Empty;

            // Make all slashes back slashes
            var normalizedPath = path.Replace('/', '\\');

            // Find the last backslash in the path
            var lastIndex = normalizedPath.LastIndexOf('\\');

            // If we don't find a backslash, return the path itself
            if (lastIndex <= 0)
                return path;

            // Return the name after the last back slash
            return path.Substring(lastIndex + 1);
        }

        #endregion
    }
}
