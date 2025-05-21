using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.LanguageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface ILanguageService
    {
        Task<IResult> AddAsync(CreateLanguageDto createLanguageDto);
        Task<IResult> DeleteAsync(ResultLanguageDto resultLanguageDto);
        Task<IResult> UpdateAsync(UpdateLanguageDto updateLanguageDto);
        Task<IDataResult<List<ResultLanguageDto>>> GetAllAsync();
    }
}
