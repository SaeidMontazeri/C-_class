using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp6
{
    internal class Mokab
    {
        int Tol;
        int Arz;
        public int Ertefa;

        public Mokab()
        {
            Tol = 8;
            Arz=2;
            Ertefa = 10;        
        }
        public Mokab(int t1, int a1, int e1)
        {
            Tol = t1;
            Arz= a1;
            Ertefa= e1;
        
        }
        public void masahat_hajm(ref int ma1, out int hh1)
        { 
            ma1=Tol*Arz;
            hh1= Tol*Arz*Ertefa;
        
        }

        public int masahat()
        { 
        return Tol*Arz;
        }

        public int Hajm() 
        {
        return Tol*Arz* Ertefa;
        }
    }
}
