using System;
using System.Collections.Generic;
using System.Text;

namespace Table
{
    class Leg : Table
    {
       Table table;
        public int Leg1 { get; set; }
        public Leg()
        {
            Leg1 = Leg1;
        }
        public  Leg(int leg1)
        {
            Leg1 = leg1;
        }
        public void SetTable(Table t)
        {
            table = t;
        }

        public override void ShowData()
        {
            Console.WriteLine("I am a leg");
            Console.WriteLine($"Chan:{Leg1} Chieu rong: {Width} , chieu cao: {Height} ");
        }
    }
}
