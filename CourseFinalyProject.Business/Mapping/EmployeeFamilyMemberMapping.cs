using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.EmployeeFamilyMemberDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class EmployeefamilyMemberMapping:Profile
    {
        public EmployeefamilyMemberMapping()
        {
            CreateMap<EmployeeFamilyMember, ResultEmployeeFamilyMemberDto>().ReverseMap();
            CreateMap<EmployeeFamilyMember, CreateEmployeeFamilyMemberDto>().ReverseMap();
            CreateMap<EmployeeFamilyMember, UpdateEmployeeFamilyMemberDto>().ReverseMap();
        }
    }
}
