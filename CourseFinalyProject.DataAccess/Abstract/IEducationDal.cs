using Core.DataAccess;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Abstract
{
  public  interface IEducationDal:IEntityRepository<Education>
    {
        Task<List<EmployeeEducationDetailsDto>> GetEmployeeEducationInfo(int empID);
    }
}
