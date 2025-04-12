using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class EmployeeInfo:BaseEntity,IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        public string Country { get; set; }
        public string RegistrationAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string IdentityCardNumber { get; set; }
        [Required] public string PIN { get; set; }
        [ForeignKey(nameof(BloodType))] public int BloodID { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public BloodType BloodType { get; set; }
        public Employee Employee { get; set; }
    }
}
