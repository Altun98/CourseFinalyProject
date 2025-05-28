using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class AwardsManager(IAwardsDal _awardsDal, IMapper _mapper) : IAwardsService
    {
        public async Task<IResult> AddAsync(CreateAwardsDto dto)
        {
            var value = _mapper.Map<Awards>(dto);
            await _awardsDal.AddAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }
        public async Task<IResult> UpdateAsync(UpdateAwardsDto dto)
        {
            var value = _mapper.Map<Awards>(dto);
            await _awardsDal.UpdateAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
        public async Task<IResult> DeleteAsync(ResultAwardsDto dto)
        {
            var value = _mapper.Map<Awards>(dto);
            await _awardsDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetAllAsync()
        { 
            var values = await _awardsDal.GetAllAsync();
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetFindEmployeeIdAsync(int empId)
        {
            var values = await _awardsDal.GetFindEmployeeIdAsync(empId);
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetFindMedalTypeIdAsync(int medalId)
        {
            var values = await _awardsDal.GetFindMedalTypeIdAsync(medalId);
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetFindAwardsTypeIdAsync(int awardsId)
        {
            var values = await _awardsDal.GetFindAwardsTypeIdAsync(awardsId);
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetFindGiveAsync(int giveId)
        {
            var values = await _awardsDal.GetFindGiveAsync(giveId);
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetControlEmployeIdDateTimeAsync(int empid, DateTime stardTime, DateTime endTime)
        {
            var values = await _awardsDal.GetControlEmployeIdDateTimeAsync(empid,stardTime,endTime);
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetControlMedalTypeIdDateTimeAsync(int medalID, DateTime stardTime, DateTime endTime)
        {
            var values = await _awardsDal.GetControlMedalTypeIdDateTimeAsync(medalID, stardTime, endTime);
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetControlAwardsTypeIdDateTimeAsync(int awardsId, DateTime stardTime, DateTime endTime)
        {
            var values = await _awardsDal.GetControlAwardsTypeIdDateTimeAsync(awardsId, stardTime, endTime);
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetIsBasicAsync()
        {
            var values = await _awardsDal.GetIsBasicAsync();
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailsAwardsDto>>> GetNotIsBasicAsync()
        {
            var values = await _awardsDal.GetNotIsBasicAsync();
            if (values != null)
                return new SuccessDateResult<List<DetailsAwardsDto>>(values);
            return new ErrorDataResult<List<DetailsAwardsDto>>(values, Messages.NotFound);
        }
    }
}
