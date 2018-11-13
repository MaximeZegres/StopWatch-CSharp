using System;
using System.Collections.Generic;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string [] args)
        {
            StopWatch stopWatch = new StopWatch();

            for (var i = 0; i < 1; i++)
            {
                stopWatch.Start(DateTime.Now);

                    for (var j = 0; j <= 500; j++)
                    {
                        Thread.Sleep(1);
                    }

                stopWatch.Stop(DateTime.Now);

                Console.WriteLine("Duration " + stopWatch.GetInterval().ToString());
                Console.ReadKey();
            }

        }


        

        



    }
}