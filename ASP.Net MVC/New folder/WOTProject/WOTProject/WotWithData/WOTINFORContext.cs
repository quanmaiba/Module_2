using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
namespace WoTWithCore
{
    public partial class WOTINFORContext : DbContext
    {
        public WOTINFORContext()
        {
        }

        public WOTINFORContext(DbContextOptions<WOTINFORContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nations> Nations { get; set; }
        public virtual DbSet<TankTypes> TankTypes { get; set; }
        public virtual DbSet<Tanks> Tanks { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=DESKTOP-E31IP5L;Initial Catalog=WOTINFOR;Integrated Security=True;Connect Timeout=30;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Nations>(entity =>
            {
                entity.HasKey(e => e.NationId);
            });

            modelBuilder.Entity<TankTypes>(entity =>
            {
                entity.HasKey(e => e.TankTypeId);
            });

            modelBuilder.Entity<Tanks>(entity =>
            {
                entity.HasKey(e => e.TankId);

                entity.HasIndex(e => e.NationId);

                entity.HasIndex(e => e.TankTypeId);

                entity.HasOne(d => d.Nation)
                    .WithMany(p => p.Tanks)
                    .HasForeignKey(d => d.NationId);

                entity.HasOne(d => d.TankType)
                    .WithMany(p => p.Tanks)
                    .HasForeignKey(d => d.TankTypeId);
            });
        }

    }
}
