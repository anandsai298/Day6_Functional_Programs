using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class Day_Of_Week
    {
            //y0 = y − (14 − m) / 12
            //x = y0 + y0/ 4 − y0/ 100 + y0/ 400
            //m0 = m + 12 × ((14 − m) / 12) − 2
            //d0 = (d + x + 31m0/ 12) mod 7
        public void Day(int D,int M,int Y)
        {
            Console.WriteLine("enter date -->");
            D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Month -->");
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Year -->");
            Y = Convert.ToInt32(Console.ReadLine());
            int y0 = Y - (14 - M) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = M + 12 * ((14 - M) / 12) - 2;
            int d0 = (D + x + 31*m0/ 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine(d0 + "is a SUNDAY");
                    break;
                case 1:
                    Console.WriteLine(d0 + "is a MONDAY");
                    break;
                case 2:
                    Console.WriteLine(d0 + "is a TUESDAY");
                    break;
                case 3:
                    Console.WriteLine(d0 + "is a WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine(d0 + "is a THURSDAY");
                    break;
                case 5:
                    Console.WriteLine(d0 + "is a FRIDAY");
                    break;
                case 6:
                    Console.WriteLine(d0 + "is a SATURDAY");
                    break;
            }
        }
    }
}
