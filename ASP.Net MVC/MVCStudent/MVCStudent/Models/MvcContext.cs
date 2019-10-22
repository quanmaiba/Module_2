using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCStudent.Models;
using System.Linq;

namespace MVCStudent.Models
{
    public class MvcContext : IdentityDbContext<ApplicationUser>
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var foreignKey in builder.Model.GetEntityTypes()
                .SelectMany(e=> e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<MVCStudent.Models.RegisterViewModel> RegisterViewModel { get; set; }
    }
}
