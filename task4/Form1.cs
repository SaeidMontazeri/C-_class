using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int snum = int.Parse(stxt.Text);
            int fnum = int.Parse(ftxt.Text);
            for (int i = snum; i <= fnum; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int snum = int.Parse(stxt.Text);
            int fnum = int.Parse(ftxt.Text);
            for (int i = snum; i <= fnum; i++)
            {
                if (i%3 == 0)
                    listBox2.Items.Add(i.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
