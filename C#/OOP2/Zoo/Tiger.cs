using System;

namespace Zoo
{
    class Tiger : Animal
    {
        public Tiger(string name, int age, string description) : base(name, age, description)
        {
            Name = name;
            Description = description;
            Age = age;
        }
        public Tiger(string name) : base(name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine("ta la ho day");
        }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
    }
}
