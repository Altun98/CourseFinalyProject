using Core.DataAccess.EntityFramework;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfMilitaryServiceDal : EfEntityRepositoryBase<MilitaryService, CourseFinalyProjectContext>, IMilitaryServiceDal
    {
        private IQueryable<DetailMilitaryServiceDto> GetQueryableDetails(CourseFinalyProjectContext context)
        {
            return from m in context.MilitaryServices
                   join emp in context.Employees on m.EmployeeID equals emp.Id
                   join br in context.Branches on m.BranchId equals br.Id
                   join gv in context.Gives on m.GiveID equals gv.Id
                   select new DetailMilitaryServiceDto
                   {
                       Id = m.Id,
                       EmployeFullName = emp.FirstName + " " + emp.LastName + " " + emp.Patronymic,
                       DocDade = m.DocDade,
                       DocNumber = m.DocNumber,
                       BranchName = br.BranchName,
                       Departament = m.Departament,
                       Position = m.Position,
                       IsMain = m.IsMain,
                       GiveName = gv.GiveName
                   };
        }


        public async Task<List<DetailMilitaryServiceDto>> GetAllAsync()
        {
            using (var contex = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(contex).ToListAsync();
                return query;
            }
        }

        public async Task<List<DetailMilitaryServiceDto>> GetByEmployeIdAsync(int empId)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context)
                    .Where(x => x.EmployeeId == empId).ToListAsync();
                return query;
            }
        }

        public async Task<List<DetailMilitaryServiceDto>> GetFindBrancAsync(string branc)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context)
                    .Where(x => x.BranchName.Contains(branc)).ToListAsync();
                return query;
            }
        }



        public async Task<List<DetailMilitaryServiceDto>> GetFindDepartamentAsync(string departament)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context)
                    .Where(x => x.Departament.Contains(departament)).ToListAsync();
                return query;
            }
        }


        public async Task<List<DetailMilitaryServiceDto>> GetFindPositionAsync(string position)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context)
                    .Where(x => x.Position.Contains(position)).ToListAsync();
                return query;
            }
        }

        public async Task<List<DetailMilitaryServiceDto>> GetIsMainAsync()
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context)
                    .Where(x => x.IsMain == true).ToListAsync();
                return query;
            }
        }

        public async Task<List<DetailMilitaryServiceDto>> GetNotIsMainAsync()
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context)
                    .Where(x => x.IsMain == false).ToListAsync();
                return query;
            }
        }

        public async Task<List<DetailMilitaryServiceDto>> GetFindDepartamentControlDocDateAsync(string departament, DateTime _start, DateTime _end)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context).
                    Where(x => x.Departament.Contains(departament) &&
                    x.DocDade >= _start && x.DocDade <= _end).ToListAsync();
                return query;
            }
        }

        public async Task<List<DetailMilitaryServiceDto>> GetFindPosiationControlDocDateAsync(string position, DateTime _start, DateTime _end)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context).
                    Where(x => x.Position.Contains(position) &&
                    x.DocDade >= _start && x.DocDade <= _end).ToListAsync();
                return query;
            }
        }
        public async Task<List<DetailMilitaryServiceDto>> GetFindBrancControlDocDateAsync(string branc, DateTime _start, DateTime _end)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var query = await GetQueryableDetails(context).
                    Where(x => x.BranchName.Contains(branc) &&
                    x.DocDade >= _start && x.DocDade <= _end).ToListAsync();
                return query;
            }
        }

    }
}
