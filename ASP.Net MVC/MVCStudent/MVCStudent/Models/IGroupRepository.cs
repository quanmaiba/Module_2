using System.Collections.Generic;

namespace MVCStudent.Models
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetGroupsAll { get; }
        Group GetGroupById(int id);
        Group UpdateGroup(Group student);
        Group AddGroup(Group student);
        Group DeleteGroup(int id);
        bool Commit();
    }
}
