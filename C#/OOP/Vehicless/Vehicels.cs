using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicless
{
    class Vehicels
    {
        private string make;
        private string model;
        private uint year;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public uint Year { get => year; set => year = value; }

        public Vehicels()
        {
            Make = "BMW";
            Model = "BMW2018";
            Year = 2015;
        }
        public Vehicels(string make , string model , uint year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void ToString()
        {
            Console.WriteLine($"Hang xe:{Make}, Doi xe: {Model} , Nam san xuat: {Year} ");
        }
    }
}
