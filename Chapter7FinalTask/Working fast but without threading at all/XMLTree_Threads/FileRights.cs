using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace XMLTree_Threads
{
    internal class FileRights
    {
        public static string GetRights(FileInfo fi)
        {
            var result = "";

            var ds = fi.GetAccessControl();

            foreach (FileSystemAccessRule ar in ds.GetAccessRules(true, true, typeof (NTAccount)))
            {
                result = string.Format("{0}", ar.FileSystemRights);
            }
            return result;
        }
    }
}
