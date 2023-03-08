using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class Reverse_Number
    {
        public void Rev(int no)
        {
            int rev = 0;
            while(no>0)
            {
                int rem = no % 10;
                rev = (rev * 10) + rem;
                no /= 10;
            }
            Console.WriteLine("reverse of " + no + "-->" + rev);
        }
    }
}
