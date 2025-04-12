using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class CombatOperations : DocumentEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        public string Territory { get; set; }
        public string? Injury { get; set; }
        public string? VeteranCardNumber { get; set; }
        public DateTime? VeteranCardStartDate { get; set; }
        public Employee Employee { get; set; }
    }
}
