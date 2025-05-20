using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.MHHKDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class MHHKManager(IMHHKDal _mHHKDal, IMapper _mapper) : IMHHKService
    {
        public async Task<IResult> AddAsync(CreateMHHKDto createMHHKDto)
        {
            var value = _mapper.Map<MHHK>(createMHHKDto);
            await _mHHKDal.AddAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultMHHKDto resultMHHKDto)
        {
            var value = _mapper.Map<MHHK>(resultMHHKDto);
            await _mHHKDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultMHHKDto>>> GetAllAsync()
        {
            var values = await _mHHKDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultMHHKDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultMHHKDto>>(valMap);
            return new ErrorDataResult<List<ResultMHHKDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<ResultMHHKDto>> GetById(int _id)
        {
            var values = await _mHHKDal.GetAllAsync(x => x.Id == _id);
            var valMap = _mapper.Map<ResultMHHKDto>(values);
            if (valMap != null)
                return new SuccessDateResult<ResultMHHKDto>(valMap);
            return new ErrorDataResult<ResultMHHKDto>(valMap, Messages.NotFound);

        }

        public async Task<IDataResult<List<ResultMHHKDto>>> GetDocdateControl(DateTime _start, DateTime _end)
        {
            var values = await _mHHKDal.GetAllAsync(x => x.MHHKDocDate >= _start && x.MHHKDocDate <= _end);
            var valMap = _mapper.Map<List<ResultMHHKDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultMHHKDto>>(valMap);
            return new ErrorDataResult<List<ResultMHHKDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultMHHKDto>>> GetFindCompany(string _company)
        {
            var values = await _mHHKDal.GetAllAsync(x => x.Company.Contains(_company));
            var valMap = _mapper.Map<List<ResultMHHKDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultMHHKDto>>(valMap);
            return new ErrorDataResult<List<ResultMHHKDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultMHHKDto>>> GetFindDiagnosis(string _diagnosis)
        {
            var values = await _mHHKDal.GetAllAsync(x => x.Diagnosis.Contains(_diagnosis));
            var valMap = _mapper.Map<List<ResultMHHKDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultMHHKDto>>(valMap);
            return new ErrorDataResult<List<ResultMHHKDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultMHHKDto>>> GetFindEmployee(int _empId)
        {
            var values = await _mHHKDal.GetAllAsync(x => x.EmployeeId == _empId);
            var valMap = _mapper.Map<List<ResultMHHKDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultMHHKDto>>(valMap);
            return new ErrorDataResult<List<ResultMHHKDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultMHHKDto>>> GetFindFeedback(string _feedback)
        {
            var values = await _mHHKDal.GetAllAsync(x => x.Feedback.Contains(_feedback));
            var valMap = _mapper.Map<List<ResultMHHKDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultMHHKDto>>(valMap);
            return new ErrorDataResult<List<ResultMHHKDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultMHHKDto>>> GetFindMHHKDocNumber(string _number)
        {
            var values = await _mHHKDal.GetAllAsync(x => x.MHHKDocNumber.Contains(_number));
            var valMap = _mapper.Map<List<ResultMHHKDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultMHHKDto>>(valMap);
            return new ErrorDataResult<List<ResultMHHKDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateMHHKDto updateMHHKDto)
        {
            var value = _mapper.Map<MHHK>(updateMHHKDto);
            await _mHHKDal.UpdateAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
    }
}
