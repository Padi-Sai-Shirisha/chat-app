using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalPrj1
{
    public partial class Form1 : Form
    {
        public static string mem;
        string op;
        int x;
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            op = "+";


        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            op = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            op = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            op = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            try { 
            int y = Convert.ToInt32(textBox1.Text);
            int res = 0;
            if (op == "+")
            {
                res = x + y;
            }
            else if (op == "-")
            {
                res = x - y;
            }
            else if (op == "*")
            {
                res = x * y;
            }
            else if (op == "/")
            {
                res = x / y;
            }
            else
            {
                res = 0;
            }
            textBox1.Text = res.ToString();
        }

       catch (DivideByZeroException ex)
            {
                textBox1.Text = "Can't / by 0";
            }
            catch (Exception ex)
            {
                textBox1.Text = "Incorrect calculation";
            }
        }
        private void button17_Click(object sender, EventArgs e)
{
    string s = textBox1.Text;
    s = s.Substring(0, s.Length - 1);
    textBox1.Text = s;
}
private void button18_Click(object sender, EventArgs e)
{
    mem = textBox1.Text;
}

private void button20_Click(object sender, EventArgs e)
{
    if (mem == null)
    {
        textBox1.Text = "";
    }
    else
        textBox1.Text = mem;
}

private void button19_Click(object sender, EventArgs e)
{
    mem = null;
}
      
    }
}
    

