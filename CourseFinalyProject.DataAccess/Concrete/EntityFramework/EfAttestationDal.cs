using Core.DataAccess.EntityFramework;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfAttestationDal : EfEntityRepositoryBase<Attestation, CourseFinalyProjectContext>, IAttestationDal
    {
        public async Task<List<EmployeesAttestationDot>> GetEmployeesAttestationsInfo(int empID)
        {
            using (CourseFinalyProjectContext context=new CourseFinalyProjectContext())
            {
                var result = from att in context.Attestations
                             join
                             emp in context.Employees on att.EmployeeID equals emp.Id
                             join
                             giv in context.Gives on att.GiveID equals giv.Id
                             where att.EmployeeID == empID
                             select new EmployeesAttestationDot
                             {
                                 Id = att.Id,
                                 EmployeeID = emp.Id,
                                 DocDade = att.DocDade,
                                 DocNumber = att.DocNumber,
                                 Feedback = att.Feedback,
                                 Description = att.Description,
                                 GiveName = giv.GiveName
                             };
                return await result.ToListAsync();
            }
        }
    }
}
