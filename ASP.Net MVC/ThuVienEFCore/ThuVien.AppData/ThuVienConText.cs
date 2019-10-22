using Microsoft.EntityFrameworkCore;
using ThuVien.DoMain;

namespace ThuVien.AppData
{
    public class ThuVienConText : DbContext
    {
        public DbSet<Sach> Saches { get; set; }
        public DbSet<LoaiSach> LoaiSaches { get; set; }
        public DbSet<NgonNgu> NgonNgus { get; set; }
        public DbSet<KhoSach> KhoSaches { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<SinhVienMuonSach> SinhVienMuonSaches { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<ViTri> ViTris { get; set; }
        public ThuVienConText(DbContextOptions<ThuVienConText> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVienMuonSach>().HasKey(sinhvienmuonsach => new { sinhvienmuonsach.MaSach, sinhvienmuonsach.MaSv });
            //    modelBuilder.Entity<Sach>()
            //       .HasOne<NhaXuatBan>(s => s.NhaXuatBan)
            //       .WithMany(g => g.Saches)
            //       .HasForeignKey(s => s.MaNXB)
            //       .OnDelete(DeleteBehavior.Cascade);
            //}
            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    optionsBuilder.UseSqlServer("Server=.;Database=ThuVienSach;Trusted_Connection=True;");
            //}

        }
}
