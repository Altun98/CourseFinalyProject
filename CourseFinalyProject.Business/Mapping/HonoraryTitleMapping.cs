using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.HonoraryTitleDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class HonoraryTitleMapping:Profile
    {
        public HonoraryTitleMapping()
        {
            CreateMap<HonoraryTitle, ResultHonoraryTitleDto>().ReverseMap();
            CreateMap<HonoraryTitle, CreateHonoraryTitleDto>().ReverseMap();
            CreateMap<HonoraryTitle, UpdateHonoraryTitleDto>().ReverseMap();
        }
    }
}
