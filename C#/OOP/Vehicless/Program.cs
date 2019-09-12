using System;
using System.Collections.Generic;

namespace Vehicless
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number ;
            List<Bike> BikeList = new List<Bike>();
            List<Car> CarList = new List<Car>();
            string str;
            do
            {
                Menu();              
                str = Console.ReadLine();
                while (!Int32.TryParse(str, out number))
                {
                    Console.WriteLine("NHAP LAI");
                    Console.WriteLine();
                    Menu();
                   
                    str = Console.ReadLine();
                }
                //bool number1 = Int32.TryParse(Console.ReadLine(), out number);
                switch (number)
                {
                    case 1:
                        Console.WriteLine(" XIN CHAO! CHAO MUNG BAN DEN VOI CUA HANG BIKE!! \n");
                        Console.WriteLine("NHAP SO LUONG ");
                        str = Console.ReadLine();
                        int num;
                       while(!Int32.TryParse(str, out num))
                        {
                            Console.WriteLine("NHAP LAI");
                            str = Console.ReadLine();
                        }
                       
                        //bool check = Int32.TryParse(str, out num);

                        for (int i = 0; i < num; i++)
                        {
                            Bike bike = new Bike();
                            Console.WriteLine($"\n NHAP SO LIEU XE {i+1} \n");
                            Console.Write("NHAP HANG:");   
                            bike.Make = Console.ReadLine();
                            Console.Write("NHAP DOI XE:");
                            bike.Model = Console.ReadLine();
                            //Console.Write("NHAP SO BANH:");
                            bike.Wheel = 2;
                            Console.Write("NHAP NAM:");
                            str = Console.ReadLine();
                            uint year1;
                            while (!UInt32.TryParse(str , out year1))
                            {
                                Console.WriteLine(  "NHAP LAI");
                                str = Console.ReadLine();
                            }
                            bike.Year = year1;
                            BikeList.Add(bike);
                        }
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("BUOC TIEP THEO BAN MUON LAM\n");
                        
                        break;
                    case 2:
                        Console.WriteLine($"SO LUONG BIKE DUOC HIEN THI \n");
                        //Console.WriteLine(reclist.Count);
                        foreach (var show in BikeList)
                        {
                            show.ToString();
                        }
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("BUOC TIEP THEO BAN MUON LAM\n");
                        break;
                    case 3:
                        Console.WriteLine("XIN CHAO!!! CHAO MUNG BAN DEN VOI CUA HANG BIKE!! XIN CHAO!!! \n");
                        Console.WriteLine("NHAP SO LUONG CAR:");
                        int numcar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"SO LUONG  CAR LA : {numcar}");
                        for (int i = 0; i < numcar; i++)
                        {
                            Car car = new Car();
                            Console.WriteLine($"\n NHAP SO LIEU XE {i + 1} \n");
                            Console.Write("NHAP HANG:");
                            car.Make = Console.ReadLine();
                            Console.Write("NHAP DOI XE:");
                            car.Model = Console.ReadLine();
                            //Console.Write("NHAP SO BANH:");
                            car.Wheel = 4;
                            Console.Write("NHAP NAM:");
                            str = Console.ReadLine();
                            uint year1;
                            while (!UInt32.TryParse(str, out year1))
                            {
                                Console.WriteLine("NHAP LAI");
                                str = Console.ReadLine();
                            }
                            car.Year = year1;
                            Console.Write("NHAP KIEU XE: ");
                            car.Type = Console.ReadLine( );
                            Console.Write("NHAP TOC DO: ");
                            str = Console.ReadLine();
                            uint speed1;
                            while(!UInt32.TryParse(str, out speed1))
                            {
                                Console.WriteLine("NHAP LAI");
                                str = Console.ReadLine();
                            }
                            car.Speed = speed1;
                            CarList.Add(car);
                        }
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("BUOC TIEP THEO BAN MUON LAM\n");
                        break;
                    case 4:
                        Console.WriteLine($"SO LUONG CAR DUOC HIEN THI\n");
                        foreach (var show in CarList)
                        {
                            show.ToString();
                        }
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("BUOC TIEP THEO BAN MUON LAM\n");
                        break;
                    case 5:
                        break;

                    default:
                        Console.WriteLine("NHAP LAI \n");
                        Menu();
                        break;
                }
            } while (number != 5 );


        }
        private static void Menu()
        {
            Console.WriteLine("CHON VIEC CAN LAM: ");
            Console.WriteLine("1. => nhap so luong Bike: ");
            Console.WriteLine("2. => hien thi Bike: ");
            Console.WriteLine("3. => nhap so luong Car: ");
            Console.WriteLine("4. => hien thi Bike: ");
            Console.WriteLine("5. => thoat chuong trinh!");
            Console.WriteLine("----------------------");
        }
       
    }
}
