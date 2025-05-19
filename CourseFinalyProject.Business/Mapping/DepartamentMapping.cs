using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.DepartamentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class DepartamentMapping:Profile
    {
        public DepartamentMapping()
        {
            CreateMap<Departament, ResultDepartamentDto>().ReverseMap();
            CreateMap<Departament, CreateDepartamentDto>().ReverseMap();
            CreateMap<Departament, UpdateDepartamentDto>().ReverseMap();
        }
    }
}
