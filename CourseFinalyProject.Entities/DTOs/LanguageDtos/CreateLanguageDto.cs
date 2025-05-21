using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.DTOs.LanguageDtos
{
    public class CreateLanguageDto : IDto
    {
        public string LanguageName { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
