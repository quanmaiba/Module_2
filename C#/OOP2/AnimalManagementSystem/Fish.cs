using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalManagementSystem
{
    class Fish : IMarineAnimal
    {
        private static int id = 30;
       
        private string name;
        private static int num = 1;
        private int age;
        private Fish fish;
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        
        public Fish()
        {

            id = ID + num;
            num++;
        }
        public override string ToString()
        {       
            return $"{base.GetType()} , id {ID}  , name: {Name} , Age: {Age} ";
        }

        public void Move()
        {
            Console.WriteLine("Swim");
        }
    }
}
