using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AcademicDegreeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class AcademicDegreeMapping:Profile
    {
        public AcademicDegreeMapping()
        {
            CreateMap<AcademicDegree, CreateAcademicDegreeDto>().ReverseMap();
            CreateMap<AcademicDegree, UpdateAcademicDegreeDto>().ReverseMap();
            CreateMap<AcademicDegree, ResultAcademicDegreeDto>().ReverseMap();
        }
    }
}
