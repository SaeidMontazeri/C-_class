using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    internal class mostatil
    {
        int Tol;
       public int Arz;
        //non_default costructor
        public mostatil(int tol, int arz)
        {
            Tol = tol;
            Arz = arz;
        }
        public int mohit() 
        {
        return (Tol+Arz)*2;
        }
         int masahat()
        {
            return Tol * Arz;
        }
    }
}
