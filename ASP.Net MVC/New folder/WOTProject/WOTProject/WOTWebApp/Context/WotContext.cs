using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOTWebApp.Models;

namespace WOTWebApp.Context
{
    public class WotContext : DbContext
    {
        public WotContext(DbContextOptions<WotContext> options) : base(options)
        {

        }
        public DbSet<Tank> Tanks { get; set; }
        public DbSet<TankType> TankTypes { get; set; }
        public DbSet<Nation> Nations { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-E31IP5L;Database = WOTINFOR; Trusted_Connection = True;");
        //}


    }
}
