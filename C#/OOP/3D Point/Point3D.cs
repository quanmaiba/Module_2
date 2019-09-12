using System;
using System.Collections.Generic;
using System.Text;

namespace _3D_Point
{
    class Point3D
    {
        
        private double x, y, z;

        public Point3D(double x, double y, double z)
        {
            MoveTo(x, y, z);
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public void MoveTo(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double DistanceTo(Point3D p2)
        {
            return Math.Sqrt((x - p2.X * x - p2.X) +
            (y - p2.Y * y - p2.Y) + (z - p2.Z * z - p2.Z));
        }

        public override string ToString()
        {
            return "(" + x + "-" + y + "-" + z + ")";
        }
    }
}
