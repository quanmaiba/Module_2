using System;

namespace Thuchanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number = 0;
            do
            {
                Menu();
                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.Write("nhap do dai canh: ");
                        HinhVuong.Side = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("dien tich hinh vuong: " + HinhVuong.Area());
                        Console.WriteLine("chu vi hinh vuong: " + HinhVuong.Perimeter());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("nhap chieu dai: ");
                        HinhChuNhat.Lenght = Convert.ToInt32(Console.ReadLine());
                        Console.Write("nhap chieu rong: ");
                        HinhChuNhat.Width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("dien tich hinh chu nhat: " + HinhChuNhat.Area());
                        Console.WriteLine("chu vi hinh hinh chu nhat: " + HinhChuNhat.Perimeter());
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("nhap ban kinh: ");
                        HinhTron.Radius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine( "dien tich hinh tron: " +HinhTron.Area());
                        Console.WriteLine( "chu vi hinh tron: " + HinhTron.Perimeter());
                        Console.WriteLine();
                   
                        break;
                    case 4:
                        Console.WriteLine("Cam on da su dung");
                        break;
                    default:
                        Console.WriteLine("chon lai");
                        break;
                }
               

            } while (number != 4);
        }

        private static void Menu()
        {
            Console.WriteLine("Chon viec can lam");
            Console.WriteLine("1 => tinh dt cv hinh vuong");
            Console.WriteLine("2 => tinh dt cv hinh chu nhat");
            Console.WriteLine("3 => tinh dt cv hinh tron");
            Console.WriteLine("4 => thoat chương trinh");
            Console.WriteLine();
        }
    }
    class HinhVuong
    {
        public static double Side { get; set; }

        public static double Area()
        {
            return Side * Side;
        }
        public static double Perimeter()
        {
            return Side * 4;
        }
    }
    class HinhChuNhat
    {
        public static double Width { get; set; }
        public static double Lenght { get; set; }

        public static double Area()
        {
            return Lenght* Width;
        }
        public static double Perimeter()
        {
            return (Lenght+ Width)*2;
        }
    }
    class HinhTron
    {
        public static double Radius { get; set; }

        public static  double Area()
        {
            return 3.14* Radius * Radius;
        }
        public static double Perimeter()
        {
            return  2* 3.14 * Radius ;
        }

    }
}


