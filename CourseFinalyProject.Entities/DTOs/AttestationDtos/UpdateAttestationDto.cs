﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.AttestationDtos
{
    public class UpdateAttestationDto:IDto
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        public string Feedback { get; set; }
        public string? Description { get; set; }
        public int GiveID { get; set; }

    }
}
