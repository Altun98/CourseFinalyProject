using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class RankType : BaseEntity, IEntity
    {
        public string RankName { get; set; }
        public string RankGroup { get; set; }
        public int NextTimeRank { get; set; }
        
    }
}
