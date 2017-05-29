using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a, b;
        char oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Values('+');
        }
        public void Values(char oper)
        {
            this.oper = oper;
            a = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + oper;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Values('-');
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Values('x');
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Values('/');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            if (oper == '+')
            {
                textBox1.Text = (a + b).ToString();

            }

            else if (oper == '-')
            {
                textBox1.Text = (a - b).ToString();

            }
            else if (oper == 'x')
            {
                textBox1.Text = (a * b).ToString();

            }
            else if (oper == '/')
            {
                textBox1.Text = (a / b).ToString();

            }
            else if (oper == '^')
            {
                textBox1.Text = (Math.Pow(a,b)).ToString();             
            }
            label1.Text += b.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = new double();
            b= new double();
            oper = new char();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = (Convert.ToDouble(textBox1.Text));
            textBox1.Text = (Math.Pow(a, 2)).ToString();
            label1.Text = a + "^2";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = (Convert.ToDouble(textBox1.Text));
            textBox1.Text = (Math.Sqrt(a)).ToString();
            label1.Text="Sqrt("+a+")";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Values('^');
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            label1.Text = a.ToString() + "!";
            for (double i = a-1; i > 1; i--)
            {
                a *= i;
            }
            textBox1.Text = a.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (1 / a).ToString();
            label1.Text = "1/" + a.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text); 
            b = (Convert.ToDouble(textBox1.Text))*Math.PI/180;
            textBox1.Text= (Math.Sin(b)).ToString();
            label1.Text = "sin("+a.ToString()+")";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = (Convert.ToDouble(textBox1.Text)) * Math.PI / 180;
            textBox1.Text = (Math.Cos(b)).ToString();
            label1.Text = "cos(" + a.ToString() + "°)";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = (Convert.ToDouble(textBox1.Text)) * Math.PI / 180;
            textBox1.Text = (Math.Tan(b)).ToString();
            label1.Text = "tan(" + a.ToString() + "°)";
        }
    }
}
