using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IAwardsService
    {
        Task<IResult> AddAsync(CreateAwardsDto dto);
        Task<IResult> DeleteAsync(ResultAwardsDto dto);
        Task<IResult> UpdateAsync(UpdateAwardsDto dto);
        Task<IDataResult<List<DetailsAwardsDto>>> GetAllAsync();
        Task<IDataResult<List<DetailsAwardsDto>>> GetFindEmployeeIdAsync(int empId);
        Task<IDataResult<List<DetailsAwardsDto>>> GetFindMedalTypeIdAsync(int medalId);
        Task<IDataResult<List<DetailsAwardsDto>>> GetFindAwardsTypeIdAsync(int awardsId);
        Task<IDataResult<List<DetailsAwardsDto>>> GetFindGiveAsync(int giveId);
        Task<IDataResult<List<DetailsAwardsDto>>> GetControlEmployeIdDateTimeAsync(int empid, DateTime stardTime, DateTime endTime);
        Task<IDataResult<List<DetailsAwardsDto>>> GetControlMedalTypeIdDateTimeAsync(int medalID, DateTime stardTime, DateTime endTime);
        Task<IDataResult<List<DetailsAwardsDto>>> GetControlAwardsTypeIdDateTimeAsync(int awardsId, DateTime stardTime, DateTime endTime);
        Task<IDataResult<List<DetailsAwardsDto>>> GetIsBasicAsync();
        Task<IDataResult<List<DetailsAwardsDto>>> GetNotIsBasicAsync();
    }
}
