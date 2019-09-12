using System;
using System.Collections.Generic;
using System.Text;

namespace Table
{
    class Table
    {
        protected Leg leg;
        private double width;
        private double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        //public int leg1{ get; set; }

        public Table()
        {
            Width = 2;
            Height = 5; 
        }
        public  Table(double _width , double _height)
        {
            Width = _width;
            Height = _height;
        }

       
        public void AddLeg(Leg l)
        {
           
             leg = l;
            leg.SetTable(this);
        }
        public virtual void ShowData()
        {
            Console.WriteLine($" Chieu rong: {Width} , chieu cao: {Height} ");
        }
    }
}
