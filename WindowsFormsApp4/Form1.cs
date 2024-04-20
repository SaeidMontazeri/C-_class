using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double taghsim(int n1,int n2)
        {
            return Math.Round( (double)n1 / n2,4);
        }
        void taghsim1(int n1, int n2)
        {
            MessageBox.Show( (Math.Round((double)n1 / n2, 4)).ToString());
        }
        void taghsim2(int n1, int n2, ref double kh1, out int baghi1)
        {
            kh1 = Math.Round((double)n1 / n2,4);
            baghi1 = n1 % n2;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            txtSum.Text = (num1 + num2).ToString();
            double kh = 0;
            int baghi;
            taghsim2(num1, num2, ref kh, out baghi);
            txtkh.Text = kh.ToString();
            txtbaghi.Text = baghi.ToString();
            MessageBox.Show("kharj:  "+ kh.ToString()+"\n"+"baghi:  "+ baghi.ToString());
            MessageBox.Show(string.Format("kharj:{0}  \n  baghi:{1} " ,kh,baghi));
            MessageBox.Show($"kharj:{kh}  \n  baghi:{baghi} " );
            //taghsim1(num1, num2);
            //double kh= taghsim(num1, num2);
            // txtkh.Text = kh.ToString();

        }
    }
}
