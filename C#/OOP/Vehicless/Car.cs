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
        private int id;
        static int count = 0;

        public string Type { get => type; set => type = value; }
        public double Speed { get => speed; set => speed = value; }
        public uint Wheel { get => wheel; set => wheel = value; }
        public int Id { get => id; set => id = value; }

        public Car()
        {
            Type = "mui tran";
            Speed = 50;
            Wheel = 4 ;
            count++;
            Id = count;
            
        }

        public Car(string type , double speed, uint wheel)
        {
            Type = type;
            Speed = speed;
            Wheel = wheel;
            count++;
            Id = count;
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
