using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.DepartamentDtos
{
    public  class UpdateDepartamentDto:IDto
    {
        public int Id { get; set; }
        public string DepartamentName { get; set; }
        public bool IsActive { get; set; }
    }
}
