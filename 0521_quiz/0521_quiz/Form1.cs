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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
           
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    //  MessageBox.Show(item.Text);

                    if (item.Text.Equals("메모장"))
                    {
                        System.Diagnostics.Process.Start("notepad.exe");
                    }
                    else if (item.Text.Equals("계산기"))
                    {
                        System.Diagnostics.Process.Start("calc.exe");
                    }
                    else if (item.Text.Equals("그림판"))
                    {
                        System.Diagnostics.Process.Start("mspaint.exe");
                    }
                

            }
        }
    }
}
