using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
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
        Task<IResult> Added(AttestationDto attestationDto);
        Task<IResult> Updated(AttestationDto attestationDto);
        Task<IResult> Deleted(AttestationDto attestationDto);
        Task<IDataResult<List<EmployeesAttestationDot>>> GetEmployeesAttestationsInfo(int empId);
        Task<IDataResult<List<AttestationDto>>> GetAll();

    }
}
