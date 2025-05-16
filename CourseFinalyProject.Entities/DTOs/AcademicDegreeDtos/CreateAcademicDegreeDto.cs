using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.AcademicDegreeDtos
{
    public class CreateAcademicDegreeDto : IDto
    {
        public int EmployeeID { get; set; }
        public string Degree { get; set; }
        public string BrancName { get; set; }
        public string? DiplomaNumber { get; set; }
        public DateTime? DiplomaDate { get; set; }
        public string? Inventions { get; set; }
    }
}
