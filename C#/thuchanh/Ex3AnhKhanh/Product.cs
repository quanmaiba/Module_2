using System;
using System.Collections.Generic;

namespace Practical_2
{
    class Product
    {
        private string name;
        private string description;
        private double price;
        private static int number = 0;
        private static int number1 = 0;
        private string id;
        private List<int> rate = new List<int>();

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public string ID { get => id; set => id = value; }

        public Product()
        {

            number1++;
            id = $@"Files/product{ID + number1}.txt";
        }
        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            number++;
            id = $"product{ID + number}.txt";

        }
        public string ViewInfo()
        {
            return $"id: {ID} ten: {Name}  mo ta: {Description} gia: {Price}";
        }
        public void AddRate(int star)
        {
            if (star < 0 || star > 5)
            {
                Console.WriteLine("loi");
                return;
            }
            rate.Add(star);
        }

    }
}
