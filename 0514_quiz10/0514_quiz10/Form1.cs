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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            string msg = "MouseMoveApp : ("+mousePoint.X+","+mousePoint.Y+")";
            this.Text = msg;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            string msg = "MouseMoveApp : (" + mousePoint.X + "," + mousePoint.Y + ")";
            this.Text = msg;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            string msg = "MouseMoveApp : (" + mousePoint.X + "," + mousePoint.Y + ")";
            this.Text = msg;
        }
    }
}
