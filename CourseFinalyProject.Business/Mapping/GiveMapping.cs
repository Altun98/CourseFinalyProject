using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.GiveDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class GiveMapping : Profile
    {
        public GiveMapping()
        {
            CreateMap<Give, CreateGiveDto>().ReverseMap();
            CreateMap<Give, ResultGiveDto>().ReverseMap();
            CreateMap<Give, UpdateGiveDto>().ReverseMap();
        }
    }
}
