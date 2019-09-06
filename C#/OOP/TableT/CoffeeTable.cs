using System;
using System.Collections.Generic;
using System.Text;

namespace Table
{
    class CoffeeTable : Table
    {
      public CoffeeTable(double width ,double height)
        {
            Width = width;
            Height = height;
        }
        public override void ShowData()
        {
            Console.WriteLine($"(Coffee table) Width: {Width}, Heigth: {Height}");
        }

    }
}
