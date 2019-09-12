using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_numbers
{
    class ComplexNumber
    {
        private double b;
        private double a;

        public ComplexNumber(double a , double b)
        {
            A = a;
            B = b;
        }

        protected double A { get => a; set => a = value; }
        protected double B { get => b; set => b = value; }

        public new string ToString()
        {
            return "(" + A + "," + B + ")";
        }
        public void SetImaginary(double b)
        {
          B = b;
        }
        public void SetReal(double a)
        {
            A = a;
        }

        public double GetMagnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }
        public double GetSum()
        {
            return a + b;
        }
        public double GetHieu()
        {
            return a - b;
        }
        public void Add(ComplexNumber c2)
        {
            a += c2.A;
            b += c2.B;
        }
    }
}
