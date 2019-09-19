using System;

namespace Student
{
    interface IStudent
    {
        string FullName { get; set; }
        int ID { get; set; }
        DateTime DateofBirth { get; set; }
        string Native { get; set; }
        string Class { get; set; }
        int PhoneNo { get; set; }
        string Mobile { get; set; }

        void Display();

    }
}
