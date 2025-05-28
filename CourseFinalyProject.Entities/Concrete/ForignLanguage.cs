using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class ForignLanguage : BaseEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeId { get; set; }
        [ForeignKey(nameof(Language))] public int LanguageId { get; set; }
        public string Dageer { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int Percentage { get; set; }//faiz
        public DateTime? EndDate { get; set; }
        public bool IsIndefinitely { get; set; } = false;// muddetsiz 
        [ForeignKey(nameof(Give))] public int GiveId { get; set; }
    }
}
