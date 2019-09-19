using System;
using System.Collections;

namespace Student
{
    class Program
    {
        public static Hashtable hashTable = new Hashtable();
        //public static Student student = new Student();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("chon");
            Console.WriteLine("1. Insert new Student");
            Console.WriteLine("2. View list of Student");
            Console.WriteLine("3. Search Student");
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
            Console.Clear();
            switch (num)
            {
                case 1:
                    InsertNews();
                    break;
                case 2:
                    ShowData();
                    break;
                case 3:
                    Console.WriteLine("Enter Class");
                    string clas = Console.ReadLine();
                    SearchStudent(clas);
                    break;
                case 4:
                    break;
            }
            Menu();
        }
        static void InsertNews()
        {
            Console.WriteLine("FullName,DateofBirth,Native,Class,PhoneNo,Mobile");
            string FullName = Console.ReadLine();
            string str = Console.ReadLine();
            DateTime DateofBirth;
            while (!DateTime.TryParse(str, out DateofBirth))
            {
                Console.WriteLine("nhap lai ");
                str = Console.ReadLine();
            }
            string Native = Console.ReadLine();
            string Class = Console.ReadLine();
            string str1 = Console.ReadLine();
            int PhoneNo;
            while (!int.TryParse(str1, out PhoneNo) || PhoneNo < 0)
            {
                Console.Write("Enter Again: ");
                str1 = Console.ReadLine();
            }
            string Mobile = Console.ReadLine();
            Student student = new Student(FullName, DateofBirth, Native, Class, PhoneNo, Mobile);

            hashTable.Add(student.ID, student);

        }
        static void ShowData()
        {
            if (hashTable != null)
            {
                foreach (Student item in hashTable.Values)
                {
                    item.Display();
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        static void SearchStudent(string clas)
        {
            if (hashTable != null)
            {
                foreach (Student item in hashTable.Values)
                {
                    if (clas.Equals(item.Class))
                    {
                        item.Display();

                    }
                }

                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
