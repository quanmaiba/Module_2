using System;
using System.Collections.Generic;
using System.Text;

namespace TestHouse
{
    class Person
    {
        private string name;
        private House house;

        public string Name { get => name; set => name = value; }
        internal House House { get => house; set => house = value; }

        public Person()
        {
            Name = "quan";
            House = new House(150);
        }
        public Person(string _name, House house)
        {
            Name = _name;
            House = house;
        }
        public void ShowData()
        {
            Console.WriteLine($"My name is {Name}.");
            house.ShowDta();
            house.Door.ShowData();

        }
        public void ShowData1()
        {
            Console.WriteLine($"My name is {Name}.");
            SmallApartment small = new SmallApartment();
            //small.ShowDta();
            house.ShowDta();
            house.Door.ShowData1();
        }
    }

}
