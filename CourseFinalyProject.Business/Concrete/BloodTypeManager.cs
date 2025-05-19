using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.BloodTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class BloodTypeManager(IBloodTypeDal _bloodTypeDal, IMapper _mapper) : IBloodTypeService
    {
        public async Task<IResult> AddAsync(CreateBloodTypeDto createBloodTypeDto)
        {
            var value = _mapper.Map<BloodType>(createBloodTypeDto);
            await _bloodTypeDal.AddAsync(value);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> DeleteAsync(ResultBloodTypeDto resultBloodTypeDto)
        {
            var value = _mapper.Map<BloodType>(resultBloodTypeDto);
            await _bloodTypeDal.DeleteAsync(value);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IDataResult<List<ResultBloodTypeDto>>> GetAllAsync()
        {
            var value = _mapper.Map<List<ResultBloodTypeDto>>(await _bloodTypeDal.GetAllAsync());
            if (value != null)
                return new SuccessDateResult<List<ResultBloodTypeDto>>(value);
            return new ErrorDataResult<List<ResultBloodTypeDto>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultBloodTypeDto>>> GetBloodTypeNameSearch(string name)
        {
            var value = _mapper.Map<List<ResultBloodTypeDto>>(await _bloodTypeDal.GetAllAsync(x => x.BloodTypeName.Contains(name)));
            if (value != null)
                return new SuccessDateResult<List<ResultBloodTypeDto>>(value);
            return new ErrorDataResult<List<ResultBloodTypeDto>>(value, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateBloodType updateBloodType)
        {
            var value = _mapper.Map<BloodType>(updateBloodType);
            await _bloodTypeDal.UpdateAsync(value);
            return new SuccessResult(Messages.Updated);
        }
    }
}
