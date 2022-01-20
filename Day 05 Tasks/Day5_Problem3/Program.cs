using System;

namespace Day5_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  //Initial Testing//
            Duration d1 = new Duration(7800); //(1,10,15); //(3600); //(7800);
            // Console.WriteLine($"{d1.hours} {d1.minutes} {d1.seconds}");
            // Console.WriteLine(d1.ToString());
            Duration d2 = new Duration(3600); //(3600/3)*2;

            DateTime d = (DateTime)d1;

            Duration d3 = d1 + d2;
            Console.WriteLine(d3.ToString());
            Console.WriteLine(d);
            */

            Duration d1 = new Duration(10, 5, 20);

            Duration d2 = new Duration(5, 54, 40);
            Duration d3 = d1 + d2;
            Duration d4 = d1 + 7800;
            d1++;
            Duration d5 = d1;

            Duration d6 = --d1;

            Duration d10 = new Duration(666);
            if (d1.Equals(d2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (d1.Equals(d1))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d10);
        }   
    }
}
