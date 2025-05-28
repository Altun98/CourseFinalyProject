using Core.DataAccess.EntityFramework;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using CourseFinalyProject.Entities.DTOs.ForignLanguageDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfForignLanguageDal : EfEntityRepositoryBase<ForignLanguage, CourseFinalyProjectContext>, IForignLanguageDal
    {
        public Task<List<DetailForignLanguage>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<DetailForignLanguage>> GetFindEmployeeIdAsync(int empId)
        {
            throw new NotImplementedException();
        }

        public Task<List<DetailForignLanguage>> GetFindGiveIdAsync(int giveId)
        {
            throw new NotImplementedException();
        }

        public Task<List<DetailForignLanguage>> GetFindLanguageIdAsync(int language)
        {
            throw new NotImplementedException();
        }

        public Task<List<DetailForignLanguage>> GetFindPercentageAsync(int percentage)
        {
            throw new NotImplementedException();
        }

        private IQueryable<DetailForignLanguage> GetQueryableDetails(CourseFinalyProjectContext context)
        {
            return from f in context.ForignLanguages
                   join emp in context.Employees on f.EmployeeId equals emp.Id
                   join l in context.Languages on f.LanguageId equals l.Id
                   join gv in context.Gives on f.GiveId equals gv.Id
                   select new DetailForignLanguage
                   {
                       Id = f.Id,
                       FullName = emp.FirstName + " " + emp.LastName + " " + emp.Patronymic,
                       Language = l.LanguageName,
                       DocNumber=f.DocNumber,
                       DocDate=f.DocDate,
                       Percentage=f.Percentage,
                       EndDate=f.EndDate,
                       IsIndefinitely=f.IsIndefinitely,
                       GiveName=gv.GiveName,
                       EmployeeId=f.EmployeeId,
                       GiveId=f.GiveId,
                       LanguageId=f.LanguageId

                   };
        }

    }
}
