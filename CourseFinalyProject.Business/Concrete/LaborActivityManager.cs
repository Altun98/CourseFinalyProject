using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
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

        public async Task<IResult> Added(LaborActicityDto laborActicityDto)
        {
            var result = _mapper.Map<LaborActivity>(laborActicityDto);
            await _laborActivity.Add(result);
            return new SuccessResult(Messages.LaborActicityAdded);
        }

        public async Task<IResult> Deleted(LaborActicityDto laborActicityDto)
        {
            var result = _mapper.Map<LaborActivity>(laborActicityDto);
            await _laborActivity.Delete(result);
            return new SuccessResult(Messages.LaborActicityDeleted);
        }

        public async Task<IDataResult<List<LaborActicityDto>>> GetAll()
        {
            var value = await _laborActivity.GetAll();
            var result = _mapper.Map<List<LaborActicityDto>>(value);
            return new SuccessDateResult<List<LaborActicityDto>>(result);
        }

        public async Task<IDataResult<List<LaborActicityDto>>> GetByID(int employeeId)
        {
            var value = await _laborActivity.GetAll(p => p.EmployeeID == employeeId);
            var result = _mapper.Map<List<LaborActicityDto>>(value);
            return new SuccessDateResult<List<LaborActicityDto>>(result);
        }

        public async Task<IDataResult<List<LaborActicityDto>>> GetDuty(string duty)
        {
            var value = await _laborActivity.GetAll(p => p.Duty == duty);
            var result = _mapper.Map<List<LaborActicityDto>>(value);
            return new SuccessDateResult<List<LaborActicityDto>>(result);
        }

        public async Task<IDataResult<List<LaborActicityDto>>> GetOrganization(string orgName)
        {
            var value = await _laborActivity.GetAll(p => p.OrganizationName == orgName);
            var result = _mapper.Map<List<LaborActicityDto>>(value);
            return new SuccessDateResult<List<LaborActicityDto>>(result);
        }

        public async Task<IResult> Updated(LaborActicityDto laborActicityDto)
        {
            var result = _mapper.Map<LaborActivity>(laborActicityDto);
            await _laborActivity.Update(result);
            return new SuccessResult(Messages.LaborActicityUpdated);
        }
    }
}
