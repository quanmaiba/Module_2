using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    class Shop 
    {   private static int count = 1;
        private static List<Product> listproduct = new List<Product>();

        internal static List<Product> Listproduct { get => listproduct; set => listproduct = value; }

        ////public Shop(string name , string description, double price) : base(name , description, price)
        ////{
        ////    Name = name;
        ////    Description = description;
        ////    Price = price;
        ////}

        public void AddProduct(Product product)
        {   
            listproduct.Add(product);

        }
        public void RemoveProduct(string name)
        {
            foreach(var item in listproduct)
            {
                if( string.CompareOrdinal(item.Name , name) == 0)
                {
                    listproduct.Remove(item);
                    break;
                }
            }
        }
        public void IterateProductList()
        {
            foreach(var item in listproduct)
            {
              
                item.ViewInfo();
                
            }
        }
        public void SearchProduct(double num1 , double num2 )
        {
            foreach(var item in listproduct)
            {
                //if (num1 < num2)
                
                    if (item.Price > num2 && item.Price < num1)
                    {
                        item.ViewInfo();
                    }
                
                //else
                //{
                //    if (item.Price < num2 && item.Price > num1)
                //    {
                //        item.ViewInfo();
                //    }
                //}
            }
        }
    }
}
