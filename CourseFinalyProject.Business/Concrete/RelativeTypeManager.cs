using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.RelativeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class RelativeTypeManager(IRelativeTypeDal _relativeTypeDal,IMapper _mapper) : IRelativeTypeService
    {
        public async Task<IResult> AddAsync(CreateRelativeDto createRelativeDto)
        {
            var valMap = _mapper.Map<RelativeType>(createRelativeDto);
            await _relativeTypeDal.AddAsync(valMap);
            if (valMap != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultRelativeDto resultRelativeDto)
        {
            var valMap = _mapper.Map<RelativeType>(resultRelativeDto);
            await _relativeTypeDal.DeleteAsync(valMap);
            if (valMap != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultRelativeDto>>> GetAllAsync()
        {
            var value =await _relativeTypeDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultRelativeDto>>(value);
            if (valMap != null)
                return new SuccessDateResult<List<ResultRelativeDto>>(valMap);
            return new ErrorDataResult<List<ResultRelativeDto>>(valMap);
        }

        public async Task<IDataResult<List<ResultRelativeDto>>> GetFindRelativeName(string _name)
        {
            var value = await _relativeTypeDal.GetAllAsync(x => x.RelativeTypeName.Contains(_name));
            var valMap = _mapper.Map<List<ResultRelativeDto>>(value);
            if(valMap!=null)
                return new SuccessDateResult<List<ResultRelativeDto>>(valMap);
            return new ErrorDataResult<List<ResultRelativeDto>>(valMap);
        }

        public async Task<IResult> UpdateAsync(UpdateRelativeDto updateRelativeDto)
        {
            var valMap = _mapper.Map<RelativeType>(updateRelativeDto);
            await _relativeTypeDal.UpdateAsync(valMap);
            if (valMap != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
    }
}
