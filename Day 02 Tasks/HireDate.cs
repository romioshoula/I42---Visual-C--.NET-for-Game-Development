using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Problem1
{
    public struct Date
    {
        int day, month, year;

        public Date(int d,int m,int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public int getDay()
        {
            return day;
        }

        public int getMonth()
        {
            return month;
        }

        public int getyear()
        {
            return year;
        }

    }
}
