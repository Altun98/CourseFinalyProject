using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.EmployeeFamilyMemberDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IEmployeeFamilyMemberService
    {
        //Aile uzuvleri
        Task<IResult> TAddAsync(CreateEmployeeFamilyMemberDto createEmployeeFamilyMemberDto);
        Task<IResult> TDeleteAsync(ResultEmployeeFamilyMemberDto resultEmployeeFamilyMemberDto);
        Task<IResult> TUpdateAsync(UpdateEmployeeFamilyMemberDto updateEmployeeFamilyMemberDto);
        Task<IDataResult<List<ResultEmployeeFamilyMemberDto>>> TGetAllAsync();
        Task<IDataResult<List<ResultEmployeeFamilyMemberDto>>> TGetEmployeeID(int empID);
    }
}
