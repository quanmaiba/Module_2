using System;
using System.IO;

namespace FileIo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteToFile("text.txt");
            //string text = "anhquan";
            //string result = null;
            ////RaedOnTex(text);

            //Console.WriteLine(result);
        }

        //private static void RaedOnTex(string text)
        //{
        //    string result = null;
        //    StringReader sr = new StringReader(text);
        //    string aLine = null;

        //    while (true)
        //    {
        //        aLine = sr.ReadLine();
        //        if (aLine != null)
        //        {
        //            result = result + aLine;
        //        }else
        //        {
        //            break;
        //        }

        //    }
        //    return result;
        //}

        private static void WriteToFile(string path)

        {
            Console.WriteLine("nhap ddo dai mang");
            int arr = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arr];
            StreamWriter sw = new StreamWriter(path);
            Random random = new Random();
            for (int i = 0; i < arr; i++)
            {
                sw.Write(random.Next(1, 100) + " ");
            }
            sw.Close();
        }
        private static void ShowMaxMin(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                int max = Convert.ToInt32(line);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    //if(line > max)
                    //{

                    //}
                }
            }
        }
    }
}
