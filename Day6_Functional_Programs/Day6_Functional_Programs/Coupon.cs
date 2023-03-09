using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class Coupon
    {
        public void Distint_Coupon(int num)
        {
            int[] arr = new int[10];
            Random random = new Random();
            arr[0] = random.Next(0, num);
            for (int i=1;i<num;i++)
            {
                int coupon = random.Next(0, num);
                for (int j=0;j<i;j++)
                {
                    if (arr[j] != coupon)
                        arr[i] = coupon;
                }
                Console.WriteLine(arr[i]);
            }

        }
    }
}
