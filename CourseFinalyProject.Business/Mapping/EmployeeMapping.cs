using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class EmployeeMapping : Profile
    {
        public EmployeeMapping()
        {
            CreateMap<Employee, ResultEmployeeDto>().ReverseMap();
            CreateMap<Employee, CreateEmployeeDto>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeDto>().ReverseMap();
        }
    }
}
