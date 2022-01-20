using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem1
{
    class PointCompare : IComparer<Point3D>
    {
        public int Compare(Point3D p1, Point3D p2)
        {
            if (p1.X < p2.X) { return -1; }
            else if (p1.X == p2.X)
            {
                if (p1.Y < p2.Y) return -1;
                else if (p1.Y > p2.Y) return 1;
                else return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
