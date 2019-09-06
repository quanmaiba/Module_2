using System;

namespace OOP
{

    class Person
    {
        protected static int age;
        public virtual void Greet()
        {
            Console.WriteLine("Hello");
        }
        public static void SetAge(int n)
        {
            age = n;
        }
        public static void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
    class Student : Person
    {
        public static void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }
       
    }
    class Teacher : Person
    {
        public override void Greet()
        {
            Console.WriteLine("Hello class");
        }
        public static void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
    class StudentAndTeacherTest {
        static  void Main()
        {
            Person teacher = new Teacher();

            Person person = new Person();
            person.Greet();
            //Student student = new Student();
            Student.SetAge(21);
            Student.GoToClasses();
            Student.ShowAge();

            //Teacher teacher = new Teacher();
            Teacher.SetAge(30);
            Teacher.ShowAge();
            teacher.Greet();
           
            Teacher.Explain();

    
        }
    }
}
