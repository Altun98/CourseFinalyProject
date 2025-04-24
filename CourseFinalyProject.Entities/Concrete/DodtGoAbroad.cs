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
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        public string Country { get; set; }
        public string? Purpose { get; set; }
        public string? Description { get; set; }
        public bool IsBusinnessTrip { get; set; } = true;
        [ForeignKey(nameof(Give))] public int GiveID { get; set; }
    }
}
