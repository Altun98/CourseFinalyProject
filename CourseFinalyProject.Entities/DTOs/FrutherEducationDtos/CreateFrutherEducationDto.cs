using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.FrutherEducationDtos
{
    public class CreateFrutherEducationDto : IDto
    {
        public int EmployeeID { get; set; }
        public string InstitutionName { get; set; }
        public string? ProgramName { get; set; }
        public string? DiplomaNumber { get; set; }
        public DateTime? DiplomaDate { get; set; }
        public bool IsCourse { get; set; } = false;
    }
}
