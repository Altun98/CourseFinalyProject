using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class MilitaryRank : BaseEntity, IEntity
    {
        [ForeignKey(nameof(Employee))] public int EmployeeID { get; set; }
        [ForeignKey(nameof(RankType))] public int RankID { get; set; }
        [ForeignKey(nameof(RankStatus))] public int RankStatusID { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        [ForeignKey(nameof(Give))] public int GiveID { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public RankType RankType { get; set; }
        public ICollection<RankStatus> RankStatuses { get; set; } = new List<RankStatus>();
        public ICollection<Give> Gives { get; set; } = new List<Give>();

    }
}
