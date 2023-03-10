using System;
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
            DateTime timespan=DateTime.Now;
            if (Start.Equals(START))
            {
                int hr1 = timespan.Hour;
                int min1 = timespan.Minute;
                int sec1 = timespan.Second;
                int mill_sec1 = timespan.Millisecond;
                Console.WriteLine("Enter Stop to stop the stopwatch ");
                string Stop = Console.ReadLine();
                if (Stop.Equals(STOP))
                {
                    DateTime timespan1 = DateTime.Now;
                    int hr2 = timespan1.Hour;
                    int min2 = timespan1.Minute;
                    int sec2 = timespan1.Second;
                    int mill_sec2 = timespan1.Millisecond;
                    Console.WriteLine("stopwatch Time -->" + (hr2 - hr1) + ":" + (min2 - min1) + ":"+(sec2 - sec1) + ":" + (mill_sec2 - mill_sec1));
                }


            }
        }
    }
}
