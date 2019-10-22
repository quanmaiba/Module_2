using System;
using Microsoft.EntityFrameworkCore;
using PokemonApp.Domain;
namespace PokemonApp.Data
{
    public class PokemonContext:DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonBattle>().HasKey(pokemon => new { pokemon.BattleId, pokemon.PokemonId });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-B8N6V6G;Database = PokemonAppDataCore;Trusted_Connection = True;");
          
        }
    }
}
