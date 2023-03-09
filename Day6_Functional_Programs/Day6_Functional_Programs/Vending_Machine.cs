using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class Vending_Machine
    {
        int[] Notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        public void Get_Change(int amount)//1010//10
        {
            int Count = 0;
            Console.WriteLine("notes change available");
            for (int i=0;i<Notes.Length;i++)
            {
                if (amount / Notes[i] >=1 && amount!=0)
                {
                    int change = amount / Notes[i];//1010/1000=1//10/10=1
                    Count += change;//1
                    Console.WriteLine(Notes[i] + "--->" + change);//1000 --> 1//10 --> 1
                    amount -= Notes[i] * change;//1010-1000=10//10-10=0
                }
            }
            Console.WriteLine("count of no of notes change -->" + Count);//1//2
        }
    }
}
