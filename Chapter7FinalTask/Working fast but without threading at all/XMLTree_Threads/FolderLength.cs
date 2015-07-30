using System;
using System.IO;

namespace XMLTree_Threads
{
    internal class FolderLength
    {
        #region "FolderLength"

        public static long DirSize(DirectoryInfo d)
        {
            long Size = 0;
            // Add file sizes.
            var fis = d.GetFiles();
            foreach (var fi in fis)
            {
                try
                {
                    Size += fi.Length;
                }
                catch (UnauthorizedAccessException)
                {
                    ;
                }
            }
            // Add subdirectory sizes.
            var dis = d.GetDirectories();
            foreach (var di in dis)
            {
                try
                {
                    Size += DirSize(di);
                }
                catch (UnauthorizedAccessException)
                {
                    ;
                }
            }
            return (Size);
        }

        #endregion
    }
}
