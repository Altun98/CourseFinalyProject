using AutoMapper;
using Core.Entities;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.RelativeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class RelativeTypeMapping:Profile
    {
        public RelativeTypeMapping()
        {
            CreateMap<RelativeType, ResultRelativeDto>().ReverseMap();
            CreateMap<RelativeType, CreateRelativeDto>().ReverseMap();
            CreateMap<RelativeType, UpdateRelativeDto>().ReverseMap();
        }
    }
}
