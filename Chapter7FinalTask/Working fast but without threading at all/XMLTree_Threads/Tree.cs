using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Xml.Linq;

namespace XMLTree_Threads
{
    internal class Tree
    {
        public static XElement CreateFileSystemXmlTree(string source)
        {
            var di = new DirectoryInfo(source);
            return new XElement("Folder_" + ReplaceSpaces(di.Name),
                new XElement("Name", di.Name),
                new XElement("Created", di.CreationTime),
                new XElement("FolderLength", (FolderLength.DirSize(di)/1024) + " KB"),
                from d in Directory.GetDirectories(source)
                select CreateFileSystemXmlTree(d),
                from fi in di.GetFiles()
                select new XElement("File_" + ReplaceSpaces(fi.Name),
                    new XElement("Name", fi.Name),
                    new XElement("Created", fi.CreationTime.ToString()),
                    new XElement("ModificationTime", fi.LastWriteTime.ToString()),
                    new XElement("LastAccessTime", fi.LastAccessTime.ToString()),
                    new XElement("Attributes", fi.Attributes),
                    new XElement("Length", fi.Length > 1024 ? (fi.Length/1024) + " KB" : (fi.Length + " Bytes")),
                    new XElement("OwnerSID", fi.GetAccessControl().GetOwner(typeof (SecurityIdentifier))),
                    new XElement("FileRights", FileRights.GetRights(fi))
                    )
                );
        }

        /// <summary>
        ///     Replace untanted chars from string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private static string ReplaceSpaces(string inputString)
        {
            inputString = inputString.Trim();
            inputString = inputString.Replace(" ", "_");
            inputString = inputString.Replace("[", "_");
            inputString = inputString.Replace("]", "_");
            inputString = inputString.Replace("(", "_");
            inputString = inputString.Replace(")", "_");
            inputString = inputString.Replace("\"", "_");
            inputString = inputString.Replace("'", "_");
            inputString = inputString.Replace("&", "_");
            inputString = inputString.Replace(",", "_");
            inputString = inputString.Replace("?", "_");
            inputString = inputString.Replace("!", "_");
            inputString = inputString.Replace("$", "_");
            inputString = inputString.Replace(":", "_");
            inputString = inputString.Replace("#", "_");
            return inputString;
        }
    }
}
