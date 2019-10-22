using Microsoft.EntityFrameworkCore;

namespace CursosCrudRazor.Model
{
    public class StudenContext : DbContext
    {
        public StudenContext(DbContextOptions<StudenContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
