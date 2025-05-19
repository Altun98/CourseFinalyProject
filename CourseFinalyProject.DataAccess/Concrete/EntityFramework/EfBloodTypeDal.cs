using Core.DataAccess.EntityFramework;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework
{
    public class EfBloodTypeDal : EfEntityRepositoryBase<BloodType, CourseFinalyProjectContext>, IBloodTypeDal
    {
        //public List<ResultEmployeeDetailsDto> GetEmployeesDetails()
        //{
        //    using (CourseFinalyProjectContext context = new CourseFinalyProjectContext())
        //    {
        //        var info = from i in context.EmployeeInfo
        //                   join e in context.Employees on i.EmployeeID equals e.Id
        //                   join b in context.BloodTypes on i.BloodID equals b.Id
        //                   select new ResultEmployeeDetailsDto
        //                   {
        //                       FirstName = e.FirstName,
        //                       LastName = e.LastName,
        //                       OldLastName = e.OldLastName,
        //                       Patronymic = e.Patronymic,
        //                       BirthDate = e.BirthDate,
        //                       BirthPlace = e.BirthPlace,
        //                       Country = i.Country,
        //                       RegistrationAddress = i.RegistrationAddress,
        //                       CurrentAddress = i.CurrentAddress,
        //                       IdentityCardNumber = i.IdentityCardNumber,
        //                       PIN = i.PIN,
        //                       BloodName = b.BloodTypeName,
        //                       Height = i.Height,
        //                       Width = i.Width
        //                   };
        //        return info.ToList();
        //    }
        //}

    }
}
