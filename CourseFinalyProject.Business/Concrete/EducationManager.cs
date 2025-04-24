using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Education;
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

        public async Task<IResult> EducationAdd(EducationDto educationDto)
        {
            var result = _mapper.Map<Education>(educationDto);
            await _education.Add(result);
            return new SuccessResult(Messages.EducationAdded);
        }

        public async Task<IResult> EducationDeleted(EducationDto educationDto)
        {
            var result = _mapper.Map<Education>(educationDto);
            await _education.Delete(result);
            return new SuccessResult(Messages.EducationDeleted);
        }

        public async Task<IResult> EducationUpdate(EducationDto educationDto)
        {
            var result = _mapper.Map<Education>(educationDto);
            await _education.Update(result);
            return new SuccessResult(Messages.EducationDeleted);
        }

        public async Task<IDataResult<List<EducationDto>>> GetAll()
        {
            var emp = await _education.GetAll();
            var result = _mapper.Map<List<EducationDto>>(emp);
            return new SuccessDateResult<List<EducationDto>>(result);
        }

        public async Task<IDataResult<List<EmployeeEducationDetailsDto>>> GetEmployeeEducationInfo(int empId)
        {
            return new SuccessDateResult<List<EmployeeEducationDetailsDto>>(await _education.GetEmployeeEducationInfo(empId));
        }
    }
}
