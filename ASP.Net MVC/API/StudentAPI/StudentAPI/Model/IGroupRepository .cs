using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Model
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
