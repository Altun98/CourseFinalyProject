using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.GiveDtos
{
    public class ResultGiveDto:IDto
    {
        public int id { get; set; }
        public string GiveName { get; set; }
    }
}
