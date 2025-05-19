using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Branch : BaseEntity, IEntity
    {
        public string BranchName { get; set; }
        public bool IsActive { get; set; } = true;
        public List<MilitaryService> MilitaryServices { get; set; }
    }
}
