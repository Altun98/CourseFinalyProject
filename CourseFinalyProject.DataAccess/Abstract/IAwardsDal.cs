using Core.DataAccess;
using Core.Utilities.Results.Data;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Abstract
{
    public interface IAwardsDal : IEntityRepository<Awards>
    {
        Task<List<DetailsAwardsDto>> GetAllAsync();
        Task<List<DetailsAwardsDto>> GetFindEmployeeIdAsync(int empId);
        Task<List<DetailsAwardsDto>> GetFindMedalTypeIdAsync(int medalId);
        Task<List<DetailsAwardsDto>> GetFindAwardsTypeIdAsync(int awardsId);
        Task<List<DetailsAwardsDto>> GetFindGiveAsync(int giveId);
        Task<List<DetailsAwardsDto>> GetControlEmployeIdDateTimeAsync(int empid, DateTime stardTime, DateTime endTime);
        Task<List<DetailsAwardsDto>> GetControlMedalTypeIdDateTimeAsync(int medalID, DateTime stardTime, DateTime endTime);
        Task<List<DetailsAwardsDto>> GetControlAwardsTypeIdDateTimeAsync(int awardsId, DateTime stardTime, DateTime endTime);
        Task<List<DetailsAwardsDto>> GetIsBasicAsync();
        Task<List<DetailsAwardsDto>> GetNotIsBasicAsync();
    }
}
