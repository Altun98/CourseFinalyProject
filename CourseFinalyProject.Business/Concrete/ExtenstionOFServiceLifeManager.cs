using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.ExtenstionOFServiceLifeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class ExtenstionOFServiceLifeManager(IExtenstionOFServiceLifeDal _extenstionOFServiceLife, IMapper _mapper) : IExtenstionOFServiceLifeService
    {
        public async Task<IResult> AddAsync(CreateExtenstionOFServiceLifeDto createExtenstionOFServiceLifeDto)
        {
            var value = _mapper.Map<ExtenstionOFServiceLife>(createExtenstionOFServiceLifeDto);
            await _extenstionOFServiceLife.AddAsync(value);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> DeleteAsync(ResultExtenstionOFServiceLifeDto resultExtenstionOFServiceLifeDto)
        {
            var value = _mapper.Map<ExtenstionOFServiceLife>(resultExtenstionOFServiceLifeDto);
            await _extenstionOFServiceLife.DeleteAsync(value);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IDataResult<List<ResultExtenstionOFServiceLifeDto>>> GetAllAsync()
        {
            var values = await _extenstionOFServiceLife.GetAllAsync();
            var valMap = _mapper.Map<List<ResultExtenstionOFServiceLifeDto>>(values);
            if (valMap.Count > 0)
                return new SuccessDateResult<List<ResultExtenstionOFServiceLifeDto>>(valMap);
            return new ErrorDataResult<List<ResultExtenstionOFServiceLifeDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultExtenstionOFServiceLifeDto>>> GetByEmployeeIdAsync(int enpID)
        {
            var values = await _extenstionOFServiceLife.GetAllAsync(x => x.EmployeeID == enpID);
            var valMap = _mapper.Map<List<ResultExtenstionOFServiceLifeDto>>(values);
            if (valMap.Count > 0)
                return new SuccessDateResult<List<ResultExtenstionOFServiceLifeDto>>(valMap);
            return new ErrorDataResult<List<ResultExtenstionOFServiceLifeDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<ResultExtenstionOFServiceLifeDto>> GetByIdAsync(int id)
        {
            var value = await _extenstionOFServiceLife.GetAsync(x => x.Id == id);
            var valMap = _mapper.Map<ResultExtenstionOFServiceLifeDto>(value);
            return new SuccessDateResult<ResultExtenstionOFServiceLifeDto>(valMap);
        }

        public async Task<IDataResult<List<ResultExtenstionOFServiceLifeDto>>> GetEndDateTimeControl(DateTime _start, DateTime _end)
        {
            var values = await _extenstionOFServiceLife.GetAllAsync(x => x.EndDate >= _start && x.EndDate <= _end);
            var valMap = _mapper.Map<List<ResultExtenstionOFServiceLifeDto>>(values);
            if (valMap.Count >= 0)
                return new SuccessDateResult<List<ResultExtenstionOFServiceLifeDto>>(valMap);
            return new ErrorDataResult<List<ResultExtenstionOFServiceLifeDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultExtenstionOFServiceLifeDto>>> GetStartDateTimeControl(DateTime _start, DateTime _end)
        {
            var values = await _extenstionOFServiceLife.GetAllAsync(x => x.StartDate >= _start && x.StartDate <= _end);
            var valMap = _mapper.Map<List<ResultExtenstionOFServiceLifeDto>>(values);
            if (valMap.Count >= 0)
                return new SuccessDateResult<List<ResultExtenstionOFServiceLifeDto>>(valMap);
            return new ErrorDataResult<List<ResultExtenstionOFServiceLifeDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateExtenstionOFServiceLifeDto updateExtenstionOFServiceLifeDto)
        {
            var value = _mapper.Map<ExtenstionOFServiceLife>(updateExtenstionOFServiceLifeDto);
            await _extenstionOFServiceLife.UpdateAsync(value);
            return new SuccessResult(Messages.Updated);
        }
    }
}
