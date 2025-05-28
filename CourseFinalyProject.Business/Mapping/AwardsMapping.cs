using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class AwardsMapping : Profile
    {
        public AwardsMapping()
        {
            CreateMap<Awards, CreateAwardsDto>().ReverseMap();
            CreateMap<Awards, UpdateAwardsDto>().ReverseMap();
            CreateMap<Awards, ResultAwardsDto>().ReverseMap();          
        }
    }
}
