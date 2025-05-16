using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.BloodTypeDtos
{
    public class CreateBloodType : IDto
    {
        public string BloodTypeName { get; set; }
    }
}
