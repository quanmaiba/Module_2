using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFtest_CodeFirst.Models;

namespace EFtest_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogDBContext())
            {
                // Nhập tên 1 Blog mới cần tạo
                Console.Write("Ten cua 1 Blog moi: ");
                var name = Console.ReadLine();

                // Thêm 1 Blog mới  
                var blog = new Blog { Name = name };
                db.Blog.Add(blog);
                db.SaveChanges();

                // Hiển thị các Blog trong database, sắp xếp theo Name
                var query = from b in db.Blog
                            orderby b.Name
                            select b;

                Console.WriteLine("Tat ca blog trong database -- dammio.com:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Go bat ky phim nao de thoat...");
                Console.ReadKey();
            }
        }
    }
}
