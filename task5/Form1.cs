using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            string [] books = new string [int.Parse(textBox2.Text)];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string[] books = new string[5];
            books[0] = textBox1.Text;
            books[1] = textBox2.Text;
            books[2] = textBox3.Text;
            books[3] = textBox4.Text;
            books[4] = textBox5.Text;
            foreach (string book in books)
            {
                MessageBox.Show(book, "کنترل کتاب ها");
            }
        }
    }
}
