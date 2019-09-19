using System;

namespace Phone
{
    class Program
    {
        static string str;
        private static int num;
        private static int phone;
        private static PhoneBook phoneBook = new PhoneBook();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("1. Insert Phone");
            Console.WriteLine("2. Remove Phone");
            Console.WriteLine("3. Update Phone");
            Console.WriteLine("4. Search Phone ");
            Console.WriteLine("5. Sort");
            Console.WriteLine("6. Exit");
            Console.Write("Enter NUmber: ");
            str = Console.ReadLine();
            //int num;

            while (!int.TryParse(str, out num) || num < 1 || num > 7)
            {
                Console.Write("Enter Again: ");
                str = Console.ReadLine();
            }
            Play(num);
        }
        static void Play(int num)
        {
           
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter Name: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("Enter Phone: ");
                   int phone = Check();
                    phoneBook.InsertPhone(str, phone);
                    break;
                case 2:
                    Console.WriteLine("Enter Name: ");
                    str = Console.ReadLine();
                    phoneBook.RemovePhone(str);
                    break;
                case 3:
                    Console.WriteLine("Enter Name: ");
                    str = Console.ReadLine();
                    Console.WriteLine("Enter Phone Want Update: ");
                    phone = Check();
                    phoneBook.UpdatePhone(str,phone);
                    break;
                case 4:
                    Console.WriteLine("Enter Name: ");
                    str = Console.ReadLine();
                    phoneBook.SearchPhone(str);
                    break;
                case 5:
                    phoneBook.Sort();
                    break;
                case 6:
                    phoneBook.Show();
                    break;
                case 7:
                    break;
            }
            Menu();
        }
        static int Check()
        {
            int num;
            str = Console.ReadLine();
            while (!int.TryParse(str, out num) || num < 0)
            {
                Console.WriteLine("Enter Again: ");
                str = Console.ReadLine();
            }
            return num;
        }
    }
}
