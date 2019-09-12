using System;
using System.Collections.Generic;
using System.Text;

namespace LuyenTap
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }

        public  void  ShowData()
        {
            Console.WriteLine($"Name: {Name}  Age: {Age}");
        }
        public override string ToString()
        {
            return /*"Name: " +*/ Name + " "+ /*"Age: " +*/ Age;
        }
    }
}
