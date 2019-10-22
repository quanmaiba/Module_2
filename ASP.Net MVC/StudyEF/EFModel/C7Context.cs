using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFModel
{
    public partial class C7Context : DbContext
    {
        public C7Context()
        {
        }

        public C7Context(DbContextOptions<C7Context> options)
            : base(options)
        {
        }

        public virtual DbSet<HocVien> HocVien { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-B8N6V6G;Initial Catalog=C7;User ID=sa;Password=123456;Connect Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<HocVien>(entity =>
            {
                entity.HasKey(e => e.MaHv)
                    .HasName("PK__HocVien__2725A6D215CCFD1B");

                entity.Property(e => e.MaHv).HasColumnName("MaHV");

                entity.Property(e => e.MonHoc)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('truong d?i')");

                entity.Property(e => e.TenHv)
                    .HasColumnName("TenHV")
                    .HasMaxLength(50);
            });
        }
    }
}
