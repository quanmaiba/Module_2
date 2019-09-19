using System;
using System.Collections;

namespace NewManagement
{

    class Program

    {
        public static Hashtable hashTable = new Hashtable();
        public static New news = new New();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("chon");
            Console.WriteLine("1. Insert new");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Average rate");
            Console.WriteLine("4. Exit");
            Console.Write("chon so:");
            string str = Console.ReadLine();
            int num;

            while (!int.TryParse(str, out num) || num < 0 || num > 4)
            {
                Console.Write("nhap lai: ");
                str = Console.ReadLine();
            }
            Chay(num);
        }
        static void Chay(int num)
        {
            switch (num)
            {
                case 1:
                    InsertNews();
                    break;
                case 2:
                    ShowData();
                    break;
                case 3:
                    ShowData();
                    break;
                case 4:
                    break;
            }
            Menu();
        }
        static void ShowData()
        {
            if (hashTable != null)
            {

                foreach (New item in hashTable.Values)
                {
                    item.Display();
                }
            }
        }
        static void InsertNews()
        {
            Console.WriteLine("nhap tieu de,ngay thang,tac gia,noi dung");
            string Title = Console.ReadLine();
            string str = Console.ReadLine();
            DateTime PublishDate;
            while (!DateTime.TryParse(str, out PublishDate))
            {
                Console.WriteLine("nhap lai ");
                str = Console.ReadLine();
            }
            string Author = Console.ReadLine();
            string Content = Console.ReadLine();


            New news = new New(Title, PublishDate, Author, Content);


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("danh gia " + (i + 1));
                str = Console.ReadLine();
                news.Ratelist.Add(Gate(str));
            }
            hashTable.Add(news.ID, news);

        }
        static int Gate(string str)
        {
            int num;
            while (!int.TryParse(str, out num) || num < 1 || num > 3)
            {

                Console.WriteLine("nhap lai");
                str = Console.ReadLine();
            }
            return num;
        }

    }
}
