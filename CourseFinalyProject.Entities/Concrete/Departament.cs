using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Departament : BaseEntity, IEntity
    {
        public string DepartamentName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
