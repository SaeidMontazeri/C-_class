using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txt1.Text);
            int a = int.Parse(txt2.Text);
            mostatil mo = new mostatil(t, a);
            MessageBox.Show( mo.mohit().ToString());

        }
    }
}