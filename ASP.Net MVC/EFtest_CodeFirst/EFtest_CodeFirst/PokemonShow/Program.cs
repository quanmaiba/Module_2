using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//using MahApps.Metro.Controls;
using Microsoft.EntityFrameworkCore;
using PokemonApp.Data;
using PokemonApp.Domain;

namespace PokemonShow
{
    class Program
    {
        private static PokemonContext context = new PokemonContext();
        private static string str;

       static void Main(string[] args)
        {
            //Create();
            //Find();
            //UpDate();
            //Delete();
            CreateBattle();
        }

        private static void CreateBattle()
        {
            try
            {
                Console.WriteLine("Enter Number Pokemon: ");
                int num = Convert.ToInt32(Console.ReadLine());

               

                DateTime startDate ; 
                DateTime endDate;                
                //CultureInfo culture = new CultureInfo();
                for (int i = 0; i < num; i++)
                {
                    Console.Write("Enter Name Battle: ");
                    str = Console.ReadLine();
                    Console.Write($"Enter the Start Date of Battle {i + 1}: ");
                    startDate = CheckDate();
                    var StartDat = startDate.Date.ToString("yyyyMMdd");

                    

                    var year =Convert.ToInt32(StartDat.Substring(0, 4));
                    var moth = Convert.ToInt32(StartDat.Substring(4, 2));
                    var day = Convert.ToInt32( StartDat.Substring(6, 2));
                   
                    Console.Write($"Enter the End Date of Battle {i + 1}: ");
                    endDate = CheckDate().Date;
                   
                    var EndDate = endDate.ToString("yyyy-MM-dd");
                    var a= String.Format("{0:yyyy-MM-dd}", startDate);
                    context.Battles.Add(new Battle
                    {
                        Name = str,
                        //StartDate = a,
                        //EndDate = to EndDate
                    }); ;
                    context.SaveChanges();
                     //Console.WriteLine($"State: {context.Entry().State}");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        private static DateTime CheckDate()
        {
            string str = Console.ReadLine();
            DateTime date;
            while (!DateTime.TryParse(str, out date))
            {
                Console.WriteLine("Enter again! ");
                str = Console.ReadLine();
            }
            return date;
        }

        private static void Delete()
        {
            Console.Write("enter name pokemon Delete: ");
            str = Console.ReadLine();
            var pokemon = context.Pokemons.Where(s => s.Name == str).ToList();
            var pokemon1 = context.Pokemons.FirstOrDefault(s=>s.Name==str);
            if (pokemon.Count > 0)
            {
                context.Pokemons.RemoveRange(pokemon);             
                context.SaveChanges();
                Console.WriteLine($"State: {context.Entry(pokemon).State}");
            }
            else
            {
                Console.WriteLine("Record does not exist in the database");
            }
          
        }

        private static void UpDate()
        {
            Console.Write("enter name pokemon Update: ");
            str = Console.ReadLine();
            Console.Write("enter nameNew pokemon Update: ");
            string str1 = Console.ReadLine();
            //var pokemon = context.Pokemons.FirstOrDefault();
            //pokemon.Name = str;
            var pokemon = context.Pokemons.Where(s => s.Name == str).ToList();

            if (pokemon.Count > 0)
            {
                foreach (var item in pokemon)
                {
                    item.Name = str1;
                    break;
                }
                context.SaveChanges();               
            }
            else
            {
                Console.WriteLine("Record does not exist in the database");
            }
            Console.WriteLine($"State: {context.Entry(pokemon).State}");
        }                   
        private static void Create()
        { Console.Write("Enter Name Pokemon: ");
                str = Console.ReadLine();
            Console.WriteLine("Enter Number Pokemon: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Pokemon pkmon;
            var listPokemon = new List<Pokemon>();
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter Name Pokemon: ");
                str = Console.ReadLine();
                pkmon = new Pokemon();
                pkmon.Name = str;
                listPokemon.Add(pkmon);
            }
            context.Pokemons.AddRange(listPokemon);
            context.SaveChanges();
        }
        private static void Find()
        {
            Console.WriteLine("Enter Name Find: ");
            str = Console.ReadLine();
            var findPokemon = context.Pokemons.Where(s => s.Name == str).ToList();

            if (findPokemon.Count > 0)
            {
                foreach (var item in findPokemon)
                {
                    Console.WriteLine($"IdPokemon:{(item.Id).ToString().PadRight(10)}  NamePokemon:{(item.Name).PadRight(10)}");
                }
            }
            else
            {
                Console.WriteLine("Record does not exist in the database");
            }
            //try
            //{              
            //    foreach (var item in findPokemon)
            //    {
            //        Console.WriteLine(item.Id + ' ' + item.Name);
            //    }

            //}
            //catch (DbUpdateConcurrencyException ex)
            //{
            //    throw new Exception("Record does not exist in the database");
            //}
            //catch (Exception ex)
            //{
            //    throw ;
            //}         
        }
    }
}
