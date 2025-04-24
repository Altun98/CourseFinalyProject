using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Attestation : BaseEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        public string Feedback { get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(Give))] public int GiveID { get; set; }
        public Employee Employee { get; set; }
        public Give Give { get; set; }
    }
}
