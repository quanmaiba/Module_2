using System;
using System.Collections.Generic;
using System.Text;

namespace Table
{
    class Table
    {
        private double width;
        private double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

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
        public virtual void ShowData()
        {
            Console.WriteLine($"Chieu rong: {Width} , chieu cao: {Height} ");
        }
    }
}
