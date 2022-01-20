using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Problem1
{
    class Point3D : ICloneable , IComparable
    {
        int x, y, z;

        public Point3D(int _X, int _Y, int _Z)
        {
            x = _X;
            y = _Y;
            z = _Z;
        }

        public Point3D(int _X, int _Y) : this(_X, _Y, 0)
        {
            ;
        }

        public Point3D(int _X) : this(_X, 0, 0)
        {
            ;
        }
        public Point3D() : this(0, 0, 0)
        {
            ;
        }

        public Point3D(Point3D pt) : this(pt.x, pt.y, pt.z)
        {
            ;
        }
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public object Clone()
        {
            return new Point3D(this);
        }

        public int CompareTo(object obj)
        {
            Point3D right = (Point3D)obj;
            return new PointCompare().Compare(this, right);
        }

        public static bool operator == (Point3D P, Point3D Pnt){
            return (P.x == Pnt.x) && (P.y == Pnt.y) && (P.z == Pnt.z);
        }

        public static bool operator !=(Point3D P, Point3D Pnt)
        {
            return !((P.x == Pnt.x) && (P.y == Pnt.y) && (P.z == Pnt.z));
        }

        public static explicit operator String(Point3D p)
        {
            return p.ToString();
        }
    }
}
