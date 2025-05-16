using AutoMapper;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AttestationDtos;
using CourseFinalyProject.Entities.DTOs.BloodTypeDtos;
using CourseFinalyProject.Entities.DTOs.CombatOperationsDtos;
using CourseFinalyProject.Entities.DTOs.ConscriptionDtos;
using CourseFinalyProject.Entities.DTOs.DodGoAbrodDtos;
using CourseFinalyProject.Entities.DTOs.Education;
using CourseFinalyProject.Entities.DTOs.Employee;
using CourseFinalyProject.Entities.DTOs.LaborActicityDtos;
using CourseFinalyProject.Entities.DTOs.MilitaryRankDtos;
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
            CreateMap<BloodType, ResultBloodTypeDto>();
            CreateMap<EmployeeInfo, ResultEmployeeInfoDto>();
            CreateMap<ResultEmployeeInfoDto, EmployeeInfo>();
            CreateMap<Education, ResultEducationDto>();
            CreateMap<ResultEducationDto, Education>();
            CreateMap<ResultCombatOperationsDto, CombatOperations>();
            CreateMap<CombatOperations, ResultCombatOperationsDto>();
            CreateMap<MilitaryRank, ResultMilitaryRankDto>();
            CreateMap<ResultMilitaryRankDto, MilitaryRank>();
            CreateMap<Attestation, ResultAttestationDto>();
            CreateMap<ResultAttestationDto, Attestation>();
            CreateMap<ResultDodGoAbrodDto, DodtGoAbroad>();
            CreateMap<DodtGoAbroad, ResultDodGoAbrodDto>();
            CreateMap<ResultLaborActicityDto, LaborActivity>();
            CreateMap<LaborActivity, ResultLaborActicityDto>();
            CreateMap<ResultConscriptionDto, Conscriptio>();
            CreateMap<Conscriptio, ResultConscriptionDto>();

        }
    }
}
