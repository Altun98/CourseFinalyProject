using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.ConscriptionDtos
{
    public class UpdateConscriptionDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public int DepartamentID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? MilitaryOathTakingDate { get; set; }
    }
}
