using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public MockEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public bool Commit()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Employee DeleteEmployee(int id)
        {
            var student = GetEmployeeById(id);
            if (student != null)
            {
                context.Employees.Remove(student);
            }

            return student;
        }

        public Employee GetEmployeeById(int id)
        {
            var student = context.Employees.Find(id);
            return student;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees.ToList();
        }

        public Employee AddEmployee(Employee student)
        {
            context.Employees.Add(student);

            return student;
        }

        public Employee UpdateEmployee(Employee student)
        {
            var entity = context.Employees.Attach(student);
            entity.State = EntityState.Modified;

            return student;
        }
    }
}
