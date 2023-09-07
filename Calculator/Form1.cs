using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        string operation;
        string result;

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = ("");
            num1 = (0);
            num2 = (0);
        }

        private void buttonEqu_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            if (operation.Equals("+"))
                result = string.Format("{0}", num1 + num2);

            if (operation.Equals("-"))
                result = string.Format("{0}", num1 - num2);

            if (operation.Equals("*"))
                result = string.Format("{0}", num1 * num2);

            if (operation.Equals("/"))
            {
                if (num2 == 0)
                    result = "Can't divide by 0";
                else
                    result = string.Format("{0}", (decimal)num1 / num2);
            }

            textBox1.Text = result + "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
