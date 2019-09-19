using System;
using System.IO;


namespace Practical_2
{
    class Program
    {
        private static Shop shop = new Shop();
        private static Product product;
        private static StreamWriter sw;

        //static string path = product.ID;
        //private static string path1 = path;
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
            Console.WriteLine("4. Search product and Edit ");
            Console.WriteLine("5. Ghi File");
            Console.WriteLine("6. Exit");
            Console.Write("chon so:");
            string str = Console.ReadLine();
            int num;

            while (!int.TryParse(str, out num) || num < 0 || num > 6)
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

                    Console.WriteLine("1. Add new product");
                    Console.Write("nhap ten: ");
                    string Name = Console.ReadLine();

                    Console.Write("nhap mo ta: ");
                    string Description = Console.ReadLine();
                    Console.Write("nhap gia: ");
                    string str1 = Console.ReadLine();
                    int numprice;
                    while (!int.TryParse(str1, out numprice) || numprice < 0 || numprice >= 100)
                    {
                        Console.Write("nhap lai: ");
                        str1 = Console.ReadLine();
                    }
                    int Price = numprice;
                    product = new Product(Name, Description, Price);
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
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("nhap gia den :");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    shop.SearchProduct(num1, num2);

                    break;
                case 5:
                    int count = shop.Listproduct.Count;
                    for (int i = 0; i < count; i++)
                    {
                        product = new Product();
                        string path = product.ID;
                        using (sw = new StreamWriter(path))
                        {
                            sw.Write(shop.Listproduct[i].ViewInfo());
                        }
                    }

                    break;
                case 6:
                    break;

            }
            Menu();
        }
    }
}
