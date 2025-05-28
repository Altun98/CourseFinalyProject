using AutoMapper;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.ForignLanguageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class ForignLanguageManager(IForignLanguageDal _forignLanguageDal, IMapper _mapper) : IForignLanguageService
    {
        public async Task<IResult> AddAsync(CreateForignLanguage dto)
        {
            var value = _mapper.Map<ForignLanguage>(dto);
            await _forignLanguageDal.AddAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Added);
            return new ErrorResult(Messages.NoAdded);
        }

        public async Task<IResult> DeleteAsync(ResultForignLanguage dto)
        {
            var value = _mapper.Map<ForignLanguage>(dto);
            await _forignLanguageDal.DeleteAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Deleted);
            return new ErrorResult(Messages.NoDelete);
        }
        public async Task<IResult> UpdateAsync(UpdateForignLanguag dto)
        {
            var value = _mapper.Map<ForignLanguage>(dto);
            await _forignLanguageDal.UpdateAsync(value);
            if (value != null)
                return new SuccessResult(Messages.Updated);
            return new ErrorResult(Messages.NoUpdate);
        }
        public async Task<IDataResult<List<DetailForignLanguage>>> GetAllAsync()
        {
            var value = await _forignLanguageDal.GetAllAsync();
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailForignLanguage>>> GetFindEmployeeIdAsync(int empId)
        {
            var value = await _forignLanguageDal.GetFindEmployeeIdAsync(empId);
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailForignLanguage>>> GetFindGiveIdAsync(int giveId)
        {
            var value = await _forignLanguageDal.GetFindGiveIdAsync(giveId);
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailForignLanguage>>> GetFindLanguageControlEndDateTime(int language, DateTime _start, DateTime _end)
        {
            var value = await _forignLanguageDal.GetFindLanguageControlEndDateTime(language, _start, _end);
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailForignLanguage>>> GetFindLanguageIdAsync(int language)
        {
            var value = await _forignLanguageDal.GetFindLanguageIdAsync(language);
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailForignLanguage>>> GetFindPercentageAsync(int percentage)
        {
            var value = await _forignLanguageDal.GetFindPercentageAsync(percentage);
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailForignLanguage>>> GetIsIndefinitely()
        {
            var value = await _forignLanguageDal.GetIsIndefinitely();
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailForignLanguage>>> GetIsIndefinitelyControlEndDateTime(DateTime start, DateTime _end)
        {
            var value = await _forignLanguageDal.GetIsIndefinitelyControlEndDateTime(start, _end);
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }

        public async Task<IDataResult<List<DetailForignLanguage>>> GetNotIsIndefinitely()
        {
            var value = await _forignLanguageDal.GetNotIsIndefinitely();
            if (value.Count > 0)
                return new SuccessDateResult<List<DetailForignLanguage>>(value);
            return new ErrorDataResult<List<DetailForignLanguage>>(value, Messages.NotFound);
        }


    }
}
