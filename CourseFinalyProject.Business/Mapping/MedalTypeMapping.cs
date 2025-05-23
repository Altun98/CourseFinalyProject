using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.MedalTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class MedalTypeMapping:Profile
    {
        public MedalTypeMapping()
        {
            CreateMap<MedalType, ResultMedalTypeDto>().ReverseMap();
            CreateMap<MedalType, CreateMedalTypeDto>().ReverseMap();
            CreateMap<MedalType, UpdateMedalTypeDto>().ReverseMap();
        }
    }
}
