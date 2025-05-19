using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.GiveDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class GiveManager(IGiveDal _giveDal, IMapper _mapper) : IGiveService
    {
        public async Task<IResult> AddAsync(CreateGiveDto createGiveDto)
        {
            var value = _mapper.Map<Give>(createGiveDto);
            await _giveDal.AddAsync(value);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> DeleteAsync(ResultGiveDto resultGiveDto)
        {
            var value = _mapper.Map<Give>(resultGiveDto);
            await _giveDal.DeleteAsync(value);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IDataResult<List<ResultGiveDto>>> GetAllAsync()
        {
            var value = await _giveDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultGiveDto>>(value);
            if (valMap != null)
                return new SuccessDateResult<List<ResultGiveDto>>(valMap);
            return new ErrorDataResult<List<ResultGiveDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<ResultGiveDto>> GetByIdAsync(int id)
        {
            var value = await _giveDal.GetAsync(x => x.Id == id);
            var valMap = _mapper.Map<ResultGiveDto>(value);
            if (valMap != null)
                return new SuccessDateResult<ResultGiveDto>(valMap);
            return new ErrorDataResult<ResultGiveDto>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultGiveDto>>> GetGiveNameSearchAsync(string giveName)
        {
            var value = await _giveDal.GetAllAsync(x => x.GiveName.Contains(giveName));
            var valMap = _mapper.Map<List<ResultGiveDto>>(value);
            if (valMap != null)
                return new SuccessDateResult<List<ResultGiveDto>>(valMap);
            return new ErrorDataResult<List<ResultGiveDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateGiveDto updateGiveDto)
        {
            var value = _mapper.Map<Give>(updateGiveDto);
            await _giveDal.UpdateAsync(value);
            return new SuccessResult(Messages.Updated);
        }
    }
}
