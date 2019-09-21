using System;
using System.Collections.Generic;
using System.IO;

namespace BaiTapCSV
{
    class CsvReader
    {
        private string name;
        private string _csvFilePath;


        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }
        public Country[] ReadFistNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];
            try
            {
                using (StreamReader sd = new StreamReader(_csvFilePath))
                {
                    sd.ReadLine();
                    string rd = String.Empty;

                    for (int i = 0; i < countries.Length; i++)
                    {
                        countries[i] = ConvertEtelement(sd.ReadLine());

                    }

                }
            }
            catch
            {
                return countries;

            }

            return countries;

        }
        public List<Country> ReadAllCountries()
        {
            List<Country> Listcountries = new List<Country>();

            try
            {
                string[] length = File.ReadAllLines(_csvFilePath);
                using (StreamReader sr = new StreamReader(_csvFilePath))
                {
                    sr.ReadLine();
                    for (int i = length.Length; i > 0 ; i++)
                    {
                        Listcountries.Add(ConvertEtelement(sr.ReadLine()));
                    }
                }
            }
            catch
            {
                return Listcountries;
            }

            return Listcountries;
        }
        public Dictionary<string, Country> ReadallCountries()
        {
            Dictionary<string, Country> DictionaryCountries = new Dictionary<string, Country>();

            try

            {
                string[] length = File.ReadAllLines(_csvFilePath);
                using (StreamReader sr = new StreamReader(_csvFilePath))
                {
                    sr.ReadLine();
                    for (int i = length.Length; i > 0; i--)
                    {
                        ConvertEtelement(sr.ReadLine());
                        DictionaryCountries.Add(name, ConvertEtelement(sr.ReadLine()));
                    }
                }
            }
            catch
            {
                
                return DictionaryCountries;
            }

            return DictionaryCountries;
        }

        public Country ConvertEtelement(string line)
        {
            //Country country = new Country();        
            string[] chars = RemoteChar(line).Split(",");
            int indx = 0;

            if (chars.Length > 4)
            {
                name = chars[indx++] + chars[indx++];
            }
            else
            {
                name = chars[indx++];
            }

            string code = chars[indx++];
            string region = chars[indx++];
            int population;
            try
            {
                population = Convert.ToInt32(chars[indx++]);
            }
            catch
            {
                population = 0;
            }

            return new Country(name, code, region, population);
        }
        public string RemoteChar(string chars)
        {
            var remotechar = new string[] { ".", "@", "/", "'", ";", "\"" };
            for (int i = 0; i < remotechar.Length; i++)
            {
                chars = chars.Replace(remotechar[i], String.Empty);
            }
            return chars;
        }
        public void Show(int count)
        {
            int dem = 1;
            Console.WriteLine("Enter Number Show: ");
            int counts = Check();
            var arr = ReadFistNCountries(count);

            foreach (var item in arr)
            {
                Console.WriteLine($"{item.Population.ToString().PadRight(15)} : {item.Name.PadRight(20)}");
                if ((dem++) % counts == 0)
                {
                    Console.WriteLine("Show ?");
                    string str = Console.ReadLine();
                    if (str != "")
                    {
                        return;
                    }

                }

            }
        }
        public void InsertList()
        {

        }
        public void ShowList()
        {
            int dem = 1;
            Console.WriteLine("Enter Number Show: ");
            int counts = Check();
            var arr = ReadAllCountries();
          
            foreach (var item in arr)
            {
                Console.WriteLine($"{item.Population.ToString().PadRight(15)} : {item.Name.PadRight(20)}");
                if ((dem++) % counts == 0)
                {
                    Console.WriteLine("SHow ?");
                    string str = Console.ReadLine();
                    if (str != "")
                    {
                        return;
                    }

                }

            }
        }
        public void ShowDictionary()
        {
            int dem = 1;
            Console.WriteLine("Enter Number Show: ");
            int counts = Check();
            var arr = ReadallCountries();
            //arr.Sort();
            foreach (var item in arr)
            {
                Console.WriteLine($"{item.Value.Population.ToString().PadRight(15)} : {item.Key.PadRight(20)}");
                if ((dem++) % counts == 0)
                {
                    Console.WriteLine("SHow ?");
                    string str = Console.ReadLine();
                    if (str != "")
                    {
                        return;
                    }

                }

            }
        }
        public int Check()
        {
            int num;
            string str = Console.ReadLine();
            while (!int.TryParse(str, out num) || num < 1)
            {
                Console.Write("Enter Again: ");
                str = Console.ReadLine();
            }
            return num;
        }
    }
}
