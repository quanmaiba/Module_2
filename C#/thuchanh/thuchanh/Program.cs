using System;

namespace thuchanh
{
    class Program
    {
        private static int getLength;

        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.LastName = "quan";
            //double score;
            //Console.WriteLine("Hello World!");
            //Console.Write("nhap so diem:");
            //string hocsinh = Console.ReadLine();
            //bool isNumber = double.TryParse(hocsinh, out score);

            //while (!isNumber ||score > 10 ||score < 0)
            //{
            //    Console.Write("nhap lai so diem:");
            //    hocsinh = Console.ReadLine();
            //    isNumber = double.TryParse(hocsinh, out score);
            //}
            //if (score <= 10 || score >= 0)
            //    Console.WriteLine($"diem cua ban: {hocsinh} ");
            Console.Write("nhap so hang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so cot: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"nhap phan tu {i}{j}: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());

                    sum += array[i, j];
                }
            }
            Console.WriteLine(sum);

        }
        static void vd1()
        {

        }
    }
}
