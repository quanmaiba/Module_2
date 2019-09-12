using System;

namespace MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyArrayList myArrayList = new MyArrayList();

            myArrayList.Add(5);
            myArrayList.Add("ff");
            myArrayList.Add("sds");
            myArrayList.Add("sdas");

            foreach(var show in myArrayList)
            {
                Console.WriteLine(show);
            }

        }
    }
}
