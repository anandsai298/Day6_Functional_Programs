using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class Temperature_Converter
    {
        public void Temp(double C,double F)
        {
            //Celsius to Fahrenheit: (°C × 9 / 5) +32 = °F
            //Fahrenheit to Celsius: (°F − 32) x 5 / 9 = °C
            C = Convert.ToDouble(Console.ReadLine());
            F = Convert.ToDouble(Console.ReadLine());
            double CTOF = (C * 9 / 5) + 32;
            double FTOC = (F - 32) * 5 / 9;
            Console.WriteLine("coversion of "+C+"Celsius to Fahrenheit ---> " + CTOF);
            Console.WriteLine("coversion of "+F+"Fahrenheit to oCelsius ---> " + FTOC);
        }
    }
}
