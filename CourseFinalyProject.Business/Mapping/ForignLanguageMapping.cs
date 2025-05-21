using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.ForignLanguageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class ForignLanguageMapping : Profile
    {
        public ForignLanguageMapping()
        {
            CreateMap<ForignLanguage, CreateForignLanguage>().ReverseMap();
            CreateMap<ForignLanguage, ResultForignLanguage>().ReverseMap();
            CreateMap<ForignLanguage, UpdateForignLanguag>().ReverseMap();
        }
    }
}
