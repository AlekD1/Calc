using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProj;

namespace Calc
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool N2;

        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (N2)
            {
                N2 = false;
                textBox1.Text = "";
            }
            Button B = (Button)sender;
            textBox1.Text = textBox1.Text + B.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double dn1, dn2,res;
            res = 0;
            dn1 =  Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D=="+")
            {
                res = MyLibrary.Sum(dn1, dn2);
            }
            if (D == "-")
            {
                res = MyLibrary.Sub(dn1, dn2);
            }
            if (D == "*")
            {
                res = MyLibrary.Mul(dn1, dn2);
            }
            if (D == "/")
            {
                res = MyLibrary.Div(dn1, dn2);
            }
            D = "";
            N2 = true;
            textBox1.Text = res.ToString();

        }

    }
}
