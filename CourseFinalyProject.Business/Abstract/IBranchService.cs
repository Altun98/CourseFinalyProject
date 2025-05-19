using Core.Utilities.Results.Data;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Entities.DTOs.BranchDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Abstract
{
    public interface IBranchService
    {
        Task<IResult> AddAsync(CreateBranchDto createBranchDto);
        Task<IResult> UpdateAsync(UpdateBranchDto updateBranchDto);
        Task<IResult> DeleteAsync(ResultBranchDto resultBranchDto);
        Task<IDataResult<List<ResultBranchDto>>> GetAllAsync();
        Task<IDataResult<List<ResultBranchDto>>> GetFindBrancName(string name);
    }
}
