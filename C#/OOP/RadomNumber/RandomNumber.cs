using System;
using System.Collections.Generic;
using System.Text;

namespace RadomNumber
{
    class RandomNumber
    {
        private static int m = 233280;
        private static int a = 9301;
        private static int c = 49297;
        private static int seed = 1;
       

        public static int M { get => m; set => m = value; }
        public static int A { get => a; set => a = value; }
        public static int C { get => c; set => c = value; }
        public static int Seed { get => seed; set => seed = value; }

        //public static int Result { set; }

        public static float GetFloat()
        {
            seed = (seed * a + c) % m;
            return Math.Abs(seed / m);
        }
        public static int GetInt(int max)
        {
           
            return Math.Round(max * GetFloat());
        }
    }
}
