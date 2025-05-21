using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.LanguageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class LanguageManager(ILanguageDal _languageDal, IMapper _mapper) : ILanguageService
    {
        public async Task<IResult> AddAsync(CreateLanguageDto createLanguageDto)
        {
            var value = _mapper.Map<Language>(createLanguageDto);
            await _languageDal.AddAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultLanguageDto resultLanguageDto)
        {
            var value = _mapper.Map<Language>(resultLanguageDto);
            await _languageDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }

        public async Task<IDataResult<List<ResultLanguageDto>>> GetAllAsync()
        {
            var value = await _languageDal.GetAllAsync();
            var valMap = _mapper.Map<List<ResultLanguageDto>>(value);
            if (valMap != null)
                return new SuccessDateResult<List<ResultLanguageDto>>(valMap);
            return new ErrorDataResult<List<ResultLanguageDto>>(valMap, Messages.NotFound);
        }

        public async Task<IResult> UpdateAsync(UpdateLanguageDto updateLanguageDto)
        {
            var value = _mapper.Map<Language>(updateLanguageDto);
            await _languageDal.UpdateAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
    }
}
