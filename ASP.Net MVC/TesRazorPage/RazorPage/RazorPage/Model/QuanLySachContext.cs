using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Model
{
    public class QuanLySachContext : DbContext
    {
        public QuanLySachContext(DbContextOptions<QuanLySachContext> options): base(options)
        {

        }
        public DbSet<QuanLySach> QuanLySachs { get; set; }
    }
}
