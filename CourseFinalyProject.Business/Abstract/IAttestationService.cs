using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AttestationDtos;
using CourseFinalyProject.Entities.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IAttestationService
    {
        Task<IResult> AddAsync(ResultAttestationDto attestationDto);
        Task<IResult> UpdateAsync(ResultAttestationDto attestationDto);
        Task<IResult> DeleteAsync(ResultAttestationDto attestationDto);
        Task<IDataResult<List<ResultEmployeesAttestationDot>>> GetEmployeesAttestationsInfoAsync(int empId);
        Task<IDataResult<List<ResultAttestationDto>>> GetAllAsync();

    }
}
