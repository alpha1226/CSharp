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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public int index = 0;
        

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }
        
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            index %= imageList1.Images.Count;
            label1.Image = imageList1.Images[index++];
        }
    }
}
