using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.BranchDtos
{
    public class UpdateBranchDto:IDto
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public bool IsActive { get; set; }
    }
}
