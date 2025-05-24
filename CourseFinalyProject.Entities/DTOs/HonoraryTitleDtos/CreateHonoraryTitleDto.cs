using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.HonoraryTitleDtos
{
    public class CreateHonoraryTitleDto : IDto
    {
        public string HonoraryTitleName { get; set; }
        public bool IsActive { get; set; }
    }
}
