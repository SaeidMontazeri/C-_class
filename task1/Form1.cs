using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            string first_name = textBox1.Text;
            string last_name = textBox2.Text;
            string name = first_name + " " + last_name;
            if (name.Equals(" "))
                {
                textBox1.Focus();
            }
            else {
                helloLable.Text = "Hello " + name + " !"; 
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            helloLable.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloLable_MouseMove(object sender, MouseEventArgs e)
        {
            helloLable.ForeColor = Color.Red;
        }

        private void helloLable_MouseLeave(object sender, EventArgs e)
        {
            helloLable.ForeColor = Color.White;
        }
    }
}
