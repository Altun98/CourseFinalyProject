using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.EmployeeDtos
{
    public class ResultEmployeeRanksInfoDto : IDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string RankName { get; set; }
        public string StatusName { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public string GiveName { get; set; }
        public DateTime? NextRankDate { get; set; }
    }
}
