using System;

namespace TestHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           

            SmallApartment smallApartment = new SmallApartment();
            Person person = new Person();

            person.Name = "Juan";
            person.House = smallApartment;
            person.ShowData();
            Console.WriteLine("--------------");

            House house1 = new House(500);
            //house1.ShowDta();
            Door door = new Door("vang");
            Person person1 = new Person("quan",house1);
            
            person1.ShowData1();
            //smallApartment.ShowDta();
            //door.ShowData();

        }
    }
}
