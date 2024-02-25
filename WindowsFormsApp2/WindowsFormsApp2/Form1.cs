using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum fasl
        { bahar,tabstan,paeiz,zemestan}

        private void btnShow_Click(object sender, EventArgs e)
        {
            //int tol, arz, mohit, masahat;
            //tol = int.Parse(txtTol.Text);
            //arz=Convert.ToInt32(txtArz.Text);
            //mohit = (tol + arz) * 2;
            //masahat = (tol * arz);
            //txtMohit.Text=mohit.ToString();
            //txtMasahat.Text=masahat.ToString();
            //------------------------
            //int[] a= new int[4];
            //a[0] = 12;
            //a[1] = 45;
            //a[2] = 1000;
            //a[3] = 2;
            //MessageBox.Show(a[2].ToString());
            //MessageBox.Show("آیا میخواهید حذف کنید؟", "اخطار", MessageBoxButtons.YesNoCancel);
            //---------------------------------
            //int[,] a = new int[2,3];
            //a[1,1] = 15;
            //a[0,2] = 72;
            //MessageBox.Show(a[1, 1].ToString());
            //----------------------
            int a;
            a = 11;
            fasl m;
            m=fasl.tabstan;
            // MessageBox.Show(m.ToString());
            //double x = 12.75;
            //MessageBox.Show(x.ToString());
            //int d=(int)x;
           // MessageBox.Show(d.ToString());
            fasl h;
            h = (fasl)2;
            MessageBox.Show(h.ToString());



        }
    }
}
