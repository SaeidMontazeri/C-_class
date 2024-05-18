using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = int.Parse(textBox1.Text);
            int a = int.Parse(textBox2.Text);
            int e11 = int.Parse(textBox3.Text);

            Mokab mo = new Mokab(t,a,e11);
            //int masahat1= mo.masahat();
            int ma = 0;
            int hh;
            mo.masahat_hajm(ref ma, out hh);
            MessageBox.Show(ma.ToString());
            MessageBox.Show(hh.ToString());
        }
    }
}
