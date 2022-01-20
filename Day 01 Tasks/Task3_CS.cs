using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Tasks_CS_3
{
    class Task3_CS
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            int timing = 0;
            timer.Reset();
            timer.Start();
            int n = 8; //No. Digits
            // Eq: No. = n * 10 ^ (n-1)
            timing = (int)(n * Math.Pow(10, n-1));
            timer.Stop();
            Console.WriteLine("1 repeated {0} times in timer of {1}", timing, timer.Elapsed.ToString());
        }
    }
}
