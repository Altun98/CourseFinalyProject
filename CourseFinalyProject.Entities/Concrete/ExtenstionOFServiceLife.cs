using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class ExtenstionOFServiceLife : DocumentEntity, IEntity
    {
        //Xidmetmuddetinin uzadilmasi
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        [ForeignKey(nameof(Give))] public int GiveID { get; set; }
        public string Item { get; set; }
        public string? Description { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
