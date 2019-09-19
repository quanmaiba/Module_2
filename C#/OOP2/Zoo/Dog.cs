using System;

namespace Zoo
{
    class Dog : Animal
    {
        public Dog(string name, int age, string description) : base(name, age, description)
        {
            Name = name;
            Description = description;
            Age = age;
        }
        public Dog(string name) : base(name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine("wo,wo");
        }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
    }
}
