using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void showinfcar(Car c1)
        {
            MessageBox.Show($"tedacharch:  {c1.charkhCount}\n" +
                $"tedaDoor:  {c1.DoorCount}\n speed: {c1.speed}\n dormoter:{c1.dormotor()}\n Color: {c1.color}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Car c = new Car(3,2,Color.Pink);
            c.speedd();
            c.speedd();
            c.speedd();

            showinfcar(c);






        }
    }
}
