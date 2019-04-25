using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0425_MEssageBoxButtonsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("MessagewBoxButtons", "TitleBar", MessageBoxButtons.OKCancel);
        }

        private void Form1_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("MessagewBoxButtons", "TitleBar", MessageBoxButtons.OKCancel);
        }
    }
}
