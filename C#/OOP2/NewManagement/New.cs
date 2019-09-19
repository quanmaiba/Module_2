using System;
using System.Collections.Generic;

namespace NewManagement
{
    class New : INew
    {

        private int id;
        private DateTime publishDate;
        //public int ID { get; set; }
        private New news;
        private List<int> list;
        private static int num = 1;
        private static int length = 3;
        public int ID { get => id; set => id = value; }
        public string Title { get; set; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverageRate { get; private set; }
        private static int Length1 { get => length; set => length = value; }

        public List<int> Ratelist { get => list; set => list = value; }

        //int[] RateList = new int[Length1];



        public New()
        {

        }
        public New(string title, DateTime publishDate, string author, string content)
        {
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
            Ratelist = new List<int>();

            id = ID + num;
            num++;

        }
        public void Display()
        {
            Console.WriteLine($"Id:{ID} Title: {Title}, publish date: {PublishDate}, author: {Author}, content: {Content}  danh gia tb: {Averagerate()}.");
        }
        //average rate: {Averagerate()}
        //public int this[int index]
        //{
        //    get {

        //            return RateList[index];

        //    }
        //    set
        //    {
        //        if (index >= 0 && index < 3)
        //        {
        //            RateList[index] = value;
        //        }
        //    }
        //}
        public void Calucate()
        {
            Console.WriteLine("danh gia trung binh:" + Averagerate());
            Display();

            //foreach (var item in RateList)
            //{
            //    AverageRate += (float)item / dodai;
            //}
            //return AverageRate;
        }
        public float Averagerate()
        {
            var sum = 0;
            var dodai = Ratelist.Count;
            for (int i = 0; i < dodai; i++)
            {
                sum += Ratelist[i];
            }
            return AverageRate = (float)sum / dodai;
        }


    }
}
