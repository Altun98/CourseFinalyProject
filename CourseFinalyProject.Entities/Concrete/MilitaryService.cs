using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class MilitaryService : DocumentEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        [ForeignKey(nameof(EmployeeDocument))] public int EmpDocID { get; set; }
        public string Branch { get; set; }
        public string? Departament { get; set; }
        public string? Position { get; set; }
        public bool IsMain { get; set; } = true;
        public Employee Employee { get; set; }
        public DiscountedService DiscountedService { get; set; }
        public EmployeeDocument EmployeeDocument { get; set; }
    }
}
