using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = start_get();

            RootObject obj = JsonConvert.DeserializeObject<RootObject>(data);

            Console.WriteLine(obj.results[0].name.first);
            foreach (var item in obj.results)
            {
                //Console.WriteLine(item.id);
            }

            Console.ReadKey();
        }

        private static string start_get()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create
                (string.Format("https://randomuser.me/api"));
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            Stream Answer = WebResp.GetResponseStream();
            StreamReader _Answer = new StreamReader(Answer);
            string abc = _Answer.ReadToEnd();

            using (StreamWriter sw = new StreamWriter("text.json"))
            {
                sw.WriteLine(abc);
            }
            return abc;
        }

    }

}