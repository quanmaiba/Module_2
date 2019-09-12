using System;

namespace Complex_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ComplexNumber number = new ComplexNumber(5,2);
            Console.WriteLine("Number is: " + number.ToString());

            number.SetImaginary(-3);
            Console.WriteLine(number.ToString());
            number.SetReal(6);
            Console.WriteLine(number.ToString());
            Console.WriteLine("gia tri: " + number.GetMagnitude());

            ComplexNumber number1 = new ComplexNumber(-1, 1);
            number.Add(number1);
            Console.WriteLine("Add vao: " + number.ToString());
            Console.WriteLine("kq: " + number.GetMagnitude());
            Console.WriteLine("kq tong: " + number.GetSum() + " hieu: " + number.GetHieu());
        }
    }
}
