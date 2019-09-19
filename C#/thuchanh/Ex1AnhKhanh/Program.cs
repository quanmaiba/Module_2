using System;
using System.IO;


namespace Ex1AnhKhanh
{
    class Program
    {
        static string str;
        static int length;
        static StreamWriter sw;
        static StreamReader sr;
        static string path = "texttest.txt";
        static int[] arr;

        static void Main(string[] args)
        {

            Console.Write("Nhap so luong mang: ");
            str = Console.ReadLine();
            while (!int.TryParse(str, out length) || length < 0 || length > 50)
            {
                Console.Write("NHAP LAI: ");
                str = Console.ReadLine();
            }
            Random rd = new Random();
            using (sw = new StreamWriter(path))
            {
                sw.WriteLine("Length: " + length);
                for (int i = 0; i < length; i++)
                {
                    sw.WriteLine(rd.Next(1, 100));
                }
            }
            arr = Arr(path);
            Menu();

        }
        static void Menu()
        {
            Console.WriteLine("CHON");
            Console.WriteLine("1. Tim Max");
            Console.WriteLine("2. Tim Min");
            Console.WriteLine("3. Tong array");
            Console.WriteLine("4. Sap xep mang");
            Console.WriteLine("5. Tim phan tu");
            Console.WriteLine("6. Exit");

            Console.Write("CHON: ");
            str = Console.ReadLine();
            int num;
            while (!int.TryParse(str, out num) || num < 0 || num > 6)
            {
                Console.Write("NHAP LAI: ");
                str = Console.ReadLine();
            }
            Play(num);
        }
        static void Play(int num)
        {
            //Console.Clear();
            switch (num)
            {
                case 1:
                    Console.WriteLine("max: " + MaxArr());
                    break;
                case 2:
                    Console.WriteLine("min: " + MinArr());
                    break;
                case 3:
                    Console.WriteLine("sum: " + SumArr());
                    break;
                case 4:
                    SortArr();
                    using (sw = new StreamWriter(path))
                    {
                        sw.WriteLine(length);
                        for (int i = 0; i < length; i++)
                        {
                            sw.WriteLine(arr[i] + " ");
                        }
                    }
                    break;
                case 5:
                    Console.Write("Enter the number: ");
                    str = Console.ReadLine();
                    int num1;
                    while (!int.TryParse(str, out num1) || num1 < 0 || num1 > 100)
                    {
                        Console.Write("NHAP LAI: ");
                        str = Console.ReadLine();
                    }
                    if (FindElement(num1) == (-1))
                    {
                        Console.WriteLine("Not Found");
                    }
                    else
                    {
                        Console.WriteLine($"Number is found at: {FindElement(num1)}");
                    }

                    break;
                case 6:
                    break;
            }

            Menu();
        }
        static int[] Arr(string path)
        {
            int[] arrint = new int[length];
            using (sr = new StreamReader(path))
            {
                string number = string.Empty;

                while ((number = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < arrint.Length; i++)
                    {
                        arrint[i] = int.Parse(sr.ReadLine());
                    }
                }
            }
            return arrint;
        }
        static int MaxArr()
        {
            int max = arr[0];
            for (int i = 0; i < length; i++)
            {
                max = Math.Max(max, arr[i]);
                //if(arr[i] > max)
                //{
                //    max = arr[i];
                //}                      
            }
            return max;
        }
        static int MinArr()
        {
            int min = arr[0];
            for (int i = 0; i < length; i++)
            {
                min = Math.Min(min, arr[i]);
                //if(arr[i] > max)
                //{
                //    max = arr[i];
                //}                      
            }
            return min;
        }
        static int SumArr()
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += arr[i];
                //if(arr[i] > max)
                //{
                //    max = arr[i];
                //}                      
            }
            return sum;
        }
        static int[] SortArr()
        {
            int i, j, tmp;
            for (i = 0; i < length; i++)
            {
                for (j = length - 1; j > i; j--)
                {
                    if (arr[j] < arr[i])
                    {
                        //cach trao doi gia tri
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }
        static int FindElement(int num)
        {

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == num)
                {
                    return i;

                }

            }
            return -1;
        }
    }
}
