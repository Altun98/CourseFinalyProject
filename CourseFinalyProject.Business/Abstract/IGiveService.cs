using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.GiveDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IGiveService
    {
        Task<IResult> AddAsync(CreateGiveDto createGiveDto);
        Task<IResult> UpdateAsync(UpdateGiveDto updateGiveDto);
        Task<IResult> DeleteAsync(ResultGiveDto resultGiveDto);
        Task<IDataResult<List<ResultGiveDto>>> GetAllAsync();
        Task<IDataResult<ResultGiveDto>> GetByIdAsync(int id);
        Task<IDataResult<List<ResultGiveDto>>> GetGiveNameSearchAsync(string giveName);
    }
}
