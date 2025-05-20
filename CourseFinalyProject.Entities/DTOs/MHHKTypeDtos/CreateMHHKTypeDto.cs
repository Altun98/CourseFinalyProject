using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.MHHKTypeDtos
{
    public class CreateMHHKTypeDto : IDto
    {
        public string MHHKTypeName { get; set; }
    }
}
