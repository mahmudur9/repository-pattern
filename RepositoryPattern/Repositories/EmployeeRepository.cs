using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Context;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DBContext context;
        public EmployeeRepository(DBContext context)
        {
            this.context = context;
        }
        public async Task AddEmployee(Employee employee)
        {
            await context.AddAsync(employee);
            await context.SaveChangesAsync();
        }

        public async Task DeleteEmployee(Guid id)
        {
            var employee = context.Employees.Find(id);
            context.Employees.Remove(employee);
            await context.SaveChangesAsync();
        }

        public async Task<IList<Employee>> EmployeeList()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(Guid id)
        {
            return await context.Employees.FindAsync(id);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            context.Update(employee);
            await context.SaveChangesAsync();
        }
    }
}
