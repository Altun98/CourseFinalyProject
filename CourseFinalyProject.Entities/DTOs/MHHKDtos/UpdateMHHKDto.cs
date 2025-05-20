using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.MHHKDtos
{
    public class UpdateMHHKDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string MHHKDocNumber { get; set; }
        public DateTime MHHKDocDate { get; set; }
        public string Feedback { get; set; }
        public string Diagnosis { get; set; }
        public string Company { get; set; }
    }
}
