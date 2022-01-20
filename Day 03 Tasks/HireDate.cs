using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_Problem1
{
    public struct HireDate: IComparable
    {
        int day, month, year;

        public HireDate(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public int Day
        {
            get { return day; }
        }

        public int Month
        {
            get {return month; }
        }

        public int Year
        {
            get { return year; }
        }

        public int CompareTo(object obj)
        {
            HireDate right = (HireDate) obj;
            if (year> right.Year) return 1;
            else if (right.Year == year)
            {
                if (month > right.Month) return 1;
                else if (month==right.Month)
                {
                    return day.CompareTo(right.Day);
                }
                else return -1;
            }
            return -1;
        }
    }
}
