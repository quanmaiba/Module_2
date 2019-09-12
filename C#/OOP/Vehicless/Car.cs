using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicless
{
    class Car : Vehicels
    {
        private string type;
        private double speed;
        private uint wheel;
      
        public string Type { get => type; set => type = value; }
        public double Speed { get => speed; set => speed = value; }
        public uint Wheel { get => wheel; set => wheel = value; }
    
        public Car()
        {
            Type = "mui tran";
            Speed = 50;
            Wheel = 4 ;         
        }

        public Car(string type , double speed, uint wheel,string make , string model , uint year):base(make, model, year)
        {
            Type = type;
            Speed = speed;
            Wheel = wheel;
           
        }
        public override void ToString()
        {
            base.ToString();
            //Console.WriteLine($"he loai {Make}");
            Console.WriteLine($"The loai {type} , Toc do : {Speed}, So banh: {Wheel} id Car: {Id} CAR");
            Console.WriteLine("--------------------------------");
        }
    }

}
