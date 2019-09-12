using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class TaphopAnimal
    {
        List<Animal> animals = new List<Animal>();

        public void add(Animal a)
        {
            if (a == null) Console.WriteLine("thieu du lieu");
           else animals.Add(a);

            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString()) ;
            }
        }
    }
}
