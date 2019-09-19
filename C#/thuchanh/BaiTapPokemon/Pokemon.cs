using System;
using System.Collections.Generic;

namespace BaiTapPokemon
{
    class Pokemon
    {
        private int id;
        private static int num = 1;
        public static List<string> typePokemon;
        public static string[] listType = { "Normal", "Water", "Grass", "Fire", "Electric", "Ghost", "Dragon", "Rock", "Ice", "Bug", "Posion" };
        public int ID { get => id; set => id = value; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public List<string> Type { get; set; }

        public Pokemon()
        {
            id = ID + num;
            num++;
            Type = new List<string>();
        }

        public Pokemon(string name, int height, int weight, int Hp, int attack, int defence, int speed, List<string> type)
        {
            Name = name;
            Height = height;
            Weight = weight;
            HP = Hp;
            Attack = attack;
            Defence = defence;
            Speed = speed;
            Type = type;
            id = ID + num;
            num++;
        }

        public string ShowInfo()
        {
            return $"ID: {ID} \t Name:{Name} \t Height:{Height} \t Weight: {Weight}\t HP: {HP},   \t Power: {RaitingPokemon()}, \t  Type: {ViewType(Type)} ";
        }
        public void Sound()
        {
            Console.WriteLine($"{Name} say: {Name.Substring(0, 4) }  {Name.Substring(0, 4)}");
        }
        public string RaitingPokemon()
        {
            double rating = (Attack + Defence + Speed) / 3;

            var Averrage = (rating >= 90) ? "Perfect" : (rating >= 60) ? "Good" : (rating >= 40) ? "Medium" : "Bad";

            return Averrage;
        }
        public static string ViewType(List<string> list)
        {
            string data = String.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                data += list[i] + " ";
            }
            return data;
        }
        public static List<string> ChooseType(int numberType)
        {
            for (int i = 0; i < listType.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {listType[i]}");
            }
            typePokemon = new List<string>();
            for (int i = 0; i < numberType; i++)
            {
                Console.Write($"Choose the Type {i + 1} of Pokemon: ");
                int type = Program.CheckType();

                if (CheckValueType(type) == false)
                {
                    Console.WriteLine("Type Exist");
                    Console.Write("Enter again:  ");
                    type = Program.CheckType();
                    //CheckValueType(type);
                   
                }
                typePokemon.Add(listType[type - 1]);
                Console.WriteLine($"Type \"{listType[type - 1]}\" is added.");

            }
            return typePokemon;
        }
        public static bool CheckValueType(int type)
        {
            int type1 = type;
            for (int i = 0; i < typePokemon.Count; i++)
            {
                if (typePokemon[i] == listType[type1 - 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
