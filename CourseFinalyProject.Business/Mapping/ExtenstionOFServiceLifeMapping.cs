using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.ExtenstionOFServiceLifeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class ExtenstionOFServiceLifeMapping : Profile
    {
        public ExtenstionOFServiceLifeMapping()
        {
            CreateMap<ExtenstionOFServiceLife, ResultExtenstionOFServiceLifeDto>().ReverseMap();
            CreateMap<ExtenstionOFServiceLife, UpdateExtenstionOFServiceLifeDto>().ReverseMap();
            CreateMap<ExtenstionOFServiceLife, CreateExtenstionOFServiceLifeDto>().ReverseMap();
        }
    }
}
