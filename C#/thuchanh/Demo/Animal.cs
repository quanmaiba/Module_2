using System;

namespace Demo
{
    abstract class Animal : IRunable, IBarkable
    {
        public string Name { get; set; }

        public virtual void Bar()
        {
            Console.WriteLine("");
        }

        public virtual void Run()
        {
            Console.WriteLine("");
        }
        abstract public void Speak();

    }
}
