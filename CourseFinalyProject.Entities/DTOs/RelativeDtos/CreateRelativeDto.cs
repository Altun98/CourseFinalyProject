using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.RelativeDtos
{
    public class CreateRelativeDto:IDto
    {
        public string RelativeTypeName { get; set; }
    }
}
