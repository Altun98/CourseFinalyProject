using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.MedalTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IMedalTypeService
    {
        Task<IResult> AddAsync(CreateMedalTypeDto createMedalTypeDto);

        Task<IResult> UpdateAsync(UpdateMedalTypeDto updateMedalTypeDto);
        Task<IResult> DeleteAsync(ResultMedalTypeDto resultMedalTypeDto);
        Task<IDataResult<List<ResultMedalTypeDto>>> GetAllAsync();
    }
}
