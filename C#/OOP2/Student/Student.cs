using System;

namespace Student
{
    class Student : IStudent
    {
        private int id;
        private static int number = 1;

        public int ID { get => id; set => id = value; }
        public string FullName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Native { get; set; }
        public string Class { get; set; }
        public int PhoneNo { get; set; }
        public string Mobile { get; set; }

        public Student()
        {
            ID = ID + number;
            number++;
        }
        public Student(string fullName, DateTime dateofBirth, string native, string _class, int phoneNo, string mobile)
        {
            FullName = fullName;
            DateofBirth = dateofBirth;
            Native = native;
            Class = _class;
            PhoneNo = phoneNo;
            Mobile = mobile;
            ID = ID + number;
            number++;
        }
        public void Display()
        {
            Console.WriteLine($"Full name: {FullName};\n" +
               $"ID: {ID};\n" +
               $"Date of birth: {DateofBirth};\n" +
               $"Native: {Native};\n" +
               $"Class: {Class};\n" +
               $"Phone number: {PhoneNo};\n" +
               $"Mobile: {Mobile}.\n");
        }
    }
}
