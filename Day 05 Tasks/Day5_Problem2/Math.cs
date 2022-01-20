using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Problem2
{
    static class Math
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Divide(int n1, int n2)
        {
            if (n2 == 0) return -1;
            return n1 / n2;
        }
    }
}
