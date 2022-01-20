using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Tasks_CS
{
    class Task1_CS
    {
        static void Main(string[] args)
        {
            int[] Arr;
            Console.WriteLine("Please Enter Size Of Array");
            int ArrSize = Convert.ToInt32(Console.ReadLine());
            Arr = new int[ArrSize];
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("enter value ( " + i + ", " + (ArrSize-1) + ") :");
                Arr[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            int n = 0;
            int n1 = 0;
            int cell = 0;
            for (int x = 0; x < Arr.Length; x++)
            {
                //   Console.WriteLine(Arr[x]); //Draw the array after input

                for (int j = x + 1; j < Arr.Length; j++)
                {
                    if (Arr[x] == Arr[j])
                    {
                        n = j;
                    }
                    n1 = x;
                    if (n - n1 > max)
                    {
                        max = n - n1;
                    }

                }
            }
            cell = Arr[n1-1]; //save cell
            Console.WriteLine("Max dist between two cells is: ");
            Console.WriteLine(max - 1);
            Console.WriteLine("The cell is: ");
            Console.WriteLine(cell);
            //int OP=0;
            //OP= int.Parse(Console.ReadLine());
            Console.ReadLine(); //Pause for enter to close
        }
    }
}
