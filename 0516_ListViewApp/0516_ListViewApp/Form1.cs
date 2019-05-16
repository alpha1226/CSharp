﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ListView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                label1.Text = subItem[0].Text + "의 국가번호는 " + subItem[1].Text + "입니다.";
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                listView1.View = View.LargeIcon;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                listView1.View = View.SmallIcon;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                listView1.View = View.List;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                listView1.View = View.Details;
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                listView1.View = View.Tile;
        }

        
    }
}
