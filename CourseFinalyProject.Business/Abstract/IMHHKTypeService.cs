using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.MHHKTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IMHHKTypeService
    {
        Task<IResult> AddAsync(CreateMHHKTypeDto createMHHKTypeDto);
        Task<IResult> DeleteAsync(ResultMHHKTypeDto resultMHHKTypeDto);
        Task<IResult> UpdateAsync(UpdateMHHKTypeDto updateMHHKTypeDto);
        Task<IDataResult<List<ResultMHHKTypeDto>>> GetAllAsync();
    }
}
