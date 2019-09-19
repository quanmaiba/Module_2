using System;

namespace NewManagement
{
    interface INew
    {
        int ID { get; set; }
        string Title { get; set; }
        DateTime PublishDate { get; set; }
        string Author { get; set; }
        string Content { get; set; }
        float AverageRate { get; }

        void Display();
    }
}
