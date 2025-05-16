using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Education;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IEducationService
    {
        Task<IResult> EducationAddAsync(ResultEducationDto educationDto);
        Task<IDataResult<List<ResultEducationDto>>> GetAllAsync();
        Task<IResult> EducationDeletedAsync(ResultEducationDto educationDto);
        Task<IResult> EducationUpdateAsync(ResultEducationDto educationDto);
        Task<IDataResult<List<ResultEmployeeEducationDetailsDto>>> GetEmployeeEducationInfoAsync(int empId);

    }
}
