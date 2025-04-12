using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Attestation : DocumentEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        [ForeignKey(nameof(EmployeeDocument))] public int EmpDocId { get; set; }
        public string Feedback { get; set; }
        public string? Description { get; set; }
        public EmployeeDocument EmployeeDocument { get; set; }
        public Employee Employee { get; set; }
    }
}
