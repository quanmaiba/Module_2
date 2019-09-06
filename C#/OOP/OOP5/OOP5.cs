using System;

namespace OOP5
{
    class Program
    {
        //Location c ;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Square sq = new Square(2, 3, 4);
            Console.WriteLine(sq.Scale(2));
            Console.WriteLine(sq.ToString());
        }
    }
    class Shapes
    {
        public static string ToString1()
        {
            return "Shape";
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
    class Square:Shapes
    {
        Location C = new Location();
        public  Square(double _x ,double _y , double _side)
        {
            C.X = _x;
            C.Y = _y;
            C.Side = _side;
        }
       
        public void Move(double _x, double _y)
        {
            C.X = _x;
            C.Y = _y;
        }
        public  double Scale(double facfor)
        {
            return C.Side *=  facfor;
        }
        public string ToString()
        {
            return " Coner(" + C.X / 2 + "), side: " + C.Side;
        }
    }
    class Location
    {
        private double x;
        private double y;
        private double side;

        public double X { get =>x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Side { get => side; set => side = value; }
    }
}
