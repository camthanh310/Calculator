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

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text != "" && txtSoB.Text != "")
            {
                double a = double.Parse(txtSoA.Text);
                double b = double.Parse(txtSoB.Text);
                double kq = a + b;
                txtKQ.Text = kq.ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text != "" && txtSoB.Text != "")
            {
                double a = double.Parse(txtSoA.Text);
                double b = double.Parse(txtSoB.Text);
                double kq = a - b;
                txtKQ.Text = kq.ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text != "" && txtSoB.Text != "")
            {
                double a = double.Parse(txtSoA.Text);
                double b = double.Parse(txtSoB.Text);
                double kq = a / b;
                txtKQ.Text = kq.ToString();
            }
        }
    }
}
