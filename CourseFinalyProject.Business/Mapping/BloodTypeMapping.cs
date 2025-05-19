using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.BloodTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class BloodTypeMapping : Profile
    {
        public BloodTypeMapping()
        {
            CreateMap<BloodType, CreateBloodTypeDto>().ReverseMap();
            CreateMap<BloodType, UpdateBloodType>().ReverseMap();
            CreateMap<BloodType, ResultBloodTypeDto>().ReverseMap();
        }
    }
}
