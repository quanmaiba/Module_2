using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Dog : Animal/*, IBarkable, IRunable*/
    {
        //public void Bar()
        //{
        //    Console.WriteLine("wo,wo");
        //}


        //public void Run()
        //{
        //    Console.WriteLine("chay bang 4 chan");
        //}

        public override void Speak()
        {
            //throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
