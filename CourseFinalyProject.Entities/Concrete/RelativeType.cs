using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class RelativeType : BaseEntity, IEntity
    {
        public string RelativeTypeName { get; set; }
        ICollection<EmployeeFamilyMember> EmployeeFamilyMembers { get; set; } = new List<EmployeeFamilyMember>();
    }
}
