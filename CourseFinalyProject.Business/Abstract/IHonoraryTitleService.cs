using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.HonoraryTitleDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IHonoraryTitleService
    {
        Task<IResult> AddAsync(CreateHonoraryTitleDto createHonoraryTitleDto);
        Task<IResult> DeleteAsync(ResultHonoraryTitleDto resultHonoraryTitleDto);
        Task<IResult> UpdateAsync(UpdateHonoraryTitleDto updateHonoraryTitleDto);
        Task<IDataResult<List<ResultHonoraryTitleDto>>> GetAllAsync();
    }
}
