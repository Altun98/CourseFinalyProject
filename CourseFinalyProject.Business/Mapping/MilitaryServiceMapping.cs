using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public  class MilitaryServiceMapping:Profile
    {
        public MilitaryServiceMapping()
        {
            CreateMap<MilitaryService, CreateMilitaryServiceDto>().ReverseMap();
            CreateMap<MilitaryService, UpdateMilitaryServiceDto>().ReverseMap();
            CreateMap<MilitaryService, DeleteMilitaryServiceDto>().ReverseMap();
        }
    }
}
