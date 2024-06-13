using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database5DataSet.Entekhab_Vahed' table. You can move, or remove it, as needed.
            this.entekhab_VahedTableAdapter.Fill(this.database5DataSet.Entekhab_Vahed);

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Text = string.Empty;
            teacherTxt.Text = string.Empty;
            codeTxt.Text = string.Empty;
            timeTxt.Text = string.Empty;
            locationTxt.Text = string.Empty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            if (nameTxt.Text == string.Empty || codeTxt.Text == string.Empty)
                MessageBox.Show("موارد خواسته شده را وارد کنید");
            else 
            {
                DataTable dt = new DataTable();
                dt = entekhab_VahedTableAdapter.SearchByCode(int.Parse(codeTxt.Text));
                if (dt.Rows.Count > 0)
                    MessageBox.Show("کلاسی با چنین کد ارائه ای موجود است");
                else
                {
                    entekhab_VahedTableAdapter.InsertQuery(int.Parse(codeTxt.Text), nameTxt.Text, teacherTxt.Text, timeTxt.Text, locationTxt.Text);
                    entekhab_VahedTableAdapter.Fill(database5DataSet.Entekhab_Vahed);
                    MessageBox.Show("کلاس مورد نظر به لیست افزوده شد");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            teacherTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            codeTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            timeTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            locationTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (codeTxt.Text == string.Empty)
                MessageBox.Show("لطفا کد ارائه را وارد کنید");
            else
            {
                DataTable dt = new DataTable();
                dt = entekhab_VahedTableAdapter.SearchByCode(int.Parse(codeTxt.Text));
                if (dt.Rows.Count == 0)
                    MessageBox.Show("کلاس مورد نظر یافت نشد");
                else
                {
                    entekhab_VahedTableAdapter.DeleteQuery(int.Parse(codeTxt.Text));
                    entekhab_VahedTableAdapter.Fill(database5DataSet.Entekhab_Vahed);
                    MessageBox.Show("کلاس مورد نظر از لیست حذف شد");
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (codeTxt.Text == string.Empty)
                MessageBox.Show("لطفا کد ارائه را وارد کنید");
            else
            {
                DataTable dt = new DataTable();
                dt = entekhab_VahedTableAdapter.SearchByCode(int.Parse(codeTxt.Text));
                if (dt.Rows.Count == 0)
                    MessageBox.Show("کلاس مورد نظر یافت نشد");
                else
                {
                    entekhab_VahedTableAdapter.UpdateQuery
                        (
                            int.Parse(codeTxt.Text), 
                            nameTxt.Text,
                            timeTxt.Text,
                            teacherTxt.Text,
                            locationTxt.Text,
                            int.Parse(codeTxt.Text)
                        );
                    entekhab_VahedTableAdapter.Fill(database5DataSet.Entekhab_Vahed);
                    MessageBox.Show("کلاس مورد نظر ویرایش شد");
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (searchTxt.Text == string.Empty)
                MessageBox.Show("عبارت مورد نظر را وارد کنید");
            else
            {
                DataTable dt = new DataTable();
                switch (searchCombo.Text)
                {
                    case "کد ارائه": dt = entekhab_VahedTableAdapter.SearchByCode(int.Parse(searchTxt.Text)); break;
                    case "نام درس": dt = entekhab_VahedTableAdapter.SearchByName(searchTxt.Text); break;
                    case "نام استاد": dt = entekhab_VahedTableAdapter.SearchByTeacher(searchTxt.Text); break;
                    default: MessageBox.Show("عبارت مورد نظر در کدام دسته بندی جستجو شود؟"); break;
                }
                dataGridView1.DataSource = dt;
                MessageBox.Show("نتیجه جستجو در جدول به نمایش درآمد");
            }
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            dt = entekhab_VahedTableAdapter.SelectAll();
            dataGridView1.DataSource = dt;
            MessageBox.Show("همه کلاس ها در جدول به نمایش درآمد");

        }
    }
}
