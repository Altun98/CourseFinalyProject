using Core.Entities;
using CourseFinalyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos
{
    public class ResultMilitaryServiceDto : IDto
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
