using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button10_Click_1(object sender, EventArgs e)
        { 
            if (N2)
            {
                N2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
                if (D == "-")
                {
                    res = dn1 - dn2;
                }
                if (D == "X")
                {
                    res = dn1 * dn2;
                }
                if (D == "/")
                {
                    res = dn1 / dn2;
                }
                D = "=";
                N2 = true;
                textBox1.Text = res.ToString();     
            }

        private void button18_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn,2);
            textBox1.Text = res.ToString();
        }
    }
    }

