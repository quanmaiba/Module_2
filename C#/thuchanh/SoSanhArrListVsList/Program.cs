using System;
using System.Collections;
using System.Collections.Generic;

namespace SoSanhArrListVsList
{
    class Program
    {
        const int LENGTH = 100;
        static ArrayList arrayList = new ArrayList();
        static List<int> List = new List<int>();
        static Random rd = new Random();
        //const int VALUE = 50;
        static int index;
        static int value;
        static string str;
        static int count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CrArrList();
            CrList();
            SrArrList();
            SrList();
            UpdateArrList();
            UpdateList();
            DelList();
            DelArrList();
        }
        static void CrArrList()
        {
            var startTime = DateTime.Now;
            for (int i = 0; i < LENGTH; i++)
            {
                arrayList.Add(rd.Next(1, 100));
            }
            var time = DateTime.Now.Subtract(startTime);
            Console.WriteLine($"\r\nExecution ArrayList time: {time.Ticks} (ticks) = {time.Milliseconds} (ms)");

        }
        static void CrList()
        {
            var startTime = DateTime.Now; 
            for (int i = 0; i < LENGTH; i++)
            {
                List.Add(rd.Next(1, 101));
            }
            var time = DateTime.Now.Subtract(startTime);
            Console.WriteLine($"\r\nExecution List time: {time.Ticks} (ticks) = {time.Milliseconds} (ms)\n");

        }
        static void SrArrList()
        {
            
            ShowArrList();
            value = Check();

            index = arrayList.IndexOf(value);
            if(index == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"value index : {index}");
            }
           
        }
        static void SrList()
        {
            Console.WriteLine($"\n  \n");
            ShowList();
            value = Check();
            index = List.IndexOf(value);
            if (index == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"value index : {index}");
            }

        }

        static void UpdateArrList()
        {
        //    Console.Clear();
            Console.WriteLine("Enter number want update Array List: \n ");
            //ShowArrList();

            value = Check();
            Console.WriteLine("Enter value want update: ");
            string value1 = Console.ReadLine(); 
            bool check = false;
            var start = DateTime.Now;

            for (int i = 0; i < LENGTH; i++)
            {
                if (arrayList[i].Equals(value))
                {
                    Console.WriteLine($"Have number: {value} index {i}");
                    arrayList[i] = value1;
                    count++;
                    check = true;
                }

            }
            if (!check)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("EDIT FINISHED");
            }
            Console.WriteLine(count);
            ////ShowArrList();
            var time = DateTime.Now.Subtract(start);
            Console.WriteLine($"\r\nExecution Update ArrayList time: {time.Ticks} (ticks) = {time.Milliseconds} (ms)\n");
        }
        static void UpdateList()
        {
            //Console.Clear();
            Console.WriteLine("Enter number want update List: \n ");
            //ShowList();

            value = Check();
            Console.WriteLine("Enter value want update: ");
            int value1 = Check();
            bool check = false;
            var start = DateTime.Now;           

            for (int i = 0; i < LENGTH; i++)
            {
                if (List[i].Equals(value))
                {
                    Console.WriteLine($"Have number: {value} index {i}");
                    List[i] = value1;
                    count++;
                    check = true;
                }

            }
            if (!check)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("EDIT FINISHED");
            }
            Console.WriteLine(count);
            //ShowList();
            var time = DateTime.Now.Subtract(start);
            Console.WriteLine($"\r\nExecution Update ArrayList time: {time.Ticks} (ticks) = {time.Milliseconds} (ms)\n");
        }
        static int Check()
        {
            int value1;
            Console.WriteLine("\nEnter Number: \n");
            str = Console.ReadLine();
            while (!int.TryParse(str, out value1) || value1 < 1)
            {
                Console.WriteLine("Enter Again: ");
                str = Console.ReadLine();
            }
            return value1;
        }
        static void ShowArrList()
        {
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }

        }
        static void ShowList()
        {
            foreach (var item in List)
            {
                Console.Write(item + " ");
            }

        }

        static void DelList()
        {
            //Console.Clear();
            Console.WriteLine("enter number want delete on List: ");
            //ShowList();

            value = Check();         
            bool check = false;
            var start = DateTime.Now;

            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Equals(value))
                {
                    List.RemoveAt(List[i]);
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("DELETE FINISHED");
            }
            Console.WriteLine(count);
            //ShowList();
            var time = DateTime.Now.Subtract(start);
            Console.WriteLine($"\r\nExecution Delete List time: {time.Ticks} (ticks) = {time.Milliseconds} (ms)");
        }
        static void DelArrList()
        {
            //Console.Clear();
            Console.WriteLine("enter number want delete on ArrList: ");
            //ShowList();

            value = Check();
            bool check = false;
            var start = DateTime.Now;

            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i].Equals(value))
                {
                    arrayList.Remove(arrayList[i]);
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("DELETE FINISHED");
            }
            Console.WriteLine(count);
            //ShowList();
            var time = DateTime.Now.Subtract(start);
            Console.WriteLine($"\r\nExecution Delete ArrayList time: {time.Ticks} (ticks) = {time.Milliseconds} (ms)");
        }
    }
}
