using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class AwardsTypeManager(IAwardsTypeDal _awardsTypeDal, IMapper _mapper) : IAwardsTypeService
    {
        public async Task<IResult> AddAsync(CreateAwardsTypeDto createAwardsTypeDto)
        {
            var value = _mapper.Map<AwardsType>(createAwardsTypeDto);
            await _awardsTypeDal.AddAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultAwardsTypeDto resultAwardsTypeDto)
        {
            var value = _mapper.Map<AwardsType>(resultAwardsTypeDto);
            await _awardsTypeDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultAwardsTypeDto>>> GetAllAsync()
        {
            var values = await _awardsTypeDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultAwardsTypeDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultAwardsTypeDto>>(valMap);
            return new ErrorDataResult<List<ResultAwardsTypeDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateAwardsTypeDto updateAwardsTypeDto)
        {
            var value = _mapper.Map<AwardsType>(updateAwardsTypeDto);
            await _awardsTypeDal.UpdateAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
    }
}
