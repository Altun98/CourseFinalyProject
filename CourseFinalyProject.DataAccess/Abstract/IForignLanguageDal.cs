using Core.DataAccess;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using CourseFinalyProject.Entities.DTOs.ForignLanguageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Abstract
{
    public interface IForignLanguageDal : IEntityRepository<ForignLanguage>
    {
        Task<List<DetailForignLanguage>> GetAllAsync();
        Task<List<DetailForignLanguage>> GetFindEmployeeIdAsync(int empId);
        Task<List<DetailForignLanguage>> GetFindLanguageIdAsync(int language);
        Task<List<DetailForignLanguage>> GetFindGiveIdAsync(int giveId);
        Task<List<DetailForignLanguage>> GetFindPercentageAsync(int percentage);     
        Task<List<DetailForignLanguage>> GetIsIndefinitely();
        Task<List<DetailForignLanguage>> GetNotIsIndefinitely();
        Task<List<DetailForignLanguage>> GetIsIndefinitelyControlEndDateTime(DateTime start, DateTime _end);
        Task<List<DetailForignLanguage>> GetFindLanguageControlEndDateTime(int language, DateTime _start, DateTime _end);
    }
}
