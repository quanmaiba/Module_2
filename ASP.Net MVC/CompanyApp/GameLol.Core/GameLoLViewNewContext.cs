using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GameLol.Core
{
    public partial class GameLoLViewNewContext : DbContext
    {
        public GameLoLViewNewContext()
        {
        }

        public GameLoLViewNewContext(DbContextOptions<GameLoLViewNewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DescriptionHeroes> DescriptionHeroes { get; set; }
        public virtual DbSet<HeroLols> HeroLols { get; set; }
        public virtual DbSet<HitRangeHeros> HitRangeHeros { get; set; }
        public virtual DbSet<PropertyHeroes> PropertyHeroes { get; set; }
        public virtual DbSet<RoleHeroes> RoleHeroes { get; set; }
        public virtual DbSet<RoleSkins> RoleSkins { get; set; }
        public virtual DbSet<SkillHeroes> SkillHeroes { get; set; }
        public virtual DbSet<SkinHeroes> SkinHeroes { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-B8N6V6G;Initial Catalog=GameLoLViewNew;User ID=sa;Password=123456;Connect Timeout=30;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<DescriptionHeroes>(entity =>
            {
                entity.HasKey(e => e.DescriptionHeroId);

                entity.HasIndex(e => e.HeroId);

                entity.Property(e => e.DescriptionHeroId).HasColumnName("DescriptionHeroID");

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.DescriptionHeroes)
                    .HasForeignKey(d => d.HeroId);
            });

            modelBuilder.Entity<HeroLols>(entity =>
            {
                entity.HasKey(e => e.HeroId);

                entity.HasIndex(e => e.HitRangeHeroId);

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.Property(e => e.HitRangeHeroId).HasColumnName("HitRangeHeroID");

                entity.HasOne(d => d.HitRangeHero)
                    .WithMany(p => p.HeroLols)
                    .HasForeignKey(d => d.HitRangeHeroId);
            });

            modelBuilder.Entity<HitRangeHeros>(entity =>
            {
                entity.HasKey(e => e.HitRangeHeroId);

                entity.Property(e => e.HitRangeHeroId).HasColumnName("HitRangeHeroID");
            });

            modelBuilder.Entity<PropertyHeroes>(entity =>
            {
                entity.HasKey(e => e.PropertyId);

                entity.HasIndex(e => e.HeroId);

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.PropertyHeroes)
                    .HasForeignKey(d => d.HeroId);
            });

            modelBuilder.Entity<RoleHeroes>(entity =>
            {
                entity.HasKey(e => new { e.HeroId, e.RoleSkinId });

                entity.HasIndex(e => e.RoleSkinId);

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.Property(e => e.RoleSkinId).HasColumnName("RoleSkinID");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.RoleHeroes)
                    .HasForeignKey(d => d.HeroId);

                entity.HasOne(d => d.RoleSkin)
                    .WithMany(p => p.RoleHeroes)
                    .HasForeignKey(d => d.RoleSkinId);
            });

            modelBuilder.Entity<RoleSkins>(entity =>
            {
                entity.HasKey(e => e.RoleSkinId);

                entity.Property(e => e.RoleSkinId).HasColumnName("RoleSkinID");
            });

            modelBuilder.Entity<SkillHeroes>(entity =>
            {
                entity.HasKey(e => e.SkillHeroId);

                entity.HasIndex(e => e.HeroId);

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.SkillHeroes)
                    .HasForeignKey(d => d.HeroId);
            });

            modelBuilder.Entity<SkinHeroes>(entity =>
            {
                entity.HasKey(e => e.SkinHeroId);

                entity.HasIndex(e => e.HeroId);

                entity.Property(e => e.SkinHeroId).HasColumnName("SkinHeroID");

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.SkinHeroes)
                    .HasForeignKey(d => d.HeroId);
            });
        }
    }
}
