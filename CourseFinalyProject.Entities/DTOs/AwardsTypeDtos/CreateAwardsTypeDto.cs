using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.AwardsTypeDtos
{
    public class CreateAwardsTypeDto:IDto
    {
        public string AwardsTypeName { get; set; }
        public string Description { get; set; }
    }
}
