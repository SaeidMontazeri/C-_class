using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Car
    {
        private int _charkhCount, _DoorCount;
        protected int _speed;
        public Color color;
         
        public int charkhCount
        {
            get
            {
                return _charkhCount;
            }
            set
            {
                if (value >= 2 && value <= 6)
                    _charkhCount = value;
            }
        }
        public int DoorCount
        {
            get
            {
                return _DoorCount;
            }
            set
            {
                if (value >= 2 && value <= 4)
                    _DoorCount = value;
            }

        }
        public int speed
        {
            get
            {
                return _speed;
            }
        }
        public Car()
        {
            charkhCount = 4;
            DoorCount = 3;
            color = Color.White;
        }
        public Car(int charkhCount1, int doorCount)
        {
            charkhCount = charkhCount1;
            DoorCount = doorCount;
            color = Color.Green;
        }
        public Car(int charkhCount1, int doorCount, Color col)
        {
            charkhCount = charkhCount1;
            DoorCount = doorCount;
            color = col;
        }
        public virtual int dormotor()
        {
            return charkhCount * DoorCount;
        }

        public virtual int speedd()
        {
            return _speed += 10;
        }
        public void mohit_masahat(ref int mo1,out int ma1)
        {
            mo1=(charkhCount + DoorCount)*2;
            ma1= charkhCount * DoorCount;

        }

    }

}

