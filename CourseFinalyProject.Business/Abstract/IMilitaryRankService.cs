using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IMilitaryRankService
    {

        Task<IResult> MilitaryRankAdded(MilitaryRankDto militaryRankDto);
        Task<IResult> MilitaryRankUpdate(MilitaryRankDto militaryRankDto);
        Task<IResult> MilitaryRankdeleted(MilitaryRankDto militaryRankDto);
        Task<IDataResult<List<MilitaryRankDto>>> GetAll();
        Task<IDataResult<List<MilitaryRankDto>>> GetEmployeeRanksInfo(int empID);      

        Task<IDataResult<List<EmployeeRanksInfoDto>>> GetRankSEmployeeDetailsInfo(int empID);
    }
}
