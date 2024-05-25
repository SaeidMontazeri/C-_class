using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Vanet:Car
    {
        int weight;
        public override int dormotor()
        {
            return charkhCount * DoorCount*2;
        }

        public override int speedd()
        {
            return _speed += 3;
        }
    }
}
