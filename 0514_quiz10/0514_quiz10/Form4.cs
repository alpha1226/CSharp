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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift == true && e.KeyCode != Keys.ShiftKey)
            {
                MessageBox.Show("Shift+" + e.KeyCode.ToString());
            }
            else if (e.Alt == true && e.KeyCode != Keys.Menu)
            {
                MessageBox.Show("Alt+" + e.KeyCode.ToString());
            }
            else if (e.Control == true && e.KeyCode != Keys.ControlKey)
            {
                MessageBox.Show("Control+" + e.KeyCode.ToString());
            }
            else if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.Menu || e.KeyCode == Keys.ControlKey) { }
            else
            {
                MessageBox.Show(e.KeyCode.ToString());
            }
        }
    }
}
