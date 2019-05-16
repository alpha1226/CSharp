using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0514_quiz10
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //label1.Text = e.KeyChar.ToString();
            if (!Char.IsDigit(ch) && ch != '-' &&ch!=8)
            {
                e.Handled = true;
            }
        }
    }
}
