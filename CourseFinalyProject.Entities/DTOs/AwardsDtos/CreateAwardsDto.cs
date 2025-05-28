using Core.Entities;
using CourseFinalyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.AwardsDtos
{
    public class CreateAwardsDto : IDto
    {
        public int EmployeeId { get; set; }
        public int? AwardsTypeId { get; set; }
        public string AwardasDocNumber { get; set; }
        public DateTime AwardsDocDate { get; set; }
        public int? MedalTypeId { get; set; }
        public int? HonoraryTitleId { get; set; }
        public string Cause { get; set; }
        public string Mains { get; set; }
        public DateTime DontSubmitDate { get; set; }
        public string DontSubmitNumber { get; set; }
        public bool IsBasis { get; set; }
    }
}
