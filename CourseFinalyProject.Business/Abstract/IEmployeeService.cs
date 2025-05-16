using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IEmployeeService
    {
        Task<IDataResult<List<ResultEmployeeDto>>> GetAllAsync();
        Task<IDataResult<List<ResultEmployeeDetailsDto>>> GetEmployeeDetailsAsync();
        Task<IResult> EmployeeAddedAsync(CreateEmployeeDto employeeDto);
        Task<IResult> EmployeeDeleteAsync(ResultEmployeeDto employeeDto);
        Task<IResult> EmployeeUpdateAsync(UpdateEmployeeDto employeeDto);
    }
}
