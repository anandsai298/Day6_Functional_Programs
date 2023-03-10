// See https://aka.ms/new-console-template for more information
using Day6_Functional_Programs;
using System;
namespace Day5_Functional_Programs
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Day6_Functional_Programs");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1.Febinocci_Series \n2.Reverse_Number\n3.PerfectNumber\n4.Temperature_Converter\n5.Monthly_Payment\n6.Coupon\n7.StopWatch\n8.Vending_Machine\n9.Day_Of_Week\n10.Exit");
                Console.WriteLine("Enter your option to execute logic ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Febinocci_Series Fs = new Febinocci_Series();
                        Console.WriteLine("print Febinocci series");
                        Fs.Febinocci(5);
                        break;
                    case 2:
                        Reverse_Number rv = new Reverse_Number();
                        Console.WriteLine("print reverse number");
                        rv.Rev(12324);
                        break;
                    case 3:
                        PerfectNumber pn = new PerfectNumber();
                        Console.WriteLine("print perfect number or not");
                        pn.PerNo(28);
                        break;
                    case 4:
                        Temperature_Converter TC = new Temperature_Converter();
                        Console.WriteLine("coversion of Temperature c to F or F to c");
                        TC.Temp(100, 100);
                        break;
                    case 5:
                        Monthly_Payment P = new Monthly_Payment();
                        Console.WriteLine("Gives the Monthy payment of an loan amount");
                        P.Payment();
                        break;
                    case 6:
                        Coupon coup = new Coupon();
                        Console.WriteLine("gives the distint coupon numbers as num value");
                        coup.Distint_Coupon(7);
                        break;
                    case 7:
                        StopWatch sw = new StopWatch();
                        Console.WriteLine("timelapse of stopwatch");
                        sw.TimeLapse();
                        break;
                    case 8:
                        Vending_Machine change = new Vending_Machine();
                        Console.WriteLine("gives the change notes and count");
                        change.Get_Change(1010);
                        break;
                    case 9:
                        Day_Of_Week day_of_week = new Day_Of_Week();
                        Console.WriteLine("gives the Day of the week from your given date month year");
                        day_of_week.Day(1,1,2023);
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }
        }
    }
}