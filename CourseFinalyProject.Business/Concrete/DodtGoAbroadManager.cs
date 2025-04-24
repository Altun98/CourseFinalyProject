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
    public class DodtGoAbroadManager : IDodtGoAbroadService
    {
        private readonly IDodtGoAbroadDal _dodtGoAbroad;
        private readonly IMapper _mapper;
        public DodtGoAbroadManager(IDodtGoAbroadDal dodtGoAbroad, IMapper mapper)
        {
            _dodtGoAbroad = dodtGoAbroad;
            _mapper = mapper;
        }
        public async Task<IResult> Added(DodGoAbrodDto goAbrodDto)
        {
            var value = _mapper.Map<DodtGoAbroad>(goAbrodDto);
            await _dodtGoAbroad.Add(value);
            return new SuccessResult(Messages.DodtGoAbrodAdded);
        }

        public async Task<IResult> Deleted(DodGoAbrodDto goAbrodDto)
        {
            var value = _mapper.Map<DodtGoAbroad>(goAbrodDto);
            await _dodtGoAbroad.Delete(value);
            return new SuccessResult(Messages.DodtGoAbrodDelete);
        }

        public async Task<IDataResult<List<DodGoAbrodDto>>> GetAll()
        {
            var result = _mapper.Map<List<DodGoAbrodDto>>(await _dodtGoAbroad.GetAll());
            return new SuccessDateResult<List<DodGoAbrodDto>>(result);
        }
        public async Task<IResult> Updated(DodGoAbrodDto goAbrodDto)
        {
            var value = _mapper.Map<DodtGoAbroad>(goAbrodDto);
            await _dodtGoAbroad.Update(value);
            return new SuccessResult(Messages.DodtGoAbrodUpdte);
        }

        public async Task<IDataResult<List<DodGoAbrodDto>>> GetById(int empid)
        {
            var value = await _dodtGoAbroad.GetAll(p => p.EmployeeID == empid);
            var result = _mapper.Map<List<DodGoAbrodDto>>(value);
            return new SuccessDateResult<List<DodGoAbrodDto>>(result);
        }

        public async Task<IDataResult<List<DodGoAbrodDto>>> GetDataTimeControl(DateTime _start, DateTime _end)
        {
            var value = await _dodtGoAbroad.GetAll(p => p.StartDate >= _start && p.EndDate <= _end);
            var result = _mapper.Map<List<DodGoAbrodDto>>(value);
            return new SuccessDateResult<List<DodGoAbrodDto>>(result);
        }

        public async Task<IDataResult<List<DodGoAbrodDto>>> GetCountry(string country)
        {
            var value = await _dodtGoAbroad.GetAll(p => p.Country == country);
            var result = _mapper.Map<List<DodGoAbrodDto>>(value);
            return new SuccessDateResult<List<DodGoAbrodDto>>(result);
        }
    }
}
