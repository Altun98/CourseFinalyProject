using Core.DataAccess.EntityFramework;
using Core.Utilities.Results.Data;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using CourseFinalyProject.Entities.DTOs.Employee;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfAwardsDal : EfEntityRepositoryBase<Awards, CourseFinalyProjectContext>, IAwardsDal
    {
        private IQueryable<DetailsAwardsDto> GetQueryableDetails(CourseFinalyProjectContext context)
        {
            return from a in context.Awards
                   join emp in context.Employees on a.EmployeeId equals emp.Id
                   join at in context.AwardsTypes on a.AwardsTypeId equals at.Id
                   join mt in context.MedalTypes on a.MedalTypeId equals mt.Id
                   join gv in context.Gives on a.GiveID equals gv.Id
                   join ht in context.HonoraryTitles on a.HonoraryTitleId equals ht.Id
                   select new DetailsAwardsDto
                   {
                       Id = a.Id,
                       FullName = emp.FirstName + " " + emp.LastName + " " + emp.Patronymic,
                       AwardsTypeName = at.AwardsTypeName,
                       AwardasDocNumber = a.AwardasDocNumber,
                       AwardsDocDate = a.AwardsDocDate,
                       MedalTypeName = mt.MedalName,
                       HonoraryTitleName = ht.HonoraryTitleName,
                       Cause = a.Cause,
                       Mains = a.Mains,
                       DontSubmitDate = a.DontSubmitDate,
                       DontSubmitNumber = a.DontSubmitNumber,
                       GiveName = gv.GiveName,
                       IsBasis = a.IsBasis,
                       AwardsTypeId = a.AwardsTypeId,
                       EmployeeId = a.EmployeeId,
                       MedalTypeId = a.MedalTypeId,
                       HonoraryTitleId = a.HonoraryTitleId,
                       GiveId = a.GiveID

                   };
        }

        public async Task<List<DetailsAwardsDto>> GetAllAsync()
        {
            using (CourseFinalyProjectContext _context = new CourseFinalyProjectContext())
            {
                var info = await GetQueryableDetails(_context).ToListAsync();
                return info;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetControlAwardsTypeIdDateTimeAsync(int awardsId, DateTime stardTime, DateTime endTime)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.AwardsTypeId == awardsId && x.AwardsDocDate >= stardTime && x.AwardsDocDate <= endTime);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetControlEmployeIdDateTimeAsync(int empid, DateTime stardTime, DateTime endTime)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.EmployeeId == empid && x.AwardsDocDate >= stardTime && x.AwardsDocDate <= endTime);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetControlMedalTypeIdDateTimeAsync(int medalID, DateTime stardTime, DateTime endTime)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.MedalTypeId == medalID && x.AwardsDocDate >= stardTime && x.AwardsDocDate <= endTime);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetFindAwardsTypeIdAsync(int awardsId)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.AwardsTypeId == awardsId);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetFindEmployeeIdAsync(int empId)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.EmployeeId == empId);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetFindGiveAsync(int giveId)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.GiveId == giveId);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetFindMedalTypeIdAsync(int medalId)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.MedalTypeId == medalId);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetIsBasicAsync()
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.IsBasis == true);
                var result = await query.ToListAsync();
                return result;
            }
        }

        public async Task<List<DetailsAwardsDto>> GetNotIsBasicAsync()
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = GetQueryableDetails(context).
                    Where(x => x.IsBasis == false);
                var result = await query.ToListAsync();
                return result;
            }
        }

    }
}
