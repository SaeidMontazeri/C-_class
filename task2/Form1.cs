using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int ans = num1 + num2;
            ansLable.Text = $"جواب شما مساوی است با {ans}";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (
                int.TryParse(textBox1.Text, out int num1) &&
                int.TryParse(textBox2.Text, out int num2)
                ) 
            {
                SumButton.Enabled = true;
                subButton.Enabled = true;
                multiButton.Enabled = true;
                divButton.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int ans = num1 - num2;
            ansLable.Text = $"جواب شما مساوی است با {ans}";
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int ans = num1 * num2;
            ansLable.Text = $"جواب شما مساوی است با {ans}";
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("مخرج نمیتواند صفر باشد");
                textBox2.Text = "";
                textBox2.Focus();
                subButton.Enabled = false;
                SumButton.Enabled = false;
                divButton.Enabled = false;
                multiButton.Enabled = false;
            }
            else 
            {
                double ans = num1 / num2;
                ansLable.Text = $"جواب شما مساوی است با {ans}";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            ansLable.Text = string.Empty;
            textBox1.Focus();
            subButton.Enabled = false;
            divButton.Enabled = false;
            multiButton.Enabled = false;
            SumButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
