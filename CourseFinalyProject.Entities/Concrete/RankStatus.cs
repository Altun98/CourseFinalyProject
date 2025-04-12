using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class RankStatus : BaseEntity, IEntity
    {
        public string StatusName { get; set; }
    }
}
