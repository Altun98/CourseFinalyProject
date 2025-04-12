using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
using CourseFinalyProject.Entities.DTOs.Education;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            // program.cs de builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // duelisi etmek lazimdir  
            CreateMap<BloodType, BloodTypeDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<EmployeeInfo, EmployeeInfoDto>();
            CreateMap<EmployeeInfoDto, EmployeeInfo>();
            CreateMap<Education, EducationDto>();
            CreateMap<EducationDto, Education>();
            CreateMap<CombatOperationsDto, CombatOperations>();
            CreateMap<CombatOperations, CombatOperationsDto>();

        }
    }
}
