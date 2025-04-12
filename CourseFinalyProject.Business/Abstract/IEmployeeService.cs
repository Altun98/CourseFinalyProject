using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IEmployeeService
    {
        Task<IDataResult<List<EmployeeDto>>> GetAll();
        Task<IDataResult<List<EmployeeDetailsDto>>> GetEmployeeDetails();
        Task<IResult> EmployeeAdded(EmployeeDto employeeDto);
        Task<IResult> EmployeeDelete(EmployeeDto employeeDto);
        Task<IResult> EmployeeUpdate(EmployeeDto employeeDto);
    }
}
