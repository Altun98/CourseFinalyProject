using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Conscriptio : BaseEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        public int DepartamentID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? MilitaryOathTakingDate { get; set; }

        public Employee Employee { get; set; }
        public Departament Departament { get; set; }
    }
}
