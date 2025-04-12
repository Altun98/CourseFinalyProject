using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class DodtGoAbroad : DocumentEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        [ForeignKey(nameof(EmployeeDocument))] public int EmpDocId { get; set; }
        public string Country { get; set; }
        public string? Purpose { get; set; }
        public string? Description { get; set; }
        public bool IsBusinnessTrip { get; set; } = true;
        public EmployeeDocument EmployeeDocument { get; set; }
        public Employee Employee { get; set; }
    }
}
