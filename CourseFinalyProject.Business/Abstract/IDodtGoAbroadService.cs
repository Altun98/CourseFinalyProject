using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.DodGoAbrodDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IDodtGoAbroadService
    {
        //xarice getme
        Task<IResult> AddedAsync(ResultDodGoAbrodDto goAbrodDto);
        Task<IResult> DeletedAsync(ResultDodGoAbrodDto goAbrodDto);
        Task<IResult> UpdatedAsync(ResultDodGoAbrodDto goAbrodDto);
        Task<IDataResult<List<ResultDodGoAbrodDto>>> GetAllAsync();
        Task<IDataResult<List<ResultDodGoAbrodDto>>> GetByIdAsync(int empid);
        Task<IDataResult<List<ResultDodGoAbrodDto>>> GetDataTimeControlAsync(DateTime _start, DateTime _end);
        Task<IDataResult<List<ResultDodGoAbrodDto>>> GetCountryAsync(string country);
    }
}
