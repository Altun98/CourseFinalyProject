using Core.Entities;
using CourseFinalyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.ExtenstionOFServiceLifeDtos
{
    public class ResultExtenstionOFServiceLifeDto : IDto
    {
        public int Id { get; set; }
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
