using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Education;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class EducationManager : IEducationService
    {
        private readonly IEducationDal _education;
        private readonly IMapper _mapper;
        public EducationManager(IEducationDal education, IMapper mapper)
        {
            _education = education;
            _mapper = mapper;
        }

        public async Task<IResult> EducationAddAsync(ResultEducationDto educationDto)
        {
            var result = _mapper.Map<Education>(educationDto);
            await _education.AddAsync(result);
            return new SuccessResult(Messages.EducationAdded);
        }

        public async Task<IResult> EducationDeletedAsync(ResultEducationDto educationDto)
        {
            var result = _mapper.Map<Education>(educationDto);
            await _education.DeleteAsync(result);
            return new SuccessResult(Messages.EducationDeleted);
        }

        public async Task<IResult> EducationUpdateAsync(ResultEducationDto educationDto)
        {
            var result = _mapper.Map<Education>(educationDto);
            await _education.UpdateAsync(result);
            return new SuccessResult(Messages.EducationDeleted);
        }

        public async Task<IDataResult<List<ResultEducationDto>>> GetAllAsync()
        {
            var emp = await _education.GetAllAsync();
            var result = _mapper.Map<List<ResultEducationDto>>(emp);
            return new SuccessDateResult<List<ResultEducationDto>>(result);
        }

        public async Task<IDataResult<List<ResultEmployeeEducationDetailsDto>>> GetEmployeeEducationInfoAsync(int empId)
        {
            return new SuccessDateResult<List<ResultEmployeeEducationDetailsDto>>(await _education.GetEmployeeEducationInfo(empId));
        }
    }
}
