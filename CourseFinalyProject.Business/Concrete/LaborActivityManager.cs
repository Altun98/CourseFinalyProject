using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.LaborActicityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class LaborActivityManager : ILaborActivityService
    {
        private readonly ILaborActivityDal _laborActivity;
        private readonly IMapper _mapper;
        public LaborActivityManager(ILaborActivityDal laborActivity, IMapper mapper)
        {
            _laborActivity = laborActivity;
            _mapper = mapper;
        }

        public async Task<IResult> AddedAsync(ResultLaborActicityDto laborActicityDto)
        {
            var result = _mapper.Map<LaborActivity>(laborActicityDto);
            await _laborActivity.AddAsync(result);
            return new SuccessResult(Messages.LaborActicityAdded);
        }

        public async Task<IResult> DeletedAsync(ResultLaborActicityDto laborActicityDto)
        {
            var result = _mapper.Map<LaborActivity>(laborActicityDto);
            await _laborActivity.DeleteAsync(result);
            return new SuccessResult(Messages.LaborActicityDeleted);
        }

        public async Task<IDataResult<List<ResultLaborActicityDto>>> GetAllAsync()
        {
            var value = await _laborActivity.GetAllAsync();
            var result = _mapper.Map<List<ResultLaborActicityDto>>(value);
            return new SuccessDateResult<List<ResultLaborActicityDto>>(result);
        }

        public async Task<IDataResult<List<ResultLaborActicityDto>>> GetByIdAsync(int employeeId)
        {
            var value = await _laborActivity.GetAllAsync(p => p.EmployeeID == employeeId);
            var result = _mapper.Map<List<ResultLaborActicityDto>>(value);
            return new SuccessDateResult<List<ResultLaborActicityDto>>(result);
        }

        public async Task<IDataResult<List<ResultLaborActicityDto>>> GetDutyAsync(string duty)
        {
            var value = await _laborActivity.GetAllAsync(p => p.Duty == duty);
            var result = _mapper.Map<List<ResultLaborActicityDto>>(value);
            return new SuccessDateResult<List<ResultLaborActicityDto>>(result);
        }

        public async Task<IDataResult<List<ResultLaborActicityDto>>> GetOrganizationAsync(string orgName)
        {
            var value = await _laborActivity.GetAllAsync(p => p.OrganizationName == orgName);
            var result = _mapper.Map<List<ResultLaborActicityDto>>(value);
            return new SuccessDateResult<List<ResultLaborActicityDto>>(result);
        }

        public async Task<IResult> UpdatedAsync(ResultLaborActicityDto laborActicityDto)
        {
            var result = _mapper.Map<LaborActivity>(laborActicityDto);
            await _laborActivity.UpdateAsync(result);
            return new SuccessResult(Messages.LaborActicityUpdated);
        }
    }
}
