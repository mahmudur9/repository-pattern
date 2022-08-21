using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Please Enter your name")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Please Enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Enter your salary")]
        public int Salary { get; set; }
    }
}
