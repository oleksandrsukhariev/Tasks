using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Core;

namespace UI
{
    public partial class Form1 : Form
    {
        private CRUD operations = new CRUD();
        WorkingWithImage workingWithImage = new WorkingWithImage();
        GroupBy group = new GroupBy();
        private static string path = String.Empty;

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(save_btn, "Press ADD NEW button first!");
            nameBox.ForeColor = Color.Gray;
            nameBox.Text = "Enter name please";
            sirnameBox.ForeColor = Color.Gray;
            sirnameBox.Text = "Enter sirname please";
            groupBox.ForeColor = Color.Gray;
            groupBox.Text = "Enter group please";
            homePhoneBox.ForeColor = Color.Gray;
            homePhoneBox.Text = "Enter home phone number please";
            workPhoneBox.ForeColor = Color.Gray;
            workPhoneBox.Text = "Enter work phone number please";
            operations.CreateDoc();
            operations.FillMyListBox(listBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            nameBox.Text = string.Empty;
            sirnameBox.Text = string.Empty;
            groupBox.Text = string.Empty;
            homePhoneBox.Text = string.Empty;
            workPhoneBox.Text = string.Empty;
            photoBox.Image = null;
            save_btn.Enabled = true;
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            operations.DeletePerson(listBox1);
            operations.FillMyListBox(listBox1);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //there will be modify changes loop later
            if (nameBox.Text != null && sirnameBox.Text != null && groupBox.Text != null && homePhoneBox.Text != null &&
                workPhoneBox.Text != null)
            {
                operations.AddNewPerson(nameBox, sirnameBox, groupBox, homePhoneBox, workPhoneBox, path);
                operations.FillMyListBox(listBox1);
            }
            else
            {
                MessageBox.Show("Fill all textboxes please!","Fill boxes!");
            }
                
            
            save_btn.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var xmlDoc = XDocument.Load("base.xml");
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    var description = from node in xmlDoc.Root.Elements("people")
                        where node.Element("Sirname").Value.Trim() == listBox1.SelectedItem.ToString()
                        select node;

                    nameBox.Text = description.First().Element("Name").Value.Trim();
                    sirnameBox.Text = description.First().Element("Sirname").Value.Trim();
                    groupBox.Text = description.First().Element("Group").Value.Trim();
                    homePhoneBox.Text = description.First().Element("HomePhone").Value.Trim();
                    workPhoneBox.Text = description.First().Element("WorkPhone").Value.Trim();
                    photoBox.Image = workingWithImage.FromXml(description.First().Element("Photo").Value);
                }
                else
                {
                    nameBox.Clear();
                    sirnameBox.Clear();
                    groupBox.Clear();
                    homePhoneBox.Clear();
                    workPhoneBox.Clear();
                    photoBox.Image = null;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Can`t navigate in this mode!",ex.Message);
            }
            
        }

        private void photoBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            openFileDialog1.Title = "Select a picture";

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            photoBox.Image = Image.FromFile(openFileDialog1.FileName);
            path = openFileDialog1.FileName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                group.GroupByNameAndSirname(listBox1);
            }
            else
            {
                operations.FillMyListBox(listBox1);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                group.ShowInGroups(listBox1);
            }
            else
            {
                operations.FillMyListBox(listBox1);
            }
        }

        private void nameBox_ModifiedChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = true;
        }

        private void sirnameBox_ModifiedChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = true;
        }

        private void groupBox_ModifiedChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = true;
        }

        private void homePhoneBox_ModifiedChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = true;
        }

        private void workPhoneBox_ModifiedChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = true;
        }
    }
}
