using System;
using System.Collections.Generic;
using System.Text;

namespace NewManagement
{
    class New : INew
    {
        private DateTime publishDate;
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverageRate { get; }
     
        public void Display()
        {
            Console.WriteLine($"Title: {Title}, publish date: {PublishDate}, author: {Author}, content: {Content}, average rate: {AverageRate}.");
        }
    }
}
