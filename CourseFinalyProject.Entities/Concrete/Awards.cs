using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Awards : BaseEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeId { get; set; }
        [ForeignKey(nameof(AwardsType))] public int? AwardsTypeId { get; set; }
        public string AwardasDocNumber { get; set; }
        public DateTime AwardsDocDate { get; set; }
        [ForeignKey(nameof(MedalType))] public int? MedalTypeId { get; set; }
        [ForeignKey(nameof(HonoraryTitle))] public int? HonoraryTitleId { get; set; }
        public string Cause { get; set; }
        public string Mains { get; set; }
        public DateTime DontSubmitDate { get; set; }
        public string DontSubmitNumber { get; set; }
        [ForeignKey(nameof(Give))] public int? GiveID { get; set; }
        public bool IsBasis { get; set; } = false;//birinci gorsenib gorsenmesi  teyin edilecek

    }
}
