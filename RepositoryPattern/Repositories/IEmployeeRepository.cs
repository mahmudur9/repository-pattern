using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IList<Employee>> EmployeeList();
        Task<Employee> GetEmployee(Guid id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(Guid id);
    }
}
