using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.DodGoAbrodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class DodtGoAbroadManager : IDodtGoAbroadService
    {
        private readonly IDodtGoAbroadDal _dodtGoAbroad;
        private readonly IMapper _mapper;
        public DodtGoAbroadManager(IDodtGoAbroadDal dodtGoAbroad, IMapper mapper)
        {
            _dodtGoAbroad = dodtGoAbroad;
            _mapper = mapper;
        }
        public async Task<IResult> AddedAsync(ResultDodGoAbrodDto goAbrodDto)
        {
            var value = _mapper.Map<DodtGoAbroad>(goAbrodDto);
            await _dodtGoAbroad.AddAsync(value);
            return new SuccessResult(Messages.DodtGoAbrodAdded);
        }

        public async Task<IResult> DeletedAsync(ResultDodGoAbrodDto goAbrodDto)
        {
            var value = _mapper.Map<DodtGoAbroad>(goAbrodDto);
            await _dodtGoAbroad.DeleteAsync(value);
            return new SuccessResult(Messages.DodtGoAbrodDelete);
        }

        public async Task<IDataResult<List<ResultDodGoAbrodDto>>> GetAllAsync()
        {
            var result = _mapper.Map<List<ResultDodGoAbrodDto>>(await _dodtGoAbroad.GetAllAsync());
            return new SuccessDateResult<List<ResultDodGoAbrodDto>>(result);
        }
        public async Task<IResult> UpdatedAsync(ResultDodGoAbrodDto goAbrodDto)
        {
            var value = _mapper.Map<DodtGoAbroad>(goAbrodDto);
            await _dodtGoAbroad.UpdateAsync(value);
            return new SuccessResult(Messages.DodtGoAbrodUpdte);
        }

        public async Task<IDataResult<List<ResultDodGoAbrodDto>>> GetByIdAsync(int empid)
        {
            var value = await _dodtGoAbroad.GetAllAsync(p => p.EmployeeID == empid);
            var result = _mapper.Map<List<ResultDodGoAbrodDto>>(value);
            return new SuccessDateResult<List<ResultDodGoAbrodDto>>(result);
        }

        public async Task<IDataResult<List<ResultDodGoAbrodDto>>> GetDataTimeControlAsync(DateTime _start, DateTime _end)
        {
            var value = await _dodtGoAbroad.GetAllAsync(p => p.StartDate >= _start && p.EndDate <= _end);
            var result = _mapper.Map<List<ResultDodGoAbrodDto>>(value);
            return new SuccessDateResult<List<ResultDodGoAbrodDto>>(result);
        }

        public async Task<IDataResult<List<ResultDodGoAbrodDto>>> GetCountryAsync(string country)
        {
            var value = await _dodtGoAbroad.GetAllAsync(p => p.Country == country);
            var result = _mapper.Map<List<ResultDodGoAbrodDto>>(value);
            return new SuccessDateResult<List<ResultDodGoAbrodDto>>(result);
        }
    }
}
