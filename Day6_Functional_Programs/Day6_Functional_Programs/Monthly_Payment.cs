using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class Monthly_Payment
    {
        public void Payment()
        {
            Console.WriteLine("PRINCIPLE AMOUNT");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("NO OF YEARS");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("RATE OF INTEREST");
            double R = Convert.ToDouble(Console.ReadLine());
            double n = 12 * Y;
            double r = R / (12 * 100);
            double Pay = (P * r) / (1 - Math.Pow(1 + r, n * -1));
            Console.WriteLine("Monthy payment of an loan amount" + Pay);
        }
    }
}
