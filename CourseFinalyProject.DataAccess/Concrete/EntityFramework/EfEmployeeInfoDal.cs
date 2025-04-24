using Core.DataAccess.EntityFramework;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeInfoDal : EfEntityRepositoryBase<EmployeeInfo, CourseFinalyProjectContext>, IEmployeeInfoDal
    {

    }
}
