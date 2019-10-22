using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        Employee UpdateEmployee(Employee student);
        Employee AddEmployee(Employee student);
        Employee DeleteEmployee(int id);
        bool Commit();
    }
}
