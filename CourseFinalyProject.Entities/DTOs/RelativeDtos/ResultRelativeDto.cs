using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.RelativeDtos
{
    public class ResultRelativeDto : IDto
    {
        public int Id { get; set; }
        public string RelativeTypeName { get; set; }
    }
}
