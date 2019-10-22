using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Model
{
    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext context;

        public GroupRepository(AppDbContext context)
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

        public Group DeleteStudent(int id)
        {
            var group = GetStudentById(id);
            if (group != null)
            {
                context.Groups.Remove(group);
            }

            return group;
        }

        public Group GetStudentById(int id)
        {
            var group = context.Groups.Find(id);
            return group;
        }

        public IEnumerable<Group> GetStudentsAll()
        {
            return context.Groups.ToList();
        }

        public Group AddStudent(Group group)
        {
            context.Groups.Add(group);

            return group;
        }

        public Group UpdateStudent(Group group)
        {
            var entity = context.Groups.Attach(group);
            entity.State = EntityState.Modified;

            return group;
        }
        
    }

}
