using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0404_FormTest
{
    public partial class Form1 : Form
    {
        int clickedButton = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickedButton = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickedButton = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickedButton = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (clickedButton)
            {
                case 1:
                    button1.BringToFront();
                    break;
                case 2:
                    button2.BringToFront();
                    break;
                case 3:
                    button3.BringToFront();
                    break;
                default:
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (clickedButton)
            {
                case 1:
                    button1.SendToBack();
                    break;
                case 2:
                    button2.SendToBack();
                    break;
                case 3:
                    button3.SendToBack();
                    break;
                default:
                    break;
            }
        }
        
    }
}
