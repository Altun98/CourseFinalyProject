using AutoMapper;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.BusinessAspects.Autofac;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.Business.ValidationRules.FluentValidation;
using CourseFinalyProject.DataAccess.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employee;
        IMapper _mapper;

        public EmployeeManager(IEmployeeDal employee, IMapper mapper)

        {
            _employee = employee;
            _mapper = mapper;
        }
      
      //  [ValidationAspect(typeof(EmployeValidation))]
        // [CacheRemoveAspect("IEmployeeService.GetAsync")]
        [SecuredOperation("admin")]
        public async Task<IResult> EmployeeAddedAsync(CreateEmployeeDto employee)
        {
            var emp = _mapper.Map<Employee>(employee);
            await _employee.AddAsync(emp);
            return new SuccessResult(Messages.EmployeeAdded);
        }
      //  [CacheRemoveAspect("IEmployeeService.GetAsync")]
        public async Task<IResult> EmployeeDeleteAsync(ResultEmployeeDto employee)
        {
            var emp = _mapper.Map<Employee>(employee);
            await _employee.DeleteAsync(emp);
            return new SuccessResult(Messages.EmployeeDeleted);
        }

      //   [CacheRemoveAspect("IEmployeeService.GetAsync")]
        public async Task<IResult> EmployeeUpdateAsync(UpdateEmployeeDto employeeDto)
        {
            var emp = _mapper.Map<Employee>(employeeDto);
            await _employee.UpdateAsync(emp);
            return new SuccessResult(Messages.EmployeeUpdate);
        }

       // [CacheAspect]
        //[PerformanceAspect(1)]
        public async Task<IDataResult<List<ResultEmployeeDto>>> GetAllAsync()
        {
            var result = _mapper.Map<List<ResultEmployeeDto>>(await _employee.GetAllAsync());
            return new SuccessDateResult<List<ResultEmployeeDto>>(result);
        }
        //[CacheAspect]
        //[PerformanceAspect(1)]
        public async Task<IDataResult<List<ResultEmployeeDetailsDto>>> GetEmployeeDetailsAsync()
        {
            return new SuccessDateResult<List<ResultEmployeeDetailsDto>>(_employee.GetEmployeesDetails());
        }

    }
}