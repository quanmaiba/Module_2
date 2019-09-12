using System;

namespace _3D_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point3D[] points = new Point3D[1];

            points[0] = new Point3D(5, 7, -2);
            points[1] = new Point3D(-5, -7, -2);

            Console.WriteLine("Distance point1 with point2: " + points[0].DistanceTo(points[1]));
        }
    }
}
