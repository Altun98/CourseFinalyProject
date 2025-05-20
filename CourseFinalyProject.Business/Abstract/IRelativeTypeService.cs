using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.RelativeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IRelativeTypeService
    {
        Task<IResult> AddAsync(CreateRelativeDto createRelativeDto);
        Task<IResult> UpdateAsync(UpdateRelativeDto updateRelativeDto);
        Task<IResult> DeleteAsync(ResultRelativeDto resultRelativeDto);
        Task<IDataResult<List<ResultRelativeDto>>> GetAllAsync();
        Task<IDataResult<List<ResultRelativeDto>>> GetFindRelativeName(string _name);
    }
}
