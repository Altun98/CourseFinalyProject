using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.LanguageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class LanguageMapping : Profile
    {
        public LanguageMapping()
        {
            CreateMap<Language, ResultLanguageDto>().ReverseMap();
            CreateMap<Language, CreateLanguageDto>().ReverseMap();
            CreateMap<Language, UpdateLanguageDto>().ReverseMap();
        }
    }
}
