using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.EducationDtos
{
    public class CreateEducationDto : IDto
    {
        public int EmployeeID { get; set; }
        public string InstitutionName { get; set; }
        public int EducationTypeID { get; set; }
        public string? FacultyName { get; set; }
        public string? Ipecialty { get; set; }
        public string? DiplomaNumber { get; set; }
        public DateTime? DiplomaDate { get; set; }
        public bool IsMilitary { get; set; } = false;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
