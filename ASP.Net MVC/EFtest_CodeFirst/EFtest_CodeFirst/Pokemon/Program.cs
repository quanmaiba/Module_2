using System;
using System.Collections.Generic;
using System.Linq;
using PokemonApp.Data;
using PokemonApp.Domain;

namespace PokemonConsole
{
    class Program
    {
        private static PokemonContext context = new PokemonContext();
        static void Main(string[] args)
        {

            //var poke = new  { Name = name };
            //using (var db = new PokemonContext())
            //{
            //    // Nhập tên 1 Blog mới cần tạo
            //    Console.Write("Ten cua 1 Blog moi: ");
            //    var name = Console.ReadLine();

            //    // Thêm 1 Blog mới  

            //    db.Pokemons.Add(poke);
            //    db.SaveChanges();

            //    // Hiển thị các Blog trong database, sắp xếp theo Name
            //    //var query = from b in db.Pokemons
            //    //            orderby b.Name
            //    //            select b;

            //    var query = db.Pokemons.ToList();

            //    Console.WriteLine("Tat ca blog trong database -- dammio.com:");
            //    foreach (var item in query)
            //    {
            //        Console.WriteLine(item.Name);
            //    }

            //    Console.WriteLine("Go bat ky phim nao de thoat...");
            //    Console.ReadKey();
            //}
            Create();
        }

        private static void Create()
        {
            var listPokemon = new List<Pokemon>();
            var pokemon = context.Pokemons
        }
    }
}
