using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IEmployeeInfoService
    {
        Task<IDataResult<List<EmployeeInfoDto>>> GetAll();
        Task<IDataResult<EmployeeInfoDto>> GetById(int id);
        Task<IDataResult<List<EmployeeInfoDto>>> SearchBloodTypeID(int bloodID);
        Task<IResult> EmployeeInfoAdded(EmployeeInfoDto employeeInfoDto);
        Task<IResult> EmployeeInfoDeleted(EmployeeInfoDto employeeInfoDto);
        Task<IResult> EmployeeInfoUpdate(EmployeeInfoDto employeeInfoDto);

    }
}
