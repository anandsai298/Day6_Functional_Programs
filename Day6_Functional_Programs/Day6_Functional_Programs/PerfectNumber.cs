using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class PerfectNumber
    {
        public void PerNo(int numb)
        {
            int Res = 0;
            for (int i=1;i<numb;i++)
            {
                if (numb % i == 0)
                    Res += i;
            }
            if (Res == numb)
                Console.WriteLine(Res + " is a Perfect Number");
            else
                Console.WriteLine(Res + " is Not a Perfect Number");
        }
    }
}
