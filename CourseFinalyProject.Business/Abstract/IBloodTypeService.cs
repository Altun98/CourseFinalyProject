using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.BloodTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IBloodTypeService
    {
        Task<IResult> AddAsync(CreateBloodTypeDto createBloodTypeDto);
        Task<IResult> UpdateAsync(UpdateBloodType updateBloodType);
        Task<IResult> DeleteAsync(ResultBloodTypeDto resultBloodTypeDto);

        Task<IDataResult<List<ResultBloodTypeDto>>> GetAllAsync();
        Task<IDataResult<List<ResultBloodTypeDto>>> GetBloodTypeNameSearch(string name);
    }
}
