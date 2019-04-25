using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mybutton1.Text = "코드에서 변경";
            mybutton1.Width = 100;

            for(int i=0; i<5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(13, 13 + (23 + 3) * i);
                button.Text = "동적생성" + i + "번째";
                button.Width = 100;
            }


        /*    Button button = new Button();
            Controls.Add(button);
            button.Location = new Point(13, 13 + 23 + 3);
            button.Text = "동적생성"; */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
