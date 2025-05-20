using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.EmployeeFamilyMemberDtos
{
    public class UpdateEmployeeFamilyMemberDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public int RelativeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string FirstNameOld { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FIN { get; set; }
        public string Address { get; set; }
    }
}
