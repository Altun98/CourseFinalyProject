using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.DepartamentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class DepartamentManager : IDepartamentService

    {
        private readonly IDepartamentDal _departament;
        private IMapper _mapper;


        public DepartamentManager(IDepartamentDal departament, IMapper mapper)
        {
            _departament = departament;
            _mapper = mapper;
        }
        public async Task<IResult> AddAsync(CreateDepartamentDto createDepartamentDto)
        {
            var value = _mapper.Map<Departament>(createDepartamentDto);
            await _departament.AddAsync(value);
            return new SuccessResult(Messages.Added);

        }

        public async Task<IResult> DeleteAsync(ResultDepartamentDto resultDepartamentDto)
        {
            var value = _mapper.Map<Departament>(resultDepartamentDto);
            await _departament.DeleteAsync(value);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IDataResult<List<ResultDepartamentDto>>> GetAllAsync()
        {
            var values = await _departament.GetAllAsync();
            var valMap = _mapper.Map<List<ResultDepartamentDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultDepartamentDto>>(valMap);
            return new ErrorDataResult<List<ResultDepartamentDto>>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<ResultDepartamentDto>> GetByIdAsync(int id)
        {
            var value = await _departament.GetAsync(x => x.Id == id);
            var valMap = _mapper.Map<ResultDepartamentDto>(value);
            if (valMap != null)
                return new SuccessDateResult<ResultDepartamentDto>(valMap);
            return new ErrorDataResult<ResultDepartamentDto>(valMap, Messages.NotFound);
        }

        public async Task<IDataResult<List<ResultDepartamentDto>>> GetDepartamentName(string _departamentName)
        {
            var values = await _departament.GetAllAsync(x => x.DepartamentName.Contains(_departamentName));
            var valMap = _mapper.Map<List<ResultDepartamentDto>>(values);
            if (valMap != null)
                return new SuccessDateResult<List<ResultDepartamentDto>>(valMap);
            return new ErrorDataResult<List<ResultDepartamentDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateDepartamentDto updateDepartamentDto)
        {
            var value = _mapper.Map<Departament>(updateDepartamentDto);
            await _departament.UpdateAsync(value);
            return new SuccessResult(Messages.Updated);
        }
    }
}
