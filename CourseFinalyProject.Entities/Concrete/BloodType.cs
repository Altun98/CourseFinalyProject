using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class BloodType : BaseEntity, IEntity
    {
        public string BloodTypeName { get; set; }
        public ICollection<EmployeeInfo> EmployeeInfos { get; set; } = new List<EmployeeInfo>();
    }
}
