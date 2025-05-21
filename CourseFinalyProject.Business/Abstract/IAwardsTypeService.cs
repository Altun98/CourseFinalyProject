using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.AwardsTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IAwardsTypeService
    {
        Task<IResult> AddAsync(CreateAwardsTypeDto createAwardsTypeDto);
        Task<IResult> UpdateAsync(UpdateAwardsTypeDto updateAwardsTypeDto);
        Task<IResult> DeleteAsync(ResultAwardsTypeDto resultAwardsTypeDto);
        Task<IDataResult<List<ResultAwardsTypeDto>>> GetAllAsync();
    }
}
