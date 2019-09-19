using System;

namespace Zoo
{
    class Program
    {
        static Cage cage;
        static Zoo zoo;
        static int cageNumber;
        static string str;
        static int choose;
        static int choose1;
        static Dog dog;
        static Cat cat;
        static Tiger tiger;
        static Animal animal;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Process(int choose)
        {
            zoo = new Zoo();

            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Add a new cage: ");
                        Console.Write("--- Enter the cage's number: ");
                        string str = Console.ReadLine();

                        while (!int.TryParse(str, out cageNumber))
                        {
                            Console.Write("Enter again! ");
                            str = Console.ReadLine();
                        }
                        MenuAnimal();


                        cage = new Cage(cageNumber);
                        zoo.AddAnimal(cage);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter the cage's number you want to remove: ");
                        string str = Console.ReadLine();

                        while (!int.TryParse(str, out cageNumber))
                        {
                            Console.Write("Enter again! ");
                            str = Console.ReadLine();
                        }
                        zoo.RemoveCage(cageNumber);
                    }
                    break;
                case 3:
                    {
                        Console.Write("Choose 'dog'(press 1), 'cat' (press 2) or 'tiger' (press 3) to add: ");
                        str = Console.ReadLine();
                        int child;
                        while (!int.TryParse(str, out child))
                        {
                            Console.Write("Enter again! ");
                            str = Console.ReadLine();
                        }
                        switch (child)
                        {
                            case 1:
                                Console.Write("Enter the name of dog: ");
                                string name = Console.ReadLine();

                                dog = new Dog(name);
                                cage.AddAnimal(dog);
                                break;
                            case 2:
                                Console.Write("Enter the name of cat: ");
                                name = Console.ReadLine();
                                cat = new Cat(name);
                                cage.AddAnimal(cat);
                                break;
                            case 3:
                                Console.Write("Enter the name of tiger: ");
                                name = Console.ReadLine();
                                tiger = new Tiger(name);
                                cage.AddAnimal(tiger);
                                break;
                            default:
                                Console.Write("Enter again! ");
                                str = Console.ReadLine();
                                break;
                        }
                    }
                    break;
                case 4:
                    {
                        Console.Write("Enter the name of animal you want to remove: ");
                        string name = Console.ReadLine();
                        cage.RemoveAnimal(name);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("\nIterate animal in the cage:");
                        Console.Write("Animal");
                        cage.IterateAnimals();
                    }
                    break;
                case 6:
                    Console.WriteLine("Exit.");
                    Environment.Exit(Environment.ExitCode);
                    break;
                default:
                    Console.WriteLine("Enter 1, 2, 3, 4 or 5: ");
                    Menu();
                    break;
            }
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("chon:");
            Console.WriteLine("1. Add cage");
            Console.WriteLine("2. Remove cage");
            Console.WriteLine("3. Add animal");
            Console.WriteLine("4. Remove animal");
            Console.WriteLine("5. Iterate Animals");
            Console.WriteLine("6. Exit");
            Console.WriteLine("\n----------------------------");

            str = Console.ReadLine();
            while (!int.TryParse(str, out choose))
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            Process(choose);
        }
        static void MenuAnimal()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("chon:");
            Console.WriteLine("1. Add Cat");
            Console.WriteLine("2. Add Dog");
            Console.WriteLine("3. Add Tiger");

            Console.WriteLine("6. Exit");
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("nhap so:");
            string str1 = Console.ReadLine();

            while (!int.TryParse(str1, out choose1))
            {
                Console.Write("Enter again! ");
                str1 = Console.ReadLine();
            }

            switch (choose1)
            {
                case 1:
                    Console.WriteLine("cho");
                    Console.Write("Enter the name of dog: ");
                    string name = Console.ReadLine();

                    dog = new Dog(name);
                    //dog.Name = "cho";
                    cage.AddAnimal(dog);
                    break;
            }
        }
    }
}
