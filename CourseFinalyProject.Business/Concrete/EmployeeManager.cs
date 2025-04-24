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
       // [SecuredOperation("admin")]
        [ValidationAspect(typeof(EmployeValidation))]
       // [CacheRemoveAspect("IEmployeeService.Get")]
        public async Task<IResult> EmployeeAdded(EmployeeDto employee)
        {
            var emp = _mapper.Map<Employee>(employee);
            await _employee.Add(emp);
            return new SuccessResult(Messages.EmployeeAdded);
        }
        [CacheRemoveAspect("IEmployeeService.Get")]
        public async Task<IResult> EmployeeDelete(EmployeeDto employee)
        {
            var emp = _mapper.Map<Employee>(employee);
            await _employee.Delete(emp);
            return new SuccessResult(Messages.EmployeeDeleted);
        }

         [CacheRemoveAspect("IEmployeeService.Get")]
        public async Task<IResult> EmployeeUpdate(EmployeeDto employeeDto)
        {
            var emp = _mapper.Map<Employee>(employeeDto);
            await _employee.Update(emp);
            return new SuccessResult(Messages.EmployeeUpdate);
        }

        [CacheAspect]
        [PerformanceAspect(1)]
        public async Task<IDataResult<List<EmployeeDto>>> GetAll()
        {
            var result = _mapper.Map<List<EmployeeDto>>(await _employee.GetAll());
            return new SuccessDateResult<List<EmployeeDto>>(result);
        }

        [CacheAspect]
        [PerformanceAspect(1)]
        public async Task<IDataResult<List<EmployeeDetailsDto>>> GetEmployeeDetails()
        {
            return new SuccessDateResult<List<EmployeeDetailsDto>>(_employee.GetEmployeesDetails());
        }

    }
}