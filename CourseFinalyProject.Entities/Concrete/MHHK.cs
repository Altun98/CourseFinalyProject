using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class MHHK : BaseEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeId { get; set; }
        public string MHHKDocNumber { get; set; }
        public DateTime MHHKDocDate { get; set; }
        public string Feedback { get; set; }//rey
        public string Diagnosis { get; set; }//diaqnoz
        public string Company { get; set; }//teskilat
    }
}
