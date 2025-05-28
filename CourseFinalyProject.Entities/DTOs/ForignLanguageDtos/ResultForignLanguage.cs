using Core.Entities;
using CourseFinalyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.ForignLanguageDtos
{
    public class ResultForignLanguage : IDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LanguageId { get; set; }
        public string Dageer { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int Percentage { get; set; }//faiz
        public DateTime? EndDate { get; set; }
        public bool IsIndefinitely { get; set; }
        public int GiveId { get; set; }
    }
}
