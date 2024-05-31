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

namespace QuestinDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //MessageBox.Show(dt.ToString("yyyy/MM/dd"));
            PersianCalendar pc = new PersianCalendar();
            string date = $"{pc.GetYear(dt).ToString()}/{pc.GetMonth(dt).ToString("00")}/{pc.GetDayOfMonth(dt).ToString("00")}";
            MessageBox.Show(date);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            int month = int.Parse(textBox2.Text);
            int day = int.Parse(textBox3.Text);
            DateTime dt = new DateTime (year, month, day);
            PersianCalendar pc = new PersianCalendar();
            string date = $"{pc.GetYear(dt).ToString()}/{pc.GetMonth(dt).ToString("00")}/{pc.GetDayOfMonth(dt).ToString("00")}";
            MessageBox.Show(date);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int year = int.Parse (textBox6.Text);
            int month = int.Parse (textBox5.Text);
            int day = int.Parse (textBox4.Text);
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime dt = new DateTime(year, month, day, pc);//(sal, mah, ruz,تقویم مبدا)
            MessageBox.Show(dt.ToString("yyyy/MM/dd"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int day = int.Parse(textBox7.Text);
            int month = int.Parse(textBox8.Text);
            int year = int.Parse(textBox9.Text);
            DateTime thatday = new DateTime(year, month, day);
            TimeSpan ts = today - thatday;
            MessageBox.Show(ts.Days.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int day = int.Parse(textBox10.Text);
            int month = int.Parse(textBox11.Text);
            int year = int.Parse(textBox12.Text);
            DateTime thatday = new DateTime(year, month, day);
            thatday = thatday.AddDays(7);
            MessageBox.Show(thatday.ToString("yyyy/MM/dd"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int day = int.Parse(textBox10.Text);
            int month = int.Parse(textBox11.Text);
            int year = int.Parse(textBox12.Text);
            DateTime thatday = new DateTime(year, month, day);
            thatday = thatday.AddDays(-7);
            MessageBox.Show(thatday.ToString("yyyy/MM/dd"));
        }
    }
}
