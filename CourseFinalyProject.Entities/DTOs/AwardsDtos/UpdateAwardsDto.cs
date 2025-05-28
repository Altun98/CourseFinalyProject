using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.AwardsDtos
{
    public class UpdateAwardsDto:IDto
    {
        public int Id { get; set; }
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
