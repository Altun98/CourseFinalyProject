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
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        [ForeignKey(nameof(Branch))] public int BranchId { get; set; }
        public string? Departament { get; set; }
        public string? Position { get; set; }
        public bool IsMain { get; set; } = true;
        [ForeignKey(nameof(Give))] public int GiveID { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public DiscountedService DiscountedService { get; set; }

    }
}
