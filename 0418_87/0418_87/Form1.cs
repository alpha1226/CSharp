using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0418_87
{
    public partial class Form1 : Form
    {
        int[] style = new int[] { 0, 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.TopLeft;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.BottomRight;
        }


        private void UpdateFont()
        {
            System.Drawing.FontStyle style = System.Drawing.FontStyle.Regular;
            if (checkBox1.Checked) style |= System.Drawing.FontStyle.Bold;
            if (checkBox2.Checked) style |= System.Drawing.FontStyle.Italic;
            if (checkBox3.Checked) style |= System.Drawing.FontStyle.Underline;
            if (checkBox4.Checked) style |= System.Drawing.FontStyle.Strikeout;
            label3.Font = new Font(label3.Font, style);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }
    }
}
