using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.MilitaryRankDtos
{
    public class UpdateMilitaryRankDto : IDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public int RankID { get; set; }
        public int StatusId { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int GiveId { get; set; }
    }
}
