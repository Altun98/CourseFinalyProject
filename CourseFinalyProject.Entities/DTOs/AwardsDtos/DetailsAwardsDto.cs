using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.AwardsDtos
{
    public class DetailsAwardsDto : IDto
    {
        //bu  sahede olan id ler  daha sonra muvafiq entitilerin adlari ile evez edilecek/
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? AwardsTypeName { get; set; }
        public string AwardasDocNumber { get; set; }
        public DateTime AwardsDocDate { get; set; }
        public string? MedalTypeName { get; set; }
        public string? HonoraryTitleName { get; set; }
        public string Cause { get; set; }
        public string Mains { get; set; }
        public DateTime DontSubmitDate { get; set; }
        public string DontSubmitNumber { get; set; }
        public string? GiveName { get; set; }
        public bool IsBasis { get; set; }

        [JsonIgnore] public int EmployeeId { get; set; }
        [JsonIgnore] public int? AwardsTypeId { get; set; }
        [JsonIgnore] public int? MedalTypeId { get; set; }
        [JsonIgnore] public int? HonoraryTitleId { get; set; }
        [JsonIgnore] public int? GiveId { get; set; }
    }
}
