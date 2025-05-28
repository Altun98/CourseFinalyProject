using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.ForignLanguageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IForignLanguageService
    {
        Task<IResult> AddAsync(CreateForignLanguage dto);
        Task<IResult> UpdateAsync(UpdateForignLanguag dto);
        Task<IResult> DeleteAsync(ResultForignLanguage dto);
        Task<IDataResult<List<ResultForignLanguage>>> GetAllAsync();
    }
}
