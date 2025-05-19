using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.ExtenstionOFServiceLifeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IExtenstionOFServiceLifeService
    {
        //Xidmet muddetinin uzadilmasi
        Task<IResult> AddAsync(CreateExtenstionOFServiceLifeDto createExtenstionOFServiceLifeDto);
        Task<IResult> UpdateAsync(UpdateExtenstionOFServiceLifeDto updateExtenstionOFServiceLifeDto);
        Task<IResult> DeleteAsync(ResultExtenstionOFServiceLifeDto resultExtenstionOFServiceLifeDto);
        Task<IDataResult<List<ResultExtenstionOFServiceLifeDto>>> GetAllAsync();
        Task<IDataResult<ResultExtenstionOFServiceLifeDto>> GetByIdAsync(int id);
        Task<IDataResult<List<ResultExtenstionOFServiceLifeDto>>> GetByEmployeeIdAsync(int enpID);
        Task<IDataResult<List<ResultExtenstionOFServiceLifeDto>>> GetEndDateTimeControl(DateTime _start, DateTime _end);
        Task<IDataResult<List<ResultExtenstionOFServiceLifeDto>>> GetStartDateTimeControl(DateTime _start, DateTime _end);
    }
}
