using System;
using System.Collections.Generic;

namespace AnimalManagementSystem
{
    class Program
    {   
        static Cat cat;
        static Fish fish;
        static Crocodile crocodile;
        static List<IAnimal> AnimalList = new List<IAnimal>();
        static string str;
        static int number;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //crocodile = new Crocodile();
            //Console.WriteLine(crocodile.ToString());
            Menu();
        }

        public static void Chay(int num)
        {
            switch (num)
            {
                case 1:
                    crocodile = new Crocodile();
                    crocodile.Name = "ca sau ";
                    crocodile.Age = 13;
                   
                    AnimalList.Add(crocodile);
                  
                    break;
                case 2:
                    cat = new Cat();
                    cat.Name = "meo ";
                    cat.Age = 16;
                  
                    AnimalList.Add(cat);
                    break;
                case 3:
                    fish = new Fish();
                    fish.Name = "ca";
                    fish.Age = 23;
                   
                    AnimalList.Add(fish);
                    break;
                case 4:
                   
                    foreach(var item in AnimalList)
                    {
                        if (item is IMarineAnimal)
                        {
                            Console.WriteLine($"{item.ToString()}");
                            item.Move();
                        }
                    }
                    break;
                case 5:

                    foreach (var item in AnimalList)
                    {
                        if (item is ITerrestrialAnimal)
                        {
                            Console.WriteLine($"{item.ToString()}");
                            item.Move();
                        }
                    }
                    break;
                case 6:
                    foreach(var item in AnimalList)
                    {                    
                        Console.WriteLine($"{item.ToString()}");
                        item.Move();
               
                    }
                    break;
                case 7:
                    str = Console.ReadLine();
                    while(!int.TryParse(str, out number) || number <0)
                    {
                        Console.Write("nhap lai");
                        str = Console.ReadLine();
                    }
                    foreach(var item in AnimalList)
                    {
                        if (item.ID == number)
                        {
                            AnimalList.Remove(item);
                            break;
                        }
                        Console.WriteLine(item.ToString());
                    }

                    break;
                case 8:
                    break;
                
                   
            }
            if (num != 8)
            {
                Menu();
            }
        }
        public static void Menu()
        {
            Console.WriteLine("chon");
            Console.WriteLine("1. Create a Crocodile");
            Console.WriteLine("2. Create a Cat");
            Console.WriteLine("3. Create a Fish");
            Console.WriteLine("4. View Terrestrial Animals");
            Console.WriteLine("5. View Marine Animals");
            Console.WriteLine("6. View All Animals");
            Console.WriteLine("7. Delete Animal");
            Console.WriteLine("8. Exit");
            Console.Write("chon so:");
            string str = Console.ReadLine();
            int num;

            while (!int.TryParse(str, out num) || num <= 0 || num >=9 )
            {
                Console.Write("nhap lai: ");
                Console.Clear();
                Menu();
                str = Console.ReadLine();
            }
            Chay(num);

        }
    }
    
}
