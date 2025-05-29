using Core.DataAccess;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Abstract
{
    public interface IMilitaryServiceDal:IEntityRepository<MilitaryService>
    {
        Task<List<DetailMilitaryServiceDto>> GetAllAsync();
        Task<List<DetailMilitaryServiceDto>> GetIsMainAsync();
        Task<List<DetailMilitaryServiceDto>> GetNotIsMainAsync();
        Task<List<DetailMilitaryServiceDto>> GetByEmployeIdAsync(int empId);
        Task<List<DetailMilitaryServiceDto>> GetFindBrancAsync(string branc);
        Task<List<DetailMilitaryServiceDto>> GetFindDepartamentAsync(string departament);
        Task<List<DetailMilitaryServiceDto>> GetFindPositionAsync(string position);
        Task<List<DetailMilitaryServiceDto>> GetFindBrancControlDocDateAsync(string branc, DateTime _start, DateTime _end);
        Task<List<DetailMilitaryServiceDto>> GetFindDepartamentControlDocDateAsync(string departament, DateTime _start, DateTime _end);
        Task<List<DetailMilitaryServiceDto>> GetFindPosiationControlDocDateAsync(string position, DateTime _start, DateTime _end);
    }
}
