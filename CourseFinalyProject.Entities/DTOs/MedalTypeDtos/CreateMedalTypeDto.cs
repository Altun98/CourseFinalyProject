using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.MedalTypeDtos
{
    public class CreateMedalTypeDto : IDto
    {
        public string MedalName { get; set; }
        public string Description { get; set; }
        public bool IsAll { get; set; }
    }
}
