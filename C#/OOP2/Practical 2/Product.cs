using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    class Product
    {
        private string name;
        private string description;
        private double price;
        private List<int> rate;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }

        public Product()
        {

        }
        public Product(string name , string description,double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public void ViewInfo()
        {
            Console.WriteLine($"ten: {Name}  mo ta: {Description} gia: {Price}");
        }
     
    }
}
