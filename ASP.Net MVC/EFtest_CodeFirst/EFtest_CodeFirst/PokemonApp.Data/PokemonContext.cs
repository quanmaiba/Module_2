using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using PokemonApp.Domain;

namespace PokemonApp.Data
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<SecretDentity> SecretDentities { get; set; }

        //public static readonly LoggerFactory MyConsoleLoggerFactory = new LoggerFactory(new[] {
        //      new ConsoleLoggerProvider((category, level)
        //        => category == DbLoggerCategory.Database.Command.Name
        //       && level == LogLevel.Information, true) });

        public PokemonContext(DbContextOptions<PokemonContext> options):base (options)
         {}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PokemonBattle>().HasKey(pokemon => new { pokemon.BattleId, pokemon.PokemonId });
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseLoggerFactory(MyConsoleLoggerFactory)
        //        .EnableSensitiveDataLogging(true)
        //        .UseSqlServer("Server=.;Database=PokemonCodeFirst;Trusted_Connection=True;");
        //}
    }
}
