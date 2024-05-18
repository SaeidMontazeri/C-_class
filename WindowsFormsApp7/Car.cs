using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    internal class Car
    {
        private int _charkhCount, _DoorCount, _speed;
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
            charkhCount = 5;
            DoorCount = 4;
            color = Color.White;
        }
        public Car(int charkhCount1, int doorCount)
        {
            charkhCount = charkhCount1;
            DoorCount = doorCount;
            color = Color.Blue;
        }
        public Car(int charkhCount1, int doorCount, Color col)
        {
            charkhCount = charkhCount1;
            DoorCount = doorCount;
            color = col;
        }
        public int dormotor()
        {
            return charkhCount * DoorCount;
        }

        public int speedd()
        {
            return _speed += 10; 
        }


    }
    }
