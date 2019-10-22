using GameLol.DoMain;
using Microsoft.EntityFrameworkCore;

namespace GameLol.Data
{
    public class GameLolContext : DbContext
    {
        public GameLolContext(DbContextOptions<GameLolContext> options) : base(options)
        {
            //nhị bị điên
        }
        public DbSet<HeroLol> HeroLols { get; set; }
        public DbSet<DescriptionHero> DescriptionHeroes { get; set; }
        public DbSet<HitRangeHero> HitRangeHeros { get; set; }
        public DbSet<PropertyHero> PropertyHeroes { get; set; }
        public DbSet<RoleHero> RoleHeros { get; set; }
        public DbSet<SkinHero> SkinHeroes { get; set; }
        public DbSet<SkillHero> SkillHeroes { get; set; }
        public DbSet<RoleSkinHero> RoleOfHeroes { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleSkinHero>().HasKey(hero => new { hero.HeroID, hero.RoleHeroID });
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseSqlServer("Server=.;Database=GameLoLGood;Trusted_Connection=True;");
        //}
    }
}
