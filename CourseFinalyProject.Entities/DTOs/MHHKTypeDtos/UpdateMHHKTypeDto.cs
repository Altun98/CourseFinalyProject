﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.MHHKTypeDtos
{
    public class UpdateMHHKTypeDto:IDto
    {
        public int Id { get; set; }
        public string MHHKTypeName { get; set; }
    }
}
