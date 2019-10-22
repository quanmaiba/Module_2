using Microsoft.EntityFrameworkCore;
using QLS.Domain;

namespace QLS.Data
{
    public class QuanLySachContext : DbContext
    {
        public QuanLySachContext(DbContextOptions<QuanLySachContext> options) : base(options)
        {

        }
        public DbSet<QuanLySach> QuanLySachs { get; set; }
    }
}
