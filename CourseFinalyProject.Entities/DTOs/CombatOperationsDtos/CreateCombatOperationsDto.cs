using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.CombatOperationsDtos
{
    public class CreateCombatOperationsDto : IDto
    {
        public int EmployeeID { get; set; }
        public string Territory { get; set; }
        public string? Injury { get; set; }
        public string? VeteranCardNumber { get; set; }
        public DateTime? VeteranCardStartDate { get; set; }
    }
}
