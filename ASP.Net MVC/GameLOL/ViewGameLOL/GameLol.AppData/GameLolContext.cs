using GameLol.DoMain;
using Microsoft.EntityFrameworkCore;

namespace GameLol.AppData
{
    public class GameLolContext : DbContext
    {
        public GameLolContext(DbContextOptions<GameLolContext> options) : base(options)
        { }
        public DbSet<HeroLol> HeroLols { get; set; }
        public DbSet<DescriptionHero> DescriptionHeroes { get; set; }
        public DbSet<HitRangeHero> HitRangeHeros { get; set; }
        public DbSet<PropertyHero> PropertyHeroes { get; set; }
        public DbSet<RoleSkin> RoleSkins { get; set; }
        public DbSet<SkinHero> SkinHeroes { get; set; }
        public DbSet<SkillHero> SkillHeroes { get; set; }
        public DbSet<RoleSkinHero> RoleHeroes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleSkinHero>().HasKey(hero => new { hero.HeroID, hero.RoleSkinID });
            //modelBuilder.Entity<HitRangeHero>().HasOne(hero => hero.HeroLol).WithOne(hero => hero.HitRangeHeroID);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseSqlServer("Server=DESKTOP-B8N6V6G;User ID=sa;Password=123456;Database=GameLoLViewNew;Trusted_Connection=True;");
        //}
    }
}
