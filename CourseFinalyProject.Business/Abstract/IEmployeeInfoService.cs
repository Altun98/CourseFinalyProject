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
        Task<IDataResult<List<ResultEmployeeInfoDto>>> GetAllAsync();
        Task<IDataResult<ResultEmployeeInfoDto>> GetById(int id);
        Task<IDataResult<List<ResultEmployeeInfoDto>>> GetSearchBloodTypeIdAsync(int bloodID);
        Task<IResult> EmployeeInfoAddedAsync(ResultEmployeeInfoDto employeeInfoDto);
        Task<IResult> EmployeeInfoDeletedAsync(ResultEmployeeInfoDto employeeInfoDto);
        Task<IResult> EmployeeInfoUpdateAsync(ResultEmployeeInfoDto employeeInfoDto);

    }
}
