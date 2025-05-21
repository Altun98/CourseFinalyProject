using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.ForignLanguageDtos
{
    public class CreateForignLanguage : IDto
    {
        public int EmployeeId { get; set; }
        public int LanguageId { get; set; }
        public string Dageer { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int Percentage { get; set; }//faiz
        public DateTime? EndDate { get; set; }
        public bool IsIndefinitely { get; set; } = false;
    }
}
