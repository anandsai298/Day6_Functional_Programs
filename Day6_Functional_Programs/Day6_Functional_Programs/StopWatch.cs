﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Functional_Programs
{
    public class StopWatch
    {
        public void TimeLapse()
        {
            const string START="Start", STOP = "Stop";
            Console.WriteLine("Enter start to start the stopwatch");
            string Start = Console.ReadLine();
            TimeSpan timespan = TimeSpan.Zero;
            if (Start.Equals(START))
            {
                int hr1 = timespan.Hours;
                int min1 = timespan.Minutes;
                int sec1 = timespan.Seconds;
                int mill_sec1 = timespan.Milliseconds;
                Console.WriteLine("Enter Stop to stop the stopwatch ");
                string Stop = Console.ReadLine();
                if (Stop.Equals(STOP))
                {
                    int hr2 = timespan.Hours;
                    int min2 = timespan.Minutes;
                    int sec2 = timespan.Seconds;
                    int mill_sec2 = timespan.Milliseconds;
                    Console.WriteLine("stopwatch Time -->" + (hr2 - hr1) + ":" + (min2 - min1) + ":"+(sec2 - sec1) + ":" + (mill_sec2 - mill_sec1));
                }


            }
        }
    }
}
