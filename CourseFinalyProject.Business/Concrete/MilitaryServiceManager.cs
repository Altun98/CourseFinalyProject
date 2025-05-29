using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class MilitaryServiceManager(IMilitaryServiceDal _militaryServiceDal, IMapper _mapper) : IMilitaryServiceService
    {
        public async Task<IResult> AddAsync(CreateMilitaryServiceDto dto)
        {
            var value = _mapper.Map<MilitaryService>(dto);
            await _militaryServiceDal.AddAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> UpdateAsync(UpdateMilitaryServiceDto dto)
        {
            var value = _mapper.Map<MilitaryService>(dto);
            await _militaryServiceDal.UpdateAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
        public async Task<IResult> DeleteAsync(DeleteMilitaryServiceDto dto)
        {
            var value = _mapper.Map<MilitaryService>(dto);
            await _militaryServiceDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetAllAsync()
        {
            var values = await _militaryServiceDal.GetAllAsync();
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetIsMainAsync()
        {
            var values = await _militaryServiceDal.GetIsMainAsync();
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetNotIsMainAsync()
        {
            var values = await _militaryServiceDal.GetNotIsMainAsync();
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetByEmployeIdAsync(int empId)
        {
            var values = await _militaryServiceDal.GetByEmployeIdAsync(empId);
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindBrancAsync(string branc)
        {
            var values = await _militaryServiceDal.GetFindBrancAsync(branc);
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindDepartamentAsync(string departament)
        {
            var values = await _militaryServiceDal.GetFindDepartamentAsync(departament);
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindPositionAsync(string position)
        {
            var values = await _militaryServiceDal.GetFindPositionAsync(position);
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindBrancControlDocDateAsync(string branc, DateTime _start, DateTime _end)
        {
            var values = await _militaryServiceDal.GetFindBrancControlDocDateAsync(branc,_start,_end);
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindDepartamentControlDocDateAsync(string departament, DateTime _start, DateTime _end)
        {
            var values = await _militaryServiceDal.GetFindDepartamentControlDocDateAsync(departament, _start, _end);
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindPosiationControlDocDateAsync(string position, DateTime _start, DateTime _end)
        {
            var values = await _militaryServiceDal.GetFindPosiationControlDocDateAsync(position, _start, _end);
            if (values.Count > 0)
                return new SuccessDateResult<List<DetailMilitaryServiceDto>>(values);
            return new ErrorDataResult<List<DetailMilitaryServiceDto>>(values, Messages.NotFound);
        }
    }
}
