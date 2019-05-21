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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
            setcolor(int.Parse(label3.Text), int.Parse(label4.Text), int.Parse(label5.Text));
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar2.Value.ToString();
            setcolor(int.Parse(label3.Text), int.Parse(label4.Text), int.Parse(label5.Text));
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar3.Value.ToString();
            setcolor(int.Parse(label3.Text), int.Parse(label4.Text), int.Parse(label5.Text));
        }


        public void setcolor(int r,int g, int b)
        {
            label2.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
