using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using ThuVien.AppData;
using ThuVien.DoMain;

namespace ThuVienConsole
{
    class Program
    {
        private static ThuVienConText _context = new ThuVienConText();
        static void Main(string[] args)
        {
            //Find();
            //Update();
            Insert();
            delete();
            using (var context = new ThuVienConText())
            {
                //var thuvien = context.Saches
                //    .Where(s => s.MaSach == "MaSach01")
                //    .Include("MaSachMoi")
                //    .FirstOrDefault();
                //var std = new NhaXuatBan()
                //{
                //    MaNXB = "S01",
                //    TenNXB = "TV"

                //};
                //context.NhaXuatBans.Add(std);
                ////context.Add<Sach>(std);
                //context.SaveChanges();
                //Console.WriteLine("thanh cong");
                //context.Saches.Update(std);

                //var sach = context.Saches.First();
                //DisplayStates(context.ChangeTracker.Entries());

                ////var etity = new List<Object>()
                ////{
                ////    ....
                ////}
                //context.Saches.Add(sach);
                //Console.WriteLine(context.Entry(disconnectedEntity).State);

                string macsach = "MS01";
                var sachs = _context.Saches
                    .FromSql($"Select * from Sach ")
                    .OrderBy(s => s.MaSach)
                    .ToList();

                //Console.WriteLine(sachs);


                //var show = context.Database.ExecuteSqlCommand("Updata Sach set masach = 'ms03' where masach ='ms02'");

                //var query = _context.Saches.ToList();

                //Console.WriteLine("Tat ca blog trong database -- dammio.com:");
                //foreach (var item in query)
                //{
                //    Console.WriteLine(item);
                //}

            }
        }

        private static void delete()
        {
            var sach = _context.Saches.FirstOrDefault(sachs => sachs.MaSach == "masach");
            _context.Saches.Remove(sach);
            _context.Entry(sach).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        private static void Insert()
        {
            _context.SinhViens.Add(new SinhVien
            {
                //new DateTime(2019,9,30)


            }); ;
        }

        private static void Update()
        {
            var sach = _context.Saches.FirstOrDefault();
            sach.MaSach = "Masca";
            _context.SaveChanges();
        }

        private static void Find()
        {
            var name = "Pikachu";
            var FindSach = _context.Saches.Where(sach => sach.MaSach == name).ToList();
            var FindSach1 = _context.Saches.Find(3);
            var FindSach2 = _context.Saches.Where(sach => EF.Functions.Like(sach.MaSach, "T%")).ToList();
        }

        private static void DisplayStates(IEnumerable<Sach> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"{entry.MaSach.GetType().Name}, {entry.MaSach.ToString()}");
            }

        }
        public partial class spGetSach : Migration
        {
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                var chuoi = "anhquan";
                var sp = @"CREATE PROCEDURE [dbo].[GetSach]
                    @MaSach varchar(50),
                     @MaLoaiSach varchar(50)
                    AS
                    BEGIN
                    SET NOCOUNT ON;
                    Insert Sach (
                    [MaSach],
                    [MaLoaiSach]
                    )
                    Values(@MaSach,@MaLoaiSach)

                    Updata Sach set maLoaiSach = 'ms03' where masach ='ms02'

                    update Sach 
                    set [MaSach] = @MaSach
                    where maloaisach = @MaloaiSach

                    End";

                _context.Database.ExecuteSqlCommand("GetSach @p0,@p1", parameters: new[] { chuoi, "MaLoaiSach01" });

                migrationBuilder.Sql(sp);
            }
        }
    }
}
