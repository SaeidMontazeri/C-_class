using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int r, count = 0;
            //    int a = int.Parse(textBox1.Text);
            //    do
            //    {
            //        a = a / 10;
            //        count ++; //count=count+1;

            //    } while (a > 0) ;
            //        MessageBox.Show(count.ToString());
            //int a = int.Parse(textBox1.Text);
            //int b = int.Parse(textBox2.Text);
            //for (int i = a + 1; i < b; i++)

            //    MessageBox.Show(i.ToString());
            //listBox1.Items.Add(i);
            //int sum = 0;
            int[] a = new int[5] { 11,25,300,700,2};
            //foreach (int m in a)
            //    sum += m;//sum=sum+m;
            //MessageBox.Show(sum.ToString());
            //for (int i = 0 ; i <= 100; i++)
            //    if(i%2==0)
            //        listBox1.Items.Add(i);
            int m = 1;
            foreach ( int n in a)
                listBox1.Items.Add(m);

        }
    }
}
