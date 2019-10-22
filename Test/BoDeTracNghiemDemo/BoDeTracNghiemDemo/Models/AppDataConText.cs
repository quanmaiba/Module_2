using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoDeTracNghiemDemo.Models
{
    public class AppDataConText : IdentityDbContext<ApplicationUser>
    {
        public AppDataConText(DbContextOptions<AppDataConText> options) : base(options)
        {

        }

        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<Thi> Thi { get; set; }
        public DbSet<CauHoi> CauHois { get; set; }
        public DbSet<DiemThi> DiemThis { get; set; }
        public DbSet<DapAn> DapAns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CauHoiThi>().HasKey(ct => new { ct.CauHoiId, ct.ThiId });
        }

        public DbSet<BoDeTracNghiemDemo.Models.CauHoiThi> CauHoiThi { get; set; }
    }
}
