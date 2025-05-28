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
        Task<IDataResult<List<DetailForignLanguage>>> GetAllAsync();
        Task<IDataResult<List<DetailForignLanguage>>> GetFindEmployeeIdAsync(int empId);
        Task<IDataResult<List<DetailForignLanguage>>> GetFindLanguageIdAsync(int language);
        Task<IDataResult<List<DetailForignLanguage>>> GetFindGiveIdAsync(int giveId);
        Task<IDataResult<List<DetailForignLanguage>>> GetFindPercentageAsync(int percentage);
        Task<IDataResult<List<DetailForignLanguage>>> GetIsIndefinitely();
        Task<IDataResult<List<DetailForignLanguage>>> GetNotIsIndefinitely();
        Task<IDataResult<List<DetailForignLanguage>>> GetIsIndefinitelyControlEndDateTime(DateTime start, DateTime _end);
        Task<IDataResult<List<DetailForignLanguage>>> GetFindLanguageControlEndDateTime(int language, DateTime _start, DateTime _end);
    }
}
