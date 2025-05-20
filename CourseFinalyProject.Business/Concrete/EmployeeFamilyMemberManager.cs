using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.EmployeeFamilyMemberDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class EmployeeFamilyMemberManager(IEmployeeFamilyMemberDal _employeeFamilyMemberDal, IMapper _mapper) : IEmployeeFamilyMemberService
    {
        public async Task<IResult> TAddAsync(CreateEmployeeFamilyMemberDto createEmployeeFamilyMemberDto)
        {
            var valMap = _mapper.Map<EmployeeFamilyMember>(createEmployeeFamilyMemberDto);
            await _employeeFamilyMemberDal.AddAsync(valMap);
            if (valMap != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> TDeleteAsync(ResultEmployeeFamilyMemberDto resultEmployeeFamilyMemberDto)
        {
            var valMap = _mapper.Map<EmployeeFamilyMember>(resultEmployeeFamilyMemberDto);
            await _employeeFamilyMemberDal.DeleteAsync(valMap);
            if (valMap != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultEmployeeFamilyMemberDto>>> TGetAllAsync()
        {
            var value = await _employeeFamilyMemberDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultEmployeeFamilyMemberDto>>(value);
            if (valMap.Count > 0)
                return new SuccessDateResult<List<ResultEmployeeFamilyMemberDto>>(valMap);
            return new ErrorDataResult<List<ResultEmployeeFamilyMemberDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultEmployeeFamilyMemberDto>>> TGetEmployeeID(int empID)
        {
            var value = await _employeeFamilyMemberDal.GetAllAsync(x => x.EmployeeID == empID);
            var valMap = _mapper.Map<List<ResultEmployeeFamilyMemberDto>>(value);
            if (valMap.Count > 0)
                return new SuccessDateResult<List<ResultEmployeeFamilyMemberDto>>(valMap);
            return new ErrorDataResult<List<ResultEmployeeFamilyMemberDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> TUpdateAsync(UpdateEmployeeFamilyMemberDto updateEmployeeFamilyMemberDto)
        {
            var valMap = _mapper.Map<EmployeeFamilyMember>(updateEmployeeFamilyMemberDto);
            await _employeeFamilyMemberDal.UpdateAsync(valMap);
            if (valMap != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
    }
}
