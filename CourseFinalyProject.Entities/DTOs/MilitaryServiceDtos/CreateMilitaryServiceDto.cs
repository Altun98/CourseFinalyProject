using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos
{
    public class CreateMilitaryServiceDto : IDto
    {
        public int EmployeeID { get; set; }
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        public string Branch { get; set; }
        public string? Departament { get; set; }
        public string? Position { get; set; }
        public bool IsMain { get; set; } = true;
        public int GiveID { get; set; }
    }
}
