using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            string elapsedtime1;
            string elapsedtime2;

            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(250);
            crono1.Stop();
            crono2.Stop();

            //TimeSpan ts1 = crono1.Elapsed;
            //TimeSpan ts2 = crono2.Elapsed;

            //elapsedtime1 = String.Format("{0:f4}", ts1.Milliseconds);
            //elapsedtime2 = String.Format("{0:f4}", ts2.Milliseconds);

            Console.WriteLine($"{crono1.Elapsed.TotalMilliseconds / 1000:f4}");
            Console.WriteLine($"{crono2.Elapsed.TotalMilliseconds / 1000:f4}");
        }
    }
}
