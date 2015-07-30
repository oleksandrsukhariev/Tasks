using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLTree_Threads
{
    internal class FromXmlToTree
    {
        public TreeNode CreateTreeFromXML(XElement el)
        {
            if (el.Elements().Count() == 0)
            {
                return new TreeNode(el.Name + ": " + el.Value);
            }
            return new TreeNode(el.Name.ToString(),
                (from child in el.Elements()
                    select CreateTreeFromXML(child)).ToArray());
        }
    }
}
