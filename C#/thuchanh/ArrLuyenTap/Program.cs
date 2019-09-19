using System;
using System.Collections.Generic;
using System.Linq;

namespace LuyenTap
{
    class Program
    {
        const int LENGTH = 10000;
        static Random rd = new Random();
        static int[] arr = new int[LENGTH];
        static List<int> list = new List<int>();
        static void Main(string[] args)
        {

            foreach (var item in list)
            {
                //Console.Write(item + ", ");
            }
            var startTime1 = DateTime.Now;
            for (int i = 0; i < LENGTH; i++)
            {
                arr[i] = rd.Next(1, 100);
                //Console.Write(arr[i] + ", ");
            }
            var time1 = DateTime.Now.Subtract(startTime1);

            Console.WriteLine($"\r\nExecution Array time: {time1.Ticks} (ticks) = {time1.Milliseconds} (ms)");

            var startTime = DateTime.Now;
            for (int j = 0; j < LENGTH; j++)
            {
                list.Add(rd.Next(1, 100));
            }
            var time = DateTime.Now.Subtract(startTime);
            Console.WriteLine($"\r\nExecution List time: {time.Ticks} (ticks) = {time.Milliseconds} (ms)");



            //SortArr();
            //SortList();

            //if (IndexArr(75) == -1)
            //{
            //    Console.WriteLine("loi");
            //}
            //else
            //{
            //    Console.WriteLine(IndexArr(75));
            //}



            //if (IndexList(75) == -1)
            //{
            //    Console.WriteLine("loi");
            //}
            //else
            //{
            //    Console.WriteLine(IndexList(75));
            //}

            //int index = 39;
            //DeleteArr(index);
            //DeleteList(index);

            //var startTime4 = DateTime.Now;

            //for (int i = 0; i < LENGTH; i++)
            //{
            //    if (i == index)

            //        list.RemoveAt(list[i]);
            //    break;
            //}
            //var time4 = DateTime.Now.Subtract(startTime4);
            //Console.WriteLine($"\r\nExecution List time: {time4.Ticks} (ticks) = {time4.Milliseconds} (ms)");

        }
        static void DeleteList(int index)
        {
            var startTime3 = DateTime.Now;

            for (int i = 0; i < LENGTH; i++)
            {
                if (i == index)

                    list.RemoveAt(list[i]);
                break;
            }
            var time3 = DateTime.Now.Subtract(startTime3);
            Console.WriteLine($"\r\nExecution Delete List time: {time3.Ticks} (ticks) = {time3.Milliseconds} (ms)");
        }
        static void DeleteArr(int index)
        {
            var startTime3 = DateTime.Now;
            arr = arr.Where((idx) => idx != index).ToArray();
            var time3 = DateTime.Now.Subtract(startTime3);
            Console.WriteLine($"\r\nExecution Delete Array time: {time3.Ticks} (ticks) = {time3.Milliseconds} (ms)");
        }
        static void SortList()
        {
            int i, j, tmp;
            var startTime3 = DateTime.Now;

            for (i = 0; i < LENGTH; i++)
            {
                for (j = LENGTH - 1; j > i; j--)
                {
                    if (arr[j] < arr[i])
                    {
                        //cach trao doi gia tri
                        tmp = list[i];
                        list[i] = list[j];
                        list[j] = tmp;
                    }
                }
            }
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}          
            var time3 = DateTime.Now.Subtract(startTime3);
            Console.WriteLine($"\r\nExecution Sort List time: {time3.Ticks} (ticks) = {time3.Milliseconds} (ms)");
        }
        static void SortArr()
        {
            int i, j, tmp;
            var startTime3 = DateTime.Now;
            for (i = 0; i < LENGTH; i++)
            {
                for (j = LENGTH - 1; j > i; j--)
                {
                    if (arr[j] < arr[i])
                    {
                        //cach trao doi gia tri
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //var time1 = DateTime.Now.Subtract(startTime1);
            var time3 = DateTime.Now.Subtract(startTime3);
            Console.WriteLine($"\r\nExecution Sort Array time: {time3.Ticks} (ticks) = {time3.Milliseconds} (ms)");
        }
        static int IndexArr()
        {
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < LENGTH; i++)
            {
                if (arr[i] == value)

                    return i;
            }
            return -1;
        }
        static int IndexList(int value)
        {
            for (int i = 0; i < LENGTH; i++)
            {
                if (list[i] == value)

                    return i;
            }
            return -1;
        }
        static void IndexBinaryArray()
        {

        }

    }
}

