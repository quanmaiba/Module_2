using System;
using System.IO;

namespace ex2Anhkhanh
{
    class Program
    {
        static string path = "text.txt";
        static string str;
        static int rows;
        static int columns;
        static StreamWriter sw;
        static StreamReader sr;
        static int[,] intArr;
        static void Main(string[] args)
        {
            Console.Write("enter rows: ");
            str = Console.ReadLine();

            while (!int.TryParse(str, out rows) || rows < 0 || rows > 50)
            {
                Console.Write("Enter Again; ");
                str = Console.ReadLine();
            }

            Console.Write("enter columns: ");
            str = Console.ReadLine();

            while (!int.TryParse(str, out columns) || columns < 0 || columns > 50)
            {
                Console.Write("Enter Again; ");
                str = Console.ReadLine();
            }
            Random rd = new Random();

            intArr = new int[rows, columns];
            using (sw = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {

                    for (int j = 0; j < columns; j++)
                    {
                        intArr[i, j] = rd.Next(1, 100);
                        sw.Write(intArr[i, j] + " ");
                    }
                    sw.WriteLine();

                }

                sw.Close();
            }
            intArr = Arr(path);
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
            Console.Clear();
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
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                sw.Write(intArr[i, j] + " ");
                            }
                            sw.WriteLine();

                        }
                    }
                    sw.Close();
                    break;
                case 5:
                    Console.Write("Enter number: ");
                    str = Console.ReadLine();
                    int number;
                    while (!int.TryParse(str, out number) || number < 0 || number > 100)
                    {
                        Console.Write("Enter again: ");
                        str = Console.ReadLine();
                    }
                    //FindElement(number);
                    if (FindElement(number) == " ")
                    {
                        Console.WriteLine("Not Found");
                    }
                    else
                    {
                        Console.WriteLine($"Number is found at: {FindElement(number)}");
                    }

                    break;
                case 6:
                    break;
            }
            Menu();
        }
        static int[,] Arr(string path)
        {
            using (sr = new StreamReader(path))
            {
                string number = string.Empty;
                int[,] arrint = new int[rows, columns];

                int i = 0;
                while ((number = sr.ReadLine()) != null)
                {
                    string[] content = number.Trim().Split(' ');
                    for (int j = 0; j < content.Length; j++)
                    {
                        arrint[i, j] = int.Parse(content[j]);
                        Console.Write(arrint[i, j] + " ");

                    }
                    i++;
                    Console.WriteLine();
                }
                return arrint;

            }

        }
        static int MaxArr()
        {
            int max = intArr[0, 0];
            foreach (var item in intArr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static int MinArr()
        {
            int min = intArr[0, 0];
            foreach (var item in intArr)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        static int SumArr()
        {
            int sum = 0;
            foreach (var item in intArr)
            {
                sum += item;
            }
            return sum;
        }
        static int[,] SortArr()
        {
            int n = columns * rows;
            int tmp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((intArr[i / rows, i % rows]) > (intArr[j / rows, j % rows]))
                    {
                        tmp = intArr[i / rows, i % rows];
                        intArr[i / rows, i % rows] = intArr[j / rows, j % rows];
                        intArr[j / rows, j % rows] = tmp;
                    }
                }
            }

            return intArr;
        }
        static string FindElement(int num)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (intArr[i, j] == num)
                    {
                        //Console.WriteLine($"Number is found at:  [{i},{j}] ");
                        return $"Number is found at:  [{i},{j}] ";

                    }
                }

            }
            //Console.WriteLine("Not Found");
            return " ";
        }
    }
}
