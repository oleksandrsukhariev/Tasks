using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLTree_Threads
{
    public partial class Form1 : Form
    {
        private readonly FromXmlToTree xmlToTree = new FromXmlToTree();

        public Form1()
        {
            InitializeComponent();
        }

        public void LoadButton_Click(object sender, EventArgs e)
        {
            string path = null;
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.SelectedPath;

            var fileSystemTree = Tree.CreateFileSystemXmlTree(path);
            displayTree.Nodes.Add(xmlToTree.CreateTreeFromXML(fileSystemTree));
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            displayTree.ExpandAll();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML документ (*.xml)|*.xml|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var root = new XElement("YourChoice", displayTree.Nodes[0].Text);
                foreach (TreeNode item in displayTree.Nodes)
                    SaveItems(root, item);
                root.Save(saveFileDialog.FileName);
            }
        }

        private void SaveItems(XElement curNode, TreeNode item)
        {
            foreach (TreeNode itemloc in item.Nodes)
            {
                var newNode = new XElement("Tag", itemloc.Text);
                SaveItems(newNode, itemloc);
                curNode.Add(newNode);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayTree.Nodes.Clear();
        }
    }
}
