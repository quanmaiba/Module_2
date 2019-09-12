using System;
using System.Collections.Generic;

namespace Practical_1
{
    class Program
    {   
        static void Main(string[] args)
        {
            ex5();
        }
        public static void ex5()
        {
            Console.Write("Enter the amount of football teams: ");
            string str = Console.ReadLine();
            int amountTeam;
            while (!int.TryParse(str, out amountTeam) || amountTeam <= 0)
            {
                Console.Write("Enter again! ");
                str = Console.ReadLine();
            }
            List<string> footballTeamList = new List<string>();
            for (int i = 0; i < amountTeam; i++)
            {
                Console.Write($"Enter name of football team {i + 1}: ");
                str = Console.ReadLine();
                while (str == " " || str == "") //check đầu vào string
                {
                    Console.WriteLine("Enter again! ");
                    str = Console.ReadLine();
                }
                footballTeamList.Add(str);
            }
            Console.Clear();
            Console.WriteLine("List football team: ");
            foreach (var item in footballTeamList)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
