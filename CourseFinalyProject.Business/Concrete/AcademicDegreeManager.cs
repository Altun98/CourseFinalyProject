using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AcademicDegreeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class AcademicDegreeManager(IAcademicDegreeDal _academicDegree, IMapper _mapper) : IAcademicDegreeService
    {
        public async Task<IResult> AddedAsync(CreateAcademicDegreeDto createAcademicDegreeDto)
        {
            var values = _mapper.Map<AcademicDegree>(createAcademicDegreeDto);
            await _academicDegree.AddAsync(values);
            return new SuccessResult(Messages.AcademicDegreeAdded);
        }

        public async Task<IResult> DeleteAsync(ResultAcademicDegreeDto resultAcademicDegreeDto)
        {
            var value = _mapper.Map<AcademicDegree>(resultAcademicDegreeDto);
            await _academicDegree.DeleteAsync(value);
            return new SuccessResult(Messages.AcademicDegreeDelete);
        }

        public async Task<IDataResult<List<ResultAcademicDegreeDto>>> GetAllAsync()
        {
            var values =await _academicDegree.GetAllAsync();
            var valMap = _mapper.Map<List<ResultAcademicDegreeDto>>(values);
            return new SuccessDateResult<List<ResultAcademicDegreeDto>>(valMap);
        }

        public async Task<IDataResult<ResultAcademicDegreeDto>> GetByDiplomaNumberAsync(string number)
        {
            //Diplom nomresine gore axtaris
            var value = await _academicDegree.GetAsync(x=>x.DiplomaNumber.Contains(number));
            var valMap = _mapper.Map<ResultAcademicDegreeDto>(value);
            return new SuccessDateResult<ResultAcademicDegreeDto>(valMap);
        }

        public async Task<IDataResult<ResultAcademicDegreeDto>> GetByIdAsync(int id)
        {
            var value = await _academicDegree.GetAsync(x => x.Id == id);
            var valMap = _mapper.Map<ResultAcademicDegreeDto>(value);
            return new SuccessDateResult<ResultAcademicDegreeDto>(valMap);
        }

        public async Task<IDataResult<List<ResultAcademicDegreeDto>>> GetDiplomaDataTimeSearchAsync(DateTime startDate, DateTime endDate)
        {
            //iki tarix arasinda diplom verilen sexsler
            var values =await _academicDegree.GetAllAsync(x => x.DiplomaDate >= startDate && x.DiplomaDate <= endDate);
            var valMap = _mapper.Map<List<ResultAcademicDegreeDto>>(values);
            return new SuccessDateResult<List<ResultAcademicDegreeDto>>(valMap);
        }

        public async Task<IResult> UpdateAsync(UpdateAcademicDegreeDto updateAcademicDegreeDto)
        {
            await _academicDegree.UpdateAsync(_mapper.Map<AcademicDegree>(updateAcademicDegreeDto));
            return new SuccessResult(Messages.AcademicDegreeUpdate);
        }
    }
}
