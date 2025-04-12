using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Give : BaseEntity, IEntity
    {
        public string GiveName { get; set; }
        public EmployeeDocument EmployeeDocument { get; set; }
    }
}
