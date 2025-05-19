using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.DepartamentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IDepartamentService
    {
        Task<IResult> AddAsync(CreateDepartamentDto createDepartamentDto);
        Task<IResult> UpdateAsync(UpdateDepartamentDto updateDepartamentDto);
        Task<IResult> DeleteAsync(ResultDepartamentDto resultDepartamentDto);
        Task<IDataResult<List<ResultDepartamentDto>>> GetAllAsync();
        Task<IDataResult<ResultDepartamentDto>> GetByIdAsync(int id);
        Task<IDataResult<List<ResultDepartamentDto>>> GetDepartamentName(string _departamentName);
    }
}
