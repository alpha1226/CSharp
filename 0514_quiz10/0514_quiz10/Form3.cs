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
    public partial class Form3 : Form
    {
        protected const int xNum = 5;
        protected const int yNum = 5;
        protected bool[,] abChecked = new bool[yNum, xNum];
        protected int cxBlock, cyBlock;

        private void Form3_Resize(object sender, EventArgs e)
        {
            cxBlock = ClientSize.Width / xNum;
            cyBlock = ClientSize.Height / yNum;
            Invalidate();
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X / cxBlock;
            int y = e.Y / cyBlock;
            if (x < xNum && y < yNum)
            {
                abChecked[y, x] ^= true;
                Invalidate(new Rectangle(x * cxBlock, y * cyBlock, cxBlock, cyBlock));
            }
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(ForeColor);
            for(int y = 0; y < yNum; y++)
            {
                for (int x = 0; x < xNum; x++)
                {
                    g.DrawRectangle(pen, x * cxBlock, y * cyBlock, cxBlock, cyBlock);
                    if (abChecked[y, x])
                    {
                        //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                        //System.Drawing.Graphics formGraphics;
                       // formGraphics = this.CreateGraphics();
                        //formGraphics.FillEllipse(myBrush, new Rectangle(x*cxBlock, y*cyBlock, cxBlock,cyBlock));
                        //myBrush.Dispose();
                       // formGraphics.Dispose();
                        g.DrawEllipse(pen, x * cxBlock, y * cyBlock, cxBlock, cyBlock);
                    }   
                }
            }
        }


        public Form3()
        {
            InitializeComponent();
        }
    }
}
