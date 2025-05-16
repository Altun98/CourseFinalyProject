using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.LaborActicityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface ILaborActivityService
    {
        Task<IResult> AddedAsync(ResultLaborActicityDto laborActicityDto);
        Task<IResult> DeletedAsync(ResultLaborActicityDto laborActicityDto);
        Task<IResult> UpdatedAsync(ResultLaborActicityDto laborActicityDto);
        Task<IDataResult<List<ResultLaborActicityDto>>> GetAllAsync();
        Task<IDataResult<List<ResultLaborActicityDto>>> GetByIdAsync(int employeeId);
        Task<IDataResult<List<ResultLaborActicityDto>>> GetOrganizationAsync(string orgName);
        Task<IDataResult<List<ResultLaborActicityDto>>> GetDutyAsync(string duty);
        //Task<IDataResult<List<LaborActicityDto>>> GetOrganizationData(string orgName, DateTime start, DateTime? end = null);
    }
}
