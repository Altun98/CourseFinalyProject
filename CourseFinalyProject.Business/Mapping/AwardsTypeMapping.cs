using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class AwardsTypeMapping : Profile
    {
        public AwardsTypeMapping()
        {
            CreateMap<AwardsType, CreateAwardsTypeDto>().ReverseMap();
            CreateMap<AwardsType, UpdateAwardsTypeDto>().ReverseMap();
            CreateMap<AwardsType, ResultAwardsTypeDto>().ReverseMap();
        }
    }
}
