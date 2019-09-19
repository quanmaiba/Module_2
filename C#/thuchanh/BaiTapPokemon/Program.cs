using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BaiTapPokemon
{
    class Program
    {
        private static List<Pokemon> PokemonList = new List<Pokemon>();
        private static string str;
        private static int num;
        private static Pokemon pokemon;
        //private StreamWriter sw;
        private static string path = "D:/pokemon/pokemon.json";
        private static RootObject o;
        static void Main(string[] args)
        {
            Menu();
            Read();
        }
        public static void Menu()
        {

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("       1. Add new Pokemon                 ");
            Console.WriteLine("       2. Iterate Pokemon list            ");
            Console.WriteLine("       3. Search ID show Pokemon          ");
            Console.WriteLine("       4. Search ID Pokemon and Edit      ");
            Console.WriteLine("       5. Show Sound Pokemon              ");
            Console.WriteLine("       6. Return Pokemon and Ratting      ");
            Console.WriteLine("       7. Write File                      ");
            Console.WriteLine("       8. Read File                       ");
            Console.WriteLine("       9. Exit                            ");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter number: ");
            string str = Console.ReadLine();
            int num;


            while (!int.TryParse(str, out num) || num < 0 || num > 9)
            {
                Console.Write("nhap lai: ");
                str = Console.ReadLine();
            }
            Play(num);

        }
        public static void Play(int num)
        {
            Console.Clear();

            switch (num)
            {
                case 1:
                    AddPokemon();
                    WriteFile();
                    Save();
                    break;
                case 2:
                    View();
                    break;
                case 3:
                    View();
                    Console.Write("Enter ID: ");
                    Console.WriteLine(SearchIDshowPokemon());
                    break;

                case 4:
                    View();
                    Console.Write("Enter Id: ");
                    EditPokemon();
                    WriteFile();
                    Save();
                    break;
                case 5:
                    View();
                    ShowSound();
                    break;
                case 6:
                    View();
                    Console.WriteLine(ReturnPokemonandRatting());

                    break;
                case 7:
                    View();
                    WriteFile();
                    Save();
                    break;
                case 8:
                    Read();
                    break;
                case 9:
                    break;
            }
            Menu();
        }
        public static void AddPokemon()
        {
            Console.WriteLine("1. Add new Pokemon");
            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Type: ");
            Console.WriteLine("Type: 1. Normal ,2. Water,3. Grass,4. Fire,5. Electric,6. Ghost ,7. Dragon,8. Rock,9. Ice,10. Bug,11. Posion ,12. Exit");
            Console.Write("Enter number of element : ");

            int num = CheckType();
            List<string> Type = Pokemon.ChooseType(num);

            Console.Write("Height: ");
            int Height = CheckAll();
            Console.WriteLine(Height);

            Console.Write("Weight: ");
            int Weight = CheckAll();
            Console.WriteLine(Weight);

            Console.Write("Attack: ");
            int Attack = CheckPow();
            Console.WriteLine(Attack);

            Console.Write("Defence: ");
            int Defence = CheckPow();
            Console.WriteLine(Defence);

            Console.Write("Speed: ");
            int Speed = CheckPow();
            Console.WriteLine(Speed);

            Console.Write("HP: ");
            int HP = CheckHp();
            Console.WriteLine(HP);


            Pokemon pokemon1 = new Pokemon(Name, Height, Weight, HP, Attack, Defence, Speed, Type);
            //MenuType();
            PokemonList.Add(pokemon1);
        }
        public static string SearchIDshowPokemon()
        {
            int Id = CheckPow();
            foreach (Pokemon item in PokemonList)
            {
                if (item.ID == Id)
                {
                    return item.ShowInfo();
                }
            }
            return "Not Founds";
        }

        public static void EditPokemon()
        {
            int Id = CheckPow();
            foreach (Pokemon item in PokemonList)
            {
                if (item.ID == Id)
                {
                    Console.WriteLine("Edit: 1. Name , 2. Height , 3. Weight , 4. HP ,5. Attack , 6. Defence, 7. Speed , 8.Type , 9.Exit ");
                    Console.Write("Enter number: ");
                    str = Console.ReadLine();
                    while (!int.TryParse(str, out num) || num < 1 || num > 8)
                    {
                        Console.Write("Enter again: ");
                        str = Console.ReadLine();
                    }

                    switch (num)
                    {
                        case 1:
                            Console.Write("Enter Name: ");
                            str = Console.ReadLine();
                            item.Name = str;
                            break;
                        case 2:
                            Console.Write("Enter Height: ");
                            int height = CheckAll();
                            item.Height = height;
                            break;
                        case 3:
                            Console.Write("Enter Weight: ");
                            int weight = CheckAll();
                            item.Weight = weight;
                            break;
                        case 4:
                            Console.Write("Enter HP: ");
                            int HP = CheckHp();
                            item.HP = HP;
                            break;
                        case 5:
                            Console.Write("Enter Attack: ");
                            int Attack = CheckAll();
                            item.Attack = Attack;
                            break;
                        case 6:
                            Console.Write("Enter Defence: ");
                            int Defence = CheckAll();
                            item.Attack = Defence;
                            break;
                        case 7:
                            Console.Write("Enter Speed: ");
                            int Speed = CheckAll();
                            item.Attack = Speed;
                            break;
                        case 8:
                            Console.WriteLine("Choose the new Type of pokemon: ");
                            Console.Write("How many type does the pokemon have? ");
                            str = Console.ReadLine();
                            int numberType = CheckType();
                            List<string> type = Pokemon.ChooseType(numberType);
                            item.Type = type;
                            break;
                        case 9:
                            break;
                    }
                }
            }

        }

        public static void ShowSound()
        {
            foreach (var item in PokemonList)
            {
                item.Sound();
            }

        }
        public static int CheckHp()
        {
            string str = Console.ReadLine();
            int num;
            while (!int.TryParse(str, out num) || num <= 0 || num > 5000)
            {
                Console.Write("nhap lai: ");
                str = Console.ReadLine();
            }
            return num;
        }
        public static int CheckPow()
        {

            string str1 = Console.ReadLine();
            int number;
            while (!int.TryParse(str1, out number) || number < 1 || number > 100)
            {
                Console.Write("nhap lai: ");
                str1 = Console.ReadLine();
            }
            return number;
        }
        public static int CheckAll()
        {

            string str1 = Console.ReadLine();
            int number;
            while (!int.TryParse(str1, out number) || number <= 0)
            {
                Console.Write("nhap lai: ");
                str1 = Console.ReadLine();
            }
            return number;
        }
        public static int CheckType()
        {

            string str1 = Console.ReadLine();
            int number;
            while (!int.TryParse(str1, out number) || number <= 0 || number > 11)
            {
                Console.Write("nhap lai: ");
                str1 = Console.ReadLine();
            }
            return number;
        }
        public static string ReturnPokemonandRatting()
        {
            Console.Write("Enter Name: ");
            str = Console.ReadLine();
            foreach (var item in PokemonList)
            {
                if (str.Equals(item.Name))
                {
                    return $"Name: {item.Name} Pow: {item.RaitingPokemon()}";
                }
            }
            return "Not Fond";
        }
        public static void WriteFile()
        {
            foreach (var item in PokemonList)
            {
                str = $"D:/pokemon/{item.ID}.txt";
                using (StreamWriter sw = new StreamWriter(str))
                {
                    sw.WriteLine("Name: " + item.Name);
                    sw.WriteLine(item.Height);
                    sw.WriteLine(item.Weight);
                    sw.WriteLine(item.HP);
                    sw.WriteLine(item.Attack);
                    sw.WriteLine(item.Defence);
                    sw.WriteLine(item.Speed);
                }
            }
        }
        public static void ReadFile()
        {
            List<Pokemon> ListNewPokemon = new List<Pokemon>();
            try
            {
                for (int i = 1; i < 100; i++)
                {
                    Pokemon pokemon = new Pokemon();
                    pokemon.Name = File.ReadLines(@"D:\pokemon\" + i + ".txt").ElementAtOrDefault(0);
                    pokemon.Height = Convert.ToInt32(File.ReadLines(@"D:\pokemon\" + i + ".txt").ElementAtOrDefault(1));
                    pokemon.Weight = Convert.ToInt32(File.ReadLines(@"D:\pokemon\" + i + ".txt").ElementAtOrDefault(2));
                    pokemon.HP = Convert.ToInt32(File.ReadLines(@"D:\pokemon\" + i + ".txt").ElementAtOrDefault(3));
                    pokemon.Attack = Convert.ToInt32(File.ReadLines(@"D:\pokemon\" + i + ".txt").ElementAtOrDefault(4));
                    pokemon.Defence = Convert.ToInt32(File.ReadLines(@"D:\pokemon\" + i + ".txt").ElementAtOrDefault(5));
                    pokemon.Speed = Convert.ToInt32(File.ReadLines(@"D:\pokemon\" + i + ".txt").ElementAtOrDefault(6));
                    ListNewPokemon.Add(pokemon);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("OK");
            }
            foreach (var item in ListNewPokemon)
            {
                item.ShowInfo();
            }
        }
        public static void View()
        {
            foreach (var item in PokemonList)
            {
                Console.WriteLine(item.ShowInfo());
            }
        }
        public static void Save()
        {

            string json = JsonConvert.SerializeObject(PokemonList);

            File.WriteAllText(path, json);

        }

        public static void Read()
        {

            string strJSON = File.ReadAllText(path);

            PokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(strJSON);

            foreach (Pokemon item in PokemonList)
            {
                Console.WriteLine(item.ShowInfo());
            }

        }
    }
}
