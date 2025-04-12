using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.Employee
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? OldLastName { get; set; }
        public string? Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
    }
}
