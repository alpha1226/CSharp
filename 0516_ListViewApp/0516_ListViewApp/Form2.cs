using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0516_ListViewApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text, 0, 1));
                treeView1.SelectedImageIndex = treeView1.ImageIndex;
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
