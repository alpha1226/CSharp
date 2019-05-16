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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for(int i = progressBar1.Minimum; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value=i;
            }
        }
    }
}
