using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Core
{
    public class GroupBy
    {
        /// <summary>
        /// Sort list box items with NAME and SIRNAME
        /// </summary>
        /// <param name="listBox1"></param>
        public void GroupByNameAndSirname(ListBox listBox1)
        {
            listBox1.Items.Clear();
            XDocument xmlDoc = XDocument.Load("base.xml");

            var result = from ar in xmlDoc.Root.Elements("people")
                         orderby ar.Element("Name").Value, ar.Element("Sirname").Value
                         select new
                         {
                             Sirname = ar.Element("Sirname").Value
                         };

            foreach (var person in result)
            {
                listBox1.Items.Add(string.Format("{0}", person.Sirname));
            }
        }

        /// <summary>
        /// Show group and people in group
        /// </summary>
        /// <param name="listBox1"></param>
        public void ShowInGroups(ListBox listBox1)
        {
            listBox1.Items.Clear();
            XDocument xmlDoc = XDocument.Load("base.xml");

            var result = from ar in xmlDoc.Root.Elements("people") group ar by ar.Element("Group").Value into g select g;

            foreach (var group in result)
            {
                listBox1.Items.Add(string.Format("{0}", group.Key));

                foreach (var person in group)
                {
                    listBox1.Items.Add(string.Format("\t{0}", person.Element("Name").Value));
                }
                
            }
        }
    }
}
