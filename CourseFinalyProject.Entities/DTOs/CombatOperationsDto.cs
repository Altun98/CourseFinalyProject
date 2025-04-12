using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs
{
    public class CombatOperationsDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string Territory { get; set; }
        public string? Injury { get; set; }
        public string? VeteranCardNumber { get; set; }
        public DateTime? VeteranCardStartDate { get; set; }

    }
}
