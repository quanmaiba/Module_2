using System;

namespace Zoo
{
    class Cat : Animal
    {
        public Cat(string name, int age, string description) : base(name, age, description)
        {
            Name = name;
            Description = description;
            Age = age;
        }
        public Cat(string name) : base(name)
        {
            Name = name;
        }
        public override void Speak()
        {
            Console.WriteLine("meo,meo");
        }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
    }
}
