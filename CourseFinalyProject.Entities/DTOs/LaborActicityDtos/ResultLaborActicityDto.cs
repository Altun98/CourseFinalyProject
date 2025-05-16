using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.LaborActicityDtos
{
    public class ResultLaborActicityDto : IDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string OrganizationName { get; set; }
        public string? OrganizationAddress { get; set; }
        public string? Duty { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
