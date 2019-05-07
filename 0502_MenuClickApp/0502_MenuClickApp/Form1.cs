using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0502_MenuClickApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 새파일NToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 미리보기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
    }
}
