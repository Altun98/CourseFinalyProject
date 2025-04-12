using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class LaborActivity : DocumentEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        public string OrganizationName { get; set; }
        public string? OrganizationAddress { get; set; }
        public string? Duty { get; set; }
    }
}
