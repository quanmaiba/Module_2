using System;

namespace AnimalManagementSystem
{
    class Cat : Animal, ITerrestrialAnimal
    {
        public int id = 20;
        private string name;
        private int age;
        private static int num = 1;
        private Crocodile crocodile;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Cat()
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
            Console.WriteLine("Run");
        }

    }
}
