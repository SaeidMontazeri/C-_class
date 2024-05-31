using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionHalqe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Minimom(int one, int two, int three, int four)
        {
            int[] nums = new int[4];
            nums[0] = one; nums[1] = two; nums[2] = three; nums[3] = four;
            int min = nums[0];
            foreach (int num in nums) 
            { 
                if (num < min) 
                    min = num;
            }
            return min;
        }
        
        int dig (int n) 
        {
            int s = 0;
            while (n > 0)
            {
                s += 1;
                n /= 10;
            }
            return s;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            MessageBox.Show($"minimum is: {Minimom(a, b, c, d)} !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox5.Text);
            MessageBox.Show($"this number has {dig(num)} digits!");
        }
    }
}
