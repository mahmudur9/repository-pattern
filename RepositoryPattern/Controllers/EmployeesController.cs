using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Context;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var employees = await employeeRepository.EmployeeList();

            return Ok(employees);
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetData(Guid id)
        {
            var employee = await employeeRepository.GetEmployee(id);
            return Ok(employee);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Employee employee)
        {
            await employeeRepository.AddEmployee(employee);

            return Ok("Employee added successfully!");
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(Employee employee)
        {
            await employeeRepository .UpdateEmployee(employee);
            return Ok("Employee updated successfully!");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await employeeRepository.DeleteEmployee(id);
            return Ok("Employee deleted successfully!");
        }
    }
}
