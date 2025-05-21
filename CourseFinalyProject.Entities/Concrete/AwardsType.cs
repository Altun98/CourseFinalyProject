using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class AwardsType : BaseEntity, IEntity
    {
        //teltif tipleri
        public string AwardsTypeName { get; set; }
        public string Description { get; set; }
    }
}
