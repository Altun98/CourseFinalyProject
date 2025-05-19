using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.ExtenstionOFServiceLifeDtos
{
    public class CreateExtenstionOFServiceLifeDto : IDto
    {
        public int EmployeeID { get; set; }
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GiveID { get; set; }
        public string Item { get; set; }
        public string? Description { get; set; }
    }
}
