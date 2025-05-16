using Core.DataAccess;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Abstract
{
  public  interface IEducationDal:IEntityRepository<Education>
    {
        Task<List<ResultEmployeeEducationDetailsDto>> GetEmployeeEducationInfo(int empID);
    }
}
