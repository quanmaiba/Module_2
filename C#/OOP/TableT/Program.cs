using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Leg leg = new Leg(2);
            //table.ShowData();

            Table table = new Table( 200 ,100);
            table.ShowData();

            Leg leg = new Leg(2);
            leg.ShowData();
            Console.WriteLine("\nsinh ra mang 10 table\n");

            Table[] tab = new Table[10];
            Random rd = new Random();

            for(int i =0; i<10; i++)
            {
                tab[i] = new Table(rd.Next(20, 201), rd.Next(50, 201));
            tab[i].ShowData(); 
            }
            Console.WriteLine("-------------");

            for(int i =0; i <10; i++)
            {
                if (i % 2 == 0)
                {
                    tab[i] = new Table(rd.Next(50, 201), rd.Next(50, 201));
                    tab[i].ShowData();
                }else
                {
                    tab[i] = new CoffeeTable(rd.Next(40, 121), rd.Next(40, 121));
                    tab[i].ShowData();
                }
            }
        }
    }
}
