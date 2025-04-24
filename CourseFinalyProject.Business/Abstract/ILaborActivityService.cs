using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface ILaborActivityService
    {
        Task<IResult> Added(LaborActicityDto laborActicityDto);
        Task<IResult> Deleted(LaborActicityDto laborActicityDto);
        Task<IResult> Updated(LaborActicityDto laborActicityDto);
        Task<IDataResult<List<LaborActicityDto>>> GetAll();
        Task<IDataResult<List<LaborActicityDto>>> GetByID(int employeeId);
        Task<IDataResult<List<LaborActicityDto>>> GetOrganization(string orgName);
        Task<IDataResult<List<LaborActicityDto>>> GetDuty(string duty);
        //Task<IDataResult<List<LaborActicityDto>>> GetOrganizationData(string orgName, DateTime start, DateTime? end = null);
    }
}
