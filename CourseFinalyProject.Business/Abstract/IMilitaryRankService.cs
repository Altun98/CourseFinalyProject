using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using CourseFinalyProject.Entities.DTOs.MilitaryRankDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IMilitaryRankService
    {

        Task<IResult> MilitaryRankAddedAsycn(ResultMilitaryRankDto militaryRankDto);
        Task<IResult> MilitaryRankUpdateAsycn(ResultMilitaryRankDto militaryRankDto);
        Task<IResult> MilitaryRankdeletedAsync(ResultMilitaryRankDto militaryRankDto);
        Task<IDataResult<List<ResultMilitaryRankDto>>> GetAllAsync();
        Task<IDataResult<List<ResultMilitaryRankDto>>> GetEmployeeRanksInfoAsync(int empID);      

        Task<IDataResult<List<ResultEmployeeRanksInfoDto>>> GetRankSEmployeeDetailsInfoAsync(int empID);
    }
}
