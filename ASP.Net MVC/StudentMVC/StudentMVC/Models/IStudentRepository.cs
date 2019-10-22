using System.Collections.Generic;

namespace StudentMVC.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudentsAll { get; }
        Student GetStudentById(int id);
        Student UpdateStudent(Student student);
        Student AddStudent(Student student);
        Student DeleteStudent(int id);
        bool Commit();
    }
}
