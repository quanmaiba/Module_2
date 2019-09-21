using System;

namespace BaiTapCSV
{
    class Program
    {
        static CsvReader reader;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string filePath = "D:/CSV/country.csv";
            reader = new CsvReader(filePath);
            //Console.Write("Enter number Show: ");
            //int count = Check();
            //reader.Show(217);
            //reader.ShowList();
            reader.ShowDictionary();
        }


    }
}
