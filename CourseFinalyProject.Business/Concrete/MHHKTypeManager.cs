using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.MHHKTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class MHHKTypeManager(IMHHKTypeDal _mHHKTypeDal, IMapper _mapper) : IMHHKTypeService
    {
        public async Task<IResult> AddAsync(CreateMHHKTypeDto createMHHKTypeDto)
        {
            var value = _mapper.Map<MHHKType>(createMHHKTypeDto);
            await _mHHKTypeDal.AddAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultMHHKTypeDto resultMHHKTypeDto)
        {
            var valMap = _mapper.Map<MHHKType>(resultMHHKTypeDto);
            await _mHHKTypeDal.DeleteAsync(valMap);
            if (valMap != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultMHHKTypeDto>>> GetAllAsync()
        {
            var val = await _mHHKTypeDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultMHHKTypeDto>>(val);
            if (val != null)
                return new SuccessDateResult<List<ResultMHHKTypeDto>>(valMap);
            return new ErrorDataResult<List<ResultMHHKTypeDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateMHHKTypeDto updateMHHKTypeDto)
        {
            var valmap = _mapper.Map<MHHKType>(updateMHHKTypeDto);
            await _mHHKTypeDal.UpdateAsync(valmap);
            if (valmap != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
    }
}
