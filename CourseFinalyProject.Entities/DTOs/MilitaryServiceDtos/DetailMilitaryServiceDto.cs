using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos
{
    public class DetailMilitaryServiceDto : IDto
    {
        public int Id { get; set; }
        public string EmployeFullName { get; set; }
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        public string BranchName { get; set; }
        public string? Departament { get; set; }
        public string? Position { get; set; }
        public bool IsMain { get; set; } = true;
        public string GiveName { get; set; }
        [JsonIgnore]
        public int EmployeeId { get; set; }
        [JsonIgnore]
        public int BracnId { get; set; }
        [JsonIgnore]
        public int GiveId { get; set; }
    }
}
