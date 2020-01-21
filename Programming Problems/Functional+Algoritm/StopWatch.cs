using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
     public class StopWatch
    {

        public void SW()
        {
            DateTime Dt =DateTime.Now;
            DateTime Dt1 = DateTime.Now;
            //time the stopwatch started
            int start_Hour =Dt.Hour;
            int start_Min = Dt.Minute;
            int Start_sec = Dt.Second;
            int Start_millisec = Dt.Millisecond;
            Console.WriteLine("press key k to endtime");
            string endString = Console.ReadLine();
            if (endString == "k")
            {
                //time the stopwatch stopped
                int stopped_Hour = Dt1.Hour;
                int end_min = Dt1.Minute;
                int end_sec = Dt1.Second;
                int end_millisec = Dt1.Millisecond;
                Console.WriteLine("Elapsed time :-" + (stopped_Hour-start_Hour) + ":" + (end_min- start_Min) + ":" + (end_sec - Start_sec) + ":" + (end_millisec-Start_millisec));
            }

        }
    }
}
