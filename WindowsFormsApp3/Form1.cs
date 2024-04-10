using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt1.Text);
            if (a % 7 == 0)
            {
                int r = Convert.ToInt32(txt2.Text);
                float mohit, masahat;
                mohit = 2 * 3 * r;
                masahat = r * r * 3;
                //MessageBox.Show("mohit: "+mohit.ToString()+"\n"+"masahat: "+masahat.ToString()) ;
                //string.Format("mohit:{0}\n masahat:{1}", mohit, masahat);
                MessageBox.Show($"mohit:{mohit}\nmasahat:{masahat}");
            }
            else
            {
                int x = Convert.ToInt32(txt3.Text);
                int y= Convert.ToInt32(txt4.Text);
                int sum = 0;
                for(int i = x; i <= y; i++)
                {
                    if (i % 2 == 0)
                        sum += i;
                }
                MessageBox.Show("sum is: "+sum.ToString());
            }
        }
    }
}
