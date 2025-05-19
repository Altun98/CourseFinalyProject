using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.BloodTypeDtos
{
    public class ResultBloodTypeDto:IDto
    {
        public int Id { get; set; }
        public string BloodTypeName { get; set; }
    }
}
