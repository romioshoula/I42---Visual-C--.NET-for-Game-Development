using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Problem3
{
    class Duration
    {
        int hours;
        int minutes;
        int seconds;

        int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public Duration(int time)
        {
            int t = time;
            hours = t / (60 * 60);
            t %= (60 * 60);
            minutes = t / (60);
            t %= 60;
            seconds = t;
        }

        public Duration(int _h, int _m, int _s):
        this(((_h* (60 * 60)) + (_m* 60) + _s) > 0?(_h * (60 * 60) + (_m * 60) + _s):0)
        {
           ;
        }

     
        public override bool Equals(object obj)
        {
            Duration dur = (Duration)obj;
            return (dur.hours == hours) && (dur.minutes == minutes) && (dur.seconds == minutes);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            String str;
            if (hours > 0)
            {
                str = String.Format($"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}");
            }
            else
            {
                if (minutes > 0)
                {
                    str = String.Format($"Minutes: {minutes}, Seconds: {seconds}");
                }
                else
                {
                    if (seconds > 0)
                    {
                        str = String.Format($"Seconds: {seconds}");

                    }
                    else
                    {
                        str = String.Format($"Seconds: " + 0);
                    }
                }
            }
            return str;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.hours + d2.hours, d1.minutes + d2.minutes, d1.seconds + d2.seconds);

        }

        public static Duration operator +(Duration d1, int i)
        {

            Duration d2 = new Duration(i);
            return new Duration(d1.hours + d2.hours, d1.minutes + d2.minutes, d1.seconds + d2.seconds);

        }

        public static Duration operator +(int i, Duration d2)
        {
            Duration d1 = new Duration(i);
            return new Duration(d1.hours + d2.hours, d1.minutes + d2.minutes, d1.seconds + d2.seconds);

        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.hours, d.minutes + 1, d.seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.hours, d.minutes - 1, d.seconds);
        }

        public static Duration operator -(Duration d)
        {
            return new Duration(d.hours, d.minutes - 1, d.seconds);

            //return new Duration(d.hours * -1, d.minutes * -1, d.seconds * -1);
        }

        public static bool operator true(Duration d)
        {
            return !((d.hours == 0) && (d.minutes == 0) && (d.seconds == 0));
        }

        public static bool operator false(Duration d)
        {
            return ((d.hours == 0) && (d.minutes == 0) && (d.seconds == 0));
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1.hours > d2.hours) return true;
            else if (d1.hours == d2.hours)
            {
                if (d1.minutes > d2.minutes) return true;
                else if (d1.minutes == d2.minutes)
                {
                    if (d1.seconds >= d2.seconds) return true;

                }
            }
            return false;

        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1.hours < d2.hours) return true;
            else if (d1.hours == d2.hours)
            {
                if (d1.minutes < d2.minutes) return true;
                else if (d1.minutes == d2.minutes)
                {
                    if (d1.seconds <= d2.seconds) return true;

                }
            }
            return false;

        }

        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1.hours > d2.hours) return true;
            else if (d1.hours == d2.hours)
            {
                if (d1.minutes > d2.minutes) return true;
                else if (d1.minutes == d2.minutes)
                {
                    if (d1.seconds > d2.seconds) return true;

                }
            }
            return false;

        }

        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1.hours < d2.hours) return true;
            else if (d1.hours == d2.hours)
            {
                if (d1.minutes < d2.minutes) return true;
                else if (d1.minutes == d2.minutes)
                {
                    if (d1.seconds < d2.seconds) return true;

                }
            }
            return false;

        }

        public static explicit operator DateTime(Duration d)
        {
            try
            {
                DateTime dt = new DateTime(DateTime.Now.Year,
                    DateTime.Now.Month, DateTime.Now.Day, d.hours,d.minutes,d.seconds);
                return dt;
            }
            catch (Exception e)
            {
                return DateTime.Now;
            }
        }

    } 
}
