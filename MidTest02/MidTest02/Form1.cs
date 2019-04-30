using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTest02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String add = textBox2.Text;
            if (radioButton1.Checked) { String gen = "남"; } else if (radioButton2.Checked) { String gen = "여"; }
            String age = textBox4.Text;
            String strTemp = "";
            foreach (object obj in checkedListBox1.CheckedItems)
            {
                strTemp += obj.ToString();
                strTemp += "";
            }


            listBox1.Items.Add(name);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
