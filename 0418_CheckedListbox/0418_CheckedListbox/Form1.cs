using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0418_CheckedListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strTemp = "";
            foreach(object obj in checkedListBox1.CheckedItems)
            {
                strTemp += obj.ToString();
                strTemp += "";
            }
            MessageBox.Show("당신의 취미는 " + strTemp + "입니다");
        }
    }
}
