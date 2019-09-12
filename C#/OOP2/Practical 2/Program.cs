using System;

namespace Practical_2
{
    class Program
    {
      private static Shop shop = new Shop();
        private static Product product;
        static void Main(string[] args)
        {
       
            Menu();
      
        }
        public static void Menu()
        {
           
            Console.WriteLine("chon");
            Console.WriteLine("1. Add new product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Iterate product list");
            Console.WriteLine("4. Search product");
            Console.WriteLine("5. Exit");
            Console.Write("chon so:");
            string str = Console.ReadLine();
            int num;

            while (!int.TryParse(str, out num) || num < 0 || num >5)
            {
                Console.Write("nhap lai: ");
                str = Console.ReadLine();
            }
            Chay(num);
            
        }
        public static void Chay(int num)
        {
            
            switch (num)
            {
                case 1:
                    product = new Product();
                    Console.WriteLine("1. Add new product");
                    Console.Write("nhap ten: ");
                    product.Name = Console.ReadLine();
                  
                    Console.Write("nhap mo ta: ");
                    product.Description = Console.ReadLine();
                    Console.Write("nhap gia: ");
                    string str1 = Console.ReadLine();
                    int numprice;
                    while (!int.TryParse(str1, out numprice) || numprice < 0 || numprice >= 100)
                    {
                        Console.Write("nhap lai: ");
                        str1 = Console.ReadLine();
                    }
                    product.Price = numprice;
                    shop.AddProduct(product);
                    break;
                case 2:
                    string str = Console.ReadLine();
                    shop.RemoveProduct(str);
                    break;
                case 3:
                    shop.IterateProductList();
                   
                    break;
                case 4:
                    Console.Write("nhap gia khoang:");
                    double num1 = Convert.ToDouble( Console.ReadLine());
                    Console.Write("nhap gia den :");
                    double num2 = Convert.ToDouble( Console.ReadLine());

                    shop.SearchProduct(num1,num2);

                    break;
                case 5:
                    break;
                
            }
            if (num != 5)
            {
                Menu();
            }
        }
    }
}
