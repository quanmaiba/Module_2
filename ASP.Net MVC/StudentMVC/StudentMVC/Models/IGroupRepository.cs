using System.Collections.Generic;

namespace StudentMVC.Models
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetStudentsAll();
        Group GetStudentById(int id);
        Group UpdateStudent(Group student);
        Group AddStudent(Group student);
        Group DeleteStudent(int id);
        bool Commit();
    }
}
