using Core.DataAccess.EntityFramework;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.ConscriptionDtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfConscriptionDal : EfEntityRepositoryBase<Conscriptio, CourseFinalyProjectContext>, IConscriptioDal
    {
        public async Task<List<ConscriptionDepartamentDetailsDto>> GetConscriptionDepartamentDetails(int departamentId)
        {
            using (var context = new CourseFinalyProjectContext())
            {
                var result = from con in context.Conscriptio
                             join
                            dep in context.Departaments on con.DepartamentID equals dep.Id
                             select new ConscriptionDepartamentDetailsDto
                             {
                                 Id = con.Id,
                                 EmployeeID = con.EmployeeID,
                                 DepartamentName = dep.DepartamentName,
                                 StartDate=con.StartDate,
                                 MilitaryOathTakingDate= con.MilitaryOathTakingDate
                             };
                return await result.ToListAsync();
            }
        }
    }
}
