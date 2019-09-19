using System;
using System.Collections.Generic;

namespace Practical_2
{
    class Shop
    {
        private static int count = 1;
        private List<Product> listproduct = new List<Product>();

        internal List<Product> Listproduct { get => listproduct; set => listproduct = value; }

        ////public Shop(string name , string description, double price) : base(name , description, price)
        ////{
        ////    Name = name;
        ////    Description = description;
        ////    Price = price;
        ////}

        public void AddProduct(Product product)
        {
            if (product != null)
            {
                listproduct.Add(product);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
        public void RemoveProduct(string name)
        {
            foreach (var item in listproduct)
            {
                if (string.CompareOrdinal(item.Name, name) == 0)
                {
                    listproduct.Remove(item);
                    break;
                }
            }
        }
        public void IterateProductList()
        {
            foreach (var item in listproduct)
            {

                Console.WriteLine(item.ViewInfo());

            }
        }
        public void SearchProduct(double num1, double num2)
        {
            foreach (var item in listproduct)
            {
                if (item.Price > num2 && item.Price < num1)
                {
                    Console.WriteLine(item.ViewInfo());
                }

                else
                {
                    Console.WriteLine("Not Founds");
                }
            }
        }
    }
}
