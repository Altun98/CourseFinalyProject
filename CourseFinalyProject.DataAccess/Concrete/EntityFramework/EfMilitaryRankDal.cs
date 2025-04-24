using Core.DataAccess.EntityFramework;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
using CourseFinalyProject.Entities.DTOs.Employee;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfMilitaryRankDal : EfEntityRepositoryBase<MilitaryRank, CourseFinalyProjectContext>, IMilitaryRankDal
    {
        public async Task<List<EmployeeRanksInfoDto>> GetEmployeeRankDetails(int empID)
        {
            using (CourseFinalyProjectContext context = new CourseFinalyProjectContext())
            {
                var info = from m in context.MilitaryRanks
                           join emp in context.Employees on m.EmployeeID equals emp.Id
                           join ra in context.RankTypes on m.RankID equals ra.Id
                           join st in context.RankStatuses on m.StatusId equals st.Id
                           join giv in context.Gives on m.GiveId equals giv.Id
                           where emp.Id == empID
                           select new EmployeeRanksInfoDto
                           {
                               Id = m.Id,
                               EmployeeID = emp.Id,
                               RankName = ra.RankName,
                               StatusName = st.StatusName,
                               DocDate = m.DocDate,
                               DocNumber = m.DocNumber,
                               GiveName = giv.GiveName,
                               NextRankDate = m.DocDate.AddMonths((int)ra.NextTimeRank)
                           };
                return await info.ToListAsync();
            }
        }
    }
}
