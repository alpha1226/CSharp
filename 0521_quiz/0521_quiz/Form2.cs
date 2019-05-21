using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0521_quiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TreeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.ItemHeight == 0)
            {
                string name = treeView1.SelectedNode.Text;
                MessageBox.Show(name);
            }
            listView1.Items.Add(treeView1.SelectedNode.Text);
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
