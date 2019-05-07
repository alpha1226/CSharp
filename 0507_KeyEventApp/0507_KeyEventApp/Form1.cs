using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0507_KeyEventApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int xPt, yPt;
        public static readonly int Move = 10;

        private void Button1_KeyUp(object sender, KeyEventArgs e)
        {
            this.xPt = this.button1.Location.X;
            this.yPt = this.button1.Location.Y;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    xPt -= Move; break;
                case Keys.Right:
                    xPt += Move; break;
                case Keys.Up:
                    yPt -= Move; break;
                case Keys.Down:
                    yPt += Move; break;
            }
            this.button1.Text = e.KeyCode.ToString();
            this.button1.Location = new Point(xPt, yPt);
        }
    }
}
