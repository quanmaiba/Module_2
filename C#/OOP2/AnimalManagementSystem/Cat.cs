using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalManagementSystem
{
    class Cat : ITerrestrialAnimal
    {
        private static int id = 20;
        private string name;
        private static int num = 1;
        private int age;
        private Cat cat;
        public   int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
      
        public Cat()
        {
           
            id = ID + num;
             num++;
        }
        public override string ToString()
        {
            return $"{base.GetType()} , id {id}  , name: {Name} , Age: {Age}  ";

        }

        public void Move()
        {
            Console.WriteLine("Run");
        }
    }
}
