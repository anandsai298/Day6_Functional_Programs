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
                Console.WriteLine("1.Febinocci_Series \n2.Exit");
                Console.WriteLine("Enter your option to execute logic ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Febinocci_Series Fs = new Febinocci_Series();
                        Fs.Febinocci(5);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}