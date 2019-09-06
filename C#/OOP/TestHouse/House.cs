using System;
using System.Collections.Generic;
using System.Text;

namespace TestHouse
{
    class House
    {
        private double area;
        private double area1;
        private Door door;

        public double Area { get => area; set => area = value; }
        internal Door Door { get => door; set => door = value; }
        public double Area1 { get => area1; set => area1 = value; }

        public House()
        {
            Area = 200;
        }
        public House(double num)
        {
            Area = num;
            Door = new Door();
        }
        public  virtual void ShowDta()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2");
        }
    }
}
