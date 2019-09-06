using System;
using System.Collections.Generic;
using System.Text;

namespace TestHouse
{
    class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {

        }
        public override void ShowDta()
        {
            Console.WriteLine($"is a subclass of House, with a preset area of {Area} m2");
        }
    }

}