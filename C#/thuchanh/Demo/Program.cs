using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Animal> listAnimal = new List<Animal>();

            //Dog dog = new Dog();
            //listAnimal.Add(dog);



            //foreach (var item in listAnimal)
            //{
            //    Console.WriteLine(item.ToString()); 
            //}
            string str = "Hello";

            Console.WriteLine(str);
            TaphopAnimal animaltaphop = new TaphopAnimal();
            Dog dog = new Dog();
            dog.Name = "cho";
            //dog.Name = "hi";
            animaltaphop.add(dog);
        }
    }
}
