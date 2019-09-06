using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9()
            //ex10();
            //ex11();
            //ex12();
            //ex13();
            //ex14();
            //ex15();
            //ex16();
            //ex17();
            //ex18();
            //ex19();
            //ex20();
            //ex21();
            //ex23();
            //ex24();
            //ex25();
            //ex26();
            //ex27();
            //ex28();
            //ex29();
            //ex30();
            //ex31();
            //ex32();
            //ex33();
            //ex34();
            //ex35();
            //ex36();
            //ex37();
            //ex38();
            //ex39();
            //ex40();
            //ex41();
            //ex42();
            //ex43();
            //ex44();
            //ex45();
            //ex46();
            //ex47();
            //ex48();
            //ex49();
            //ex50();
            //ex51();
            //ex52();
            //ex53();
            //ex50();
            //ex50();
            //ex50();
            //ex50();
            //ex50();
            //ex50();
            //ex50();

            //Console.ReadKey();
        }
        //Console.WriteLine("Hello");
        //Console.WriteLine("Alexandra Abramov ");
        //Console.Write("nhap so a: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.Write("nhap so b: ");
        //int b = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"tong hai so: {a} + {b} = {a + b}");
        //Console.WriteLine($"phep chia hai so:  {a} / {b} = {a / b}");
        //Console.WriteLine();

        //Console.Write("Tong bieu thuc\n");
        //Console.WriteLine($"tong bieu thuc sau: -1 + 4 * 6 = {-1 + 4 * 6}");
        //Console.WriteLine($"tong bieu thuc sau: (35 + 5) % 7 = {(35 + 5) % 7}");
        //Console.WriteLine($"tong bieu thuc sau: 14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
        //Console.WriteLine($"tong bieu thuc sau: 2 + 15/6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");

        static void ex5() {
            Console.Write("Bai 5:Hoan doi vi tri\n");
            Console.WriteLine();
            Console.Write("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"gia tri a hoan doi: {a} ");
            Console.WriteLine($"gia tri a hoan doi: {b} ");
        }
        static void ex6() {
            Console.Write("Bai6: Nhan ba so \n");
            Console.WriteLine();
            Console.Write("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ket qua nhan ba so: {a} x {b} x {c} = {a * b * c} ");
        }

        static void ex7() {

            Console.Write("Bai7: tinh tat ca \n");
            Console.WriteLine();
            Console.Write("nhap so c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"tong 2 so: {c} + {d} = {c + d}");
            Console.WriteLine($"hieu 2 so: {c} - {d} = {c - d}");
            Console.WriteLine($"nhan 2 so: {c} x {d} = {c * d}");
            Console.WriteLine($"chia 2 so: {c} / {d} = {c / d}");
            Console.WriteLine($"chia lay du 2 so: {c} % {d} = {c % d}");
        }
        static void ex8()
        {
            Console.Write("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($" {a} x {i} = {a * i}");
            }
        }
        static void ex9()
        {
            Console.Write("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            decimal kq = (a + b + c + d) / 4;
            var kq1 = Math.Round(kq, 2);
            Console.WriteLine(kq1);
            Console.WriteLine($"trung binh: ({a} + {b} + {c} + {d}) / 4 = {kq} ");

        }
        static void ex10()
        {
            Console.Write("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"({a} + {b}) x {c} = {(a + b) * c}");
            Console.WriteLine($"{a}x{b} + {b}x{c} = {a * b + b * c}");
        }
        static void ex11()
        {
            Console.Write("nhap do tuoi: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 20)
            {
                Console.WriteLine($" ban trog gia hon 20 day");
            } else Console.WriteLine($" ban trog con tre day");
        }
        static void ex12()
        {
            Console.Write("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{a}{b} {a}{b} {a}{b} {a}{b}");
                Console.WriteLine($"{a}{b}{a}{b}{a}{b}{a}{b}");
            }
        }
        static void ex13()
        {
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }
        static void ex14()
        {
            Console.Write("nhap do C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"tu do C sang do K: { c + 273} ");
            Console.WriteLine($"tu do C sang do K: { c * 18 / 10 + 32} ");
        }
        static void ex15()
        {
            Console.Write("nhap chuoi: ");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1);
            Console.Write("nhap ky tu muon xoa: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(remove_char(str1, n));
        }
        public static string remove_char(string str1, int n)
        {
            return str1.Remove(n, 1);
        }
        static void ex16()
        {
            Console.Write("nhap chuoi: ");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1);

            Console.WriteLine(fist_last(str1));
        }
        public static string fist_last(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
        static void ex17()
        {
            Console.Write("nhap chuoi: ");
            string str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }
        static void ex18()
        {
            Console.Write("nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            bool c = (a < 0 & b > 0 || a > 0 & b < 0) ? true : false;
            Console.WriteLine(c);
        }
        static void ex19()
        {
            Console.Write("nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(result(a, b));
        }
        public static int result(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
        static void ex20()
        {
            Console.Write("nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(result1(a, b));
        }
        public static int result1(int a, int b)
        {
            return a > b ? (a - b) * 2 : b - a;
        }

        static void ex21() {
            Console.Write("nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(result2(a, b));
        }
        public static bool result2(int a, int b)
        {
            if (a == 20 || b == 20 || a + b == 20)
            {
                return true;
            }
            return false;
        }
        static void ex23()
        {
            Console.Write("nhap chuoi: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.ToLower());
        }
        static void ex24()
        {
            Console.Write("nhap chuoi: ");
            string str = Console.ReadLine();

            Console.WriteLine(check(str));
        }
        public static string check(string str)
        {
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string obj = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    obj = s;
                    ctr = s.Length;
                }
            }
            return obj;
        }
        static void ex25() {
            for (int i = 1; i < 100; i += 2) {
                Console.WriteLine(i);
            }
        }
        static void ex26()
        {
            Console.WriteLine("Sum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr< 500)
            {
                if (isPrime(n))
                {
                    Console.WriteLine(n);
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine("Sum = " + sum.ToString());

        }
        public static bool isPrime(int n)
        {
            if (n < 2) return false;

            int x = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 2; i <= x; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
static void ex27()
        {
            Console.Write("nhap so: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine($"tong cua chu so: {sum} ");
        }
        static void ex28()
        {
            Console.Write("nhap chuoi: ");
            string line = Console.ReadLine();
            Console.WriteLine("chuoi ban dau: " + line);
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = line.Split(new[] {
             " "
                }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach (String s in wordsList)
            {

                Console.WriteLine("chuoi moi: " + s);
            }
        }
        static void ex29()
        {
            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
        }
        static void ex30()
        {
            string hexval = "6B5";
            Console.WriteLine("Hexadecimal number: " + hexval);
            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: " + decValue);
        }
        static void ex31()
        {
            int[] arr1 = { 1, 3, -5, 4 };
            int[] arr2 = { 1, 3, -5, 4 };

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] * arr2[i] + " ");
            }
        }

        static void ex32()
        {
            Console.Write("nhap chuoi: ");
            string str = Console.ReadLine();
            var str2 = str.Substring(str.Length - 4);
            if (str.Length < 4)
            {
                Console.WriteLine(str);
            } else { Console.WriteLine(str2 + str2 + str2 + str2); }


        }
        static void ex33()
        {
            Console.Write(" nhap so: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 3 == 0)
            {
                Console.WriteLine($"{a} la boi so cua 3");
            } else if (a % 7 == 0)
            {
                Console.WriteLine($"{a} la boi so cua 7");
            }

        }
        static void ex34()
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        }
        static void ex35()
        {
            Console.Write("Input a first number(<100): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number(>200): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m < 100 && n > 200) || (m > 200 && n < 100));
        }
        static void ex36()
        {
            Console.Write("Input a first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m >= -10 && m <= 10) ? true : false);
            Console.WriteLine((n >= -10 && n <= 10) ? true : false);
        }
        static void ex37()
        {
            string str = "PHP Tutorial";
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
        }
        static void ex38()
        {
            string str1 = "PHP Tutorial";
            var result = "";

            if (str1.Length >= 1 && str1[0] == 'P')
                result += str1[0];
            if (str1.Length >= 2 && str1[1] == 'H')
                result += str1[1];
            Console.WriteLine(result);
        }
        static void ex39()
        {
            Console.Write("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("so lon nhat:" + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("so nho nhat:" + Math.Min(a, Math.Min(b, c)));
        }
        static void ex40()
        {
            Console.Write("nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = 20;

            var value1 = Math.Abs(a - n);
            var value2 = Math.Abs(b - n);

            Console.WriteLine(value1 == value2 ? 0 : (value1 > value2 ? b : a));
        }
        static void ex41()
        {
            Console.Write("Input a string (conatins at least one 'w' char) : ");
            string str = Console.ReadLine();
            var count = str.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);
        }
        static void ex42()
        {
            Console.Write("nhap chuoi: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.Length);

            if (str.Length < 4)
            {
                Console.WriteLine(str.Substring(0, 3).ToUpper());
            }
            else
            {
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
            }

        }
        static void ex43()
        {
            Console.Write("nhap chuoi: ");
            string str = Console.ReadLine();

            Console.WriteLine((str.StartsWith('w') || str.Substring(0, 2).StartsWith("ww")) ? true : false);
        }
        static void ex44()
        {
            Console.Write("nhap chuoi lon 2 ky tu: ");
            string str = Console.ReadLine();

            if (str.Length > 2)
            {
                for (int i = 1; i < str.Length; i += 2)
                {
                    Console.Write("chuoi moi: " + str.Substring(i, 1));
                }
            }
            else Console.WriteLine("chuoi loi");
        }
        static void ex45()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine();
            Console.Write("nhap so muon dem: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of " + x + " present in the said array:");
            Console.WriteLine(nums.Count(n => n == x));
        }
        static void ex46()
        {
            Console.Write("nhap so: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 52, 45, 2, 35, 6, 2, 2, 6, 2 };
            if (arr.Length > 0)
            {
                Console.WriteLine((arr[0] == num || arr[arr.Length - 1] == num) ? true : false);
            }
        }
        static void ex47()
        {
            int sum = 0;
            int[] arr = new int[10];
            for(int i= 0; i < 10; i++)
            {
                Console.Write($"nhap pha tu vi tri index {i} :   ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine($"tong tat ca: {sum}");
        }
        static void ex48()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(string.Join(", ", arr));

            Console.WriteLine((arr.Length > 1) && (arr[0].Equals(arr[arr.Length - 1])));

        }
        static void ex49()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(string.Join(", ", arr));
            int[] arr1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine(string.Join(", ", arr1));

            Console.WriteLine((arr[0].Equals(arr1[arr1.Length-1]))||(arr[arr.Length-1].Equals(arr1[0])));
        }
        static void ex50()
        {
            int[] arr = { 1, 3, 4, 5 };
            Console.WriteLine(string.Join(",", arr));

            int temp = arr[0];

            for (int i =0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;

            Console.WriteLine(string.Join(",", arr));
        }
        static void ex51()
        {
            int[] arr = { 1, 3, 4, 5 };
            Console.WriteLine(string.Join(",", arr));
            int max = arr[0];

            if (arr.Length > 2)
            {        
                if (arr[arr.Length-1] > max)
                {
                    max = arr[arr.Length-1];
                }               
                Console.WriteLine(max);                
            }   
        }
        static void ex52()
        {
           
            int[] arr1 = { 1, 2, 5 };
            int[] arr2 = { 0, 3, 8 };
            int[] arr3 = { -1, 0, 2 };

            Console.WriteLine(string.Join("," ,arr1));
            Console.WriteLine(string.Join(",", arr2));
            Console.WriteLine(string.Join(",", arr3));

            Console.WriteLine($"{arr1[1]},{arr2[1]},{arr3[1]}"); 
        }
        static void ex53()
        {
            int[] arr = { 2, 4, 7, 8, 6 };

            Console.WriteLine(string.Join(",",arr));

            Console.WriteLine(check53(arr));
        }
        public static bool check53(int[] arr)
        {
            for (int i = 0; i < arr.Length; i ++)
            {
                if (arr[i] % 2 == 0)
                {
                    return false;
                }
               
            }
            return true;
        }
        static void ex54()
        {

        }
    }
}


