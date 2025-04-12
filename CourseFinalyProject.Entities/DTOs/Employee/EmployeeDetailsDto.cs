using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.Employee
{
    public class EmployeeDetailsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? OldLastName { get; set; }
        public string? Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string Country { get; set; }
        public string RegistrationAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string IdentityCardNumber { get; set; }
        public string PIN { get; set; }
        public string BloodName { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
    }
}
