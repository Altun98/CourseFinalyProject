using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
   public class Education:DocumentEntity,IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        public string InstitutionName { get; set; }
        public int EducationTypeID { get; set; }
        public string? FacultyName { get; set; }
        public string? Ipecialty { get; set; }
        public string? DiplomaNumber { get; set; }
        public DateTime? DiplomaDate { get; set; }
        public bool IsMilitary { get; set; } = false; //herbi tehsil olub olmamasini mueyyen edir 

        public Employee Employee { get; set; }
        public EducationType EducationType { get; set; }
    }
}
