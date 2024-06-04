using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (
                double.TryParse(textBox1.Text, out double value ) &&
                double.TryParse(textBox2.Text,out double value2 ) &&
                optxt.Text != string.Empty
                ) 
            { 
                calButton.Enabled = true;
            }
        }

        private void optxt_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null , null);
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            string op = optxt.Text;
            ansLable.Visible = true;
            switch (op)
            {
                case "+": label1.Visible = true; ansLable.Text = (num1 + num2).ToString(); break;
                case "-": label1.Visible = true; ansLable.Text = (num1 - num2).ToString(); break;
                case "*": label1.Visible = true; ansLable.Text = (num1 * num2).ToString(); break;
                case "/": label1.Visible = true; ansLable.Text = (num1 / num2).ToString(); break;
                default: ansLable.Text = "عملگر درست را وارد کنید"; break;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            optxt.Text = string.Empty;
            label1.Visible = false;
            ansLable.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
