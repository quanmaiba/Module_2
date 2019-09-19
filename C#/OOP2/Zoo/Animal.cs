using System;

namespace Zoo
{
    class Animal
    {
        private string name;
        private int age;
        private string description;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Description { get => description; set => description = value; }

        public Animal()
        {

        }
        public Animal(string name)
        {
            Name = name;
        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Animal(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
        }
        public virtual void ViewInfo()
        {
            Console.WriteLine($" ten: {Name} , mo ta: {Description} , tuoi: {Age}");
        }
        public virtual void Speak()
        {
            Console.WriteLine("hello");
        }
    }
}
