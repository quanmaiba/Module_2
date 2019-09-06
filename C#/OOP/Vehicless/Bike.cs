using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicless
{
    class Bike : Vehicels
    {
        private uint wheel;
        private int id;
        static int count = 0;

        public uint Wheel { get => wheel; set => wheel = value; }
        public int Id { get => id; set => id = value; }


        public Bike() 
        {
            Wheel = 2 ;
            count++;
            Id = count;
        }
        public Bike(string make, string model, uint year, uint wheel) : base (make, model, year)
        {
            Wheel = wheel;
            count++;
            Id = count;
        }
        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"So banh: {Wheel}  id Bike: {Id} BIKE");
            Console.WriteLine("--------------------------------------");
        }
    }
}
