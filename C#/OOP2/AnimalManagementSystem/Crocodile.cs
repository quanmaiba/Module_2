using System;

namespace AnimalManagementSystem
{
    class Crocodile : Animal, IMarineAnimal, ITerrestrialAnimal
    {
        public int id = 10;
        private string name;
        private int age;
        private static int num = 1;
        private Crocodile crocodile;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Crocodile()
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
            Console.WriteLine("Run & Swim");
        }

    }
}
