using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Rectangle> reclist = new List<Rectangle>();
            Shape shape = new Shape();
            shape.ToString();
            Rectangle rec = new Rectangle();
            rec.Side1 = Convert.ToInt32(Console.ReadLine());
            //rec.Side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(rec.Area());

            reclist.Add(rec);

            foreach (var rc in reclist)
            {
                rc.ToString();
            }
            //rec.Side1;
            Console.Write("nhapso: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Rectangle[] recn = new Rectangle[n];
            Random rd = new Random();

            for(int i =0; i < n; i++)
            {
                recn[i] = new Rectangle(rd.Next(30, 51), rd.Next(30, 51));
                recn[i].ToString();
            }

            for (int i = 0; i < n; i++)
            {
                Rectangle rec2 = new Rectangle();
                rec2.Side1 = Convert.ToDouble(Console.ReadLine());
                rec2.Side2 = Convert.ToDouble( Console.ReadLine());

                reclist.Add(rec2);
            }
            foreach (var rec1 in reclist)
            {
                rec1.ToString();
            }


        }
    }
    class Shape 
    {
        //Locatinon c = new Locatinon();

        //public Shape(double x,double y)
        //{
        //    c.x = x;
        //    c.y = y;
        //}
        //public static double Radius;
        public virtual void ToString()
        {
            Console.WriteLine("Shape"); 
        }
        //public  Shape(double n)
        //{
        //    Radius = (3.14 * n *  n);
        //}
        public virtual double Area()
        {
            return 0.0;
        }
        public double Perimeter()
        {
            return 0.0;
        }
       
    }
    class Rectangle : Shape
    {
        private double side1;
        //private double side2;
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get; set; }

        public override double Area()
        {
            return Side1 * Side2;
        }
        public Rectangle()
        {
            Side1 = 200;
            Side2 = 300;
        }
        public Rectangle(double w ,double h)
        {
            Side1 = w;
            Side2 = h;
        }
        public virtual void ToString()
        {
            Console.WriteLine($" chieu dai {Side1}  chie rong: {Side2}   dien tich: {Area()}");
        }

    }
    class Circle:Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius*3.14;
        }
    }
    class Locatinon
    {
        private static double x;
        private static double y;

        private static double X { get; set ; }
        private static double Y { get ; set ; }
    }


}
