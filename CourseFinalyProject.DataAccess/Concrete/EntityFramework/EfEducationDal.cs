using Core.DataAccess.EntityFramework;
using Core.Utilities.Results.Data;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfEducationDal : EfEntityRepositoryBase<Education, CourseFinalyProjectContext>, IEducationDal
    {
        public async Task<List<ResultEmployeeEducationDetailsDto>> GetEmployeeEducationInfo(int empID)
        {
            using (CourseFinalyProjectContext contex = new CourseFinalyProjectContext())
            {
                var eduInfo = from edu in contex.Educations
                              join emp in contex.Employees on edu.EmployeeID equals emp.Id
                              join eduT in contex.EducationTypes on edu.EducationTypeID equals eduT.Id
                              where edu.EmployeeID == empID
                              select new ResultEmployeeEducationDetailsDto
                              {
                                  Id = edu.Id,
                                  EmployeeID = emp.Id,
                                  EducationType = eduT.EducationTypeName,
                                  InstitutionName = edu.InstitutionName,
                                  FacultyName = edu.FacultyName,
                                  Ipecialty = edu.Ipecialty,
                                  IsMilitary = edu.IsMilitary,
                                  DiplomaNumber = edu.DiplomaNumber,
                                  DiplomaDate = (DateTime)edu.DiplomaDate,
                                  StartDate = (DateTime)edu.StartDate,
                                  EndDate = (DateTime)edu.EndDate
                              };
                return await eduInfo.ToListAsync();
            }
        }
    }
}
