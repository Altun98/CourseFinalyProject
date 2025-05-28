using Core.DataAccess.EntityFramework;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using CourseFinalyProject.Entities.DTOs.ForignLanguageDtos;
using Microsoft.EntityFrameworkCore;
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
                       DocNumber = f.DocNumber,
                       DocDate = f.DocDate,
                       Percentage = f.Percentage,
                       EndDate = f.EndDate,
                       IsIndefinitely = f.IsIndefinitely,
                       GiveName = gv.GiveName,
                       EmployeeId = f.EmployeeId,
                       GiveId = f.GiveId,
                       LanguageId = f.LanguageId

                   };
        }

        public async Task<List<DetailForignLanguage>> GetAllAsync()
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var result = await GetQueryableDetails(context).ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailForignLanguage>> GetFindEmployeeIdAsync(int empId)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context)
                    .Where(x => x.EmployeeId == empId);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailForignLanguage>> GetFindGiveIdAsync(int giveId)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context)
                    .Where(x => x.GiveId == giveId);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailForignLanguage>> GetFindLanguageIdAsync(int language)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context)
                    .Where(x => x.LanguageId == language);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailForignLanguage>> GetFindPercentageAsync(int percentage)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context)
                    .Where(x => x.Percentage == percentage);
                var result = await query.ToListAsync();
                return result;
            }
        }



        public async Task<List<DetailForignLanguage>> GetFindLanguageControlEndDateTime(int language, DateTime _start, DateTime _end)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).Where(x => x.LanguageId == language && x.EndDate >= _start && x.EndDate <= _end);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailForignLanguage>> GetIsIndefinitely()
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).Where(x => x.IsIndefinitely == true);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailForignLanguage>> GetNotIsIndefinitely()
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).Where(x => x.IsIndefinitely == false);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailForignLanguage>> GetIsIndefinitelyControlEndDateTime(DateTime start, DateTime _end)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).Where(x => x.IsIndefinitely == false && x.EndDate >= start && x.EndDate <= _end);
                var result = await query.ToListAsync();
                return result;
            }
        }
    }
}
