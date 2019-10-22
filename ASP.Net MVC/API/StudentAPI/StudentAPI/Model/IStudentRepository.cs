using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Model
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudentsAll();
        Student GetStudentById(int id);
        Student UpdateStudent(Student student);
        Student AddStudent(Student student);
        Student DeleteStudent(int id);
        bool Commit();
    }

}
