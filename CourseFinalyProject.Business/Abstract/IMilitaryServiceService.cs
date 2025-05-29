using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IMilitaryServiceService
    {
        Task<IResult> AddAsync(CreateMilitaryServiceDto dto);
        Task<IResult> UpdateAsync(UpdateMilitaryServiceDto dto);
        Task<IResult> DeleteAsync(DeleteMilitaryServiceDto dto);
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetAllAsync();
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetIsMainAsync();
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetNotIsMainAsync();
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetByEmployeIdAsync(int empId);
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindBrancAsync(string branc);
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindDepartamentAsync(string departament);
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindPositionAsync(string position);
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindBrancControlDocDateAsync(string branc, DateTime _start, DateTime _end);
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindDepartamentControlDocDateAsync(string departament, DateTime _start, DateTime _end);
        Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindPosiationControlDocDateAsync(string position, DateTime _start, DateTime _end);

    }
}
