using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.Employee
{
    public class EmployeeInfoDto
    {
        public int EmployeeID { get; set; }
        public string Country { get; set; }
        public string RegistrationAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string IdentityCardNumber { get; set; }
        public string PIN { get; set; }
        public int BloodID { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
    }
}
