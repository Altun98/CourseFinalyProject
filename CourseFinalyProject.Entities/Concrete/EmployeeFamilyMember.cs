using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class EmployeeFamilyMember : BaseEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        [ForeignKey(nameof(RelativeType))] public int RelativeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string FirstNameOld { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string FIN { get; set; }
        public string Address { get; set; }

    }
}
