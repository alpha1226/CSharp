using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0502_RadioGroup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GroupBox groupBox1 = new GroupBox();
            GroupBox groupBox2 = new GroupBox();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            RadioButton radio5 = new RadioButton();
            Button button = new Button();

            groupBox1.Text = "식물";
            groupBox2.Text = "물고기";

            radio1.Text = "감자";
            radio2.Text = "고구마";
            radio3.Text = "광어";
            radio4.Text = "우럭";

            button.Text = "클릭";

            groupBox1.Size = new Size(120, 100);
            groupBox2.Size = new Size(120, 100);

            groupBox1.Location = new Point(10, 100);
            groupBox2.Location = new Point(150, 100);

            radio1.Location = new Point(10, 10);
            radio2.Location = new Point(10, 40);
            radio3.Location = new Point(10, 10);
            radio4.Location = new Point(10, 40);
            button.Location = new Point(10, 70);

            button.Click += ButtonClick;

            groupBox1.Controls.Add(radio1);
            groupBox1.Controls.Add(radio2);
            groupBox2.Controls.Add(radio3);
            groupBox2.Controls.Add(radio4);
            Controls.Add(button);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
        }

        private void ButtonClick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
