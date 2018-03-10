using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int itong = 0;
            itong = a + b;
            label1.Text = itong.ToString();

        }
    }
}
