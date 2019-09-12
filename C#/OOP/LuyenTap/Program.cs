using System;
using System.Collections;

namespace LuyenTap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string a = "  sdsad     dasdas  ";
        xuly:
            {
                a = a.Trim();

                Console.WriteLine(a);
                
                a = a.Replace("  ", " ");
             
                Console.WriteLine(a);
                bool dem = a.Contains(" ");
                if (dem == true)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    goto xuly;
                   
                }
            }
             
          

            var now = DayMontYear();
            Console.WriteLine($"Day: {now.Item1} , Month: {now.Item2}, Year: {now.Item3} Gio: {now.Item4} Phut: {now.Item5} Giay:{now.Item6} Khac:{now.Item7}");

            ArrayList arrPerson = new ArrayList();
            Hashtable hash = new Hashtable();
            Console.WriteLine(hash[""]);

            SortedList sortedList = new SortedList(new SortPerson());
            SortedList sortedList1 = new SortedList(sortedList ,new SortPerson());

            

            sortedList.Add(new Person("quan1", 15), "quan15");
            sortedList.Add(new Person("quan2", 17), "quan17");
            sortedList.Add(new Person("quan4", 13), "quan13");

            foreach(DictionaryEntry item in sortedList)
            {
                Console.WriteLine("key: " + item.Key + " value: " + item.Value);
            }

            for (int i = 0; i < 3; i++)
            {
                Person person = new Person();
                Console.Write("Ho va Ten: ");
                person.Name = Console.ReadLine();
                Console.Write("Tuoi: ");
                person.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                arrPerson.Add(person);
            }

            //arrPerson.Add(new Person("mai bai quan", 19));
            //arrPerson.Add(new Person("mai bai quan", 22));
            //arrPerson.Add(new Person("mai bai quan", 17));
            //arrPerson.Add(new Person("mai bai quan", 25));


            Console.WriteLine("Danh sach Person ban dau");
            foreach(Person item in arrPerson)
            {
               item.ShowData(); 
            }

            arrPerson.Sort(new SortPerson());

            Console.WriteLine();
            Console.WriteLine("danh sach tanwg dan:");
            foreach(Person item in arrPerson)
            {
                item.ShowData();
            }



        }
        static Tuple<int, int, int,int,int,int,int> DayMontYear()
        {
            DateTime now = DateTime.Now;

            return new Tuple<int, int, int,int, int, int,int>(now.Day, now.Month, now.Year,now.Hour,now.Minute,now.Second,now.Millisecond);
        }
    }
}
