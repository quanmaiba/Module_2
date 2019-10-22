using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MVCStudent.Models
{
    public class GroupRepository : IGroupRepository
    {
        private readonly MvcContext context;

        public GroupRepository(MvcContext context)
        {
            this.context = context;
        }

        public bool Commit()
        {
            try
            {
                context.SaveChanges();
                return false;
            }
            catch
            {
                return true;
            }
        }

        public Group DeleteGroup(int id)
        {
            var group = GetGroupById(id);
            if (group != null)
            {
                context.Groups.Remove(group);
            }

            return group;
        }

        public Group GetGroupById(int id)
        {
            var group = context.Groups.Find(id);
            return group;
        }

        public IEnumerable<Group> GetGroupsAll => context.Groups;


        public Group AddGroup(Group group)
        {
            context.Groups.Add(group);

            return group;
        }

        public Group UpdateGroup(Group group)
        {
            var entity = context.Groups.Attach(group);
            entity.State = EntityState.Modified;

            return group;
        }

    }
}
