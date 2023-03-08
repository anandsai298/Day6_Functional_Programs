using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class Febinocci_Series
    {
        public void Febinocci(int num)
        {
            int Fn = 0, Sn = 1, Tn = 0;
            Console.WriteLine("first no --> "+Fn + "\n" +"second no --> "+ Sn);
            for (int i=0;i<num;i++)
            {
                Tn = Fn + Sn;
                Console.WriteLine("Febonocci series of given" + num + "is : " + Tn);
                Fn = Sn;
                Sn = Tn;
            }
        }
    }
}
