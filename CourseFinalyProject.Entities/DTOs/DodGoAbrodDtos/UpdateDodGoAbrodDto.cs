using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.DodGoAbrodDtos
{
    public class UpdateDodGoAbrodDto : IDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        public string Country { get; set; }
        public string? Purpose { get; set; }
        public string? Description { get; set; }
        public bool IsBusinnessTrip { get; set; } = true;
        public int GiveID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
