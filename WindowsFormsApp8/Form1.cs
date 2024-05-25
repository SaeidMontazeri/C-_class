using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void howinfocar(Car  car)
        {
            MessageBox.Show($"charkhCount :{car.charkhCount} \n" +
$"DoorCount {car.DoorCount}\ncolor: {car.color}\n dormotor: {car.dormotor()}\n speed: {car.speedd()}\n ");
        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            Car c = new Car(5,4);
            //c.speedd();
            //c.speedd();            
            //howinfocar(c);
            int mo = 0;
            int ma;
            c.mohit_masahat(ref mo,out ma);
            MessageBox.Show($"mohit: {mo}\n masahat:{ma}");

        }

        private void btnVanet_Click(object sender, EventArgs e)
        {
            Vanet v = new Vanet();
            v.speedd();

            //howinfocar(v);


        }
    }
}
