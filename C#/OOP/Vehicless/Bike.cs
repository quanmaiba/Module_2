using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicless
{
    class Bike : Vehicels
    {
        private uint wheel;
      
        public uint Wheel { get => wheel; set => wheel = value; }
        
        public Bike() 
        {
            Wheel = 2 ;
        
        }
        public Bike(string make, string model, uint year, uint wheel) : base (make, model, year)
        {
            Wheel = wheel;
          
        }
        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"So banh: {Wheel}  id Bike: {Id} BIKE");
            Console.WriteLine("--------------------------------------");
        }
    }
}
